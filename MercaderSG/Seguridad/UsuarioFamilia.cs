using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;
using Servicios;

namespace MercaderSG
{
    public partial class UsuarioFamilia
    {
        public UsuarioFamilia()
        {
            InitializeComponent();
            _UsuarioCMB.Name = "UsuarioCMB";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _InformacionLbl.Name = "InformacionLbl";
        }

        private StringBuilder CadenaNoAlta = new StringBuilder();
        private StringBuilder CadenaAlta = new StringBuilder();
        private StringBuilder FamNoPatentes = new StringBuilder();
        private bool AccionUsuarioAlta = true;
        private Autenticar UsuAut = Autenticar.Instancia();
        private string UsuSel;
        private int Contador = 0;

        private void FamliaUsuario_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            UsuarioCMB.DataSource = UsuarioRN.CargarUsuario();
            UsuarioCMB.DisplayMember = "Usuario";
            UsuarioCMB.ValueMember = "CodUsu";
            FamiliaCLB.DataSource = FamiliaRN.CargarFamiliaConPatentes();
            FamiliaCLB.DisplayMember = "Descripcion";
            FamiliaCLB.ValueMember = "CodFam";
            PanelInferior.Visible = false;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(UsuAut.UsuarioLogueado, UsuarioCMB.SelectedItem.Usuario, false), AccionUsuarioAlta == true)))
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.MismoUsuarioAltaFamilia, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCLB();
                return;
            }

            var ListaFamilia = new List<UsuFamEN>();
            UsuSel = Conversions.ToString(UsuarioCMB.SelectedItem.Usuario);
            string UsuEnc = "";
            CadenaAlta.Clear();
            CadenaNoAlta.Clear();
            UsuEnc = Seguridad.Encriptar(Conversions.ToString(UsuarioCMB.SelectedItem.Usuario));
            if (FamiliaCLB.CheckedIndices.Count > 0)
            {
                foreach (FamiliaEN item in FamiliaCLB.CheckedItems)
                {
                    var UnUsuFam = new UsuFamEN();
                    UnUsuFam.CodFam = item.CodFam;
                    UnUsuFam.DescFam = item.Descripcion;
                    ListaFamilia.Add(UnUsuFam);
                }
            }
            else
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoFamSel, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var UsuFam = new UsuarioEN();
            UsuFam.UsuFamL = ListaFamilia;
            try
            {
                UsuarioRN.AltaUsuarioFamilia(UsuEnc, UsuFam);
            }
            catch (WarningException ex)
            {
                if ((ex.Message ?? "") == (My.Resources.ArchivoIdioma.UsuarioDadoBaja ?? ""))
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UsuarioCMB.DataSource = null;
                    UsuarioCMB.DataSource = UsuarioRN.CargarUsuario();
                    UsuarioCMB.DisplayMember = "Usuario";
                    UsuarioCMB.ValueMember = "CodUsu";
                    LimpiarCLB();
                    return;
                }

                PanelInferior.Visible = true;
                bool Opcion;
                int ContadorAdver = 0;
                Contador = 0;
                foreach (FamiliaEN item in FamiliaCLB.CheckedItems)
                {
                    Opcion = true;
                    foreach (UsuFamEN fam in ex.MensajesUsuFam)
                    {
                        if ((item.Descripcion ?? "") == (fam.DescFam ?? ""))
                        {
                            ContadorAdver += 1;
                            CadenaNoAlta.Append(ContadorAdver + ") " + fam.DescFam + Environment.NewLine);
                            Opcion = false;
                            break;
                        }
                    }

                    if (Opcion)
                    {
                        Contador += 1;
                        CadenaAlta.Append(Contador + ") " + item.Descripcion + Environment.NewLine);
                    }
                }

                LimpiarCLB();
            }
            catch (CriticalException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCLB();
            }

            Contador = 0;
            foreach (FamiliaEN item in FamiliaCLB.CheckedItems)
            {
                Contador += 1;
                CadenaAlta.Append(Contador + ") " + item.Descripcion + Environment.NewLine);
            }

            PanelInferior.Visible = true;
            LimpiarCLB();
        }

        private void ErrorLbl_Click(object sender, EventArgs e)
        {
            var frm = new ResultadoFamPatUsu();
            frm.TituloAltaLbl.Text = My.Resources.ArchivoIdioma.AltaUsuFam;
            frm.TituloErrorLbl.Text = My.Resources.ArchivoIdioma.NoTieneFamilia1 + UsuSel + My.Resources.ArchivoIdioma.NoTieneFamilia2;
            frm.LblError.Text = CadenaNoAlta.ToString();
            frm.LblAlta.Text = CadenaAlta.ToString();
            if (CadenaNoAlta.Length > 0)
            {
                frm.AdvertenciaPanel.Visible = true;
            }
            else
            {
                frm.AdvertenciaPanel.Visible = false;
            }

            if (CadenaAlta.Length > 0)
            {
                frm.InformacionPanel.Visible = true;
            }
            else
            {
                frm.InformacionPanel.Visible = false;
            }

            frm.AdvertenciaPanelPatentes.Visible = false;
            frm.ShowDialog();
            PanelInferior.Visible = false;
        }

        public void LimpiarCLB()
        {
            for (int i = 0, loopTo = FamiliaCLB.Items.Count - 1; i <= loopTo; i++)
                FamiliaCLB.SetItemChecked(i, false);
        }

        private void UsuarioFamilia_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.UsuFamSMI.Enabled = true;
        }

        private void UsuarioFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "113");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.UsuarioFamiliaFrm;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            FamiliaGB.Text = My.Resources.ArchivoIdioma.FamiliasGBTiene;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
            InformacionLbl.Text = My.Resources.ArchivoIdioma.ResultadoOperacion;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(UsuarioCMB, My.Resources.ArchivoIdioma.TTListaUsuarios);
            ControlesTP.SetToolTip(FamiliaCLB, My.Resources.ArchivoIdioma.TTlistaFamilias);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAltaUsuFam);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsuarioCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCLB();
        }
    }
}