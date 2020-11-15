using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class GestionFamilia
    {
        public GestionFamilia()
        {
            InitializeComponent();
            _AgregarBtn.Name = "AgregarBtn";
            _ModificarBtn.Name = "ModificarBtn";
            _EliminarBtn.Name = "EliminarBtn";
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AltaFamilia = false;
        private bool BajaFamilia = false;
        private bool ModificarFamilia = false;
        private Autenticar UsuAut = Autenticar.Instancia();

        private void CargarPermisos()
        {
            AltaFamilia = PermisoOK(26);
            AgregarBtn.Enabled = AltaFamilia;
            ModificarFamilia = PermisoOK(27);
            ModificarBtn.Enabled = ModificarFamilia;
            BajaFamilia = PermisoOK(28);
            EliminarBtn.Enabled = BajaFamilia;
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
        private void GestionFamilia_Load(object sender, EventArgs e)
        {
            FamiliaDG.AutoGenerateColumns = false;
            FamiliaDG.DataSource = FamiliaRN.CargarFamilia();
            AplicarIdioma();
            CargarTT();
            CargarPermisos();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            var frm = new AltaFamilia();
            frm.PuedeModificar = ModificarFamilia;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FamiliaDG.DataSource = FamiliaRN.CargarFamilia();
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (FamiliaDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoFamilias, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = FamiliaDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarFamilia, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Codigo;
            string Descripcion;
            Codigo = Conversions.ToInteger(FamiliaDG.CurrentRow.Cells[0].Value);
            Descripcion = Conversions.ToString(FamiliaDG.CurrentRow.Cells[1].Value);
            var frm = new ModificarFamilia();
            frm.FamiliaSel = Conversions.ToString(FamiliaDG.CurrentRow.Cells[1].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FamiliaDG.DataSource = FamiliaRN.CargarFamilia();
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (FamiliaDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoFamilias, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Fila = FamiliaDG.CurrentRow;
            if (!Fila.Selected)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.DebeSeleccionarFamilia, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Codigo;
            string Descripcion;
            Codigo = Conversions.ToInteger(FamiliaDG.CurrentRow.Cells[0].Value);
            Descripcion = Conversions.ToString(FamiliaDG.CurrentRow.Cells[1].Value);
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.EliminarFamilia + Descripcion + My.Resources.ArchivoIdioma.Pregunta, My.Resources.ArchivoIdioma.MsgBoxEliminarFamilia, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                var Familia = new FamiliaEN();
                Familia.CodFam = Codigo;
                Familia.Descripcion = Descripcion;
                try
                {
                    FamiliaRN.BajaFamilia(Familia);
                }
                catch (InformationException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FamiliaDG.DataSource = FamiliaRN.CargarFamilia();
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FamiliaDG.DataSource = FamiliaRN.CargarFamilia();
                }
            }
            else
            {
                return;
            }
        }

        private void GestionFamilia_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.GestionFamiliaSMI.Enabled = true;
        }

        private void GestionFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "115");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.N & AltaFamilia == true)
            {
                AgregarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.U & ModificarFamilia == true)
            {
                ModificarBtn.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.D & BajaFamilia == true)
            {
                EliminarBtn.PerformClick();
            }
        }

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.GestionFamiliaFrm;
            OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
            AgregarBtn.Text = My.Resources.ArchivoIdioma.AltaFamBtn;
            ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarFamBtn;
            EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarFamBtn;
            RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
            CodCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            DescripcionCAB.HeaderText = My.Resources.ArchivoIdioma.DescripcionLbl;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(AgregarBtn, My.Resources.ArchivoIdioma.TTAgregarFam);
            ControlesTP.SetToolTip(ModificarBtn, My.Resources.ArchivoIdioma.TTModificarFam);
            ControlesTP.SetToolTip(EliminarBtn, My.Resources.ArchivoIdioma.TTEliminarFam);
            ControlesTP.SetToolTip(FamiliaDG, My.Resources.ArchivoIdioma.TTlistaFamilias);
        }
    }
}