using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    public partial class FiltroCriticidad
    {
        public FiltroCriticidad()
        {
            InitializeComponent();
            _CriticidadCMB.Name = "CriticidadCMB";
            _BuscarCritiBtn.Name = "BuscarCritiBtn";
        }

        public static event BotonClickEventHandler BotonClick;

        public delegate void BotonClickEventHandler();

        private void BuscarCritiBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            BotonClick?.Invoke();
        }

        private void CritiTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracterPermitido = "123" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracterPermitido.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CriticidadCMB.SelectedValue, 0, false)))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.DebeSeleccionarCriticidad, CriticidadCMB);
                CriticidadCMB.Focus();
                Resultado = false;
                return Resultado;
            }

            return Resultado;
        }

        private void FiltroCriticidad_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
        }

        public void AplicarIdioma()
        {
            CriticidadGB.Text = My.Resources.ArchivoIdioma.CriticidadGB;
            CriticidadLbl.Text = My.Resources.ArchivoIdioma.CriticidadLbl;
            BuscarCritiBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BuscarCritiBtn, My.Resources.ArchivoIdioma.TTBuscarCriticidad);
        }

        private void CriticidadCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(CriticidadCMB);
        }
    }
}