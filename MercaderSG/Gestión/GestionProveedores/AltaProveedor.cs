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

namespace MercaderSG
{
    public partial class AltaProveedor
    {
        public AltaProveedor()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _DepartamentoTxt.Name = "DepartamentoTxt";
            _AgregarLocBtn.Name = "AgregarLocBtn";
            _PisoTxt.Name = "PisoTxt";
            _CalleTxt.Name = "CalleTxt";
            _NumeroTxt.Name = "NumeroTxt";
            _CorreoElectronicoTxt.Name = "CorreoElectronicoTxt";
            _CuitTxt.Name = "CuitTxt";
            _TelefonoTxt.Name = "TelefonoTxt";
            _QuitarTelBtn.Name = "QuitarTelBtn";
            _AgregarTelBtn.Name = "AgregarTelBtn";
            _TelefonosDG.Name = "TelefonosDG";
            _RazonSocialTxt.Name = "RazonSocialTxt";
        }

        private List<TelefonoEN> ListaTelefonos = new List<TelefonoEN>();
        public bool PuedeModificar = false;

        private void AltaProveedor_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            CargarFoco(DatosGB);
            CargarFoco(TelefonosGB);
            CargarFoco(DomicilioGB);
            LocalidadCMB.DataSource = LocalidadRN.CargarLocalidad();
            LocalidadCMB.DisplayMember = "Descripcion";
            LocalidadCMB.ValueMember = "CodLoc";
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
                MensajeTT.Show(My.Resources.ArchivoIdioma.CincoTelMax, AgregarTelBtn);
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
                TelefonoTxt.Focus();
                ListaTelefonos.RemoveAt(TelefonosDG.CurrentRow.Index);
                TelefonosDG.DataSource = null;
                TelefonosDG.DataSource = ListaTelefonos;
                TelefonosDG.Columns[0].Visible = false;
                TelefonosDG.Columns[1].Visible = false;
                TelefonosDG.Columns[2].Visible = false;
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var ProveedorNuevo = new ProveedorEN();
            ProveedorNuevo.RazonSocial = RazonSocialTxt.Text;
            ProveedorNuevo.Cuit = CuitTxt.Text;
            ProveedorNuevo.CorreoElectronico = CorreoElectronicoTxt.Text;
            ProveedorNuevo.CodLoc = Conversions.ToInteger(LocalidadCMB.SelectedValue);
            ProveedorNuevo.Calle = CalleTxt.Text;
            ProveedorNuevo.Numero = NumeroTxt.Text;
            ProveedorNuevo.Piso = PisoTxt.Text;
            ProveedorNuevo.Departamento = DepartamentoTxt.Text;
            ProveedorNuevo.Telefono = ListaTelefonos;
            try
            {
                ProveedorRN.AltaProveedor(ProveedorNuevo);
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.ProveedorExistente ?? ""))
                {
                    if (PuedeModificar == true)
                    {
                        var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.ModificarProveedor + CuitTxt.Text + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxModificarProveedor, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Resultado == DialogResult.OK)
                        {
                            var frm = new ModificarProveedor();
                            frm.CuitSel = CuitTxt.Text;
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

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarLocBtn_Click(object sender, EventArgs e)
        {
            var frm = new AltaLocalidad();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LocalidadCMB.DataSource = LocalidadRN.CargarLocalidad();
                ErrorP.SetError(AgregarLocBtn, "");
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            ErrorP.SetError(TelefonoTxt, "");
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

            // Correo
            if (string.IsNullOrEmpty(CorreoElectronicoTxt.Text))
            {
                ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.CampoObligatorio);
                Resultado = false;
            }

            switch (CorreoElectronicoTxt.Text.Length)
            {
                case var case5 when case5 > 50:
                    {
                        ErrorP.SetError(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case6 when 1 <= case6 && case6 <= 50:
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
                case var case7 when case7 > 50:
                    {
                        ErrorP.SetError(CalleTxt, My.Resources.ArchivoIdioma.Contener50Carac);
                        Resultado = false;
                        break;
                    }

                case var case8 when 1 <= case8 && case8 <= 50:
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

        private void CorreoElectronicoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(CorreoElectronicoTxt, "");
        }

        private void TelefonoTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(TelefonosDG, "");
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

        private void RazonSocialTxtCalleTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "áéúíóÁÉÍÓÚQWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890.- " + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
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

        private void AltaProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "103");
            }
        }

        private void TelefonosDG_Click(object sender, EventArgs e)
        {
            ErrorP.SetError(TelefonosDG, "");
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
            Text = My.Resources.ArchivoIdioma.AltaProveedorFrm;
            DatosGB.Text = My.Resources.ArchivoIdioma.DatosEmpresa;
            RazonSocialLbl.Text = My.Resources.ArchivoIdioma.RazonSocialGral;
            CuitLbl.Text = My.Resources.ArchivoIdioma.CuitGral;
            CorreoElectronicoLbl.Text = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
            TelefonosGB.Text = My.Resources.ArchivoIdioma.TelefonosGB;
            NumeroTelLbl.Text = My.Resources.ArchivoIdioma.NumeroTelLbl;
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
            ControlesTP.SetToolTip(CorreoElectronicoTxt, My.Resources.ArchivoIdioma.TTCorreoElectronico);
            ControlesTP.SetToolTip(TelefonoTxt, My.Resources.ArchivoIdioma.TTTelefonoProv);
            ControlesTP.SetToolTip(AgregarTelBtn, My.Resources.ArchivoIdioma.TTAgregarTel);
            ControlesTP.SetToolTip(QuitarTelBtn, My.Resources.ArchivoIdioma.TTQuitarTel);
            ControlesTP.SetToolTip(TelefonosDG, My.Resources.ArchivoIdioma.TTListaTel);
            ControlesTP.SetToolTip(LocalidadCMB, My.Resources.ArchivoIdioma.TTLocalidad);
            ControlesTP.SetToolTip(AgregarLocBtn, My.Resources.ArchivoIdioma.TTAgregarLocalidad);
            ControlesTP.SetToolTip(CalleTxt, My.Resources.ArchivoIdioma.TTCalleProv);
            ControlesTP.SetToolTip(NumeroTxt, My.Resources.ArchivoIdioma.TTNumeroCalleProv);
            ControlesTP.SetToolTip(PisoTxt, My.Resources.ArchivoIdioma.TTPisoProv);
            ControlesTP.SetToolTip(DepartamentoTxt, My.Resources.ArchivoIdioma.TTDepartemento);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarAltaProv);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}