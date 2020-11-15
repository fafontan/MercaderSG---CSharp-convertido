using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class ResetearContrasena
    {
        public ResetearContrasena()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        private void ResetearContrasena_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            UsuarioCMB.DataSource = UsuarioRN.CargarUsuario();
            UsuarioCMB.DisplayMember = "Usuario";
            UsuarioCMB.ValueMember = "CodUsu";
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            var Usuario = new UsuarioEN();
            Usuario.Usuario = Conversions.ToString(UsuarioCMB.SelectedItem);
            //Usuario.Usuario = Conversions.ToString(UsuarioCMB.SelectedItem.Usuario);
            Usuario.CodUsu = Conversions.ToInteger(UsuarioCMB.SelectedValue);
            var Sfd = new SaveFileDialog();
            Sfd.Filter = My.Resources.ArchivoIdioma.SDFArchivoTexto;
            Sfd.FileName = Conversions.ToString(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.FileNameTxtUsu, UsuarioCMB.SelectedItem));
            //Sfd.FileName = Conversions.ToString(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.FileNameTxtUsu, UsuarioCMB.SelectedItem.Usuario));
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
                SW.WriteLine(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.TxtUsuario, UsuarioCMB.SelectedItem));
                //SW.WriteLine(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.TxtUsuario, UsuarioCMB.SelectedItem.Usuario));
                SW.WriteLine(My.Resources.ArchivoIdioma.TxtContraseña + SB.ToString());
                SW.Close();
                FS.Close();
                Usuario.Contraseña = SB.ToString();
                Usuario.TipoAccion = false;
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
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetearContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.ResetearContrasenaSMI.Enabled = true;
        }

        private void ResetearContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "132");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.ResetearContraseñaFrm;
            UsuarioGB.Text = My.Resources.ArchivoIdioma.SeleccionarUsuarioGB;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(UsuarioCMB, My.Resources.ArchivoIdioma.TTListaUsuarios);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarResetearContraseña);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}