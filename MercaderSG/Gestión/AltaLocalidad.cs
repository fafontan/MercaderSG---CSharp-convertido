using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class AltaLocalidad
    {
        public AltaLocalidad()
        {
            InitializeComponent();
            _CodPostalTxt.Name = "CodPostalTxt";
            _DescripcionTxt.Name = "DescripcionTxt";
            _AceptarBtn.Name = "AceptarBtn";
            _CancelarBtn.Name = "CancelarBtn";
        }

        private void AltaLocalidad_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarFoco(LocalidadGB);
            ProvinciaCMB.DataSource = LocalidadRN.CargarProvincia();
            ProvinciaCMB.DisplayMember = "Descripcion";
            ProvinciaCMB.ValueMember = "CodProvincia";
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var Localidad = new LocalidadEN();
            Localidad.Descripcion = DescripcionTxt.Text;
            Localidad.CodigoPostal = CodPostalTxt.Text;
            Localidad.CodProvincia = Conversions.ToInteger(ProvinciaCMB.SelectedValue);
            try
            {
                LocalidadRN.AltaLocalidad(Localidad);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DescripcionTxt.Clear();
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }


        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(DescripcionTxt.Text))
            {
                ErrorP.SetError(DescripcionTxt, My.Resources.ArchivoIdioma.CampoVacio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(DescripcionTxt, "");
            }

            switch (DescripcionTxt.Text.Length)
            {
                case var @case when @case > 50:
                    {
                        ErrorP.SetError(DescripcionTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 50:
                    {
                        ErrorP.SetError(DescripcionTxt, "");
                        break;
                    }
            }

            if (string.IsNullOrEmpty(CodPostalTxt.Text))
            {
                ErrorP.SetError(CodPostalTxt, My.Resources.ArchivoIdioma.CampoVacio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(CodPostalTxt, "");
            }

            switch (CodPostalTxt.Text.Length)
            {
                case var case2 when case2 > 10:
                    {
                        ErrorP.SetError(CodPostalTxt, My.Resources.ArchivoIdioma.Contener10Carac);
                        Resultado = false;
                        break;
                    }

                case var case3 when 1 <= case3 && case3 <= 10:
                    {
                        ErrorP.SetError(CodPostalTxt, "");
                        break;
                    }
            }

            return Resultado;
        }

        private void DescripcionTxt_Validated(object sender, EventArgs e)
        {
            DescripcionTxt.Text = Strings.UCase(Strings.Mid(DescripcionTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(DescripcionTxt.Text, 2));
        }

        private void DescripcionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = "áéúíóÁÉÍÓÚQWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void CodPostalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = "1234567890" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void DescripcionTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DescripcionTxt, "");
        }

        private void CodPostalTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DescripcionTxt, "");
        }

        private void AltaLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
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
            Text = My.Resources.ArchivoIdioma.AltaLocalidadFrm;
            LocalidadGB.Text = My.Resources.ArchivoIdioma.LocalidadLbl;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            CodPostalLbl.Text = My.Resources.ArchivoIdioma.CodPostalLbl;
            ProvinciaLbl.Text = My.Resources.ArchivoIdioma.ProvinciaLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescripcionLoc);
            ControlesTP.SetToolTip(CodPostalTxt, My.Resources.ArchivoIdioma.TTCodPostalLoc);
            ControlesTP.SetToolTip(ProvinciaCMB, My.Resources.ArchivoIdioma.TTProvinciaLoc);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarAltaLoc);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}