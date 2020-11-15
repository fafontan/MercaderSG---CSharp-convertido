using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class GestionUsuario
    {
        public GestionUsuario()
        {
            InitializeComponent();
            _ExportarAXLSToolStripMenuItem.Name = "ExportarAXLSToolStripMenuItem";
            _AgregarBtn.Name = "AgregarBtn";
            _EliminarTelBtn.Name = "EliminarTelBtn";
            _ModificarBtn.Name = "ModificarBtn";
            _EliminarBtn.Name = "EliminarBtn";
            _BusquedaTxt.Name = "BusquedaTxt";
            _BuscarBtn.Name = "BuscarBtn";
            _RecargarBtn.Name = "RecargarBtn";
            _SiguienteBtn.Name = "SiguienteBtn";
            _AnteriorBtn.Name = "AnteriorBtn";
            _UltimoBtn.Name = "UltimoBtn";
            _PrimeroBtn.Name = "PrimeroBtn";
        }

        private List<UsuarioEN> ListaUsuarios = new List<UsuarioEN>();
        private List<UsuarioEN> ListaUsuariosTemp = new List<UsuarioEN>();
        private List<UsuarioEN> ListaUsuariosTempGral = new List<UsuarioEN>();
        public int NroPag = 0;
        private int CantidadPaginas = 0;
        public string PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
        public string PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
        public string PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AltaUsuario = false;
        private bool BajaUsuario = false;
        private bool ModificarUsuario = false;
        private bool EliminarTel = false;
        private Autenticar UsuAut = Autenticar.Instancia();

        private void CargarPermisos()
        {
            AltaUsuario = PermisoOK(22);
            AgregarBtn.Enabled = AltaUsuario;
            ModificarUsuario = PermisoOK(23);
            ModificarBtn.Enabled = ModificarUsuario;
            BajaUsuario = PermisoOK(24);
            EliminarBtn.Enabled = BajaUsuario;
            EliminarTel = PermisoOK(25);
            EliminarTelBtn.Enabled = EliminarTel;
        }

        private bool PermisoOK(int CodPat)
        {
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(fila[0], CodPat, false)))
                {
                    return true;
                }
            }

            return false;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            BusquedaTxt.Focus();
            AplicarIdioma();
            CargaTT();
            CargarPermisos();
            CargarFoco(GestionUsuariosGB);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBUsuario);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBApellido);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBNombre);
            BuscarCmb.SelectedIndex = 0;
            if (CantidadPaginas == 1 | UsuarioDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }

            ListaUsuariosTempGral.AddRange(ListaUsuarios);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ListaUsuarios = UsuarioRN.CargarUsuario();
            for (int i = 0, loopTo = ListaUsuarios.Count - 1; i <= loopTo; i++)
            {
                if (BGW.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BGW.ReportProgress((int)(100 * i / (double)ListaUsuarios.Count));
                }
            }
        }

        private void BGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
            Parte1Lbl.Text = string.Empty;
            Parte2Lbl.Text = string.Empty;
            InfoPagLbl.Spring = true;
            UsuarioDG.AutoGenerateColumns = false;
            UsuarioDG.DataSource = PaginaSig(NroPag);
            if (UsuarioDG.Rows.Count == 0)
            {
                InfoPagina(0);
            }
            else
            {
                InfoPagina(1);
            }

            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = 0;
            My.MyProject.Forms.BarraProgreso.Close();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            NroPag = 0;
            ListaUsuariosTemp.Clear();
            ListaUsuariosTemp.AddRange(ListaUsuarios);
            ListaUsuarios.Clear();
            ListaUsuarios = UsuarioRN.BuscarUsuario(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
            UsuarioDG.DataSource = null;
            UsuarioDG.AutoGenerateColumns = false;
            UsuarioDG.DataSource = PaginaSig(NroPag);
            if (UsuarioDG.Rows.Count > 0)
            {
                InfoPagina(1);
            }
            else
            {
                InfoPagina(0);
            }

            if (UsuarioDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteUsuBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaUsuarios.Clear();
                ListaUsuarios.AddRange(ListaUsuariosTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
                UsuarioDG.DataSource = null;
                UsuarioDG.DataSource = PaginaSig(NroPag);
                if (UsuarioDG.Rows.Count > 0)
                {
                    InfoPagina(1);
                }
                else
                {
                    InfoPagina(0);
                }
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            var frm = new AltaUsuario();
            frm.PuedeModificar = ModificarUsuario;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaUsuarios.Clear();
                ListaUsuarios = UsuarioRN.CargarUsuario();
                ListaUsuariosTempGral.Clear();
                ListaUsuariosTempGral.AddRange(ListaUsuarios);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
                InfoPagina(1);
                UsuarioDG.DataSource = null;
                UsuarioDG.DataSource = PaginaSig(NroPag);
                if (CantidadPaginas == 1)
                {
                    DeshabilitarPaginacion();
                }
                else
                {
                    HabilitarPaginacion();
                }
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (UsuarioDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoUsuarios, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = UsuarioDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarUsuario, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(UsuAut.UsuarioLogueado, UsuarioDG.CurrentRow.Cells[1].Value, false), ModificarUsuario == true)))
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.ModificarVosMismo, My.Resources.ArchivoIdioma.ModificarUsuBtn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var frm = new ModificarUsuario();
                frm.UsuarioSel = Conversions.ToString(UsuarioDG.CurrentRow.Cells[1].Value);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListaUsuarios.Clear();
                    ListaUsuarios = UsuarioRN.CargarUsuario();
                    ListaUsuariosTempGral.Clear();
                    ListaUsuariosTempGral.AddRange(ListaUsuarios);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
                    InfoPagina(1);
                    UsuarioDG.DataSource = null;
                    UsuarioDG.DataSource = PaginaSig(NroPag);
                    if (CantidadPaginas == 1)
                    {
                        DeshabilitarPaginacion();
                    }
                    else
                    {
                        HabilitarPaginacion();
                    }
                }
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (UsuarioDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoUsuarios, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = UsuarioDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarUsuario, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Usuario = new UsuarioEN();
            Usuario.CodUsu = Conversions.ToInteger(UsuarioDG.CurrentRow.Cells[0].Value);
            Usuario.Usuario = Conversions.ToString(UsuarioDG.CurrentRow.Cells[1].Value);
            if ((UsuAut.UsuarioLogueado ?? "") == (Usuario.Usuario ?? "") & BajaUsuario == true)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.EliminarVosMismo, My.Resources.ArchivoIdioma.EliminarUsuBtn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var Resultado = MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.EliminarUsuario, UsuarioDG.CurrentRow.Cells[1].Value), My.Resources.ArchivoIdioma.Pregunta)), My.Resources.ArchivoIdioma.MsgBoxEliminarUsuario, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Resultado == DialogResult.OK)
                {
                    try
                    {
                        UsuarioRN.BajaUsuario(Usuario);
                    }
                    catch (InformationException ex)
                    {
                        MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListaUsuarios.Clear();
                        ListaUsuarios = UsuarioRN.CargarUsuario();
                        ListaUsuariosTempGral.Clear();
                        ListaUsuariosTempGral.AddRange(ListaUsuarios);
                        NroPag = 0;
                        CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
                        UsuarioDG.DataSource = null;
                        UsuarioDG.DataSource = PaginaSig(NroPag);
                        if (UsuarioDG.Rows.Count > 0)
                        {
                            InfoPagina(1);
                        }
                        else
                        {
                            InfoPagina(0);
                        }

                        if (CantidadPaginas == 1 | UsuarioDG.Rows.Count == 0)
                        {
                            DeshabilitarPaginacion();
                        }
                        else
                        {
                            HabilitarPaginacion();
                        }
                    }
                    catch (WarningException ex)
                    {
                        MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ListaUsuarios.Clear();
                        ListaUsuarios = UsuarioRN.CargarUsuario();
                        ListaUsuariosTempGral.Clear();
                        ListaUsuariosTempGral.AddRange(ListaUsuarios);
                        NroPag = 0;
                        CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
                        UsuarioDG.DataSource = null;
                        UsuarioDG.DataSource = PaginaSig(NroPag);
                        if (UsuarioDG.Rows.Count > 0)
                        {
                            InfoPagina(1);
                        }
                        else
                        {
                            InfoPagina(0);
                        }

                        if (CantidadPaginas == 1 | UsuarioDG.Rows.Count == 0)
                        {
                            DeshabilitarPaginacion();
                        }
                        else
                        {
                            HabilitarPaginacion();
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void EliminarTelBtn_Click(object sender, EventArgs e)
        {
            if (UsuarioDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoUsuarios, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = UsuarioDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarUsuario, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new EliminarTelUsuario();
            frm.CodUsu = Conversions.ToInteger(UsuarioDG.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public List<UsuarioEN> PaginaSig(int NroPagActual)
        {
            NroPag += 1;
            var ListaAux = new List<UsuarioEN>();
            foreach (UsuarioEN item in ListaUsuarios.Paginacion(NroPag))
            {
                var UnUsuario = new UsuarioEN();
                UnUsuario.CodUsu = item.CodUsu;
                UnUsuario.Usuario = item.Usuario;
                UnUsuario.Apellido = item.Apellido;
                UnUsuario.Nombre = item.Nombre;
                UnUsuario.CorreoElectronico = item.CorreoElectronico;
                UnUsuario.Edad = item.Edad;
                ListaAux.Add(UnUsuario);
            }

            return ListaAux;
        }

        public List<UsuarioEN> PaginaAnt(int NroPagActual)
        {
            NroPag -= 1;
            var ListaAux = new List<UsuarioEN>();
            foreach (UsuarioEN item in ListaUsuarios.Paginacion(NroPag))
            {
                var UnUsuario = new UsuarioEN();
                UnUsuario.CodUsu = item.CodUsu;
                UnUsuario.Usuario = item.Usuario;
                UnUsuario.Apellido = item.Apellido;
                UnUsuario.Nombre = item.Nombre;
                UnUsuario.CorreoElectronico = item.CorreoElectronico;
                UnUsuario.Edad = item.Edad;
                ListaAux.Add(UnUsuario);
            }

            return ListaAux;
        }

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            if (NroPag > CantidadPaginas - 1)
            {
                SiguienteBtn.Enabled = false;
                UltimoBtn.Enabled = false;
            }
            else
            {
                PrimeroBtn.Enabled = true;
                AnteriorBtn.Enabled = true;
                UsuarioDG.DataSource = null;
                UsuarioDG.DataSource = PaginaSig(NroPag);
                InfoPagina(NroPag);
            }
        }

        private void AnteriorBtn_Click(object sender, EventArgs e)
        {
            if (NroPag == 1)
            {
                PrimeroBtn.Enabled = false;
                AnteriorBtn.Enabled = false;
            }
            else
            {
                SiguienteBtn.Enabled = true;
                UltimoBtn.Enabled = true;
                UsuarioDG.DataSource = null;
                UsuarioDG.DataSource = PaginaAnt(NroPag);
                InfoPagina(NroPag);
            }
        }

        private void PrimeroBtn_Click(object sender, EventArgs e)
        {
            NroPag = 0;
            PrimeroBtn.Enabled = false;
            AnteriorBtn.Enabled = false;
            SiguienteBtn.Enabled = true;
            UltimoBtn.Enabled = true;
            UsuarioDG.DataSource = null;
            UsuarioDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void UltimoBtn_Click(object sender, EventArgs e)
        {
            NroPag = CantidadPaginas - 1;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            PrimeroBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
            UsuarioDG.DataSource = null;
            UsuarioDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            if (CantidadPaginas == 1)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            ListaUsuarios.Clear();
            ListaUsuarios.AddRange(ListaUsuariosTempGral);
            NroPag = 0;
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaUsuarios.Count / 25d));
            InfoPagina(1);
            UsuarioDG.DataSource = null;
            UsuarioDG.DataSource = PaginaSig(NroPag);
        }

        public void InfoPagina(int NroPag)
        {
            InfoPagLbl.Text = PaginaNro + " " + NroPag + " " + PaginaDe + " " + CantidadPaginas + " " + PaginaRegistros + " " + ListaUsuarios.Count;
            InfoPagLbl.TextAlign = ContentAlignment.MiddleCenter;
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void ExportarAXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsuarioDG.RowCount > 0)
            {
                var Sfd = new SaveFileDialog();
                Sfd.Filter = "Excel (*.xls)|*.xls";
                Sfd.FileName = My.Resources.ArchivoIdioma.FileNameUsuarioPdfXls;
                if (Sfd.ShowDialog() == DialogResult.OK)
                {
                    var App = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook WB;
                    var WS = new Microsoft.Office.Interop.Excel.Worksheet();
                    WB = App.Workbooks.Add();
                    WS = (Microsoft.Office.Interop.Excel.Worksheet)WB.ActiveSheet;
                    for (int i = 1, loopTo = UsuarioDG.Columns.Count; i <= loopTo; i++)
                        WS.Cells[(object)1, (object)i] = UsuarioDG.Columns[i - 1].HeaderText;
                    for (int i = 0, loopTo1 = UsuarioDG.Rows.Count - 1; i <= loopTo1; i++)
                    {
                        for (int j = 0, loopTo2 = UsuarioDG.Columns.Count - 1; j <= loopTo2; j++)
                        {
                            WS.Cells[(object)(i + 2), (object)(j + 1)] = UsuarioDG.Rows[i].Cells[j].Value.ToString();
                            WS.Cells[(object)(i + 2), (object)1].Font.Color = (object)Color.Blue;
                        }
                    }

                    {
                        var withBlock = WS.get_Range(WS.Cells[(object)1, (object)1], WS.Cells[(object)1, (object)UsuarioDG.ColumnCount]).Font;
                        withBlock.Color = (object)Color.White;
                        withBlock.Bold = (object)1;
                        withBlock.Size = (object)12;
                    }

                    WS.get_Range(WS.Cells[(object)1, (object)1], WS.Cells[(object)1, (object)UsuarioDG.ColumnCount]).Interior.Color = (object)Color.Black;
                    WS.Columns.AutoFit();
                    WS.Columns.HorizontalAlignment = (object)2;
                    WB.SaveAs(Sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    WB.Close();
                    Process.Start(Sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoRegExportar, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(BusquedaTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.BusquedaVacia, BusquedaTxt);
                Resultado = false;
                return Resultado;
            }

            switch (BuscarCmb.SelectedItem)
            {
                case var @case when Operators.ConditionalCompareObjectEqual(@case, My.Resources.ArchivoIdioma.CMBApellido, false):
                    {
                        if (BusquedaTxt.Text.Length > 50)
                        {
                            MensajeTT.Show(My.Resources.ArchivoIdioma.Contener50Carac, BusquedaTxt);
                            BusquedaTxt.Focus();
                            Resultado = false;
                        }

                        for (int i = 0, loopTo = BusquedaTxt.Text.Length - 1; i <= loopTo; i++)
                        {
                            if (Information.IsNumeric(BusquedaTxt.Text[i]))
                            {
                                MensajeTT.Show(My.Resources.ArchivoIdioma.BusquedaNumero, BusquedaTxt);
                                Resultado = false;
                                break;
                            }
                        }

                        break;
                    }

                case var case1 when Operators.ConditionalCompareObjectEqual(case1, My.Resources.ArchivoIdioma.CMBNombre, false):
                    {
                        if (BusquedaTxt.Text.Length > 50)
                        {
                            MensajeTT.Show(My.Resources.ArchivoIdioma.Contener50Carac, BusquedaTxt);
                            BusquedaTxt.Focus();
                            Resultado = false;
                        }

                        for (int i = 0, loopTo1 = BusquedaTxt.Text.Length - 1; i <= loopTo1; i++)
                        {
                            if (Information.IsNumeric(BusquedaTxt.Text[i]))
                            {
                                MensajeTT.Show(My.Resources.ArchivoIdioma.BusquedaNumero, BusquedaTxt);
                                Resultado = false;
                                break;
                            }
                        }

                        break;
                    }

                case var case2 when Operators.ConditionalCompareObjectEqual(case2, My.Resources.ArchivoIdioma.CMBUsuario, false):
                    {
                        if (BusquedaTxt.Text.Length < 6)
                        {
                            MensajeTT.Show(My.Resources.ArchivoIdioma.ContenerMenos6Carac, BusquedaTxt);
                            BusquedaTxt.Focus();
                            Resultado = false;
                        }

                        if (BusquedaTxt.Text.Length > 20)
                        {
                            MensajeTT.Show(My.Resources.ArchivoIdioma.Contener20Carac, BusquedaTxt);
                            BusquedaTxt.Focus();
                            Resultado = false;
                        }

                        break;
                    }
            }

            return Resultado;
        }

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(BusquedaTxt);
        }

        private void CargaTT()
        {
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
            ControlesTP.SetToolTip(AgregarBtn, My.Resources.ArchivoIdioma.TTUsuarioAltaBtn);
            ControlesTP.SetToolTip(ModificarBtn, My.Resources.ArchivoIdioma.TTUsuarioModificarBtn);
            ControlesTP.SetToolTip(EliminarBtn, My.Resources.ArchivoIdioma.TTUsuarioEliminarBtn);
            ControlesTP.SetToolTip(EliminarTelBtn, My.Resources.ArchivoIdioma.TTEliminarTelBtn);
            ControlesTP.SetToolTip(SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
            ControlesTP.SetToolTip(AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
            ControlesTP.SetToolTip(UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
            ControlesTP.SetToolTip(PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(UsuarioDG, My.Resources.ArchivoIdioma.TTListaUsuarios);
        }

        public void HabilitarPaginacion()
        {
            PrimeroBtn.Enabled = true;
            SiguienteBtn.Enabled = true;
            UltimoBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
        }

        public void DeshabilitarPaginacion()
        {
            PrimeroBtn.Enabled = false;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            AnteriorBtn.Enabled = false;
        }

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionUsuarioForm;
            GestionUsuariosGB.Text = My.Resources.ArchivoIdioma.GestionUsuariosGB;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
            AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarUsuBtn;
            ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarUsuBtn;
            EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarUsuBtn;
            EliminarTelBtn.Text = My.Resources.ArchivoIdioma.EliminarTelBtn;
            RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
            CodUsuCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioCodigoCAB;
            UsuarioCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioUsuarioCAB;
            ApellidoCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioApellidoCAB;
            NombreCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioNombreCAB;
            CorreoCAB.HeaderText = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
            EdadCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioEdadCAB;
        }

        private void TieneFoco(object sender, EventArgs e)
        {
            TextBox MiTextBox = (TextBox)sender;
            MiTextBox.BackColor = Color.WhiteSmoke;
        }

        private void PierdeFoco(object sender, EventArgs e)
        {
            TextBox MiTextBox = (TextBox)sender;
            MiTextBox.BackColor = Color.White;
        }

        public void CargarFoco(GroupBox Grupo)
        {
            foreach (Control Ctrl in Grupo.Controls)
            {
                if (Ctrl is TextBox)
                {
                    TextBox MiTextBox = (TextBox)Ctrl;
                    if (MiTextBox.ReadOnly == false)
                    {
                        MiTextBox.GotFocus += TieneFoco;
                        MiTextBox.LostFocus += PierdeFoco;
                    }
                }
            }
        }

        private void GestionUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "120");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.N & AltaUsuario == true)
            {
                AgregarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.U & ModificarUsuario == true)
            {
                ModificarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.D & BajaUsuario == true)
            {
                EliminarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.T & EliminarTel == true)
            {
                EliminarTelBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.E)
            {
                ExportarAXLSToolStripMenuItem.PerformClick();
            }
        }

        private void BusquedaTxt_Validated(object sender, EventArgs e)
        {
            BusquedaTxt.Text = Strings.UCase(Strings.Mid(BusquedaTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(BusquedaTxt.Text, 2));
        }

        private void GestionUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionUsuarioSMI.Enabled = true;
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}