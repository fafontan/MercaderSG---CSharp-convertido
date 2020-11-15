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
    public partial class ModificarCliente
    {
        public ModificarCliente()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _DepartamentoTxt.Name = "DepartamentoTxt";
            _AgregarLocBtn.Name = "AgregarLocBtn";
            _PisoTxt.Name = "PisoTxt";
            _CalleTxt.Name = "CalleTxt";
            _NumeroTxt.Name = "NumeroTxt";
            _CuitTxt.Name = "CuitTxt";
            _RazonSocialTxt.Name = "RazonSocialTxt";
            _TelefonosDG.Name = "TelefonosDG";
        }

        private int CodigoCliente;
        public string ClienteSel;
        public bool EstadoCliente = false;

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarFoco(DatosGB);
            CargarFoco(DomicilioGB);
            CargarFoco(TelefonosGB);
            ClienteSel = Seguridad.Encriptar(ClienteSel);
            LocalidadCMB.DataSource = LocalidadRN.CargarLocalidad();
            LocalidadCMB.DisplayMember = "Descripcion";
            LocalidadCMB.ValueMember = "CodLoc";
            try
            {
                var Cliente = ClienteRN.ObtenerCliente(ClienteSel);
                CuitTxt.Text = Cliente.Cuit;
                RazonSocialTxt.Text = Cliente.RazonSocial;
                LocalidadCMB.SelectedValue = Cliente.CodLoc;
                CalleTxt.Text = Cliente.Calle;
                NumeroTxt.Text = Cliente.Numero;
                PisoTxt.Text = Cliente.Piso;
                DepartamentoTxt.Text = Cliente.Departamento;
                CodigoCliente = Cliente.CodCli;
                TelefonosDG.AutoGenerateColumns = false;
                TelefonosDG.DataSource = ClienteRN.ObtenerTelefonoCliente(CodigoCliente);
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

            string ClienteCuit = CuitTxt.Text;
            ClienteCuit = Seguridad.Encriptar(ClienteCuit);
            var Cliente = new ClienteEN();
            Cliente.CodCli = CodigoCliente;
            Cliente.Cuit = ClienteCuit;
            Cliente.RazonSocial = RazonSocialTxt.Text;
            Cliente.CodLoc = Conversions.ToInteger(LocalidadCMB.SelectedValue);
            Cliente.Calle = CalleTxt.Text;
            Cliente.Numero = NumeroTxt.Text;
            Cliente.Piso = PisoTxt.Text;
            Cliente.Departamento = DepartamentoTxt.Text;
            Cliente.Telefono = ListaTelefono;
            try
            {
                ClienteRN.ModificarCliente(Cliente);
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

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarLocBtn_Click(object sender, EventArgs e)
        {
            var frm = new AltaLocalidad();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LocalidadCMB.Focus();
                LocalidadCMB.DataSource = LocalidadRN.CargarLocalidad();
                ErrorP.SetError(AgregarLocBtn, "");
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool ConsistenciaDatos()
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

            // RS
            if (string.IsNullOrEmpty(RazonSocialTxt.Text))
            {
                ErrorP.SetError(RazonSocialTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(RazonSocialTxt, "");
            }

            switch (RazonSocialTxt.Text.Length)
            {
                case var @case when @case > 50:
                    {
                        ErrorP.SetError(RazonSocialTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case1 when 1 <= case1 && case1 <= 50:
                    {
                        ErrorP.SetError(RazonSocialTxt, "");
                        break;
                    }
            }

            // Cuit

            if (string.IsNullOrEmpty(CuitTxt.Text))
            {
                ErrorP.SetError(CuitTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(CuitTxt, "");
            }

            switch (CuitTxt.Text.Length)
            {
                case var case2 when case2 > 13:
                    {
                        ErrorP.SetError(CuitTxt, My.Resources.ArchivoIdioma.Contener13Carac);
                        Resultado = false;
                        break;
                    }

                case var case3 when 1 <= case3 && case3 <= 13:
                    {
                        var Cuit = new Regex("(30|33)[-]([0-9]{8})[-]([0-9]{1})");
                        if (!Cuit.IsMatch(CuitTxt.Text))
                        {
                            ErrorP.SetError(CuitTxt, My.Resources.ArchivoIdioma.FormatoCUIT);
                            Resultado = false;
                        }
                        else if (!ValidarCuit(CuitTxt.Text))
                        {
                            ErrorP.SetError(CuitTxt, My.Resources.ArchivoIdioma.ValorCUIT);
                            Resultado = false;
                        }

                        break;
                    }

                case var case4 when case4 == 13:
                    {
                        var Cuit = new Regex("(30|33)[-]([0-9]{8})[-]([0-9]{1})");
                        if (!Cuit.IsMatch(CuitTxt.Text))
                        {
                            ErrorP.SetError(CuitTxt, My.Resources.ArchivoIdioma.FormatoCUIT);
                            Resultado = false;
                        }
                        else if (!ValidarCuit(CuitTxt.Text))
                        {
                            ErrorP.SetError(CuitTxt, My.Resources.ArchivoIdioma.ValorCUIT);
                            Resultado = false;
                        }

                        break;
                    }
            }

            // Localidad
            if (LocalidadCMB.SelectedItem is null)
            {
                ErrorP.SetError(AgregarLocBtn, My.Resources.ArchivoIdioma.DebeAgregarLocalidad);
                Resultado = false;
            }

            // Calle
            if (string.IsNullOrEmpty(CalleTxt.Text))
            {
                ErrorP.SetError(CalleTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else
            {
                ErrorP.SetError(CalleTxt, "");
            }

            switch (CalleTxt.Text.Length)
            {
                case var case5 when case5 > 50:
                    {
                        ErrorP.SetError(CalleTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case6 when 1 <= case6 && case6 <= 50:
                    {
                        ErrorP.SetError(CalleTxt, "");
                        break;
                    }
            }

            // Num
            if (string.IsNullOrEmpty(NumeroTxt.Text))
            {
                ErrorP.SetError(NumeroTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }
            else if (NumeroTxt.Text.Length > 10)
            {
                ErrorP.SetError(NumeroTxt, My.Resources.ArchivoIdioma.Contener10Carac);
                Resultado = false;
            }

            // Piso
            if (PisoTxt.Text.Length > 10)
            {
                ErrorP.SetError(PisoTxt, My.Resources.ArchivoIdioma.Contener10Carac);
                Resultado = false;
            }

            // dpto
            if (DepartamentoTxt.Text.Length > 5)
            {
                ErrorP.SetError(DepartamentoTxt, My.Resources.ArchivoIdioma.Contener5Carac);
                Resultado = false;
            }

            return Resultado;
        }

        private bool ValidarCuit(string Cuit)
        {
            string CadenaEntrante = Cuit;
            string Cadena = Cuit;
            Cadena = Regex.Replace(Cadena, "[-]", "");
            int Sumatoria = 0;
            int e = 6;
            for (int i = 0, loopTo = Cadena.Length - 1; i <= loopTo; i++)
            {
                e -= 1;
                if (e == 1)
                {
                    e = 7;
                }

                if (Information.IsNumeric(Cadena[i]))
                {
                    Sumatoria += Conversion.Val(Cadena[i]) * e;
                }
                else
                {
                    Sumatoria += Strings.Asc(Cadena[i]) * e;
                }
            }

            double M11;
            M11 = Sumatoria / 11d;
            int M11Entero = (int)Conversion.Int(M11);
            int ResultadoM11;
            ResultadoM11 = M11Entero * 11;
            int Resto = Sumatoria - ResultadoM11;
            if (Resto == 11)
            {
                Resto = 0;
            }

            if (Resto == 10)
            {
                Resto = 9;
            }

            int UltimoNumero = Convert.ToInt32(Cuit.Substring(Cuit.Length - 1, 1));
            if (Resto == UltimoNumero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RazonSocialTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(RazonSocialTxt, "");
        }

        private void CuitTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(CuitTxt, "");
        }

        private void CalleTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(CalleTxt, "");
        }

        private void NumeroTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(NumeroTxt, "");
        }

        private void PisoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(PisoTxt, "");
        }

        private void DepartamentoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DepartamentoTxt, "");
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

        private void RazonSocialCalleTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "QWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890.-áéúíóÁÉÍÓÚ " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void CuitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = "1234567890-" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void NumeroYPisoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = "1234567890" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void DepartamentoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "QWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void RazonSocialTxt_Validated(object sender, EventArgs e)
        {
            RazonSocialTxt.Text = Strings.UCase(Strings.Mid(RazonSocialTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(RazonSocialTxt.Text, 2));
        }

        private void CalleTxt_Validated(object sender, EventArgs e)
        {
            CalleTxt.Text = Strings.UCase(Strings.Mid(CalleTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(CalleTxt.Text, 2));
        }

        private void DepartamentoTxt_Validated(object sender, EventArgs e)
        {
            DepartamentoTxt.Text = Strings.UCase(Strings.Mid(DepartamentoTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(DepartamentoTxt.Text, 2));
        }

        private void ModificarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "121");
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
            Text = My.Resources.ArchivoIdioma.ModificarClienteFrm;
            DatosGB.Text = My.Resources.ArchivoIdioma.DatosEmpresa;
            RazonSocialLbl.Text = My.Resources.ArchivoIdioma.RazonSocialGral;
            CuitLbl.Text = My.Resources.ArchivoIdioma.CuitGral;
            TelefonosGB.Text = My.Resources.ArchivoIdioma.TelefonosGB;
            TelefonoCAB.HeaderText = My.Resources.ArchivoIdioma.CodTelefono;
            NumeroCAB.HeaderText = My.Resources.ArchivoIdioma.NumeroTelLbl;
            DomicilioGB.Text = My.Resources.ArchivoIdioma.DomicilioGB;
            LocalidadLbl.Text = My.Resources.ArchivoIdioma.LocalidadLbl;
            CalleLbl.Text = My.Resources.ArchivoIdioma.CalleLbl;
            NumeroLbl.Text = My.Resources.ArchivoIdioma.NumeroCalleLbl;
            PisoLbl.Text = My.Resources.ArchivoIdioma.PisoLbl;
            DepartamentoLbl.Text = My.Resources.ArchivoIdioma.DepartamentoLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(RazonSocialTxt, My.Resources.ArchivoIdioma.TTRazonSocial);
            ControlesTP.SetToolTip(CuitTxt, My.Resources.ArchivoIdioma.TTCuit);
            ControlesTP.SetToolTip(TelefonosDG, My.Resources.ArchivoIdioma.TTListaTel);
            ControlesTP.SetToolTip(LocalidadCMB, My.Resources.ArchivoIdioma.TTLocalidad);
            ControlesTP.SetToolTip(AgregarLocBtn, My.Resources.ArchivoIdioma.TTAgregarLocalidad);
            ControlesTP.SetToolTip(CalleTxt, My.Resources.ArchivoIdioma.TTCalleCli);
            ControlesTP.SetToolTip(NumeroTxt, My.Resources.ArchivoIdioma.TTNumeroCalleCli);
            ControlesTP.SetToolTip(PisoTxt, My.Resources.ArchivoIdioma.TTPisoCli);
            ControlesTP.SetToolTip(DepartamentoTxt, My.Resources.ArchivoIdioma.TTDepartemento);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarModCli);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}