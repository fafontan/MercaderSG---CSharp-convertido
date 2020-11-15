using System;
using Negocios;

namespace MercaderSG
{
    public partial class UltimaNPRepor
    {
        public UltimaNPRepor()
        {
            InitializeComponent();
        }

        private void UltimaNPRepor_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.UltimaNotaPedidoFrm;
            var NPDS = new GeneralDS();
            NotaPedidoRN.CargarUltimaNotaPedido(NPDS);
            var Reporte = new NotaPedidoRP();
            Reporte.SetDataSource(NPDS);
            UltimaNotaPedRPV.ReportSource = Reporte;
        }
    }
}