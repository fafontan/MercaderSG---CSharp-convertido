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
    public partial class BuscarProveedor
    {
        public BuscarProveedor()
        {
            InitializeComponent();
            _ProveedorDG.Name = "ProveedorDG";
            _RecargarBtn.Name = "RecargarBtn";
            _BuscarBtn.Name = "BuscarBtn";
        }

        private List<ProveedorEN> ListaProv = new List<ProveedorEN>();
        private List<ProveedorEN> ListaProvTemp = new List<ProveedorEN>();
        private List<ProveedorEN> ListaProvTempGral = new List<ProveedorEN>();
        private int NroPag = 0;
        private ProveedorEN _provsel;

        public ProveedorEN ProvSel
        {
            get
            {
                return _provsel;
            }

            set
            {
                _provsel = value;
            }
        }

        private void BuscarProveedor_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            CargarTT();
            AplicarIdioma();
            CargarFoco(ProveedorGB);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBCuit);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBRazonSocial);
            BuscarCmb.SelectedIndex = 0;
            ListaProvTempGral.AddRange(ListaProv);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ListaProv = ProveedorRN.CargarProveedor();
            for (int i = 0, loopTo = ListaProv.Count - 1; i <= loopTo; i++)
            {
                if (BGW.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BGW.ReportProgress((int)(100 * i / (double)ListaProv.Count));
                }
            }
        }

        private void BGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ProveedorDG.AutoGenerateColumns = false;
            ProveedorDG.DataSource = PaginaSig(NroPag);
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = 0;
            My.MyProject.Forms.BarraProgreso.Close();
        }

        public List<ProveedorEN> PaginaSig(int NroPagActual)
        {
            var ListaAux = new List<ProveedorEN>();
            foreach (ProveedorEN item in ListaProv.Paginacion(NroPag))
            {
                var UnProveedor = new ProveedorEN();
                UnProveedor.CodProv = item.CodProv;
                UnProveedor.RazonSocial = item.RazonSocial;
                UnProveedor.Cuit = item.Cuit;
                UnProveedor.Direccion = item.Direccion;
                UnProveedor.CorreoElectronico = item.CorreoElectronico;
                UnProveedor.Activo = item.Activo;
                ListaAux.Add(UnProveedor);
            }

            return ListaAux;
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            ListaProv.Clear();
            ListaProv.AddRange(ListaProvTempGral);
            NroPag = 0;
            ProveedorDG.DataSource = null;
            ProveedorDG.DataSource = PaginaSig(NroPag);
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            NroPag = 0;
            ListaProvTemp.Clear();
            ListaProvTemp.AddRange(ListaProv);
            ListaProv.Clear();
            try
            {
                ListaProv = ProveedorRN.BuscarProveedor(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaProv.Clear();
                ListaProv.AddRange(ListaProvTempGral);
                NroPag = 0;
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaSig(NroPag);
            }

            ProveedorDG.DataSource = null;
            ProveedorDG.AutoGenerateColumns = false;
            ProveedorDG.DataSource = PaginaSig(NroPag);
            if (ProveedorDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteProvBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaProv.Clear();
                ListaProv.AddRange(ListaProvTempGral);
                NroPag = 0;
                ProveedorDG.DataSource = null;
                ProveedorDG.DataSource = PaginaSig(NroPag);
            }
        }

        private void ProveedorDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _provsel = (ProveedorEN)ProveedorDG.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
        }

        private void BuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

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

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.BuscarProveedorFrm;
            ProveedorGB.Text = My.Resources.ArchivoIdioma.SeleccionarProv;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            CodProvCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            RazonSocialCAB.HeaderText = My.Resources.ArchivoIdioma.RazonSocialGral;
            CuitCAB.HeaderText = My.Resources.ArchivoIdioma.CuitGral;
            DireccionCAB.HeaderText = My.Resources.ArchivoIdioma.DireccionCAB;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BusquedaTxt, My.Resources.ArchivoIdioma.TTBuscarProvTxt);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarProv);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(ProveedorDG, My.Resources.ArchivoIdioma.TTListaProveedor);
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
        private void ProveedorDG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _provsel = (ProveedorEN)ProveedorDG.CurrentRow.DataBoundItem;
                DialogResult = DialogResult.OK;
            }
        }
    }
}