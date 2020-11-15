using System;
using System.Windows.Forms;
using Excepciones;
using Negocios;

namespace MercaderSG
{
    public partial class ConsultarNV
    {
        public ConsultarNV()
        {
            InitializeComponent();
        }

        public string NroNota;

        private void ConsultarNV_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.NotaVentaFrm;
            var NVDS = new GeneralDS();
            try
            {
                NotaVentaRN.CargarNotaVenta(NVDS, NroNota);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                My.MyProject.Forms.GestionNV.Activate();
                Close();
            }

            var Reporte = new NotaVentaRP();
            Reporte.SetDataSource(NVDS);
            NotaVentaCRV.ReportSource = Reporte;
        }

        private void ConsultarNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}