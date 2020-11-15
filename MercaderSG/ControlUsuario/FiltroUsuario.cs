using System;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    public partial class FiltroUsuario
    {
        public FiltroUsuario()
        {
            InitializeComponent();
            _UsuarioCMB.Name = "UsuarioCMB";
            _BuscarUsuBtn.Name = "BuscarUsuBtn";
        }

        public static event BotonClickEventHandler BotonClick;

        public delegate void BotonClickEventHandler();

        private void BuscarUsuBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            BotonClick?.Invoke();
        }

        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(UsuarioCMB.SelectedValue, 0, false)))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.DebeSeleccionarUsuario, UsuarioCMB);
                UsuarioCMB.Focus();
                Resultado = false;
                return Resultado;
            }

            return Resultado;
        }

        private void FiltroUsuario_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
        }

        public void AplicarIdioma()
        {
            UsuarioGB.Text = My.Resources.ArchivoIdioma.UsuarioGBBit;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            BuscarUsuBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BuscarUsuBtn, My.Resources.ArchivoIdioma.TTBuscarUsuarios);
        }

        private void UsuarioCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(UsuarioCMB);
        }
    }
}