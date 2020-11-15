using System;

namespace MercaderSG
{
    public partial class FiltroCompleto
    {
        public FiltroCompleto()
        {
            InitializeComponent();
            _DesdeComDTP.Name = "DesdeComDTP";
            _BuscarComBtn.Name = "BuscarComBtn";
        }

        public static event BotonClickEventHandler BotonClick;

        public delegate void BotonClickEventHandler();

        private void BuscarComBtn_Click(object sender, EventArgs e)
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
            if (DesdeComDTP.Value > HastaComDTP.Value)
            {
                ErrorP.SetError(DesdeComDTP, My.Resources.ArchivoIdioma.FechaDesdeMenor);
                DesdeComDTP.Focus();
                Resultado = false;
            }

            return Resultado;
        }

        private void DesdeComDTP_ValueChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DesdeComDTP, "");
        }

        private void FiltroCompleto_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            HastaComDTP.MaxDate = DateTime.Today;
            DesdeComDTP.MaxDate = DateTime.Today;
        }

        public void AplicarIdioma()
        {
            CompletoGB.Text = My.Resources.ArchivoIdioma.FCompletoGB;
            DesdeComLbl.Text = My.Resources.ArchivoIdioma.FechaDesdeLbl;
            HastaComLbl.Text = My.Resources.ArchivoIdioma.FechaHastaLbl;
            UsuComLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            CritiComLbl.Text = My.Resources.ArchivoIdioma.CriticidadLbl;
            BuscarComBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BuscarComBtn, My.Resources.ArchivoIdioma.TTBuscarCompleto);
        }
    }
}