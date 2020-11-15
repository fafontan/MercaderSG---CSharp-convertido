using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class AltaUsuario
    {
        public AltaUsuario()
        {
            InitializeComponent();
            _TelefonoTxt.Name = "TelefonoTxt";
            _QuitarTelBtn.Name = "QuitarTelBtn";
            _AgregarTelBtn.Name = "AgregarTelBtn";
            _TelefonosDG.Name = "TelefonosDG";
            _NombreTxt.Name = "NombreTxt";
            _ApellidoTxt.Name = "ApellidoTxt";
            _CorreoElectronicoTxt.Name = "CorreoElectronicoTxt";
            _UsuarioTxt.Name = "UsuarioTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        private List<TelefonoEN> ListaTelefonos = new List<TelefonoEN>();
        private Autenticar UsuAut = Autenticar.Instancia();
        public bool PuedeModificar = false;

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            CargarFoco(DatosGB);
            CargarFoco(TelefonosGB);
            CargarFoco(UsuarioGB);
            FechaNacDTP.MaxDate = DateTime.Today;
            FechaNacDTP.Value = DateTime.Today;
            UsuarioTxt.Focus();
            IdiomaCMB.DataSource = Idioma.ListarIdiomas();
            IdiomaCMB.DisplayMember = "Descripcion";
            IdiomaCMB.ValueMember = "CodIdioma";
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var UsuarioNuevo = new UsuarioEN();
            UsuarioNuevo.Usuario = UsuarioTxt.Text;
            UsuarioNuevo.CorreoElectronico = CorreoElectronicoTxt.Text;
            UsuarioNuevo.CodIdioma = Conversions.ToInteger(IdiomaCMB.SelectedValue);
            UsuarioNuevo.Apellido = ApellidoTxt.Text;
            UsuarioNuevo.Nombre = NombreTxt.Text;
            UsuarioNuevo.FechaNacimiento = FechaNacDTP.Value;
            UsuarioNuevo.Telefono = ListaTelefonos;
            var Sfd = new SaveFileDialog();
            Sfd.Filter = My.Resources.ArchivoIdioma.SDFArchivoTexto;
            Sfd.FileName = My.Resources.ArchivoIdioma.FileNameTxtUsu + UsuarioTxt.Text;
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                var FS = new FileStream(Sfd.FileName, FileMode.Create);
                var SW = new StreamWriter(FS);
                string Caracteres = @"qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890~!@#$%^&*()_-+={}[]\|:;<>,.?/";
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
                UsuarioNuevo.Contraseña = SB.ToString();
            }
            else
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeGernerarContraseña, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuarioRN.AltaUsuario(UsuarioNuevo);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.UsuarioExistente ?? ""))
                {
                    if (PuedeModificar == true & !((UsuAut.UsuarioLogueado ?? "") == (UsuarioTxt.Text ?? "")))
                    {
                        var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.ModificarUsuario + UsuarioTxt.Text + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxModificarUsuario, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Resultado == DialogResult.OK)
                        {
                            var frm = new ModificarUsuario();
                            frm.UsuarioSel = UsuarioTxt.Text;
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
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void AgregarTelBtn_Click(object sender, EventArgs e)
        {
            bool Valor = true;
            if (string.IsNullOrEmpty(TelefonoTxt.Text))
            {
                ErrorP.SetError(TelefonoTxt, My.Resources.ArchivoIdioma.IngreseNumero);
                Valor = false;
            }
            else
            {
                ErrorP.SetError(TelefonoTxt, "");
            }

            switch (TelefonoTxt.Text.Length)
            {
                case var @case when @case > 25:
                    {
                        ErrorP.SetError(TelefonoTxt, My.Resources.ArchivoIdioma.Contener25Num);
                        Valor = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 25:
                    {
                        ErrorP.SetError(TelefonoTxt, "");
                        break;
                    }
            }

            if (TelefonosDG.Rows.Count == 5)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.CincoTelMax, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Valor = false;
            }

            if (!Valor)
            {
                return;
            }
            else
            {
                TelefonoTxt.Focus();
            }

            var UnTelefono = new TelefonoEN();
            UnTelefono.Numero = TelefonoTxt.Text;
            ListaTelefonos.Add(UnTelefono);
            TelefonosDG.DataSource = null;
            TelefonosDG.DataSource = ListaTelefonos;
            TelefonoTxt.Clear();
            TelefonosDG.Columns[0].Visible = false;
            TelefonosDG.Columns[1].Visible = false;
            TelefonosDG.Columns[2].Visible = false;
        }

        private void QuitarTelBtn_Click(object sender, EventArgs e)
        {
            if (TelefonosDG.Rows.Count == 0)
            {
                ErrorP.SetError(TelefonosDG, My.Resources.ArchivoIdioma.NoTelefonoDG);
                return;
            }

            if (TelefonosDG.CurrentRow is null)
            {
                ErrorP.SetError(TelefonosDG, My.Resources.ArchivoIdioma.NoTelSeleccionado);
            }
            else
            {
                ListaTelefonos.RemoveAt(TelefonosDG.CurrentRow.Index);
                TelefonosDG.DataSource = null;
                TelefonosDG.DataSource = ListaTelefonos;
                TelefonosDG.Columns[0].Visible = false;
                TelefonosDG.Columns[1].Visible = false;
                TelefonosDG.Columns[2].Visible = false;
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool ConsistenciaDatos()
        {
            bool Resultado = true;
            ErrorP.SetError(TelefonoTxt, "");
            if (TelefonosDG.Rows.Count < 3)
            {
                ErrorP.SetError(TelefonosDG, My.Resources.ArchivoIdioma.AgregarMin3Tel);
                Resultado = false;
            }

            // Usuario

            if (string.IsNullOrEmpty(UsuarioTxt.Text))
            {
                ErrorP.SetError(UsuarioTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                UsuarioTxt.Focus();
                Resultado = false;
            }

            switch (UsuarioTxt.Text.Length)
            {
                case var @case when 1 <= @case && @case <= 5:
                    {
                        ErrorP.SetError(UsuarioTxt, My.Resources.ArchivoIdioma.ContenerMenos6Carac);
                        UsuarioTxt.Focus();
                        Resultado = false;
                        break;
                    }

                case var case1 when 6 <= case1 && case1 <= 20:
                    {
                        ErrorP.SetError(UsuarioTxt, "");
                        break;
                    }

                case var case2 when case2 > 20:
                    {
                        ErrorP.SetError(UsuarioTxt, My.Resources.ArchivoIdioma.Contener20Carac);
                        UsuarioTxt.Focus();
                        Resultado = false;
                        break;
                    }
            }

            // Correo
            if (string.IsNullOrEmpty(CorreoElectronicoTxt.Text))
            {
                ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }

            switch (CorreoElectronicoTxt.Text.Length)
            {
                case var case3 when case3 > 50:
                    {
                        ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case4 when 1 <= case4 && case4 <= 50:
                    {
                        var Email = new Regex(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
                        if (!Email.IsMatch(CorreoElectronicoTxt.Text))
                        {
                            ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.FormatoCorreo);
                            Resultado = false;
                        }

                        break;
                    }
            }

            // Apellido
            if (string.IsNullOrEmpty(ApellidoTxt.Text))
            {
                ErrorP.SetError(ApellidoTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(ApellidoTxt, "");
            }

            switch (ApellidoTxt.Text.Length)
            {
                case var case5 when case5 > 50:
                    {
                        ErrorP.SetError(ApellidoTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case6 when 1 <= case6 && case6 <= 50:
                    {
                        ErrorP.SetError(ApellidoTxt, "");
                        break;
                    }
            }

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
                case var case7 when case7 > 50:
                    {
                        ErrorP.SetError(NombreTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case8 when 1 <= case8 && case8 <= 50:
                    {
                        ErrorP.SetError(NombreTxt, "");
                        break;
                    }
            }

            return Resultado;
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

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(UsuarioTxt, "");
        }

        private void ApellidoTxt_Validated(object sender, EventArgs e)
        {
            ApellidoTxt.Text = Strings.UCase(Strings.Mid(ApellidoTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(ApellidoTxt.Text, 2));
        }

        private void NombreTxt_Validated(object sender, EventArgs e)
        {
            NombreTxt.Text = Strings.UCase(Strings.Mid(NombreTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(NombreTxt.Text, 2));
        }

        private void UsuarioTxt_Validated(object sender, EventArgs e)
        {
            UsuarioTxt.Text = Strings.UCase(Strings.Mid(UsuarioTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(UsuarioTxt.Text, 2));
        }

        private void TelefonoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "1234567890()- " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void ApellidoYNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "QWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÚÓáéíóúqwertyuiopasdfghjklñzxcvbnm " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void ContraseñaTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(CorreoElectronicoTxt, "");
        }

        private void ApellidoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(ApellidoTxt, "");
        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(NombreTxt, "");
        }

        private void TelefonoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(TelefonoTxt, "");
        }

        private void AltaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "104");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void TelefonosDG_Click(object sender, EventArgs e)
        {
            ErrorP.SetError(TelefonosDG, "");
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.AltaUsuarioForm;
            UsuarioGB.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.NombreUsuarioLbl;
            CorreoElectronicoLbl.Text = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
            IdiomaLbl.Text = My.Resources.ArchivoIdioma.IdiomaPfrm;
            DatosGB.Text = My.Resources.ArchivoIdioma.DatosPersonales;
            ApellidoLbl.Text = My.Resources.ArchivoIdioma.CMBApellido;
            NombreLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            FechaNacLbl.Text = My.Resources.ArchivoIdioma.FechaNacimientoLbl;
            TelefonosGB.Text = My.Resources.ArchivoIdioma.TelefonosGB;
            NumeroLbl.Text = My.Resources.ArchivoIdioma.NumeroTelLbl;
            NumeroCAB.HeaderText = My.Resources.ArchivoIdioma.NumeroTelLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(UsuarioTxt, My.Resources.ArchivoIdioma.TTUsuarioText);
            ControlesTP.SetToolTip(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.TTCorreoElectronicoUsu);
            ControlesTP.SetToolTip(ApellidoTxt, My.Resources.ArchivoIdioma.TTApellidoUsu);
            ControlesTP.SetToolTip(IdiomaCMB, My.Resources.ArchivoIdioma.TTIdiomas);
            ControlesTP.SetToolTip(NombreTxt, My.Resources.ArchivoIdioma.TTNombreUsu);
            ControlesTP.SetToolTip(FechaNacDTP, My.Resources.ArchivoIdioma.TTNacimientoUsu);
            ControlesTP.SetToolTip(TelefonoTxt, My.Resources.ArchivoIdioma.TTTelelonoUsu);
            ControlesTP.SetToolTip(AgregarTelBtn, My.Resources.ArchivoIdioma.TTAgregarTel);
            ControlesTP.SetToolTip(QuitarTelBtn, My.Resources.ArchivoIdioma.TTQuitarTel);
            ControlesTP.SetToolTip(TelefonosDG, My.Resources.ArchivoIdioma.TTListaTel);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarAltaUsu);
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
    }
}