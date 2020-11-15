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
    public partial class GestionNV
    {
        public GestionNV()
        {
            InitializeComponent();
            _NroNotaTxt.Name = "NroNotaTxt";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _BuscarBtn.Name = "BuscarBtn";
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private Autenticar UsuAut = Autenticar.Instancia();
        public bool ConsultarNota = false;
        public bool BajaNV = false;
        public bool ConsultaRemitoNV = false;
        public bool GenerarRemitoNV = false;

        private void CargarPermisos()
        {
            ConsultarNota = PermisoOK(14);
            BajaNV = PermisoOK(17);
            ConsultaRemitoNV = PermisoOK(15);
            GenerarRemitoNV = PermisoOK(16);
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
        private void GestionNV_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            CargarPermisos();
            if (ConsultarNota == true)
            {
                AccionCMB.Items.Add(My.Resources.ArchivoIdioma.ConsultarNV);
            }

            if (ConsultaRemitoNV == true)
            {
                AccionCMB.Items.Add(My.Resources.ArchivoIdioma.ConsultarRemNV);
            }

            if (GenerarRemitoNV == true)
            {
                AccionCMB.Items.Add(My.Resources.ArchivoIdioma.GenerarRemito);
            }

            if (BajaNV == true)
            {
                AccionCMB.Items.Add(My.Resources.ArchivoIdioma.BajaNotaVenta);
            }

            AccionCMB.SelectedIndex = 0;
            NotaVentaDG.AutoGenerateColumns = false;
            NotaVentaDG.DataSource = NotaVentaRN.CargarNotaVenta();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (NotaVentaDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoNotasVentas, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = NotaVentaDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarNV, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (AccionCMB.SelectedItem)
            {
                case var @case when Operators.ConditionalCompareObjectEqual(@case, My.Resources.ArchivoIdioma.ConsultarNV, false):
                    {
                        var frm = new ConsultarNV();
                        frm.NroNota = Conversions.ToString(NotaVentaDG.CurrentRow.Cells[0].Value);
                        frm.Show();
                        NroNotaTxt.Clear();
                        break;
                    }

                case var case1 when Operators.ConditionalCompareObjectEqual(case1, My.Resources.ArchivoIdioma.GenerarRemito, false):
                    {
                        try
                        {
                            NVRemitoRN.GenerarRemito(Conversions.ToString(NotaVentaDG.CurrentRow.Cells[0].Value));
                        }
                        catch (InformationException ex)
                        {
                            MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NroNotaTxt.Clear();
                        }
                        catch (WarningException ex)
                        {
                            MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NroNotaTxt.Clear();
                        }

                        break;
                    }

                case var case2 when Operators.ConditionalCompareObjectEqual(case2, My.Resources.ArchivoIdioma.ConsultarRemNV, false):
                    {
                        var frm = new ConsultarRemito();
                        frm.NroNota = Conversions.ToString(NotaVentaDG.CurrentRow.Cells[0].Value);
                        frm.Show();
                        NroNotaTxt.Clear();
                        break;
                    }

                case var case3 when Operators.ConditionalCompareObjectEqual(case3, My.Resources.ArchivoIdioma.BajaNotaVenta, false):
                    {
                        try
                        {
                            var NV = new NotaVentaEN();
                            NV.NroNota = Conversions.ToString(NotaVentaDG.CurrentRow.Cells[0].Value);
                            NotaVentaRN.BajaNotaVenta(NV);
                        }
                        catch (InformationException ex)
                        {
                            MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NotaVentaDG.DataSource = NotaVentaRN.CargarNotaVenta();
                            NroNotaTxt.Clear();
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

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (!ConsistenciaDatos())
            {
                return;
            }

            try
            {
                NotaVentaDG.DataSource = NotaVentaRN.BuscarNotaVenta(NroNotaTxt.Text);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NroNotaTxt.Clear();
                NotaVentaDG.DataSource = NotaVentaRN.CargarNotaVenta();
            }

            if (NotaVentaDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteNVBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NroNotaTxt.Clear();
                NotaVentaDG.DataSource = NotaVentaRN.CargarNotaVenta();
            }
        }

        private void GestionNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionNVSMI.Enabled = true;
        }

        private void GestionNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "117");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionNVFrm;
            AccionLbl.Text = My.Resources.ArchivoIdioma.AccionLbl;
            NroNotaLbl.Text = My.Resources.ArchivoIdioma.NumeroNota;
            BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
            NotaGB.Text = My.Resources.ArchivoIdioma.NotaVentaGB;
            NroNotaCAB.HeaderText = My.Resources.ArchivoIdioma.NroNotaCAB;
            FechaCAB.HeaderText = My.Resources.ArchivoIdioma.FechaLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(AccionCMB, My.Resources.ArchivoIdioma.TTListaAcciones);
            ControlesTP.SetToolTip(NroNotaTxt, My.Resources.ArchivoIdioma.TTNroNotaVenta);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarNotaVenta);
            ControlesTP.SetToolTip(NotaVentaDG, My.Resources.ArchivoIdioma.TTListaNotaVenta);
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
    }
}