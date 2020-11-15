using System;
using System.Windows.Forms;

namespace MercaderSG
{
    public partial class ResultadoFamPatUsu
    {
        public ResultadoFamPatUsu()
        {
            InitializeComponent();
        }

        private void ErrorFamPatUsu_Load(object sender, EventArgs e)
        {
            Text = My.Resources.ArchivoIdioma.InformeErrores;
        }

        private void ResultadoFamPatUsu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}