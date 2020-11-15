using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    public partial class ModificarUsuario
    {
        public ModificarUsuario()
        {
            InitializeComponent();
            _ApellidoTxt.Name = "ApellidoTxt";
            _TelefonosDG.Name = "TelefonosDG";
            _NombreTxt.Name = "NombreTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        private int CodigoUsuario;
        public string UsuarioSel;

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarFoco(UsuarioGB);
            CargarFoco(DatosPersonalesGB);
            FechaNacDTP.MaxDate = DateTime.Today;
            UsuarioSel = Seguridad.Encriptar(UsuarioSel);
            IdiomaCMB.DataSource = Idioma.ListarIdiomas();
            IdiomaCMB.DisplayMember = "Descripcion";
            IdiomaCMB.ValueMember = "CodIdioma";
            try
            {
                var Usuario = UsuarioRN.ObtenerUsuario(UsuarioSel);
                UsuarioTxt.Text = Usuario.Usuario;
                ApellidoTxt.Text = Usuario.Apellido;
                NombreTxt.Text = Usuario.Nombre;
                IdiomaCMB.SelectedValue = Usuario.CodIdioma;
                CorreoElectronicoTxt.Text = Usuario.CorreoElectronico;
                FechaNacDTP.Value = Usuario.FechaNacimiento;
                CodigoUsuario = Usuario.CodUsu;
                TelefonosDG.AutoGenerateColumns = false;
                TelefonosDG.DataSource = UsuarioRN.ObtenerTelefonoUsuario(CodigoUsuario);
                TelefonosDG.Columns[0].ReadOnly = true;
                TelefonosDG.Columns[1].ReadOnly = true;
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

            var ListaTelefono = new List<TelefonoEN>();
            foreach (DataGridViewRow fila in TelefonosDG.Rows)
            {
                var UnTelefono = new TelefonoEN();
                UnTelefono.CodTel = Conversions.ToInteger(fila.Cells[0].Value);
                UnTelefono.CodEn = Conversions.ToInteger(fila.Cells[1].Value);
                UnTelefono.Numero = Conversions.ToString(fila.Cells[2].Value);
                ListaTelefono.Add(UnTelefono);
            }

            string UsuarioModificar = UsuarioTxt.Text;
            var UnUsuario = new UsuarioEN();
            UnUsuario.CodUsu = CodigoUsuario;
            UnUsuario.Usuario = UsuarioModificar;
            UnUsuario.Apellido = ApellidoTxt.Text;
            UnUsuario.Nombre = NombreTxt.Text;
            UnUsuario.CodIdioma = Conversions.ToInteger(IdiomaCMB.SelectedValue);
            UnUsuario.FechaNacimiento = FechaNacDTP.Value;
            UnUsuario.Telefono = ListaTelefono;
            try
            {
                UsuarioRN.ModificarUsuario(UnUsuario);
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

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (TelefonosDG.Rows.Count < 3)
            {
                ErrorP.SetError(TelefonosDG, My.Resources.ArchivoIdioma.AgregarMin3Tel);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(TelefonosDG, "");
            }

            // Correo
            if (string.IsNullOrEmpty(CorreoElectronicoTxt.Text))
            {
                ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }

            switch (CorreoElectronicoTxt.Text.Length)
            {
                case var @case when @case > 50:
                    {
                        ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 50:
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
                case var case2 when case2 > 50:
                    {
                        ErrorP.SetError(ApellidoTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case3 when 1 <= case3 && case3 <= 50:
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
                case var case4 when case4 > 50:
                    {
                        ErrorP.SetError(NombreTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case5 when 1 <= case5 && case5 <= 50:
                    {
                        ErrorP.SetError(NombreTxt, "");
                        break;
                    }
            }

            return Resultado;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApellidoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(ApellidoTxt, "");
        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(NombreTxt, "");
        }

        private void ApellidoyNombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "QWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÚÓáéíóúqwertyuiopasdfghjklñzxcvbnm " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void ApellidoTxt_Validated(object sender, EventArgs e)
        {
            ApellidoTxt.Text = Strings.UCase(Strings.Mid(ApellidoTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(ApellidoTxt.Text, 2));
        }

        private void NombreTxt_Validated(object sender, EventArgs e)
        {
            NombreTxt.Text = Strings.UCase(Strings.Mid(NombreTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(NombreTxt.Text, 2));
        }

        private void ModificarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "127");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void TelefonosDG_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox Celda = (TextBox)e.Control;
            Celda.KeyPress += Celda_Keypress;
        }

        private void Celda_Keypress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "1234567890()- " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.ModificarUsuarioForm;
            UsuarioGB.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.NombreUsuarioLbl;
            CorreoElectronicoLbl.Text = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
            IdiomaLbl.Text = My.Resources.ArchivoIdioma.IdiomaPfrm;
            DatosPersonalesGB.Text = My.Resources.ArchivoIdioma.DatosPersonales;
            ApellidoLbl.Text = My.Resources.ArchivoIdioma.CMBApellido;
            NombreLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
            FechaNacLbl.Text = My.Resources.ArchivoIdioma.FechaNacimientoLbl;
            TelefonosGB.Text = My.Resources.ArchivoIdioma.TelefonosGB;
            TelefonoCAB.HeaderText = My.Resources.ArchivoIdioma.DGModificarUsuarioTelCAB;
            NumeroCAB.HeaderText = My.Resources.ArchivoIdioma.DGModificarUsuarioNumeroCAB;
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
            ControlesTP.SetToolTip(TelefonosDG, My.Resources.ArchivoIdioma.TTListaTel);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTModificarUsuBtn);
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