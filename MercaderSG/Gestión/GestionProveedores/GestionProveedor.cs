using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class GestionProveedor
    {
        public GestionProveedor()
        {
            InitializeComponent();
            _RecargarBtn.Name = "RecargarBtn";
            _SiguienteBtn.Name = "SiguienteBtn";
            _AgregarBtn.Name = "AgregarBtn";
            _EliminarTelBtn.Name = "EliminarTelBtn";
            _ModificarBtn.Name = "ModificarBtn";
            _EliminarBtn.Name = "EliminarBtn";
            _BuscarCmb.Name = "BuscarCmb";
            _BusquedaTxt.Name = "BusquedaTxt";
            _BuscarBtn.Name = "BuscarBtn";
            _AnteriorBtn.Name = "AnteriorBtn";
            _UltimoBtn.Name = "UltimoBtn";
            _PrimeroBtn.Name = "PrimeroBtn";
            _ExportarAXLSToolStripMenuItem.Name = "ExportarAXLSToolStripMenuItem";
        }

        private List<ProveedorEN> ListaProveedor = new List<ProveedorEN>();
        private List<ProveedorEN> ListaProveedorTemp = new List<ProveedorEN>();
        private List<ProveedorEN> ListaProveedorTempGral = new List<ProveedorEN>();
        public int NroPag = 0;
        private int CantidadPaginas = 0;
        private Autenticar UsuAut = Autenticar.Instancia();
        public string PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
        public string PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
        public string PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AltaProveedor = false;
        private bool ModificarProveedor = false;
        private bool BajaProveedor = false;
        private bool EliminarTel = false;

        private void CargarPermisos()
        {
            AltaProveedor = PermisoOK(10);
            AgregarBtn.Enabled = AltaProveedor;
            ModificarProveedor = PermisoOK(11);
            ModificarBtn.Enabled = ModificarProveedor;
            BajaProveedor = PermisoOK(12);
            EliminarBtn.Enabled = BajaProveedor;
            EliminarTel = PermisoOK(13);
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
        private void GestionProveedor_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            AplicarIdioma();
            CargaTT();
            CargarFoco(GestionProveedoresGB);
            CargarPermisos();
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBCuit);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBRazonSocial);
            BuscarCmb.SelectedIndex = 0;
            if (CantidadPaginas == 1 | ProveedorDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }

            ListaProveedorTempGral.AddRange(ListaProveedor);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ListaProveedor = ProveedorRN.CargarProveedor();
            for (int i = 0, loopTo = ListaProveedor.Count - 1; i <= loopTo; i++)
            {
                if (BGW.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BGW.ReportProgress((int)(100 * i / (double)ListaProveedor.Count));
                }
            }
        }

        private void BGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
            Parte1Lbl.Text = string.Empty;
            Parte2Lbl.Text = string.Empty;
            InfoPagLbl.Spring = true;
            InfoPagina(1);
            ProveedorDG.AutoGenerateColumns = false;
            ProveedorDG.DataSource = PaginaSig(NroPag);
            if (ProveedorDG.Rows.Count == 0)
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
            ListaProveedorTemp.Clear();
            ListaProveedorTemp.AddRange(ListaProveedor);
            ListaProveedor.Clear();
            ListaProveedor = ProveedorRN.BuscarProveedor(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
            ProveedorDG.DataSource = null;
            ProveedorDG.AutoGenerateColumns = false;
            ProveedorDG.DataSource = PaginaSig(NroPag);
            if (ProveedorDG.Rows.Count > 0)
            {
                InfoPagina(1);
            }
            else
            {
                InfoPagina(0);
            }

            if (ProveedorDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteProvBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaProveedor.Clear();
                ListaProveedor.AddRange(ListaProveedorTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaSig(NroPag);
                if (ProveedorDG.Rows.Count > 0)
                {
                    InfoPagina(1);
                }
                else
                {
                    InfoPagina(0);
                }
            }
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            var frm = new AltaProveedor();
            frm.PuedeModificar = ModificarProveedor;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaProveedor.Clear();
                ListaProveedor = ProveedorRN.CargarProveedor();
                ListaProveedorTempGral.Clear();
                ListaProveedorTempGral.AddRange(ListaProveedor);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
                InfoPagina(1);
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaSig(NroPag);
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
            if (ProveedorDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProveedor, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProveedorDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProveedor, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new ModificarProveedor();
            frm.CuitSel = Conversions.ToString(ProveedorDG.CurrentRow.Cells[2].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaProveedor.Clear();
                ListaProveedor = ProveedorRN.CargarProveedor();
                ListaProveedorTempGral.Clear();
                ListaProveedorTempGral.AddRange(ListaProveedor);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
                InfoPagina(1);
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaSig(NroPag);
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

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (ProveedorDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProveedor, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProveedorDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProveedor, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Proveedor = new ProveedorEN();
            Proveedor.CodProv = Conversions.ToInteger(ProveedorDG.CurrentRow.Cells[0].Value);
            Proveedor.RazonSocial = Conversions.ToString(ProveedorDG.CurrentRow.Cells[1].Value);
            Proveedor.Cuit = Conversions.ToString(ProveedorDG.CurrentRow.Cells[2].Value);
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.EliminarProveedor + Proveedor.RazonSocial + " || " + Proveedor.Cuit + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxEliminarProveedor, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                try
                {
                    ProveedorRN.BajaProveedor(Proveedor);
                }
                catch (InformationException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaProveedor.Clear();
                    ListaProveedor = ProveedorRN.CargarProveedor();
                    ListaProveedorTempGral.Clear();
                    ListaProveedorTempGral.AddRange(ListaProveedor);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
                    ProveedorDG.DataSource = null;
                    ProveedorDG.DataSource = PaginaSig(NroPag);
                    if (ProveedorDG.Rows.Count > 0)
                    {
                        InfoPagina(1);
                    }
                    else
                    {
                        InfoPagina(0);
                    }

                    if (CantidadPaginas == 1 | ProveedorDG.Rows.Count == 0)
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
                    ListaProveedor.Clear();
                    ListaProveedor = ProveedorRN.CargarProveedor();
                    ListaProveedorTempGral.Clear();
                    ListaProveedorTempGral.AddRange(ListaProveedor);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
                    ProveedorDG.DataSource = null;
                    ProveedorDG.DataSource = PaginaSig(NroPag);
                    if (ProveedorDG.Rows.Count > 0)
                    {
                        InfoPagina(1);
                    }
                    else
                    {
                        InfoPagina(0);
                    }

                    if (CantidadPaginas == 1 | ProveedorDG.Rows.Count == 0)
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

        private void EliminarTelBtn_Click(object sender, EventArgs e)
        {
            if (ProveedorDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProveedor, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProveedorDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProveedor, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new EliminarTelProveedor();
            frm.CodProv = Conversions.ToInteger(ProveedorDG.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public List<ProveedorEN> PaginaSig(int NroPagActual)
        {
            NroPag += 1;
            var ListaAux = new List<ProveedorEN>();
            foreach (ProveedorEN item in ListaProveedor.Paginacion(NroPag))
            {
                var UnProveedor = new ProveedorEN();
                UnProveedor.CodProv = item.CodProv;
                UnProveedor.RazonSocial = item.RazonSocial;
                UnProveedor.Cuit = item.Cuit;
                UnProveedor.CorreoElectronico = item.CorreoElectronico;
                UnProveedor.Direccion = item.Direccion;
                ListaAux.Add(UnProveedor);
            }

            return ListaAux;
        }

        public List<ProveedorEN> PaginaAnt(int NroPagActual)
        {
            NroPag -= 1;
            var ListaAux = new List<ProveedorEN>();
            foreach (ProveedorEN item in ListaProveedor.Paginacion(NroPag))
            {
                var UnProveedor = new ProveedorEN();
                UnProveedor.CodProv = item.CodProv;
                UnProveedor.RazonSocial = item.RazonSocial;
                UnProveedor.Cuit = item.Cuit;
                UnProveedor.CorreoElectronico = item.CorreoElectronico;
                UnProveedor.Direccion = item.Direccion;
                ListaAux.Add(UnProveedor);
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
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaSig(NroPag);
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
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaAnt(NroPag);
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
            ProveedorDG.DataSource = null;
            ProveedorDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void UltimoBtn_Click(object sender, EventArgs e)
        {
            NroPag = CantidadPaginas - 1;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            PrimeroBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
            ProveedorDG.DataSource = null;
            ProveedorDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            if (ProveedorDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
                return;
            }

            if (CantidadPaginas == 1)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            ListaProveedor.Clear();
            ListaProveedor.AddRange(ListaProveedorTempGral);
            NroPag = 0;
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProveedor.Count / 25d));
            InfoPagina(1);
            ProveedorDG.DataSource = null;
            ProveedorDG.DataSource = PaginaSig(NroPag);
        }

        public void InfoPagina(int NroPag)
        {
            InfoPagLbl.Text = PaginaNro + " " + NroPag + " " + PaginaDe + " " + CantidadPaginas + " " + PaginaRegistros + " " + ListaProveedor.Count;
            InfoPagLbl.TextAlign = ContentAlignment.MiddleCenter;
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(BusquedaTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.BusquedaVacia, BusquedaTxt);
                BusquedaTxt.Clear();
                BusquedaTxt.Focus();
                Resultado = false;
            }

            switch (BuscarCmb.SelectedItem)
            {
                case var @case when Operators.ConditionalCompareObjectEqual(@case, My.Resources.ArchivoIdioma.CMBCuit, false):
                    {
                        switch (BusquedaTxt.Text.Length)
                        {
                            case var case1 when case1 > 13:
                                {
                                    MensajeTT.Show(My.Resources.ArchivoIdioma.Contener13Carac, BusquedaTxt);
                                    BusquedaTxt.Focus();
                                    Resultado = false;
                                    break;
                                }

                            case var case2 when 1 <= case2 && case2 <= 13:
                                {
                                    var Cuit = new Regex("([0-9]{2})[-]([0-9]{8})[-]([0-9]{1})");
                                    if (!Cuit.IsMatch(BusquedaTxt.Text))
                                    {
                                        MensajeTT.Show(My.Resources.ArchivoIdioma.FormatoCUIT, BusquedaTxt);
                                        BusquedaTxt.Focus();
                                        Resultado = false;
                                    }

                                    break;
                                }

                            case var case3 when case3 == 13:
                                {
                                    var Cuit = new Regex("([0-9]{2})[-]([0-9]{8})[-]([0-9]{1})");
                                    if (!Cuit.IsMatch(BusquedaTxt.Text))
                                    {
                                        MensajeTT.Show(My.Resources.ArchivoIdioma.FormatoCUIT, BusquedaTxt);
                                        BusquedaTxt.Focus();
                                        Resultado = false;
                                    }

                                    break;
                                }
                        }

                        break;
                    }

                case var case4 when Operators.ConditionalCompareObjectEqual(case4, My.Resources.ArchivoIdioma.CMBRazonSocial, false):
                    {
                        if (BusquedaTxt.Text.Length > 50)
                        {
                            MensajeTT.Show(My.Resources.ArchivoIdioma.Contener50Carac, BusquedaTxt);
                            BusquedaTxt.Focus();
                            Resultado = false;
                        }

                        break;
                    }
            }

            return Resultado;
        }

        private void GestionProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionProveedorSMI.Enabled = true;
        }

        private void GestionProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "119");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.N & AltaProveedor == true)
            {
                AgregarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.U & ModificarProveedor == true)
            {
                ModificarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.D & BajaProveedor == true)
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

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(BusquedaTxt);
        }

        private void BuscarCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaTxt.Clear();
        }

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionProveedorFrm;
            GestionProveedoresGB.Text = My.Resources.ArchivoIdioma.GestionProveedorGB;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
            AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarProvBtn;
            ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarProvBtn;
            EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarProvBtn;
            EliminarTelBtn.Text = My.Resources.ArchivoIdioma.EliminarTelBtn;
            RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
            CodProvCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            RazonSocialCAB.HeaderText = My.Resources.ArchivoIdioma.RazonSocialGral;
            CuitCAB.HeaderText = My.Resources.ArchivoIdioma.CuitGral;
            CorreoElectronicoCAB.HeaderText = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
            DireccionCAB.HeaderText = My.Resources.ArchivoIdioma.DireccionCAB;
        }

        private void CargaTT()
        {
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
            ControlesTP.SetToolTip(AgregarBtn, My.Resources.ArchivoIdioma.TTProveedorAltaBtn);
            ControlesTP.SetToolTip(ModificarBtn, My.Resources.ArchivoIdioma.TTProveedorModificarBtn);
            ControlesTP.SetToolTip(EliminarBtn, My.Resources.ArchivoIdioma.TTProveedorEliminarBtn);
            ControlesTP.SetToolTip(EliminarTelBtn, My.Resources.ArchivoIdioma.TTEliminarTelBtn);
            ControlesTP.SetToolTip(SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
            ControlesTP.SetToolTip(AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
            ControlesTP.SetToolTip(UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
            ControlesTP.SetToolTip(PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(ProveedorDG, My.Resources.ArchivoIdioma.TTListaProveedor);
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
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void ExportarAXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProveedorDG.RowCount > 0)
            {
                var Sfd = new SaveFileDialog();
                Sfd.Filter = "Excel (*.xls)|*.xls";
                Sfd.FileName = My.Resources.ArchivoIdioma.FileNameClientePdfXls;
                if (Sfd.ShowDialog() == DialogResult.OK)
                {
                    var App = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook WB;
                    var WS = new Microsoft.Office.Interop.Excel.Worksheet();
                    WB = App.Workbooks.Add();
                    WS = (Microsoft.Office.Interop.Excel.Worksheet)WB.ActiveSheet;
                    for (int i = 1, loopTo = ProveedorDG.Columns.Count; i <= loopTo; i++)
                        WS.Cells[(object)1, (object)i] = ProveedorDG.Columns[i - 1].HeaderText;
                    for (int i = 0, loopTo1 = ProveedorDG.Rows.Count - 1; i <= loopTo1; i++)
                    {
                        for (int j = 0, loopTo2 = ProveedorDG.Columns.Count - 1; j <= loopTo2; j++)
                        {
                            WS.Cells[(object)(i + 2), (object)(j + 1)] = ProveedorDG.Rows[i].Cells[j].Value.ToString();
                            WS.Cells[(object)(i + 2), (object)1].Font.Color = (object)Color.Blue;
                        }
                    }

                    {
                        var withBlock = WS.get_Range(WS.Cells[(object)1, (object)1], WS.Cells[(object)1, (object)ProveedorDG.ColumnCount]).Font;
                        withBlock.Color = (object)Color.White;
                        withBlock.Bold = (object)1;
                        withBlock.Size = (object)12;
                    }

                    WS.get_Range(WS.Cells[(object)1, (object)1], WS.Cells[(object)1, (object)ProveedorDG.ColumnCount]).Interior.Color = (object)Color.Black;
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

    }
}