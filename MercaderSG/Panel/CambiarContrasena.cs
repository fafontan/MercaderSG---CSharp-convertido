using System;
using System.Drawing;
using System.Windows.Forms;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class CambiarContrasena
    {
        public CambiarContrasena()
        {
            InitializeComponent();
            _ConAnteriorTxt.Name = "ConAnteriorTxt";
            _NuevaContraseñaTxt.Name = "NuevaContraseñaTxt";
            _ReNuevaContraseñaTxt.Name = "ReNuevaContraseñaTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        private void CambiarContrasena_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            CargarFoco(ContrasenaGB);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            string ConAnt = ConAnteriorTxt.Text;
            string NuevaCon = NuevaContraseñaTxt.Text;
            string ReNuevaCon = ReNuevaContraseñaTxt.Text;
            var UsuAut = Autenticar.Instancia();
            if ((NuevaCon ?? "") == (ReNuevaCon ?? ""))
            {
                try
                {
                    UsuarioRN.CambiarContraseña(UsuAut.UsuarioLogueado, ConAnt, NuevaCon);
                }
                catch (InformationException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.UsuarioDadoBaja ?? ""))
                    {
                        Close();
                    }
                    else
                    {
                        ConAnteriorTxt.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoCoincidenPass, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NuevaContraseñaTxt.Clear();
                ReNuevaContraseñaTxt.Clear();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(ConAnteriorTxt.Text) & string.IsNullOrEmpty(NuevaContraseñaTxt.Text) & string.IsNullOrEmpty(ReNuevaContraseñaTxt.Text))
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.Completar3CamposCon, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConAnteriorTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            // Contraseña Anterior
            if (string.IsNullOrEmpty(ConAnteriorTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoObligatorio, ConAnteriorTxt);
                ConAnteriorTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            switch (ConAnteriorTxt.Text.Length)
            {
                case var @case when 1 <= @case && @case <= 7:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.ContenerMenos8Carac, ConAnteriorTxt);
                        ConAnteriorTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }

                case var case1 when 8 <= case1 && case1 <= 12:
                    {
                        MensajeTT.Hide(ConAnteriorTxt);
                        break;
                    }

                case var case2 when case2 > 12:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.Contener12Carac, ConAnteriorTxt);
                        ConAnteriorTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }
            }

            // Nueva Contraseña

            if (string.IsNullOrEmpty(NuevaContraseñaTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoObligatorio, NuevaContraseñaTxt);
                NuevaContraseñaTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            switch (NuevaContraseñaTxt.Text.Length)
            {
                case var case3 when 1 <= case3 && case3 <= 7:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.ContenerMenos8Carac, NuevaContraseñaTxt);
                        NuevaContraseñaTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }

                case var case4 when 8 <= case4 && case4 <= 12:
                    {
                        MensajeTT.Hide(NuevaContraseñaTxt);
                        break;
                    }

                case var case5 when case5 > 12:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.Contener12Carac, NuevaContraseñaTxt);
                        NuevaContraseñaTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }
            }

            // Repetir Contraseña

            if (string.IsNullOrEmpty(ReNuevaContraseñaTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoObligatorio, ReNuevaContraseñaTxt);
                ReNuevaContraseñaTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            switch (ReNuevaContraseñaTxt.Text.Length)
            {
                case var case6 when 1 <= case6 && case6 <= 7:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.ContenerMenos8Carac, ReNuevaContraseñaTxt);
                        ReNuevaContraseñaTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }

                case var case7 when 8 <= case7 && case7 <= 12:
                    {
                        MensajeTT.Hide(ReNuevaContraseñaTxt);
                        break;
                    }

                case var case8 when case8 > 12:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.Contener12Carac, ReNuevaContraseñaTxt);
                        ReNuevaContraseñaTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }
            }

            return Resultado;
        }

        private void ContraseñasTxts_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = @"qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890~!@#$%^&*()_-+={}[]\|:;<>,.?/" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void ConAnteriorTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(ConAnteriorTxt);
        }

        private void NuevaContraseñaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(NuevaContraseñaTxt);
        }

        private void ReNuevaContraseñaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(ReNuevaContraseñaTxt);
        }

        private void CambiarContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.CambiarContrasenaSMI.Enabled = true;
        }

        private void CambiarContrasena_KeyDown(object sender, KeyEventArgs e)
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
            Text = My.Resources.ArchivoIdioma.CambiarContraseñaFrm;
            ContrasenaGB.Text = My.Resources.ArchivoIdioma.CambiarContraseña;
            ConAnteriorLbl.Text = My.Resources.ArchivoIdioma.ConAnteriorLbl;
            NuevaContraseñaLbl.Text = My.Resources.ArchivoIdioma.NuevaConLbl;
            ReNuevaContraseñaLbl.Text = My.Resources.ArchivoIdioma.ReNuevaConLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(ConAnteriorTxt, My.Resources.ArchivoIdioma.TTConAnterior);
            ControlesTP.SetToolTip(NuevaContraseñaTxt, My.Resources.ArchivoIdioma.TTNuevaCon);
            ControlesTP.SetToolTip(ReNuevaContraseñaTxt, My.Resources.ArchivoIdioma.TTConfirmarCon);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.CambiarContraseña);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}