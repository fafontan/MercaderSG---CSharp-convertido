using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class AltaProducto
    {
        public AltaProducto()
        {
            InitializeComponent();
            _ACBtn.Name = "ACBtn";
            _DescripcionTxt.Name = "DescripcionTxt";
            _CantidadTxt.Name = "CantidadTxt";
            _NombreTxt.Name = "NombreTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        public bool PuedeModificar = false;

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var UnProducto = new ProductoEN();
            UnProducto.Nombre = NombreTxt.Text;
            UnProducto.Precio = PrecioTxt.Value.ToString();
            UnProducto.Sector = Conversions.ToString(SectorCMB.SelectedItem);
            UnProducto.Cantidad = Conversions.ToInteger(CantidadTxt.Text);
            UnProducto.Descripcion = DescripcionTxt.Text;
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
                    ProductoRN.AltaProducto(UnProducto);
                }
                catch (InformationException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.ProductoExistente ?? ""))
                    {
                        if (PuedeModificar == true)
                        {
                            var ResultadoMensaje = MessageBox.Show(My.Resources.ArchivoIdioma.ModificarProducto + NombreTxt.Text + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxModificarProducto, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (ResultadoMensaje == DialogResult.OK)
                            {
                                var frm = new ModificarProducto();
                                frm.ProductoSel = NombreTxt.Text;
                                Dispose();
                                frm.ShowDialog();
                            }
                            else
                            {
                                Close();
                            }
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void ACBtn_Click(object sender, EventArgs e)
        {
            ErrorP.SetError(DescripcionTxt, "");
            DescripcionTxt.Clear();
            DescripcionTxt.Text = Conversions.ToString(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.ACDescProd, SectorCMB.SelectedItem));
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            CargarFoco(ProductoGB);
            SectorCMB.Items.Add("Farmaceutico");
            SectorCMB.Items.Add("Quimico");
            SectorCMB.Items.Add("Alimenticio");
            SectorCMB.SelectedIndex = 0;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
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

            // Precio
            if (string.IsNullOrEmpty(PrecioTxt.Text))
            {
                ErrorP.SetError(PrecioTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(PrecioTxt, "");
            }

            switch (PrecioTxt.Text.Length)
            {
                case var case2 when case2 > 9:
                    {
                        ErrorP.SetError(PrecioTxt, My.Resources.ArchivoIdioma.Contener9Carac);
                        Resultado = false;
                        break;
                    }

                case var case3 when 1 <= case3 && case3 <= 9:
                    {
                        ErrorP.SetError(PrecioTxt, "");
                        break;
                    }
            }


            // Cantidad
            if (string.IsNullOrEmpty(CantidadTxt.Text))
            {
                ErrorP.SetError(CantidadTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(CantidadTxt, "");
            }

            switch (CantidadTxt.Text.Length)
            {
                case var case4 when case4 > 3:
                    {
                        ErrorP.SetError(CantidadTxt, My.Resources.ArchivoIdioma.Contener3Carac);
                        Resultado = false;
                        break;
                    }

                case var case5 when 1 <= case5 && case5 <= 3:
                    {
                        ErrorP.SetError(CantidadTxt, "");
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
                case var case6 when case6 > 100:
                    {
                        ErrorP.SetError(DescripcionTxt, My.Resources.ArchivoIdioma.Contener100Carac);
                        Resultado = false;
                        break;
                    }

                case var case7 when 1 <= case7 && case7 <= 100:
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

        private void PrecioTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(PrecioTxt, "");
        }

        private void CantidadTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(CantidadTxt, "");
        }

        private void DescripcionTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DescripcionTxt, "");
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = @"QWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890áéúíóÁÉÍÓÚ-.,_[]|\/#() " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void PrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "1234567890.," + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
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

        private void AltaProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "102");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
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
            Text = My.Resources.ArchivoIdioma.AltaProductoFrm;
            ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
            NombreLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            SectorLbl.Text = My.Resources.ArchivoIdioma.CMBSector;
            PrecioLbl.Text = My.Resources.ArchivoIdioma.Precio;
            CantidadLbl.Text = My.Resources.ArchivoIdioma.Cantidad;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(NombreTxt, My.Resources.ArchivoIdioma.TTNombreProd);
            ControlesTP.SetToolTip(SectorCMB, My.Resources.ArchivoIdioma.TTSectorProd);
            ControlesTP.SetToolTip(PrecioTxt, My.Resources.ArchivoIdioma.TTPrecioProd);
            ControlesTP.SetToolTip(CantidadTxt, My.Resources.ArchivoIdioma.TTCantidadProd);
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescrProd);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarAltaProd);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
            ControlesTP.SetToolTip(ACBtn, My.Resources.ArchivoIdioma.TTAutoCompletar);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void PrecioTxt_Validated(object sender, EventArgs e)
        {
        }
    }
}