using System;
using System.Windows.Forms;
using Excepciones;
using Negocios;

namespace MercaderSG
{
    public partial class ConsultarRemito
    {
        public ConsultarRemito()
        {
            InitializeComponent();
        }

        public string NroNota;

        private void ConsultarRemito_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.ConsultaRemitoFrm;
            var RemDS = new GeneralDS();
            try
            {
                NVRemitoRN.CargarRemitoNV(RemDS, NroNota);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                My.MyProject.Forms.GestionNV.Activate();
                Close();
            }

            var Reporte = new UltimaNVRepor();
            Reporte.SetDataSource(RemDS);
            RemitoCRV.ReportSource = Reporte;
        }

        private void ConsultarRemito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}