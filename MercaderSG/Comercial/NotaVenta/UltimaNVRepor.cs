using System;
using System.Windows.Forms;
using Negocios;

namespace MercaderSG
{
    public partial class UltimaNVRepor
    {
        public UltimaNVRepor()
        {
            InitializeComponent();
        }

        private void ReportesNV_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.UltimaNotaVentaFrm;
            var NVDS = new GeneralDS();
            NotaVentaRN.CargarUltimaNotaVenta(NVDS);
            var Reporte = new NotaVentaRP();
            Reporte.SetDataSource(NVDS);
            UltimaNotaRPV.ReportSource = Reporte;
        }

        private void UltimaNVRepor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}