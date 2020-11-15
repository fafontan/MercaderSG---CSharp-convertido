using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class NotaPedido
    {
        public NotaPedido()
        {
            InitializeComponent();
            _BuscarCliBtn.Name = "BuscarCliBtn";
            _BuscarProdBtn.Name = "BuscarProdBtn";
            _GenerarBtn.Name = "GenerarBtn";
            _NuevoBtn.Name = "NuevoBtn";
            _EliminarBtn.Name = "EliminarBtn";
            _AgregarBtn.Name = "AgregarBtn";
        }

        private List<DetalleEN> ListaDetalle = new List<DetalleEN>();

        private void BuscarProdBtn_Click(object sender, EventArgs e)
        {
            MensajeTT.Hide(CantidadTxt);
            MensajeTT.Hide(CodProvTxt);
            LimpiarDatosProducto();
            var frm = new BuscarProducto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CodProdTxt.Text = frm.ProductoSel.CodProd.ToString();
                NombreProdTxt.Text = frm.ProductoSel.Nombre;
                DescProdTxt.Text = frm.ProductoSel.Descripcion;
                PrecioTxt.Text = frm.ProductoSel.Precio;
                AgregarBtn.Enabled = true;
                CantidadTxt.Focus();
            }
            else
            {
                AgregarBtn.Enabled = false;
            }
        }

        public void LimpiarDatosProducto()
        {
            CodProdTxt.Clear();
            NombreProdTxt.Clear();
            DescProdTxt.Clear();
            PrecioTxt.Clear();
            CantidadTxt.Clear();
        }

        private void NotaPedido_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            AgregarBtn.Enabled = false;
            EliminarBtn.Enabled = false;
            NuevoBtn.Enabled = false;
            GenerarBtn.Enabled = false;
            DetalleDG.AutoGenerateColumns = false;
            TotalTxt.Text = "$0";
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            MensajeTT.Hide(CantidadTxt);
            MensajeTT.Hide(CodProvTxt);
            if (string.IsNullOrEmpty(CantidadTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.IngresarCantidad, CantidadTxt);
                return;
            }

            for (int i = 0, loopTo = DetalleDG.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CodProdTxt.Text, DetalleDG.Rows[i].Cells[0].Value, false)))
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoIngresarMismoProducto, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarDatosProducto();
                    return;
                }
            }

            var DetalleNV = new DetalleEN();
            DetalleNV.CodProd = Conversions.ToInteger(CodProdTxt.Text);
            DetalleNV.NombreProducto = NombreProdTxt.Text;
            DetalleNV.Precio = PrecioTxt.Text;
            DetalleNV.Cantidad = Conversions.ToInteger(CantidadTxt.Text);
            ListaDetalle.Add(DetalleNV);
            DetalleDG.DataSource = null;
            DetalleDG.DataSource = ListaDetalle;
            AgregarBtn.Enabled = false;
            EliminarBtn.Enabled = true;
            NuevoBtn.Enabled = true;
            GenerarBtn.Enabled = true;
            CalcularTotal();
            LimpiarDatosProducto();
            BuscarProdBtn.Focus();
        }

        public void CalcularTotal()
        {
            double Total = 0d;
            foreach (DetalleEN item in ListaDetalle)
                Total += item.Cantidad * Conversions.ToDouble(item.Precio);
            TotalTxt.Text = "$" + Total.ToString();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            MensajeTT.Hide(CantidadTxt);
            MensajeTT.Hide(CodProvTxt);
            ListaDetalle.RemoveAt(DetalleDG.CurrentRow.Index);
            DetalleDG.DataSource = null;
            DetalleDG.DataSource = ListaDetalle;
            if (DetalleDG.Rows.Count == 0)
            {
                EliminarBtn.Enabled = false;
                NuevoBtn.Enabled = false;
                GenerarBtn.Enabled = false;
            }

            CalcularTotal();
            LimpiarDatosProducto();
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            MensajeTT.Hide(CantidadTxt);
            MensajeTT.Hide(CodProvTxt);
            DetalleDG.DataSource = null;
            ListaDetalle.Clear();
            AgregarBtn.Enabled = false;
            EliminarBtn.Enabled = false;
            NuevoBtn.Enabled = false;
            GenerarBtn.Enabled = false;
            CalcularTotal();
            LimpiarDatosProducto();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            MensajeTT.Hide(CantidadTxt);
            MensajeTT.Hide(CodProvTxt);
            if (!ConsistenciaDatos())
            {
                return;
            }

            var NuevaNP = new NotaPedidoEN();
            NuevaNP.CodProv = Conversions.ToInteger(CodProvTxt.Text);
            NuevaNP.Detalle = ListaDetalle;
            try
            {
                NotaPedidoRN.CrearNotaPedido(NuevaNP);
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                var Mensaje = MessageBox.Show(My.Resources.ArchivoIdioma.ImprimirNotaPedido + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Mensaje == DialogResult.OK)
                {
                    var frm = new UltimaNPRepor();
                    frm.Show();
                    Close();
                }
                else
                {
                    Close();
                }
            }
        }

        private void BuscarCliBtn_Click(object sender, EventArgs e)
        {
            MensajeTT.Hide(CantidadTxt);
            MensajeTT.Hide(CodProvTxt);
            var frm = new BuscarProveedor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CodProvTxt.Text = frm.ProvSel.CodProv.ToString();
                RazonSocialTxt.Text = frm.ProvSel.RazonSocial;
                CuitTxt.Text = frm.ProvSel.Cuit;
                DireccionTxt.Text = frm.ProvSel.Direccion;
                EstadoCB.Checked = frm.ProvSel.Activo;
            }
        }

        private void NotaPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GenerarNPSMI.Enabled = true;
        }

        private void NotaPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "128");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.AltaNotaPedidoFrm;
            ProveedorGB.Text = My.Resources.ArchivoIdioma.DatosProveedorGB;
            CodProvLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
            CuitLbl.Text = My.Resources.ArchivoIdioma.CuitGral;
            DireccionLbl.Text = My.Resources.ArchivoIdioma.DireccionCAB;
            RazonSocialLbl.Text = My.Resources.ArchivoIdioma.RazonSocialGral;
            ActivoLbl.Text = My.Resources.ArchivoIdioma.ActivoLbl;
            FechaEmiLbl.Text = My.Resources.ArchivoIdioma.FechaEmiForm;
            ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
            CodProdLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreProdLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            DescProdLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            PrecioLbl.Text = My.Resources.ArchivoIdioma.Precio;
            CantidadLbl.Text = My.Resources.ArchivoIdioma.Cantidad;
            NotaVentaGB.Text = My.Resources.ArchivoIdioma.DetalleNotaVenta;
            CodProdCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreCAB.HeaderText = My.Resources.ArchivoIdioma.CMBNombre;
            PrecioCAB.HeaderText = My.Resources.ArchivoIdioma.Precio;
            CantidadCAB.HeaderText = My.Resources.ArchivoIdioma.Cantidad;
            AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarGral;
            EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarGral;
            NuevoBtn.Text = My.Resources.ArchivoIdioma.NuevoGral;
            TotalLbl.Text = My.Resources.ArchivoIdioma.TotalLbl;
            GenerarBtn.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(CodProvTxt, My.Resources.ArchivoIdioma.TTCodProv);
            ControlesTP.SetToolTip(BuscarProdBtn, My.Resources.ArchivoIdioma.TTBuscarProvNotas);
            ControlesTP.SetToolTip(CuitTxt, My.Resources.ArchivoIdioma.TTCuit);
            ControlesTP.SetToolTip(DireccionTxt, My.Resources.ArchivoIdioma.TTDireccionProv);
            ControlesTP.SetToolTip(RazonSocialTxt, My.Resources.ArchivoIdioma.TTRazonSocial);
            ControlesTP.SetToolTip(FechaDTP, My.Resources.ArchivoIdioma.TTFechaEmisionNP);
            ControlesTP.SetToolTip(CodProdTxt, My.Resources.ArchivoIdioma.TTCodProd);
            ControlesTP.SetToolTip(BuscarProdBtn, My.Resources.ArchivoIdioma.TTBuscarProdNota);
            ControlesTP.SetToolTip(NombreProdTxt, My.Resources.ArchivoIdioma.TTNombreProd);
            ControlesTP.SetToolTip(DescProdTxt, My.Resources.ArchivoIdioma.TTDescrProd);
            ControlesTP.SetToolTip(PrecioTxt, My.Resources.ArchivoIdioma.TTPrecioProd);
            ControlesTP.SetToolTip(CantidadTxt, My.Resources.ArchivoIdioma.TTIngreseCantidad);
            ControlesTP.SetToolTip(DetalleDG, My.Resources.ArchivoIdioma.TTListaProductoNP);
            ControlesTP.SetToolTip(AgregarBtn, My.Resources.ArchivoIdioma.TTAgregarDetalle);
            ControlesTP.SetToolTip(EliminarBtn, My.Resources.ArchivoIdioma.TTEliminarDetalle);
            ControlesTP.SetToolTip(NuevoBtn, My.Resources.ArchivoIdioma.TTNuevoDetalle);
            ControlesTP.SetToolTip(GenerarBtn, My.Resources.ArchivoIdioma.TTGenerarNotaPedido);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(CodProvTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.AgregarProvNV, CodProvTxt);
                Resultado = false;
                return Resultado;
            }

            return Resultado;
        }
    }
}