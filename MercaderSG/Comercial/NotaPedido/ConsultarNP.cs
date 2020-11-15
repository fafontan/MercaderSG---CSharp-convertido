using System;
using System.Windows.Forms;
using Excepciones;
using Negocios;

namespace MercaderSG
{
    public partial class ConsultarNP
    {
        public ConsultarNP()
        {
            InitializeComponent();
        }

        public string NroNota;

        private void ConsultarNP_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.ConsultarNPFrm;
            var NPDS = new GeneralDS();
            try
            {
                NotaPedidoRN.CargarNotaPedido(NPDS, NroNota);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                My.MyProject.Forms.GestionNP.Activate();
                Close();
            }

            var Reporte = new NotaPedidoRP();
            Reporte.SetDataSource(NPDS);
            NotaPedidoCRV.ReportSource = Reporte;
        }
    }
}