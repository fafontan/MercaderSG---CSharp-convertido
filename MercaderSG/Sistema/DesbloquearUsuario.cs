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
    public partial class DesbloquearUsuario
    {
        public DesbloquearUsuario()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        private void DesbloquearUsuario_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            var ListaUsuario = new List<UsuarioEN>();
            foreach (UsuarioEN item in UsuarioRN.CargarUsuario())
            {
                var UnUsuario = new UsuarioEN();
                if (item.Bloqueado == true)
                {
                    UnUsuario.CodUsu = item.CodUsu;
                    UnUsuario.Usuario = item.Usuario;
                    ListaUsuario.Add(UnUsuario);
                }
            }

            UsuarioCMB.DataSource = ListaUsuario;
            UsuarioCMB.DisplayMember = "Usuario";
            UsuarioCMB.ValueMember = "CodUsu";
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioRN.DesbloquearUsuario(Conversions.ToString(UsuarioCMB.SelectedItem.Usuario));
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DesbloquearUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.DesbloquearUsuarioSMI.Enabled = true;
        }

        private void DesbloquearUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "107");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.DesbloquearUsuarioFrm;
            UsuarioGB.Text = My.Resources.ArchivoIdioma.SeleccionarUsuarioGB;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(UsuarioCMB, My.Resources.ArchivoIdioma.TTListaUsuBloqueados);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarDesbloquearUsu);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

    }
}