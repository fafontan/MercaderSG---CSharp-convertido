using System;
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
    public partial class ModificarStock
    {
        public ModificarStock()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _CantNuevaTxt.Name = "CantNuevaTxt";
        }

        public string ProductoSel;

        private void ModificarStock_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarFoco(CantidadGB);
            ProductoSel = Seguridad.Encriptar(ProductoSel);
            try
            {
                var Producto = ProductoRN.ObtenerProducto(ProductoSel);
                CodigoTxt.Text = Producto.CodProd.ToString();
                NombreTxt.Text = Producto.Nombre;
                DescripcionTxt.Text = Producto.Descripcion;
                CantActualTxt.Text = Producto.Cantidad.ToString();
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dispose();
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            var Producto = new ProductoEN();
            Producto.CodProd = Conversions.ToInteger(CodigoTxt.Text);
            Producto.Nombre = NombreTxt.Text;
            Producto.Cantidad = Conversions.ToInteger(CantidadNuevaTxt.Text);
            try
            {
                ProductoRN.ModificarStockProducto(Producto);
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void ModificarStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "126");
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

            // Cantidad
            if (string.IsNullOrEmpty(CantidadNuevaTxt.Text))
            {
                ErrorP.SetError(CantidadNuevaTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            // ErrorP.SetError(CantidadTxt, "")
            else if (Convert.ToInt32(CantidadNuevaTxt.Text) > 100)
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CantidadMayor100, CantidadNuevaTxt);
                // ErrorP.SetError(CantidadTxt, My.Resources.ArchivoIdioma.CantidadMayor100)
                Resultado = false;
            }

            switch (CantidadNuevaTxt.Text.Length)
            {
                case var @case when @case > 3:
                    {
                        ErrorP.SetError(CantidadNuevaTxt, My.Resources.ArchivoIdioma.Contener3Carac);
                        Resultado = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 3:
                    {
                        ErrorP.SetError(CantidadNuevaTxt, "");
                        break;
                    }
            }

            return Resultado;
        }

        private void CantidadTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(CantNuevaTxt, "");
        }

        private void CantidadTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "1234567890" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
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

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.ModificarStockProductoFrm;
            ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
            CodigoLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            CantidadGB.Text = My.Resources.ArchivoIdioma.CantidadGB;
            CantActualLbl.Text = My.Resources.ArchivoIdioma.CantActualLbl;
            CantNuevaLbl.Text = My.Resources.ArchivoIdioma.NuevoCantLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(CodigoTxt, My.Resources.ArchivoIdioma.TTCodProd);
            ControlesTP.SetToolTip(NombreTxt, My.Resources.ArchivoIdioma.TTNombreProd);
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescrProd);
            ControlesTP.SetToolTip(CantActualTxt, My.Resources.ArchivoIdioma.TTCantActual);
            ControlesTP.SetToolTip(CantNuevaTxt, My.Resources.ArchivoIdioma.TTNuevaCant);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarModificarPrecioProd);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}