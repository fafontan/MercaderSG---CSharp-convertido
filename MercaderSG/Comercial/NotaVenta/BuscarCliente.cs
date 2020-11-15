using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class BuscarCliente
    {
        public BuscarCliente()
        {
            InitializeComponent();
            _ClienteDG.Name = "ClienteDG";
            _RecargarBtn.Name = "RecargarBtn";
            _BuscarBtn.Name = "BuscarBtn";
        }

        private List<ClienteEN> ListaClientes = new List<ClienteEN>();
        private List<ClienteEN> ListaClientesTemp = new List<ClienteEN>();
        private List<ClienteEN> ListaClientesTempGral = new List<ClienteEN>();
        private int NroPag = 0;
        private ClienteEN _clientesel;

        public ClienteEN ClienteSel
        {
            get
            {
                return _clientesel;
            }

            set
            {
                _clientesel = value;
            }
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            CargarTT();
            AplicarIdioma();
            CargarFoco(ClienteGB);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBCuit);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBRazonSocial);
            BuscarCmb.SelectedIndex = 0;
            ListaClientesTempGral.AddRange(ListaClientes);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ListaClientes = ClienteRN.CargarCliente();
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
            ClienteDG.AutoGenerateColumns = false;
            ClienteDG.DataSource = PaginaSig(NroPag);
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = 0;
            My.MyProject.Forms.BarraProgreso.Close();
        }

        public List<ClienteEN> PaginaSig(int NroPagActual)
        {
            var ListaAux = new List<ClienteEN>();
            foreach (ClienteEN item in ListaClientes.Paginacion(NroPag))
            {
                var UnCliente = new ClienteEN();
                UnCliente.CodCli = item.CodCli;
                UnCliente.RazonSocial = item.RazonSocial;
                UnCliente.Cuit = item.Cuit;
                UnCliente.Direccion = item.Direccion;
                UnCliente.Activo = item.Activo;
                UnCliente.Localidad = item.Localidad;
                ListaAux.Add(UnCliente);
            }

            return ListaAux;
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            ListaClientes.Clear();
            ListaClientes.AddRange(ListaClientesTempGral);
            NroPag = 0;
            ClienteDG.DataSource = null;
            ClienteDG.DataSource = PaginaSig(NroPag);
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
            try
            {
                ListaClientes = ClienteRN.BuscarCliente(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaClientes.Clear();
                ListaClientes.AddRange(ListaClientesTempGral);
                NroPag = 0;
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaSig(NroPag);
            }

            ClienteDG.DataSource = null;
            ClienteDG.AutoGenerateColumns = false;
            ClienteDG.DataSource = PaginaSig(NroPag);
            if (ClienteDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteCliBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaClientes.Clear();
                ListaClientes.AddRange(ListaClientesTempGral);
                NroPag = 0;
                ClienteDG.DataSource = null;
                ClienteDG.DataSource = PaginaSig(NroPag);
            }
        }

        private void ClienteDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _clientesel = (ClienteEN)ClienteDG.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
        }

        private void BuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
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

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.BuscarClienteFrm;
            ClienteGB.Text = My.Resources.ArchivoIdioma.SeleccionarCli;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            CodCliCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            RazonSocialCAB.HeaderText = My.Resources.ArchivoIdioma.RazonSocialGral;
            CuitCAB.HeaderText = My.Resources.ArchivoIdioma.CuitGral;
            DireccionCAB.HeaderText = My.Resources.ArchivoIdioma.DireccionCAB;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BusquedaTxt, My.Resources.ArchivoIdioma.TTBuscarCliTxt);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarCli);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(ClienteDG, My.Resources.ArchivoIdioma.TTListaClientes);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
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
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void ClienteDG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _clientesel = (ClienteEN)ClienteDG.CurrentRow.DataBoundItem;
                DialogResult = DialogResult.OK;
            }
        }
    }
}