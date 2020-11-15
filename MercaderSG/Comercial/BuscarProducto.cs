using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class BuscarProducto
    {
        public BuscarProducto()
        {
            InitializeComponent();
            _RecargarBtn.Name = "RecargarBtn";
            _ProductosDG.Name = "ProductosDG";
            _BuscarBtn.Name = "BuscarBtn";
        }

        private List<ProductoEN> ListaProductos = new List<ProductoEN>();
        private List<ProductoEN> ListaProductosTemp = new List<ProductoEN>();
        private List<ProductoEN> ListaProductosTempGral = new List<ProductoEN>();
        private int NroPag = 0;
        private ProductoEN _productosel;

        public ProductoEN ProductoSel
        {
            get
            {
                return _productosel;
            }

            set
            {
                _productosel = value;
            }
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            CargarTT();
            AplicarIdioma();
            CargarFoco(ProductoGB);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBNombre);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBSector);
            BuscarCmb.SelectedIndex = 0;
            ListaProductosTempGral.AddRange(ListaProductos);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ListaProductos = ProductoRN.CargarProducto();
            for (int i = 0, loopTo = ListaProductos.Count - 1; i <= loopTo; i++)
            {
                if (BGW.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BGW.ReportProgress((int)(100 * i / (double)ListaProductos.Count));
                }
            }
        }

        private void BGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ProductosDG.AutoGenerateColumns = false;
            ProductosDG.DataSource = PaginaSig(NroPag);
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = 0;
            My.MyProject.Forms.BarraProgreso.Close();
        }

        public List<ProductoEN> PaginaSig(int NroPagActual)
        {
            NroPag += 1;
            var ListaAux = new List<ProductoEN>();
            foreach (ProductoEN item in ListaProductos.Paginacion(NroPag))
            {
                var UnProducto = new ProductoEN();
                UnProducto.CodProd = item.CodProd;
                UnProducto.Nombre = item.Nombre;
                UnProducto.Sector = item.Sector;
                UnProducto.Cantidad = item.Cantidad;
                UnProducto.Precio = item.Precio;
                UnProducto.Descripcion = item.Descripcion;
                ListaAux.Add(UnProducto);
            }

            return ListaAux;
        }

        private void ProductosDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _productosel = (ProductoEN)ProductosDG.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            NroPag = 0;
            ListaProductosTemp.Clear();
            ListaProductosTemp.AddRange(ListaProductos);
            ListaProductos.Clear();
            try
            {
                ListaProductos = ProductoRN.BuscarProducto(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaProductos.Clear();
                ListaProductos.AddRange(ListaProductosTempGral);
                NroPag = 0;
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
            }

            ProductosDG.DataSource = null;
            ProductosDG.AutoGenerateColumns = false;
            ProductosDG.DataSource = PaginaSig(NroPag);
            if (ProductosDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteProdBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaProductos.Clear();
                ListaProductos.AddRange(ListaProductosTempGral);
                NroPag = 0;
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
            }
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            ListaProductos.Clear();
            ListaProductos.AddRange(ListaProductosTempGral);
            NroPag = 0;
            ProductosDG.DataSource = null;
            ProductosDG.DataSource = PaginaSig(NroPag);
        }

        private void BuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _productosel = (ProductoEN)ProductosDG.CurrentRow.DataBoundItem;
                DialogResult = DialogResult.OK;
            }

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
                case var @case when Operators.ConditionalCompareObjectEqual(@case, My.Resources.ArchivoIdioma.CMBNombre, false):
                    {
                        if (BusquedaTxt.Text.Length > 20)
                        {
                            MensajeTT.Show(My.Resources.ArchivoIdioma.Contener20Carac, BusquedaTxt);
                            BusquedaTxt.Focus();
                            Resultado = false;
                        }

                        break;
                    }

                case var case1 when Operators.ConditionalCompareObjectEqual(case1, My.Resources.ArchivoIdioma.CMBSector, false):
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
            Text = My.Resources.ArchivoIdioma.BuscarProductoFrm;
            ProductoGB.Text = My.Resources.ArchivoIdioma.SeleccionarProd;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            CodProdCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreCAB.HeaderText = My.Resources.ArchivoIdioma.CMBNombre;
            PrecioUnitarioCAB.HeaderText = My.Resources.ArchivoIdioma.Precio;
            CantidadCAB.HeaderText = My.Resources.ArchivoIdioma.Cantidad;
            SectorCAB.HeaderText = My.Resources.ArchivoIdioma.CMBSector;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BusquedaTxt, My.Resources.ArchivoIdioma.IngresarProdBuscar);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarProd);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(ProductosDG, My.Resources.ArchivoIdioma.TTListaProducto);
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
    }
}