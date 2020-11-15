using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class LogIn
    {
        public LogIn()
        {
            InitializeComponent();
            _AceptarBtn.Name = "AceptarBtn";
            _UsuarioTxt.Name = "UsuarioTxt";
            _ContraseñaTxt.Name = "ContraseñaTxt";
            _CancelarBtn.Name = "CancelarBtn";
        }

        public List<ErrorIntegridadEN> ListaErrorInt = new List<ErrorIntegridadEN>();
        public DataTable DtErrorIntegridad;
        public DataTable DtErrorIntegridadDVV;
        private bool EstadoLog = false;

        private void LogIn_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.IniciarSesionForm;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            ContraseñaLbl.Text = My.Resources.ArchivoIdioma.ContrasenaLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
            CargarFoco();
            CargarTT();
            UsuarioTxt.Focus();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            try
            {
                var ListaUsuariosPatentes = new List<string>();
                var Usuario = new UsuarioEN();
                Usuario.Usuario = UsuarioTxt.Text;
                Usuario.Contraseña = ContraseñaTxt.Text;
                if (UsuarioRN.Logueo(Usuario) == true)
                {
                    int IdiomaUsuario = Idioma.DetectarIdioma(Usuario.CodUsu);
                    string DescripcionIdioma;
                    if (IdiomaUsuario == 1)
                    {
                        DescripcionIdioma = "es-AR";
                        My.MyProject.Forms.Principal.EspanolSMI.Enabled = false;
                        My.MyProject.Forms.Principal.InglesSMI.Enabled = true;
                    }
                    else
                    {
                        DescripcionIdioma = "en-US";
                        My.MyProject.Forms.Principal.EspanolSMI.Enabled = true;
                        My.MyProject.Forms.Principal.InglesSMI.Enabled = false;
                    }

                    Idioma.AplicarIdioma(DescripcionIdioma);
                    var UsuAut = Autenticar.Instancia();
                    UsuAut.dtPatUsu = PatenteRN.ObtenerPatenteUsuario(Usuario.CodUsu);
                    Principal.ListaErrorInt = ListaErrorInt;
                    Principal.DtErrorIntegridad = DtErrorIntegridad;
                    Principal.DtErrorIntegridadDVV = DtErrorIntegridadDVV;
                    My.MyProject.Forms.Principal.Show();
                    EstadoLog = true;
                    Close();
                }
                else
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.ContraseñaIncorrecta, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ContraseñaTxt.Clear();
                    ContraseñaTxt.Focus();
                }
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CriticalException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsuarioTxt.Clear();
                ContraseñaTxt.Clear();
                UsuarioTxt.Focus();
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.UsuarioRevision ?? ""))
                {
                    var Usuario = new UsuarioEN();
                    Usuario.Usuario = UsuarioTxt.Text;
                    var Sfd = new SaveFileDialog();
                    Sfd.Filter = My.Resources.ArchivoIdioma.SDFArchivoTexto;
                    Sfd.FileName = My.Resources.ArchivoIdioma.FileNameTxtUsu + UsuarioTxt.Text;
                    if (Sfd.ShowDialog() == DialogResult.OK)
                    {
                        var FS = new FileStream(Sfd.FileName, FileMode.Create);
                        var SW = new StreamWriter(FS);
                        string Caracteres = @"1234567890qwertyuiopaslñzxcvbnmQWERTYPÑLKJHGFDSXCVBNM_-.[]{};_:^¨*\|!·$%&/()=?¿@#~€";
                        var Rnd = new Random();
                        var SB = new StringBuilder();
                        char CH;
                        for (int i = 1; i <= 10; i++)
                        {
                            CH = Caracteres[Rnd.Next(0, Caracteres.Length)];
                            SB.Append(CH);
                        }

                        SW.WriteLine(My.Resources.ArchivoIdioma.TxtUsuario + UsuarioTxt.Text);
                        SW.WriteLine(My.Resources.ArchivoIdioma.TxtContraseña + SB.ToString());
                        SW.Close();
                        FS.Close();
                        Usuario.Contraseña = SB.ToString();
                        Usuario.TipoAccion = true;
                    }
                    else
                    {
                        MessageBox.Show(My.Resources.ArchivoIdioma.DebeGernerarContraseña, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        UsuarioRN.ResetearContraseña(Usuario);
                    }
                    catch (InformationException ex1)
                    {
                        MessageBox.Show(ex1.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (WarningException ex1)
                    {
                        MessageBox.Show(ex1.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                ContraseñaTxt.Clear();
                ContraseñaTxt.Focus();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void UsuarioTxt_Validated(object sender, EventArgs e)
        {
            UsuarioTxt.Text = Strings.UCase(Strings.Mid(UsuarioTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(UsuarioTxt.Text, 2));
        }

        public bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(UsuarioTxt.Text) & string.IsNullOrEmpty(ContraseñaTxt.Text))
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.UsuConObligatorios, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsuarioTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            if (string.IsNullOrEmpty(UsuarioTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoObligatorio, UsuarioTxt);
                UsuarioTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            switch (UsuarioTxt.Text.Length)
            {
                case var @case when 1 <= @case && @case <= 5:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.ContenerMenos6Carac, UsuarioTxt);
                        UsuarioTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }

                case var case1 when 6 <= case1 && case1 <= 20:
                    {
                        MensajeTT.Hide(UsuarioTxt);
                        break;
                    }

                case var case2 when case2 > 20:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.Contener20Carac, UsuarioTxt);
                        UsuarioTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }
            }

            if (string.IsNullOrEmpty(ContraseñaTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoObligatorio, ContraseñaTxt);
                ContraseñaTxt.Focus();
                Resultado = false;
                return Resultado;
            }

            switch (ContraseñaTxt.Text.Length)
            {
                case var case3 when 1 <= case3 && case3 <= 7:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.ContenerMenos8Carac, ContraseñaTxt);
                        ContraseñaTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }

                case var case4 when 8 <= case4 && case4 <= 12:
                    {
                        MensajeTT.Hide(ContraseñaTxt);
                        break;
                    }

                case var case5 when case5 > 12:
                    {
                        MensajeTT.Show(My.Resources.ArchivoIdioma.Contener12Carac, ContraseñaTxt);
                        ContraseñaTxt.Focus();
                        Resultado = false;
                        return Resultado;
                    }
            }

            return Resultado;
        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(UsuarioTxt);
        }

        private void UsuarioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "1234567890qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM_-." + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void ContraseñaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = @"qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890~!@#$%^&*()_-+={}[]\|:;<>,.?/" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void ContraseñaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(ContraseñaTxt);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void CargarTT()
        {
            ControlesTP.SetToolTip(UsuarioTxt, My.Resources.ArchivoIdioma.TTUsuarioLoginTxt);
            ControlesTP.SetToolTip(ContraseñaTxt, My.Resources.ArchivoIdioma.TTContrasenaLoginTxt);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarLogin);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

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

        public void CargarFoco()
        {
            foreach (Control Ctrl in Controls)
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
        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EstadoLog == false)
            {
                Application.Exit();
            }
        }
    }
}