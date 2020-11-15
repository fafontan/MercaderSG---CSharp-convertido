using System;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class ModificarFamilia
    {
        public ModificarFamilia()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _DescripcionTxt.Name = "DescripcionTxt";
        }

        private int CodigoFamilia;
        public string FamiliaSel;

        private void ModificarFamilia_Load(object sender, EventArgs e)
        {
            FamiliaSel = Seguridad.Encriptar(FamiliaSel);
            var Familia = FamiliaRN.ObtenerFamilia(FamiliaSel);
            DescripcionTxt.Text = Familia.Descripcion;
            CodigoFamilia = Familia.CodFam;
            AplicarIdioma();
            CargarTT();
        }

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.ModificarFamFrm;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescripcionModFam);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTModificarFam);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var Familia = new FamiliaEN();
            Familia.CodFam = CodigoFamilia;
            Familia.Descripcion = DescripcionTxt.Text;
            try
            {
                FamiliaRN.ModificarFamilia(Familia);
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

        private void ModificarFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "122");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(DescripcionTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoVacio, DescripcionTxt);
                Resultado = false;
                return Resultado;
            }

            if (DescripcionTxt.Text.Length > 25)
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.Contener25Num, DescripcionTxt);
                Resultado = false;
                return Resultado;
            }

            return Resultado;
        }

        private void DescripcionTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(DescripcionTxt);
        }

        private void DescripcionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPosibles = "qwertyuiopasdfghjklñzxcvbnmáéíúóQWERTYUIOPASDFGHJKLÑZXCVBNMÁÉÍÚÓ-_12334567890" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPosibles.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void DescripcionTxt_Validated(object sender, EventArgs e)
        {
            DescripcionTxt.Text = Strings.UCase(Strings.Mid(DescripcionTxt.Text, 1, 1)) + Strings.LCase(Strings.Mid(DescripcionTxt.Text, 2));
        }
    }
}