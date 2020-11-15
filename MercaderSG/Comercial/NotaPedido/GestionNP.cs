using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class GestionNP
    {
        public GestionNP()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _BuscarBtn.Name = "BuscarBtn";
            _NroNotaTxt.Name = "NroNotaTxt";
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private Autenticar UsuAut = Autenticar.Instancia();
        public bool ConsultarNota = false;
        public bool BajaNP = false;

        private void CargarPermisos()
        {
            ConsultarNota = PermisoOK(19);
            BajaNP = PermisoOK(20);
        }

        private bool PermisoOK(int CodPat)
        {
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(fila[0], CodPat, false)))
                {
                    return true;
                }
            }

            return false;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void GestionNP_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarPermisos();
            if (ConsultarNota == true)
            {
                AccionCMB.Items.Add(My.Resources.ArchivoIdioma.ConsultarNP);
            }

            if (BajaNP == true)
            {
                AccionCMB.Items.Add(My.Resources.ArchivoIdioma.BajaNotaPed);
            }

            AccionCMB.SelectedIndex = 0;
            NotaPedidoDG.AutoGenerateColumns = false;
            NotaPedidoDG.DataSource = NotaPedidoRN.CargarNotaPedido();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            try
            {
                NotaPedidoDG.DataSource = NotaPedidoRN.BuscarNotaPedido(NroNotaTxt.Text);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NroNotaTxt.Clear();
                NroNotaTxt.Focus();
                NotaPedidoDG.DataSource = NotaPedidoRN.CargarNotaPedido();
            }

            if (NotaPedidoDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteNPBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NroNotaTxt.Clear();
                NroNotaTxt.Focus();
                NotaPedidoDG.DataSource = NotaPedidoRN.CargarNotaPedido();
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (NotaPedidoDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoNotasPedido, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = NotaPedidoDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarNP, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (AccionCMB.SelectedItem)
            {
                case var @case when Operators.ConditionalCompareObjectEqual(@case, My.Resources.ArchivoIdioma.ConsultarNP, false):
                    {
                        var frm = new ConsultarNP();
                        frm.NroNota = Conversions.ToString(NotaPedidoDG.CurrentRow.Cells[0].Value);
                        frm.Show();
                        break;
                    }

                case var case1 when Operators.ConditionalCompareObjectEqual(case1, My.Resources.ArchivoIdioma.BajaNotaPed, false):
                    {
                        var NV = new NotaPedidoEN();
                        NV.NroNota = Conversions.ToString(NotaPedidoDG.CurrentRow.Cells[0].Value);
                        try
                        {
                            NotaPedidoRN.BajaNotaPedido(NV);
                        }
                        catch (InformationException ex)
                        {
                            MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NotaPedidoDG.DataSource = NotaPedidoRN.CargarNotaPedido();
                        }
                        catch (WarningException ex)
                        {
                            MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NroNotaTxt.Clear();
                        }

                        break;
                    }
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionNPFrm;
            AccionLbl.Text = My.Resources.ArchivoIdioma.AccionLbl;
            NroNotaLbl.Text = My.Resources.ArchivoIdioma.NumeroNota;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            NotaGB.Text = My.Resources.ArchivoIdioma.NotaPedidoGB;
            NroNotaCAB.HeaderText = My.Resources.ArchivoIdioma.NroNotaCAB;
            FechaCAB.HeaderText = My.Resources.ArchivoIdioma.FechaLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(AccionCMB, My.Resources.ArchivoIdioma.TTListaAcciones);
            ControlesTP.SetToolTip(NroNotaTxt, My.Resources.ArchivoIdioma.TTNroNotaPedido);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarNotaPedido);
            ControlesTP.SetToolTip(NotaPedidoDG, My.Resources.ArchivoIdioma.TTListaNotaPedido);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTRealizarAccion);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool ConsistenciaDatos()
        {
            bool Resultado = true;
            if (string.IsNullOrEmpty(NroNotaTxt.Text))
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.CampoVacio, NroNotaTxt);
                Resultado = false;
                return Resultado;
            }

            return Resultado;
        }

        private void NroNotaTxt_TextChanged(object sender, EventArgs e)
        {
            MensajeTT.Hide(NroNotaTxt);
        }

        private void NroNotaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string CaracteresPermitidos = "QWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjklñzxcvbnm1234567890-" + Convert.ToChar(8);
            char c = e.KeyChar;
            if (!CaracteresPermitidos.Contains(Conversions.ToString(c)))
            {
                e.Handled = true;
            }
        }

        private void NroNotaTxt_Validated(object sender, EventArgs e)
        {
            NroNotaTxt.Text = Strings.UCase(NroNotaTxt.Text);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void GestionNP_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionNPSMI.Enabled = true;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionNP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "116");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}