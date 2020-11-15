using System;

namespace MercaderSG
{
    public partial class FiltroFecha
    {
        public FiltroFecha()
        {
            InitializeComponent();
            _DesdeDTP.Name = "DesdeDTP";
            _BuscarFechaBtn.Name = "BuscarFechaBtn";
        }

        public static event BotonClickEventHandler BotonClick;

        public delegate void BotonClickEventHandler();

        private void BuscarFechaBtn_Click(object sender, EventArgs e)
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
            if (DesdeDTP.Value > HastaDTP.Value)
            {
                ErrorP.SetError(DesdeDTP, My.Resources.ArchivoIdioma.FechaDesdeMenor);
                DesdeDTP.Focus();
                Resultado = false;
            }

            return Resultado;
        }

        private void DesdeDTP_ValueChanged(object sender, EventArgs e)
        {
            ErrorP.SetError(DesdeDTP, "");
        }

        private void FiltroFecha_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            HastaDTP.MaxDate = DateTime.Today;
            DesdeDTP.MaxDate = DateTime.Today;
        }

        public void AplicarIdioma()
        {
            FechasGB.Text = My.Resources.ArchivoIdioma.FechasGB;
            DesdeLbl.Text = My.Resources.ArchivoIdioma.FechaDesdeLbl;
            HastaLbl.Text = My.Resources.ArchivoIdioma.FechaHastaLbl;
            BuscarFechaBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(BuscarFechaBtn, My.Resources.ArchivoIdioma.TTBuscarFechas);
        }
    }
}