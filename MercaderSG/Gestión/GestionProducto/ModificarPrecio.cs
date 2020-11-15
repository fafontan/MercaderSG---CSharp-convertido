using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class ModificarPrecio
    {
        public ModificarPrecio()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        public string ProductoSel;

        private void ModificarPrecio_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarFoco(PrecioGB);
            ProductoSel = Seguridad.Encriptar(ProductoSel);
            try
            {
                var Producto = ProductoRN.ObtenerProducto(ProductoSel);
                CodigoTxt.Text = Producto.CodProd.ToString();
                NombreTxt.Text = Producto.Nombre;
                DescripcionTxt.Text = Producto.Descripcion;
                PrecioActualTxt.Text = Producto.Precio;
                NuevoPrecioTxt.Value = Conversions.ToDecimal(PrecioActualTxt.Text);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dispose();
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var Producto = new ProductoEN();
            Producto.CodProd = Conversions.ToInteger(CodigoTxt.Text);
            Producto.Precio = NuevoPrecioTxt.Value.ToString();
            var CadenaMensaje = new StringBuilder();
            CadenaMensaje.Append(My.Resources.ArchivoIdioma.PregPrecioCorrecto + Environment.NewLine);
            CadenaMensaje.Append(Environment.NewLine);
            CadenaMensaje.Append(My.Resources.ArchivoIdioma.FormatoPrecioCorrecto + Environment.NewLine);
            CadenaMensaje.Append(My.Resources.ArchivoIdioma.FormatoPrecioCorrectoDec);
            var Resultado = MessageBox.Show(CadenaMensaje.ToString(), My.Resources.ArchivoIdioma.Precio + " - MercaderSG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                try
                {
                    ProductoRN.ModificarPrecioProducto(Producto);
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
            else
            {
                return;
            }
        }

        private void ModificarPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "123");
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

            // Precio
            if (string.IsNullOrEmpty(NuevoPrecioTxt.Text))
            {
                ErrorP.SetError(NuevoPrecioTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(NuevoPrecioTxt, "");
            }

            switch (NuevoPrecioTxt.Text.Length)
            {
                case var @case when @case > 9:
                    {
                        ErrorP.SetError(NuevoPrecioTxt, My.Resources.ArchivoIdioma.Contener9Carac);
                        Resultado = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 9:
                    {
                        ErrorP.SetError(NuevoPrecioTxt, "");
                        break;
                    }
            }

            return Resultado;
        }

        private void NuevoPrecioTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(NuevoPrecioTxt, "");
        }

        private void NuevoPrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = @"QWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890-.,_[]|\/#() " + Convert.ToChar(8);
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
                if (Ctrl is TextBox & !(Ctrl.Enabled == false))
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
            Text = My.Resources.ArchivoIdioma.ModificarPrecioProductoFrm;
            ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
            CodigoLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            PrecioGB.Text = My.Resources.ArchivoIdioma.NuevoPrecioLbl;
            PrecioActualLbl.Text = My.Resources.ArchivoIdioma.PrecioActualLbl;
            NuevoPrecioLbl.Text = My.Resources.ArchivoIdioma.NuevoPrecioLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(CodigoTxt, My.Resources.ArchivoIdioma.TTCodProd);
            ControlesTP.SetToolTip(NombreTxt, My.Resources.ArchivoIdioma.TTNombreProd);
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescrProd);
            ControlesTP.SetToolTip(PrecioActualTxt, My.Resources.ArchivoIdioma.TTPrecioActual);
            ControlesTP.SetToolTip(NuevoPrecioTxt, My.Resources.ArchivoIdioma.TTNuevoPrecio);
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