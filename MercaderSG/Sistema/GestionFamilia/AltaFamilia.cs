using System;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class AltaFamilia
    {
        public AltaFamilia()
        {
            InitializeComponent();
            _DescripcionTxt.Name = "DescripcionTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
        }

        public bool PuedeModificar = false;

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            var FamiliaNueva = new FamiliaEN();
            FamiliaNueva.Descripcion = DescripcionTxt.Text;
            try
            {
                FamiliaRN.AltaFamilia(FamiliaNueva);
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.FamiliaExistente ?? ""))
                {
                    if (PuedeModificar == true)
                    {
                        var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.ModificarFamilia + DescripcionTxt.Text + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.ModificarFamiliaTitu, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Resultado == DialogResult.OK)
                        {
                            var Frm = new ModificarFamilia();
                            Frm.FamiliaSel = DescripcionTxt.Text;
                            Dispose();
                            Frm.ShowDialog();
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

        private void AltaFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "101");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
        }

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.AltaFamiliaFrm;
            DescripcionLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(DescripcionTxt, My.Resources.ArchivoIdioma.TTDescripcionFam);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAltafam);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
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