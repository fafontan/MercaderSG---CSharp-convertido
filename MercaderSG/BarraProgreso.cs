using System;
using System.Windows.Forms;

namespace MercaderSG
{
    public partial class BarraProgreso
    {
        public BarraProgreso()
        {
            InitializeComponent();
        }

        private void BarraProgreso_Load(object sender, EventArgs e)
        {
            ProgressBar1.Style = ProgressBarStyle.Continuous;
        }
    }
}