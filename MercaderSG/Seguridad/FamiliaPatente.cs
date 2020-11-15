using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class FamiliaPatente
    {
        public FamiliaPatente()
        {
            InitializeComponent();
            _BuscarBtn.Name = "BuscarBtn";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _InformacionLbl.Name = "InformacionLbl";
        }

        private StringBuilder DenPat = new StringBuilder();
        private StringBuilder AsigPat = new StringBuilder();
        private StringBuilder PatNoDenegadas = new StringBuilder();
        private string DescFamSel;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AccionUsuarioAlta = false;
        private bool AccionUsuarioBaja = false;
        private Autenticar UsuAut = Autenticar.Instancia();

        private void CargarPermisos()
        {
            if (PermisoOK(34))
            {
                AccionUsuarioAlta = true;
            }

            if (PermisoOK(35))
            {
                AccionUsuarioBaja = true;
            }
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
        private void FamiliaPatente_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            CargarPermisos();
            AceptarBtn.Enabled = false;
            PanelInferior.Visible = false;
            FamiliaCMB.DataSource = FamiliaRN.CargarFamilia();
            FamiliaCMB.DisplayMember = "Descripcion";
            FamiliaCMB.ValueMember = "CodFam";
            if (FamiliaCMB.Items.Count == 0)
            {
                BuscarBtn.Enabled = false;
            }
            else
            {
                BuscarBtn.Enabled = true;
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            DescFamSel = Conversions.ToString(FamiliaCMB.SelectedItem.Descripcion);
            CargarPatentes(DescFamSel);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            var ListaPatentesADenegar = new List<FamPatEN>();
            int Numero = 1;
            if (PatentesCLB.CheckedItems.Count == 0 & DenPatentesCLB.CheckedItems.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoPatSel, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PatenteRN.ObtenerPatentesFamilia(Conversions.ToInteger(FamiliaCMB.SelectedItem.CodFam)) == false & PatentesCLB.CheckedItems.Count == 1)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.MasUnaPat, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListaPatentesADenegar.Clear();
            foreach (PatenteEN item in DenPatentesCLB.CheckedItems)
            {
                var UnaPatFam = new FamPatEN();
                UnaPatFam.CodPat = item.CodPat;
                UnaPatFam.DescPat = item.Descripcion;
                UnaPatFam.Activo = true;
                ListaPatentesADenegar.Add(UnaPatFam);
            }

            AsigPat.Clear();
            DenPat.Clear();
            PatNoDenegadas.Clear();

            // Lista Patente para alta
            var ListaPatenes = new List<FamPatEN>();
            int CodFamSel = 0;
            CodFamSel = Conversions.ToInteger(FamiliaCMB.SelectedValue);
            DescFamSel = Conversions.ToString(FamiliaCMB.SelectedItem.Descripcion);
            foreach (PatenteEN item in PatentesCLB.CheckedItems)
            {
                var UnaFamPat = new FamPatEN();
                UnaFamPat.CodFam = CodFamSel;
                UnaFamPat.CodPat = item.CodPat;
                UnaFamPat.DescPat = item.Descripcion;
                ListaPatenes.Add(UnaFamPat);
            }

            var FamPat = new FamiliaEN();
            FamPat.FamPatL = ListaPatenes;

            // Lista Patentes a Denegar
            var ListaPatentesBaja = new List<FamPatEN>();
            foreach (PatenteEN item in DenPatentesCLB.CheckedItems)
            {
                var UnaFamPat = new FamPatEN();
                UnaFamPat.CodFam = CodFamSel;
                UnaFamPat.CodPat = item.CodPat;
                UnaFamPat.DescPat = item.Descripcion;
                ListaPatentesBaja.Add(UnaFamPat);
            }

            var BajaFamPat = new FamiliaEN();
            BajaFamPat.FamPatL = ListaPatentesBaja;

            // Alta y Baja
            if (AccionUsuarioAlta == true & AccionUsuarioBaja == true)
            {
                try
                {
                    FamiliaRN.AltaFamiliaPatente(FamPat);
                    FamiliaRN.BajaFamiliaPatente(DescFamSel, BajaFamPat);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FamiliaCMB.DataSource = null;
                    FamiliaCMB.DataSource = FamiliaRN.CargarFamilia();
                    FamiliaCMB.DisplayMember = "Descripcion";
                    FamiliaCMB.ValueMember = "CodFam";
                    LimpiarCLB();
                    return;
                }

                foreach (PatenteEN item in PatentesCLB.CheckedItems)
                {
                    AsigPat.Append(Numero + ") " + item.Descripcion + Environment.NewLine);
                    Numero += 1;
                }

                CargarPatentes(DescFamSel);
                LimpiarCLB();
                Numero = 1;
                foreach (PatenteEN ItemPat in DenPatentesCLB.Items)
                {
                    foreach (FamPatEN ItemDen in ListaPatentesADenegar)
                    {
                        if (ItemPat.CodPat == ItemDen.CodPat)
                        {
                            PatNoDenegadas.Append(Numero + ") " + ItemPat.Descripcion + Environment.NewLine);
                            Numero += 1;
                            ItemDen.Activo = false;
                        }
                    }
                }

                Numero = 1;
                foreach (FamPatEN item in ListaPatentesADenegar)
                {
                    if (item.Activo == true)
                    {
                        DenPat.Append(Numero + ") " + item.DescPat + Environment.NewLine);
                        Numero += 1;
                    }
                }

                PanelInferior.Visible = true;
                return;
            }

            // Alta Solo
            if (AccionUsuarioAlta == true & AccionUsuarioBaja == false)
            {
                if (DenPatentesCLB.CheckedItems.Count > 0 & PatentesCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoTienePermisoBajaPatFam + Environment.NewLine + My.Resources.ArchivoIdioma.NoTienePermisoBajaPatFam2, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DenPatentesCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoPermisosBajaPatenteFamilia, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    for (int i = 0, loopTo = DenPatentesCLB.Items.Count - 1; i <= loopTo; i++)
                        DenPatentesCLB.SetItemChecked(i, false);
                    return;
                }

                try
                {
                    FamiliaRN.AltaFamiliaPatente(FamPat);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FamiliaCMB.DataSource = null;
                    FamiliaCMB.DataSource = FamiliaRN.CargarFamilia();
                    FamiliaCMB.DisplayMember = "Descripcion";
                    FamiliaCMB.ValueMember = "CodFam";
                    LimpiarCLB();
                    return;
                }

                foreach (PatenteEN item in PatentesCLB.CheckedItems)
                {
                    AsigPat.Append(Numero + ") " + item.Descripcion + Environment.NewLine);
                    Numero += 1;
                }

                PanelInferior.Visible = true;
                CargarPatentes(DescFamSel);
                LimpiarCLB();
                return;
            }

            // Baja Solo
            if (AccionUsuarioAlta == false & AccionUsuarioBaja == true)
            {
                if (PatentesCLB.CheckedItems.Count > 0 & DenPatentesCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoTienePermisoAltaPatFam + Environment.NewLine + My.Resources.ArchivoIdioma.NoTienePermisoAltaPatFam2, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PatentesCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoPermisosAltaPatenteFamilia, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    for (int i = 0, loopTo1 = PatentesCLB.Items.Count - 1; i <= loopTo1; i++)
                        PatentesCLB.SetItemChecked(i, false);
                    return;
                }

                try
                {
                    FamiliaRN.BajaFamiliaPatente(DescFamSel, BajaFamPat);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FamiliaCMB.DataSource = null;
                    FamiliaCMB.DataSource = FamiliaRN.CargarFamilia();
                    FamiliaCMB.DisplayMember = "Descripcion";
                    FamiliaCMB.ValueMember = "CodFam";
                    LimpiarCLB();
                    return;
                }

                CargarPatentes(DescFamSel);
                LimpiarCLB();
                Numero = 1;
                foreach (PatenteEN ItemPat in DenPatentesCLB.Items)
                {
                    foreach (FamPatEN ItemDen in ListaPatentesADenegar)
                    {
                        if (ItemPat.CodPat == ItemDen.CodPat)
                        {
                            PatNoDenegadas.Append(Numero + ") " + ItemPat.Descripcion + Environment.NewLine);
                            Numero += 1;
                            ItemDen.Activo = false;
                        }
                    }
                }

                Numero = 1;
                foreach (FamPatEN item in ListaPatentesADenegar)
                {
                    if (item.Activo == true)
                    {
                        DenPat.Append(Numero + ") " + item.DescPat + Environment.NewLine);
                        Numero += 1;
                    }
                }

                PanelInferior.Visible = true;
                return;
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ErrorLbl_Click(object sender, EventArgs e)
        {
            var frm = new ResultadoFamPatUsu();
            frm.TituloAltaLbl.Text = My.Resources.ArchivoIdioma.AltaFamPat + DescFamSel;
            frm.LblAlta.Text = AsigPat.ToString();
            frm.TituloErrorLbl.Text = My.Resources.ArchivoIdioma.NoTienePatente1 + DescFamSel;
            frm.LblError.Text = DenPat.ToString();
            frm.TituloNoAltaPermisosLbl.Text = My.Resources.ArchivoIdioma.PatentesNoEliminadasFam;
            frm.LblErrorEliminarPermisos.Text = PatNoDenegadas.ToString();
            frm.CausaLbl.Text = My.Resources.ArchivoIdioma.CausaFam;

            // 
            if (DenPat.Length > 0)
            {
                frm.AdvertenciaPanel.Visible = true;
            }
            else
            {
                frm.AdvertenciaPanel.Visible = false;
            }

            // 
            if (AsigPat.Length > 0)
            {
                frm.InformacionPanel.Visible = true;
            }
            else
            {
                frm.InformacionPanel.Visible = false;
            }

            // 
            if (PatNoDenegadas.Length > 0)
            {
                frm.AdvertenciaPanelPatentes.Visible = true;
            }
            else
            {
                frm.AdvertenciaPanelPatentes.Visible = false;
            }

            frm.ShowDialog();
            PanelInferior.Visible = false;
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void LimpiarCLB()
        {
            for (int i = 0, loopTo = PatentesCLB.Items.Count - 1; i <= loopTo; i++)
                PatentesCLB.SetItemChecked(i, false);
            for (int i = 0, loopTo1 = DenPatentesCLB.Items.Count - 1; i <= loopTo1; i++)
                DenPatentesCLB.SetItemChecked(i, false);
        }

        private void FamiliaPatente_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.PatFamSMI.Enabled = true;
        }

        private void FamiliaPatente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "130");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        public void CargarPatentes(string Fam)
        {
            try
            {
                PatentesCLB.DataSource = PatenteRN.CargarNoPatentesFamilia(Fam);
                PatentesCLB.DisplayMember = "Descripcion";
                PatentesCLB.ValueMember = "CodPat";
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FamiliaCMB.DataSource = null;
                FamiliaCMB.DataSource = FamiliaRN.CargarFamilia();
                FamiliaCMB.DisplayMember = "Descripcion";
                FamiliaCMB.ValueMember = "CodFam";
                return;
            }

            DenPatentesCLB.DataSource = PatenteRN.CargarPatentesFamilia(Fam);
            DenPatentesCLB.DisplayMember = "Descripcion";
            DenPatentesCLB.ValueMember = "CodPat";
            AceptarBtn.Enabled = true;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.PatenteFamiliaFrm;
            FamiliaLbl.Text = My.Resources.ArchivoIdioma.FamiliaLbl;
            PatentesNoGB.Text = My.Resources.ArchivoIdioma.PatentesNoFamLbl;
            PatentesGB.Text = My.Resources.ArchivoIdioma.PatentesFamLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
            InformacionLbl.Text = My.Resources.ArchivoIdioma.ResultadoOperacion;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(FamiliaCMB, My.Resources.ArchivoIdioma.TTFamiliaCMB);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarFam);
            ControlesTP.SetToolTip(PatentesCLB, My.Resources.ArchivoIdioma.TTPatentesNoFam);
            ControlesTP.SetToolTip(DenPatentesCLB, My.Resources.ArchivoIdioma.TTPatentesFam);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAltaBajaPatFam);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}