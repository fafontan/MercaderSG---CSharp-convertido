using System;
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
    public partial class ModificarProducto
    {
        public ModificarProducto()
        {
            InitializeComponent();
            _DescripcionTxt.Name = "DescripcionTxt";
            _NombreTxt.Name = "NombreTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        public string ProductoSel;
        private string ProductoGuardo;

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            CargarFoco(ProductoGB);
            SectorCMB.Items.Add("Farmaceutico");
            SectorCMB.Items.Add("Quimico");
            SectorCMB.Items.Add("Alimenticio");
            ProductoGuardo = ProductoSel;
            ProductoSel = Seguridad.Encriptar(ProductoSel);
            try
            {
                var Producto = ProductoRN.ObtenerProducto(ProductoSel);
                CodigoTxt.Text = Producto.CodProd.ToString();
                NombreTxt.Text = Producto.Nombre;
                SectorCMB.SelectedItem = Producto.Sector;
                DescripcionTxt.Text = Producto.Descripcion;
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
            Producto.Nombre = NombreTxt.Text;
            Producto.Sector = Conversions.ToString(SectorCMB.SelectedItem);
            Producto.Descripcion = DescripcionTxt.Text;
            try
            {
                ProductoRN.ModificarProducto(Producto);
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.NombreProductoExistente ?? ""))
                {
                    NombreTxt.Text = ProductoGuardo;
                    NombreTxt.Select();
                }
                else
                {
                    Close();
                }
            }
        }

        private void ModificarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "124");
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

            // Nombre
            if (string.IsNullOrEmpty(NombreTxt.Text))
            {
                ErrorP.SetError(NombreTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(NombreTxt, "");
            }

            switch (NombreTxt.Text.Length)
            {
                case var @case when @case > 50:
                    {
                        ErrorP.SetError(NombreTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 50:
                    {
                        ErrorP.SetError(NombreTxt, "");
                        break;
                    }
            }

            // Descripcion
            if (string.IsNullOrEmpty(DescripcionTxt.Text))
            {
                ErrorP.SetError(DescripcionTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(DescripcionTxt, "");
            }

            switch (DescripcionTxt.Text.Length)
            {
                case var case2 when case2 > 100:
                    {
                        ErrorP.SetError(DescripcionTxt, My.Resources.ArchivoIdioma.Contener100Carac);
                        Resultado = false;
                        break;
                    }

                case var case3 when 1 <= case3 && case3 <= 100:
                    {
                        ErrorP.SetError(DescripcionTxt, "");
                        break;
                    }
            }

            return Resultado;
        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(NombreTxt, "");
        }

        private void DescripcionTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DescripcionTxt, "");
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = @"áéúíóÁÉÍÓÚQWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890-.,_[]|\/#() " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void DescripcionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = @"áéúíóÁÉÍÓÚQWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890-.,_[]|\/#() " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void DescripcionTxt_Validated(object sender, EventArgs e)
        {
            DescripcionTxt.Text = Strings.UCase(Strings.Mid(DescripcionTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(DescripcionTxt.Text, 2));
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
            Text = My.Resources.ArchivoIdioma.ModificarProductoFrm;
            ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
            CodigoLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
            NombreLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            SectorLbl.Text = My.Resources.ArchivoIdioma.CMBSector;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(CodigoTxt, My.Resources.ArchivoIdioma.TTCodProd);
            ControlesTP.SetToolTip(NombreTxt, My.Resources.ArchivoIdioma.TTNombreProd);
            ControlesTP.SetToolTip(SectorCMB, My.Resources.ArchivoIdioma.TTSectorProd);
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescrProd);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarModificarProd);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}