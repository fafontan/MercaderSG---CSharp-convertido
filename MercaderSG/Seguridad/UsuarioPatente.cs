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
    public partial class UsuarioPatente
    {
        public UsuarioPatente()
        {
            InitializeComponent();
            _UsuariosCMB.Name = "UsuariosCMB";
            _BuscarBtn.Name = "BuscarBtn";
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _InformacionLbl.Name = "InformacionLbl";
        }

        private StringBuilder AsigPat = new StringBuilder();
        private StringBuilder DenPat = new StringBuilder();
        private StringBuilder PatNoDenegadas = new StringBuilder();
        private Autenticar UsuAut = Autenticar.Instancia();
        private string UsuSel;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool AccionUsuarioAlta = false;
        private bool AccionUsuarioBaja = false;

        private void CargarPermisos()
        {
            if (PermisoOK(37))
            {
                AccionUsuarioAlta = true;
            }

            if (PermisoOK(38))
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
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            var ListaPatentesADenegar = new List<PatUsuEN>();
            int Numero = 1;
            if (DenPatentesCLB.CheckedItems.Count == 0 & PatentesCLB.CheckedItems.Count == 0 & PatDenegadasCLB.CheckedItems.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoPatSel, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectEqual(UsuAut.UsuarioLogueado, UsuariosCMB.SelectedItem.Usuario, false), AccionUsuarioAlta == true), PatDenegadasCLB.CheckedItems.Count > 0), PatentesCLB.CheckedItems.Count > 0), Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectEqual(UsuAut.UsuarioLogueado, UsuariosCMB.SelectedItem.Usuario, false), AccionUsuarioAlta == true), PatDenegadasCLB.CheckedItems.Count > 0)), Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectEqual(UsuAut.UsuarioLogueado, UsuariosCMB.SelectedItem.Usuario, false), AccionUsuarioAlta == true), PatentesCLB.CheckedItems.Count > 0))))

            {
                MessageBox.Show(My.Resources.ArchivoIdioma.MismoUsuarioAltaPatentes, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                for (int i = 0, loopTo = PatentesCLB.Items.Count - 1; i <= loopTo; i++)
                    PatentesCLB.SetItemChecked(i, false);
                for (int i = 0, loopTo1 = PatDenegadasCLB.Items.Count - 1; i <= loopTo1; i++)
                    PatDenegadasCLB.SetItemChecked(i, false);
                return;
            }

            ListaPatentesADenegar.Clear();
            foreach (PatenteEN item in DenPatentesCLB.CheckedItems)
            {
                var UnaPatUsu = new PatUsuEN();
                UnaPatUsu.CodPat = item.CodPat;
                UnaPatUsu.DescPat = item.Descripcion;
                UnaPatUsu.Activo = true;
                ListaPatentesADenegar.Add(UnaPatUsu);
            }

            AsigPat.Clear();
            DenPat.Clear();
            PatNoDenegadas.Clear();

            // Lista patentes para Alta
            string UsuEnc;
            UsuEnc = Seguridad.Encriptar(Conversions.ToString(UsuariosCMB.SelectedItem.Usuario));
            var ListaPatentes = new List<PatUsuEN>();
            foreach (PatenteEN item in PatentesCLB.CheckedItems)
            {
                var UnaPatente = new PatUsuEN();
                UnaPatente.CodPat = item.CodPat;
                UnaPatente.DescPat = item.Descripcion;
                ListaPatentes.Add(UnaPatente);
            }

            foreach (PatenteEN item in PatDenegadasCLB.CheckedItems)
            {
                var UnaPatente = new PatUsuEN();
                UnaPatente.CodPat = item.CodPat;
                UnaPatente.DescPat = item.Descripcion;
                ListaPatentes.Add(UnaPatente);
            }

            var PatUsu = new UsuarioEN();
            PatUsu.UsuPatL = ListaPatentes;

            // Lista Patentes a denegar
            var ListaPatentesDen = new List<PatUsuEN>();
            foreach (PatenteEN item in DenPatentesCLB.CheckedItems)
            {
                var UnaPatente = new PatUsuEN();
                UnaPatente.CodPat = item.CodPat;
                UnaPatente.DescPat = item.Descripcion;
                ListaPatentesDen.Add(UnaPatente);
            }

            var DenPatUsu = new UsuarioEN();
            DenPatUsu.UsuPatL = ListaPatentesDen;


            // Acciones
            // Alta y Denegar
            if (AccionUsuarioAlta == true & AccionUsuarioBaja == true)
            {
                try
                {
                    UsuarioRN.AltaPatenteUsuario(UsuEnc, PatUsu);
                    UsuarioRN.DenegarPatenteUsuario(UsuEnc, DenPatUsu);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UsuariosCMB.DataSource = null;
                    UsuariosCMB.DataSource = UsuarioRN.CargarUsuario();
                    UsuariosCMB.DisplayMember = "Usuario";
                    UsuariosCMB.ValueMember = "CodUsu";
                    LimpiarCLB();
                    return;
                }

                foreach (PatenteEN item in PatentesCLB.CheckedItems)
                {
                    AsigPat.Append(Numero + ") " + item.Descripcion + Environment.NewLine);
                    Numero += 1;
                }

                foreach (PatenteEN item in PatDenegadasCLB.CheckedItems)
                {
                    AsigPat.Append(Numero + ") " + item.Descripcion + Environment.NewLine);
                    Numero += 1;
                }

                CargarPatentes(UsuEnc);
                LimpiarCLB();
                Numero = 1;
                foreach (PatenteEN ItemPat in DenPatentesCLB.Items)
                {
                    foreach (PatUsuEN ItemDen in ListaPatentesADenegar)
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
                foreach (PatUsuEN item in ListaPatentesADenegar)
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
                if (DenPatentesCLB.CheckedItems.Count > 0 & PatDenegadasCLB.CheckedItems.Count > 0 & PatentesCLB.CheckedItems.Count > 0 | DenPatentesCLB.CheckedItems.Count > 0 & PatentesCLB.CheckedItems.Count > 0 | PatDenegadasCLB.CheckedItems.Count > 0 & DenPatentesCLB.CheckedItems.Count > 0)

                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoTienePermisoBajaPatUsu + Environment.NewLine + My.Resources.ArchivoIdioma.NoTienePermisoBajaPatUsu2, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DenPatentesCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoPermisosBajaPatente, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    for (int i = 0, loopTo2 = DenPatentesCLB.Items.Count - 1; i <= loopTo2; i++)
                        DenPatentesCLB.SetItemChecked(i, false);
                    return;
                }

                try
                {
                    UsuarioRN.AltaPatenteUsuario(UsuEnc, PatUsu);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UsuariosCMB.DataSource = null;
                    UsuariosCMB.DataSource = UsuarioRN.CargarUsuario();
                    UsuariosCMB.DisplayMember = "Usuario";
                    UsuariosCMB.ValueMember = "CodUsu";
                    LimpiarCLB();
                    return;
                }

                foreach (PatenteEN item in PatentesCLB.CheckedItems)
                {
                    AsigPat.Append(Numero + ") " + item.Descripcion + Environment.NewLine);
                    Numero += 1;
                }

                foreach (PatenteEN item in PatDenegadasCLB.CheckedItems)
                {
                    AsigPat.Append(Numero + ") " + item.Descripcion + Environment.NewLine);
                    Numero += 1;
                }

                PanelInferior.Visible = true;
                CargarPatentes(UsuEnc);
                LimpiarCLB();
                return;
            }

            // Denegar Solo
            if (AccionUsuarioAlta == false & AccionUsuarioBaja == true)
            {
                if (DenPatentesCLB.CheckedItems.Count > 0 & PatDenegadasCLB.CheckedItems.Count > 0 & PatentesCLB.CheckedItems.Count > 0 | DenPatentesCLB.CheckedItems.Count > 0 & PatentesCLB.CheckedItems.Count > 0 | PatDenegadasCLB.CheckedItems.Count > 0 & DenPatentesCLB.CheckedItems.Count > 0)

                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoTienePermisoAltaPatUsu + Environment.NewLine + My.Resources.ArchivoIdioma.NoTienePermisoAltaPatUsu2, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PatentesCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoPermisosAltaPatente, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    for (int i = 0, loopTo3 = PatentesCLB.Items.Count - 1; i <= loopTo3; i++)
                        PatentesCLB.SetItemChecked(i, false);
                    return;
                }
                else if (PatDenegadasCLB.CheckedItems.Count > 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoPermisosAltaPatente, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    for (int i = 0, loopTo4 = PatentesCLB.Items.Count - 1; i <= loopTo4; i++)
                        PatDenegadasCLB.SetItemChecked(i, false);
                    return;
                }

                try
                {
                    UsuarioRN.DenegarPatenteUsuario(UsuEnc, DenPatUsu);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UsuariosCMB.DataSource = null;
                    UsuariosCMB.DataSource = UsuarioRN.CargarUsuario();
                    UsuariosCMB.DisplayMember = "Usuario";
                    UsuariosCMB.ValueMember = "CodUsu";
                    LimpiarCLB();
                    return;
                }

                CargarPatentes(UsuEnc);
                LimpiarCLB();
                Numero = 1;
                foreach (PatenteEN ItemPat in DenPatentesCLB.Items)
                {
                    foreach (PatUsuEN ItemDen in ListaPatentesADenegar)
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
                foreach (PatUsuEN item in ListaPatentesADenegar)
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

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            PanelInferior.Visible = false;
            string UsuEnc;
            UsuEnc = Seguridad.Encriptar(Conversions.ToString(UsuariosCMB.SelectedItem.Usuario));
            CargarPatentes(UsuEnc);
        }

        private void UsuarioPatente_Load(object sender, EventArgs e)
        {
            CargarTT();
            AplicarIdioma();
            UsuariosCMB.DataSource = UsuarioRN.CargarUsuario();
            UsuariosCMB.DisplayMember = "Usuario";
            UsuariosCMB.ValueMember = "CodUsu";
            AceptarBtn.Enabled = false;
            CargarPermisos();
            PanelInferior.Visible = false;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CargarPatentes(string UsuEnc)
        {
            try
            {
                PatentesCLB.DataSource = PatenteRN.CargarPatente(UsuEnc);
                PatentesCLB.DisplayMember = "Descripcion";
                PatentesCLB.ValueMember = "CodPat";
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsuariosCMB.DataSource = null;
                UsuariosCMB.DataSource = UsuarioRN.CargarUsuario();
                UsuariosCMB.DisplayMember = "Usuario";
                UsuariosCMB.ValueMember = "CodUsu";
                return;
            }

            DenPatentesCLB.DataSource = PatenteRN.CargarPatenteUsuario(UsuEnc);
            DenPatentesCLB.DisplayMember = "Descripcion";
            DenPatentesCLB.ValueMember = "CodPat";
            PatDenegadasCLB.DataSource = PatenteRN.CargarPatentesDenegadasUsuario(UsuEnc);
            PatDenegadasCLB.DisplayMember = "Descripcion";
            PatDenegadasCLB.ValueMember = "CodPat";
            AceptarBtn.Enabled = true;
        }

        private void InformacionLbl_Click(object sender, EventArgs e)
        {
            var frm = new ResultadoFamPatUsu();
            frm.TituloAltaLbl.Text = Conversions.ToString(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.PatOk, UsuariosCMB.SelectedItem.Usuario));
            frm.LblAlta.Text = AsigPat.ToString();
            frm.TituloErrorLbl.Text = My.Resources.ArchivoIdioma.DenegarPatOk;
            frm.LblError.Text = DenPat.ToString();
            frm.TituloNoAltaPermisosLbl.Text = My.Resources.ArchivoIdioma.PatentesNoDenegadasUsu;
            frm.LblErrorEliminarPermisos.Text = PatNoDenegadas.ToString();
            frm.CausaLbl.Text = My.Resources.ArchivoIdioma.CausaUsu;

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

        private void LimpiarCLB()
        {
            for (int i = 0, loopTo = PatentesCLB.Items.Count - 1; i <= loopTo; i++)
                PatentesCLB.SetItemChecked(i, false);
            for (int i = 0, loopTo1 = PatDenegadasCLB.Items.Count - 1; i <= loopTo1; i++)
                PatDenegadasCLB.SetItemChecked(i, false);
            for (int i = 0, loopTo2 = DenPatentesCLB.Items.Count - 1; i <= loopTo2; i++)
                DenPatentesCLB.SetItemChecked(i, false);
        }

        private void UsuarioPatente_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.PatUsuSMI.Enabled = true;
        }

        private void UsuarioPatente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "131");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.UsuarioPatenteFrm;
            UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
            PatentesGB.Text = My.Resources.ArchivoIdioma.PatentesUsuLbl;
            PatDenegadasGB.Text = My.Resources.ArchivoIdioma.PatentesDenegadasUsu;
            DenPatentesGB.Text = My.Resources.ArchivoIdioma.PatentesNoUsuLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
            InformacionLbl.Text = My.Resources.ArchivoIdioma.ResultadoOperacion;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(UsuariosCMB, My.Resources.ArchivoIdioma.TTListaUsuarios);
            ControlesTP.SetToolTip(BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarUsuariosPat);
            ControlesTP.SetToolTip(DenPatentesCLB, My.Resources.ArchivoIdioma.TTPatentesNoUsu);
            ControlesTP.SetToolTip(PatDenegadasCLB, My.Resources.ArchivoIdioma.TTPatDenegadasUsu);
            ControlesTP.SetToolTip(PatentesCLB, My.Resources.ArchivoIdioma.TTPatentesUsu);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAltaBajaPatUsu);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void UsuariosCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCLB();
        }
    }
}