using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class GestionCliente
    {
        public GestionCliente()
        {
            InitializeComponent();
            _BusquedaTxt.Name = "BusquedaTxt";
            _BuscarCmb.Name = "BuscarCmb";
            _ClienteDG.Name = "ClienteDG";
            _ExportarAXLSToolStripMenuItem.Name = "ExportarAXLSToolStripMenuItem";
            _OperacionGB.Name = "OperacionGB";
            _AgregarBtn.Name = "AgregarBtn";
            _EliminarTelBtn.Name = "EliminarTelBtn";
            _ModificarBtn.Name = "ModificarBtn";
            _EliminarBtn.Name = "EliminarBtn";
            _BuscarBtn.Name = "BuscarBtn";
            _RecargarBtn.Name = "RecargarBtn";
            _SiguienteBtn.Name = "SiguienteBtn";
            _AnteriorBtn.Name = "AnteriorBtn";
            _UltimoBtn.Name = "UltimoBtn";
            _PrimeroBtn.Name = "PrimeroBtn";
        }

        private Autenticar UsuAut = Autenticar.Instancia();
        private List<ClienteEN> ListaClientes = new List<ClienteEN>();
        private List<ClienteEN> ListaClientesTemp = new List<ClienteEN>();
        private List<ClienteEN> ListaClientesTempGral = new List<ClienteEN>();
        public int NroPag = 0;
        private int CantidadPaginas = 0;
        public string PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
        public string PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
        public string PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AltaCliente = false;
        private bool BajaCliente = false;
        private bool ModificarCliente = false;
        private bool EliminarTel = false;

        private void CargarPermisos()
        {
            AltaCliente = PermisoOK(1);
            AgregarBtn.Enabled = AltaCliente;
            ModificarCliente = PermisoOK(2);
            ModificarBtn.Enabled = ModificarCliente;
            BajaCliente = PermisoOK(3);
            EliminarBtn.Enabled = BajaCliente;
            EliminarTel = PermisoOK(4);
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
        private void GestionCliente_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            CargarFoco(GestionClientesGB);
            AplicarIdioma();
            CargarTT();
            CargarPermisos();
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBCuit);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBRazonSocial);
            BuscarCmb.SelectedIndex = 0;
            if (CantidadPaginas == 1 | ClienteDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }

            ListaClientesTempGral.AddRange(ListaClientes);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ListaClientes = ClienteRN.CargarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0, loopTo = ListaClientes.Count - 1; i <= loopTo; i++)
            {
                if (BGW.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BGW.ReportProgress((int)(100 * i / (double)ListaClientes.Count));
                }
            }
        }

        private void BGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
            Parte1Lbl.Text = string.Empty;
            Parte2Lbl.Text = string.Empty;
            InfoPagLbl.Spring = true;
            ClienteDG.AutoGenerateColumns = false;
            ClienteDG.DataSource = PaginaSig(NroPag);
            if (ClienteDG.Rows.Count == 0)
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
            ListaClientesTemp.Clear();
            ListaClientesTemp.AddRange(ListaClientes);
            ListaClientes.Clear();
            ListaClientes = ClienteRN.BuscarCliente(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
            ClienteDG.DataSource = null;
            ClienteDG.AutoGenerateColumns = false;
            ClienteDG.DataSource = PaginaSig(NroPag);
            if (ClienteDG.Rows.Count > 0)
            {
                InfoPagina(1);
            }
            else
            {
                InfoPagina(0);
            }

            if (ClienteDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteCliBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaClientes.Clear();
                ListaClientes.AddRange(ListaClientesTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaSig(NroPag);
                if (ClienteDG.Rows.Count > 0)
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
            var frm = new AltaCliente();
            frm.PuedeModificar = ModificarCliente;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaClientes.Clear();
                ListaClientes = ClienteRN.CargarCliente();
                ListaClientesTempGral.Clear();
                ListaClientesTempGral.AddRange(ListaClientes);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
                InfoPagina(1);
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaSig(NroPag);
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
            if (ClienteDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoClientes, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ClienteDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarCliente, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Cliente = new ClienteEN();
            Cliente.CodCli = Conversions.ToInteger(ClienteDG.CurrentRow.Cells[0].Value);
            Cliente.RazonSocial = Conversions.ToString(ClienteDG.CurrentRow.Cells[1].Value);
            Cliente.Cuit = Conversions.ToString(ClienteDG.CurrentRow.Cells[2].Value);
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.EliminarCliente + Cliente.RazonSocial + " || " + Cliente.Cuit + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxEliminarCliente, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                try
                {
                    ClienteRN.BajaCliente(Cliente);
                }
                catch (InformationException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaClientes.Clear();
                    ListaClientes = ClienteRN.CargarCliente();
                    ListaClientesTempGral.Clear();
                    ListaClientesTempGral.AddRange(ListaClientes);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
                    ClienteDG.DataSource = null;
                    ClienteDG.DataSource = PaginaSig(NroPag);
                    if (ClienteDG.Rows.Count > 0)
                    {
                        InfoPagina(1);
                    }
                    else
                    {
                        InfoPagina(0);
                    }

                    if (CantidadPaginas == 1 | ClienteDG.Rows.Count == 0)
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
                    ListaClientes.Clear();
                    ListaClientes = ClienteRN.CargarCliente();
                    ListaClientesTempGral.Clear();
                    ListaClientesTempGral.AddRange(ListaClientes);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
                    ClienteDG.DataSource = null;
                    ClienteDG.DataSource = PaginaSig(NroPag);
                    if (ClienteDG.Rows.Count > 0)
                    {
                        InfoPagina(1);
                    }
                    else
                    {
                        InfoPagina(0);
                    }

                    if (CantidadPaginas == 1 | ClienteDG.Rows.Count == 0)
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

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (ClienteDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoClientes, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ClienteDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarCliente, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string RazonSocial, Cuit;
            RazonSocial = Conversions.ToString(ClienteDG.CurrentRow.Cells[1].Value);
            Cuit = Conversions.ToString(ClienteDG.CurrentRow.Cells[2].Value);
            var frm = new ModificarCliente();
            frm.ClienteSel = Conversions.ToString(ClienteDG.CurrentRow.Cells[2].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaClientes.Clear();
                ListaClientes = ClienteRN.CargarCliente();
                ListaClientesTempGral.Clear();
                ListaClientesTempGral.AddRange(ListaClientes);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
                InfoPagina(1);
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaSig(NroPag);
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

        private void EliminarTelBtn_Click(object sender, EventArgs e)
        {
            if (ClienteDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoClientes, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ClienteDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarCliente, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new EliminarTelCliente();
            frm.CodCli = Conversions.ToInteger(ClienteDG.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool ConsistenciaDatos()
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

        private void BuscarCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaTxt.Clear();
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

        private void GestionCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionClienteSMI.Enabled = true;
        }

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(BusquedaTxt);
        }

        private void GestionCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.N & AltaCliente == true)
            {
                AgregarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.U & ModificarCliente == true)
            {
                ModificarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.D & BajaCliente == true)
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

            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "114");
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public List<ClienteEN> PaginaSig(int NroPagActual)
        {
            NroPag += 1;
            var ListaAux = new List<ClienteEN>();
            foreach (ClienteEN item in ListaClientes.Paginacion(NroPag))
            {
                var UnCliente = new ClienteEN();
                UnCliente.CodCli = item.CodCli;
                UnCliente.RazonSocial = item.RazonSocial;
                UnCliente.Cuit = item.Cuit;
                UnCliente.Direccion = item.Direccion;
                UnCliente.Localidad = item.Localidad;
                ListaAux.Add(UnCliente);
            }

            return ListaAux;
        }

        public List<ClienteEN> PaginaAnt(int NroPagActual)
        {
            NroPag -= 1;
            var ListaAux = new List<ClienteEN>();
            foreach (ClienteEN item in ListaClientes.Paginacion(NroPag))
            {
                var UnCliente = new ClienteEN();
                UnCliente.CodCli = item.CodCli;
                UnCliente.RazonSocial = item.RazonSocial;
                UnCliente.Cuit = item.Cuit;
                UnCliente.Direccion = item.Direccion;
                UnCliente.Localidad = item.Localidad;
                ListaAux.Add(UnCliente);
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
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaSig(NroPag);
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
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaAnt(NroPag);
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
            ClienteDG.DataSource = null;
            ClienteDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void UltimoBtn_Click(object sender, EventArgs e)
        {
            NroPag = CantidadPaginas - 1;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            PrimeroBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
            ClienteDG.DataSource = null;
            ClienteDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            if (ClienteDG.Rows.Count == 0)
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

            ListaClientes.Clear();
            ListaClientes.AddRange(ListaClientesTempGral);
            NroPag = 0;
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaClientes.Count / 25d));
            InfoPagina(1);
            ClienteDG.DataSource = null;
            ClienteDG.DataSource = PaginaSig(NroPag);
        }

        public void InfoPagina(int NroPag)
        {
            InfoPagLbl.Text = PaginaNro + " " + NroPag + " " + PaginaDe + " " + CantidadPaginas + " " + PaginaRegistros + " " + ListaClientes.Count;
            InfoPagLbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void ExportarAXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionClienteFrm;
            GestionClientesGB.Text = My.Resources.ArchivoIdioma.GestionClienteGB;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
            AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarCliBtn;
            ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarCliBtn;
            EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarCliBtn;
            EliminarTelBtn.Text = My.Resources.ArchivoIdioma.EliminarTelBtn;
            RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
            CodCliCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            RazonSocialCAB.HeaderText = My.Resources.ArchivoIdioma.RazonSocialGral;
            CuitCAB.HeaderText = My.Resources.ArchivoIdioma.CuitGral;
            DireccionCAB.HeaderText = My.Resources.ArchivoIdioma.DireccionCAB;
            LocalidadCAB.HeaderText = My.Resources.ArchivoIdioma.LocalidadLbl;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
            ControlesTP.SetToolTip(AgregarBtn, My.Resources.ArchivoIdioma.TTClienteAltaBtn);
            ControlesTP.SetToolTip(ModificarBtn, My.Resources.ArchivoIdioma.TTClienteModificarBtn);
            ControlesTP.SetToolTip(EliminarBtn, My.Resources.ArchivoIdioma.TTClienteEliminarBtn);
            ControlesTP.SetToolTip(EliminarTelBtn, My.Resources.ArchivoIdioma.TTEliminarTelBtn);
            ControlesTP.SetToolTip(SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
            ControlesTP.SetToolTip(AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
            ControlesTP.SetToolTip(UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
            ControlesTP.SetToolTip(PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(ClienteDG, My.Resources.ArchivoIdioma.TTListaClientes);
        }

        private void OperacionGB_Enter(object sender, EventArgs e)
        {
        }

        private void ClienteDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}