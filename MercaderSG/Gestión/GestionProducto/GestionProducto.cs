using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class GestionProducto
    {
        public GestionProducto()
        {
            InitializeComponent();
            _MasBtn.Name = "MasBtn";
            _ModificarStockBtn.Name = "ModificarStockBtn";
            _ModificarPrecioBtn.Name = "ModificarPrecioBtn";
            _AgregarBtn.Name = "AgregarBtn";
            _ModificarBtn.Name = "ModificarBtn";
            _EliminarBtn.Name = "EliminarBtn";
            _BuscarCmb.Name = "BuscarCmb";
            _BusquedaTxt.Name = "BusquedaTxt";
            _BuscarBtn.Name = "BuscarBtn";
            _RecargarBtn.Name = "RecargarBtn";
            _SiguienteBtn.Name = "SiguienteBtn";
            _AnteriorBtn.Name = "AnteriorBtn";
            _UltimoBtn.Name = "UltimoBtn";
            _PrimeroBtn.Name = "PrimeroBtn";
        }

        private List<ProductoEN> ListaProductos = new List<ProductoEN>();
        private List<ProductoEN> ListaProductosTemp = new List<ProductoEN>();
        private List<ProductoEN> ListaProductosTempGral = new List<ProductoEN>();
        public int NroPag = 0;
        private int CantidadPaginas = 0;
        private Autenticar UsuAut = Autenticar.Instancia();
        public string PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
        public string PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
        public string PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AltaProducto = false;
        private bool ModificarProducto = false;
        private bool BajaProducto = false;
        private bool StockProducto = false;
        private bool PrecioProducto = false;

        private void CargarPermisos()
        {
            AltaProducto = PermisoOK(5);
            AgregarBtn.Enabled = AltaProducto;
            ModificarProducto = PermisoOK(6);
            ModificarBtn.Enabled = ModificarProducto;
            BajaProducto = PermisoOK(7);
            EliminarBtn.Enabled = BajaProducto;
            StockProducto = PermisoOK(8);
            ModificarStockBtn.Enabled = StockProducto;
            PrecioProducto = PermisoOK(9);
            ModificarPrecioBtn.Enabled = PrecioProducto;
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
        private void GestionProducto_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            CargarFoco(GestionProductosGB);
            AplicarIdioma();
            CargarTT();
            CargarPermisos();
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBNombre);
            BuscarCmb.Items.Add(My.Resources.ArchivoIdioma.CMBSector);
            BuscarCmb.SelectedIndex = 0;
            if (CantidadPaginas == 1 | ProductosDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }

            ListaProductosTempGral.AddRange(ListaProductos);
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ListaProductos = ProductoRN.CargarProducto();
            }
            catch (CriticalException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
            Parte1Lbl.Text = string.Empty;
            Parte2Lbl.Text = string.Empty;
            InfoPagLbl.Spring = true;
            ProductosDG.AutoGenerateColumns = false;
            ProductosDG.DataSource = PaginaSig(NroPag);
            if (ProductosDG.Rows.Count == 0)
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
            ListaProductosTemp.Clear();
            ListaProductosTemp.AddRange(ListaProductos);
            ListaProductos.Clear();
            ListaProductos = ProductoRN.BuscarProducto(Conversions.ToString(BuscarCmb.SelectedItem), BusquedaTxt.Text);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
            ProductosDG.DataSource = null;
            ProductosDG.AutoGenerateColumns = false;
            ProductosDG.DataSource = PaginaSig(NroPag);
            if (ProductosDG.Rows.Count > 0)
            {
                InfoPagina(1);
            }
            else
            {
                InfoPagina(0);
            }

            if (ProductosDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteProdBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BusquedaTxt.Clear();
                ListaProductos.Clear();
                ListaProductos.AddRange(ListaProductosTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
                if (ProductosDG.Rows.Count > 0)
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
            var frm = new AltaProducto();
            frm.PuedeModificar = ModificarProducto;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaProductos.Clear();
                ListaProductos = ProductoRN.CargarProducto();
                ListaProductosTempGral.Clear();
                ListaProductosTempGral.AddRange(ListaProductos);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                InfoPagina(1);
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
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
            if (ProductosDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProductos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProductosDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProducto, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new ModificarProducto();
            frm.ProductoSel = Conversions.ToString(ProductosDG.CurrentRow.Cells[1].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaProductos.Clear();
                ListaProductos = ProductoRN.CargarProducto();
                ListaProductosTempGral.Clear();
                ListaProductosTempGral.AddRange(ListaProductos);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                InfoPagina(1);
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
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
            if (ProductosDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProductos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProductosDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProducto, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Producto = new ProductoEN();
            Producto.CodProd = Conversions.ToInteger(ProductosDG.CurrentRow.Cells[0].Value);
            Producto.Nombre = Conversions.ToString(ProductosDG.CurrentRow.Cells[1].Value);
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.EliminarProducto + Producto.Nombre + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxEliminarProducto, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                try
                {
                    ProductoRN.BajaProducto(Producto);
                }
                catch (InformationException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaProductos.Clear();
                    ListaProductos = ProductoRN.CargarProducto();
                    ListaProductosTempGral.Clear();
                    ListaProductosTempGral.AddRange(ListaProductos);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                    ProductosDG.DataSource = null;
                    ProductosDG.DataSource = PaginaSig(NroPag);
                    if (ProductosDG.Rows.Count > 0)
                    {
                        InfoPagina(1);
                    }
                    else
                    {
                        InfoPagina(0);
                    }

                    if (CantidadPaginas == 1 | ProductosDG.Rows.Count == 0)
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
                    ListaProductos.Clear();
                    ListaProductos = ProductoRN.CargarProducto();
                    ListaProductosTempGral.Clear();
                    ListaProductosTempGral.AddRange(ListaProductos);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                    ProductosDG.DataSource = null;
                    ProductosDG.DataSource = PaginaSig(NroPag);
                    if (ProductosDG.Rows.Count > 0)
                    {
                        InfoPagina(1);
                    }
                    else
                    {
                        InfoPagina(0);
                    }

                    if (CantidadPaginas == 1 | ProductosDG.Rows.Count == 0)
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

        private void ModificarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductosDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProductos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProductosDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProducto, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new ModificarStock();
            frm.ProductoSel = Conversions.ToString(ProductosDG.CurrentRow.Cells[1].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaProductos.Clear();
                ListaProductos = ProductoRN.CargarProducto();
                ListaProductosTempGral.Clear();
                ListaProductosTempGral.AddRange(ListaProductos);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                InfoPagina(1);
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
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

        private void ModificarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProductosDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoProductos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = ProductosDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarProducto, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new ModificarPrecio();
            frm.ProductoSel = Conversions.ToString(ProductosDG.CurrentRow.Cells[1].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListaProductos.Clear();
                ListaProductos = ProductoRN.CargarProducto();
                ListaProductosTempGral.Clear();
                ListaProductosTempGral.AddRange(ListaProductos);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
                InfoPagina(1);
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
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

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
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
                ListaAux.Add(UnProducto);
            }

            return ListaAux;
        }

        public List<ProductoEN> PaginaAnt(int NroPagActual)
        {
            NroPag -= 1;
            var ListaAux = new List<ProductoEN>();
            foreach (ProductoEN item in ListaProductos.Paginacion(NroPag))
            {
                var UnProducto = new ProductoEN();
                UnProducto.CodProd = item.CodProd;
                UnProducto.Nombre = item.Nombre;
                UnProducto.Sector = item.Sector;
                UnProducto.Cantidad = item.Cantidad;
                UnProducto.Precio = item.Precio;
                ListaAux.Add(UnProducto);
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
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaSig(NroPag);
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
                ProductosDG.DataSource = null;
                ProductosDG.DataSource = PaginaAnt(NroPag);
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
            ProductosDG.DataSource = null;
            ProductosDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void UltimoBtn_Click(object sender, EventArgs e)
        {
            NroPag = CantidadPaginas - 1;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            PrimeroBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
            ProductosDG.DataSource = null;
            ProductosDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            if (ProductosDG.Rows.Count == 0)
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

            ListaProductos.Clear();
            ListaProductos.AddRange(ListaProductosTempGral);
            NroPag = 0;
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaProductos.Count / 25d));
            InfoPagina(1);
            ProductosDG.DataSource = null;
            ProductosDG.DataSource = PaginaSig(NroPag);
        }

        public void InfoPagina(int NroPag)
        {
            InfoPagLbl.Text = PaginaNro + " " + NroPag + " " + PaginaDe + " " + CantidadPaginas + " " + PaginaRegistros + " " + ListaProductos.Count;
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

        private void BuscarCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaTxt.Clear();
        }

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(BusquedaTxt);
        }

        private void MasBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpcionesCMS.Show(MousePosition);
            }
        }

        private void GestionProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionProductoSMI.Enabled = true;
        }

        private void GestionProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "118");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.N & AltaProducto == true)
            {
                AgregarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.U & ModificarProducto == true)
            {
                ModificarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.D & BajaProducto == true)
            {
                EliminarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.S & StockProducto == true)
            {
                ModificarStockBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.P & PrecioProducto == true)
            {
                ModificarPrecioBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.E)
            {
                ExportarAXLSToolStripMenuItem.PerformClick();
            }
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
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionProductosFrm;
            GestionProductosGB.Text = My.Resources.ArchivoIdioma.GestionProductosGB;
            BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
            IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
            AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarProdBtn;
            ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarProdBtn;
            EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarProdBtn;
            MasBtn.Text = My.Resources.ArchivoIdioma.MasOpcionesBtn;
            ModificarStockBtn.Text = My.Resources.ArchivoIdioma.ModificarStockBtn;
            ModificarPrecioBtn.Text = My.Resources.ArchivoIdioma.ModificarPrecioBtn;
            RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
            CodProdCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreCAB.HeaderText = My.Resources.ArchivoIdioma.CMBNombre;
            PrecioUnitarioCAB.HeaderText = My.Resources.ArchivoIdioma.Precio;
            CantidadCAB.HeaderText = My.Resources.ArchivoIdioma.Cantidad;
            SectorCAB.HeaderText = My.Resources.ArchivoIdioma.CMBSector;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
            ControlesTP.SetToolTip(AgregarBtn, My.Resources.ArchivoIdioma.TTProductoAltaBtn);
            ControlesTP.SetToolTip(ModificarBtn, My.Resources.ArchivoIdioma.TTProductoModificarBtn);
            ControlesTP.SetToolTip(EliminarBtn, My.Resources.ArchivoIdioma.TTProductoEliminarBtn);
            ControlesTP.SetToolTip(MasBtn, My.Resources.ArchivoIdioma.TTMasOpciones);
            ControlesTP.SetToolTip(SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
            ControlesTP.SetToolTip(AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
            ControlesTP.SetToolTip(UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
            ControlesTP.SetToolTip(PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(ProductosDG, My.Resources.ArchivoIdioma.TTListaProducto);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}