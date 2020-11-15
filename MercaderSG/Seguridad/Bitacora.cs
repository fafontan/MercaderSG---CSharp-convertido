using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using Negocios;

namespace MercaderSG
{
    public partial class Bitacora
    {
        public Bitacora()
        {
            InitializeComponent();
            _ExportarAXLSToolStripMenuItem.Name = "ExportarAXLSToolStripMenuItem";
            _DepurarBtn.Name = "DepurarBtn";
            _FiltroCMB.Name = "FiltroCMB";
            _RecargarBtn.Name = "RecargarBtn";
            _SiguienteBtn.Name = "SiguienteBtn";
            _AnteriorBtn.Name = "AnteriorBtn";
            _UltimoBtn.Name = "UltimoBtn";
            _PrimeroBtn.Name = "PrimeroBtn";
            _BitacoraDG.Name = "BitacoraDG";
        }

        private List<BitacoraEN> ListaBitacora = new List<BitacoraEN>();
        private List<BitacoraEN> ListaBitacoraTemp = new List<BitacoraEN>();
        private List<BitacoraEN> ListaBitacoraTempGral = new List<BitacoraEN>();
        private List<BitacoraEN> ListaBitacoraActualOrdenar = new List<BitacoraEN>();
        public FiltroCompleto FC = new FiltroCompleto();
        public FiltroUsuario FU = new FiltroUsuario();
        public FiltroFecha FF = new FiltroFecha();
        public FiltroCriticidad FCriti = new FiltroCriticidad();
        public int NroPag = 0;
        private int CantidadPaginas = 0;
        public string PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
        public string PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
        public string PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;

        private void Bitacora_Load(object sender, EventArgs e)
        {
            BGW.WorkerReportsProgress = true;
            BGW.WorkerSupportsCancellation = true;
            BGW.RunWorkerAsync();
            My.MyProject.Forms.BarraProgreso.ShowDialog();
            AplicarIdioma();
            CargarTT();
            var ListaUsuarios = new List<UsuarioEN>();
            var UsuarioVacio = new UsuarioEN();
            UsuarioVacio.CodUsu = 0;
            UsuarioVacio.Usuario = "";
            var UsuarioSistema = new UsuarioEN();
            UsuarioSistema.CodUsu = 9999;
            UsuarioSistema.Usuario = "Sistema";
            ListaUsuarios = UsuarioRN.CargarUsuario();
            ListaUsuarios.Insert(0, UsuarioVacio);
            ListaUsuarios.Insert(1, UsuarioSistema);
            FC.UsuarioCMB.DataSource = ListaUsuarios;
            FC.UsuarioCMB.DisplayMember = "Usuario";
            FC.UsuarioCMB.ValueMember = "CodUsu";
            FU.UsuarioCMB.DataSource = ListaUsuarios;
            FU.UsuarioCMB.DisplayMember = "Usuario";
            FU.UsuarioCMB.ValueMember = "CodUsu";
            FC.CriticidadCMB.DataSource = CargarComboCriticidad();
            FC.CriticidadCMB.DisplayMember = "Descripcion";
            FC.CriticidadCMB.ValueMember = "CodCriti";
            FCriti.CriticidadCMB.DataSource = CargarComboCriticidad();
            FCriti.CriticidadCMB.DisplayMember = "Descripcion";
            FCriti.CriticidadCMB.ValueMember = "CodCriti";
            FCriti.CriticidadCMB.SelectedValue = 0;
            FCriti.CriticidadCMB.SelectedValue = 0;
            FC.UsuarioCMB.SelectedValue = 0;
            FU.UsuarioCMB.SelectedValue = 0;
            FiltroCMB.Items.Add(My.Resources.ArchivoIdioma.CompletoLbl);
            FiltroCMB.Items.Add(My.Resources.ArchivoIdioma.UsuarioLbl);
            FiltroCMB.Items.Add(My.Resources.ArchivoIdioma.CriticidadLbl);
            FiltroCMB.Items.Add(My.Resources.ArchivoIdioma.FechaLbl);
            FiltroCMB.SelectedIndex = 0;
            if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }

            ListaBitacoraTempGral.AddRange(ListaBitacora);
            FiltroCompleto.BotonClick += BotonFiltroCompleto;
            FiltroUsuario.BotonClick += BotonFiltroUsuario;
            FiltroCriticidad.BotonClick += BotonFiltroCriticidad;
            FiltroFecha.BotonClick += BotonFiltroFecha;
        }

        public List<CriticidadEN> CargarComboCriticidad()
        {
            var ListaCriticidad = new List<CriticidadEN>();
            var CritiVacia = new CriticidadEN();
            CritiVacia.CodCriti = 0;
            CritiVacia.Descripcion = "";
            ListaCriticidad.Add(CritiVacia);
            var DatosCriti1 = new CriticidadEN();
            DatosCriti1.CodCriti = 1;
            DatosCriti1.Descripcion = My.Resources.ArchivoIdioma.CritiAlta;
            ListaCriticidad.Add(DatosCriti1);
            var DatosCriti2 = new CriticidadEN();
            DatosCriti2.CodCriti = 2;
            DatosCriti2.Descripcion = My.Resources.ArchivoIdioma.CritiMedia;
            ListaCriticidad.Add(DatosCriti2);
            var DatosCrit3 = new CriticidadEN();
            DatosCrit3.CodCriti = 3;
            DatosCrit3.Descripcion = My.Resources.ArchivoIdioma.CritiBaja;
            ListaCriticidad.Add(DatosCrit3);
            return ListaCriticidad;
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            ListaBitacora = BitacoraRN.CargarBitacora();
            for (int i = 0, loopTo = ListaBitacora.Count - 1; i <= loopTo; i++)
            {
                if (BGW.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BGW.ReportProgress((int)(100 * i / (double)ListaBitacora.Count));
                }
            }
        }

        private void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
            Parte1Lbl.Text = string.Empty;
            Parte2Lbl.Text = string.Empty;
            InfoPagLbl.Spring = true;
            InfoPagina(1);
            BitacoraDG.AutoGenerateColumns = false;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            My.MyProject.Forms.BarraProgreso.ProgressBar1.Value = 0;
            My.MyProject.Forms.BarraProgreso.Close();
        }


        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void BotonFiltroCompleto()
        {
            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoEventos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fechas solo
            if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(FC.UsuarioCMB.SelectedValue, 0, false), Operators.ConditionalCompareObjectEqual(FC.CriticidadCMB.SelectedValue, 0, false))))
            {
                NroPag = 0;
                ListaBitacoraTemp.Clear();
                ListaBitacoraTemp.AddRange(ListaBitacora);
                ListaBitacora.Clear();
                var FechaDesdeCom = FC.DesdeComDTP.Value;
                var FechaHastaCom = FC.HastaComDTP.Value;
                ListaBitacora = BitacoraRN.CargarBitacora(FechaDesdeCom, FechaHastaCom);
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.AutoGenerateColumns = false;
                BitacoraDG.DataSource = PaginaSig(NroPag);
                if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
                {
                    DeshabilitarPaginacion();
                }
                else
                {
                    HabilitarPaginacion();
                }

                if (BitacoraDG.Rows.Count == 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControles();
                    ListaBitacora.Clear();
                    ListaBitacora.AddRange(ListaBitacoraTempGral);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                    InfoPagina(1);
                    BitacoraDG.DataSource = null;
                    BitacoraDG.DataSource = PaginaSig(NroPag);
                }

                return;
            }

            // Criticidad + Fechas

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(FC.UsuarioCMB.SelectedValue, 0, false)))
            {
                NroPag = 0;
                ListaBitacoraTemp.Clear();
                ListaBitacoraTemp.AddRange(ListaBitacora);
                ListaBitacora.Clear();
                int CritiCom = Conversions.ToInteger(FC.CriticidadCMB.SelectedValue);
                var FechaDesdeCom = FC.DesdeComDTP.Value;
                var FechaHastaCom = FC.HastaComDTP.Value;
                ListaBitacora = BitacoraRN.CargarBitacora(CritiCom, FechaDesdeCom, FechaHastaCom);
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.AutoGenerateColumns = false;
                BitacoraDG.DataSource = PaginaSig(NroPag);
                if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
                {
                    DeshabilitarPaginacion();
                }
                else
                {
                    HabilitarPaginacion();
                }

                if (BitacoraDG.Rows.Count == 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControles();
                    ListaBitacora.Clear();
                    ListaBitacora.AddRange(ListaBitacoraTempGral);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                    InfoPagina(1);
                    BitacoraDG.DataSource = null;
                    BitacoraDG.DataSource = PaginaSig(NroPag);
                }

                return;
            }

            // Usuario + Fechas

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(FC.CriticidadCMB.SelectedValue, 0, false)))
            {
                NroPag = 0;
                ListaBitacoraTemp.Clear();
                ListaBitacoraTemp.AddRange(ListaBitacora);
                ListaBitacora.Clear();
                string UsuarioCom = Conversions.ToString(FC.UsuarioCMB.SelectedItem);
                //string UsuarioCom = Conversions.ToString(FC.UsuarioCMB.SelectedItem.Usuario);
                var FechaDesdeCom = FC.DesdeComDTP.Value;
                var FechaHastaCom = FC.HastaComDTP.Value;
                ListaBitacora = BitacoraRN.CargarBitacora(UsuarioCom, FechaDesdeCom, FechaHastaCom);
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.AutoGenerateColumns = false;
                BitacoraDG.DataSource = PaginaSig(NroPag);
                if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
                {
                    DeshabilitarPaginacion();
                }
                else
                {
                    HabilitarPaginacion();
                }

                if (BitacoraDG.Rows.Count == 0)
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControles();
                    ListaBitacora.Clear();
                    ListaBitacora.AddRange(ListaBitacoraTempGral);
                    NroPag = 0;
                    CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                    InfoPagina(1);
                    BitacoraDG.DataSource = null;
                    BitacoraDG.DataSource = PaginaSig(NroPag);
                }

                return;
            }

            NroPag = 0;
            ListaBitacoraTemp.Clear();
            ListaBitacoraTemp.AddRange(ListaBitacora);
            ListaBitacora.Clear();
            string Usuario = Conversions.ToString(FC.UsuarioCMB.SelectedItem);
            //string Usuario = Conversions.ToString(FC.UsuarioCMB.SelectedItem.Usuario);
            int Criticidad = Conversions.ToInteger(FC.CriticidadCMB.SelectedValue);
            var FechaDesde = FC.DesdeComDTP.Value;
            var FechaHasta = FC.HastaComDTP.Value;
            ListaBitacora = BitacoraRN.CargarBitacora(Usuario, Criticidad, FechaDesde, FechaHasta);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
            InfoPagina(1);
            BitacoraDG.DataSource = null;
            BitacoraDG.AutoGenerateColumns = false;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControles();
                ListaBitacora.Clear();
                ListaBitacora.AddRange(ListaBitacoraTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaSig(NroPag);
            }
        }

        private void BotonFiltroUsuario()
        {
            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoEventos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NroPag = 0;
            ListaBitacoraTemp.Clear();
            ListaBitacoraTemp.AddRange(ListaBitacora);
            ListaBitacora.Clear();
            string Usuario = Conversions.ToString(FU.UsuarioCMB.SelectedItem);
            //string Usuario = Conversions.ToString(FU.UsuarioCMB.SelectedItem.Usuario);
            ListaBitacora = BitacoraRN.CargarBitacora(Usuario);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
            InfoPagina(1);
            BitacoraDG.DataSource = null;
            BitacoraDG.AutoGenerateColumns = false;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControles();
                ListaBitacora.Clear();
                ListaBitacora.AddRange(ListaBitacoraTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaSig(NroPag);
            }
        }

        private void BotonFiltroCriticidad()
        {
            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoEventos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NroPag = 0;
            ListaBitacoraTemp.Clear();
            ListaBitacoraTemp.AddRange(ListaBitacora);
            ListaBitacora.Clear();
            int Criticidad = Conversions.ToInteger(FCriti.CriticidadCMB.SelectedValue);
            ListaBitacora = BitacoraRN.CargarBitacora(Criticidad);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
            InfoPagina(1);
            BitacoraDG.DataSource = null;
            BitacoraDG.AutoGenerateColumns = false;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControles();
                ListaBitacora.Clear();
                ListaBitacora.AddRange(ListaBitacoraTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaSig(NroPag);
            }
        }

        private void BotonFiltroFecha()
        {
            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoEventos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NroPag = 0;
            ListaBitacoraTemp.Clear();
            ListaBitacoraTemp.AddRange(ListaBitacora);
            ListaBitacora.Clear();
            var FechaDesde = FF.DesdeDTP.Value;
            var FechaHasta = FF.HastaDTP.Value;
            ListaBitacora = BitacoraRN.CargarBitacora(FechaDesde, FechaHasta);
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
            InfoPagina(1);
            BitacoraDG.DataSource = null;
            BitacoraDG.AutoGenerateColumns = false;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            if (CantidadPaginas == 1 | BitacoraDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            if (BitacoraDG.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoExisteEventosBusqueda, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControles();
                ListaBitacora.Clear();
                ListaBitacora.AddRange(ListaBitacoraTempGral);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                InfoPagina(1);
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaSig(NroPag);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void FiltroCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FiltroCMB.SelectedItem)
            {
                case var @case when Operators.ConditionalCompareObjectEqual(@case, My.Resources.ArchivoIdioma.CompletoLbl, false):
                    {
                        LimpiarControles();
                        PanelMedio.Controls.Clear();
                        PanelMedio.Controls.Add(FC);
                        break;
                    }

                case var case1 when Operators.ConditionalCompareObjectEqual(case1, My.Resources.ArchivoIdioma.UsuarioLbl, false):
                    {
                        LimpiarControles();
                        PanelMedio.Controls.Clear();
                        PanelMedio.Controls.Add(FU);
                        break;
                    }

                case var case2 when Operators.ConditionalCompareObjectEqual(case2, My.Resources.ArchivoIdioma.CriticidadLbl, false):
                    {
                        LimpiarControles();
                        PanelMedio.Controls.Clear();
                        PanelMedio.Controls.Add(FCriti);
                        break;
                    }

                case var case3 when Operators.ConditionalCompareObjectEqual(case3, My.Resources.ArchivoIdioma.FechaLbl, false):
                    {
                        LimpiarControles();
                        PanelMedio.Controls.Clear();
                        PanelMedio.Controls.Add(FF);
                        break;
                    }
            }
        }

        public void HabilitarPaginacion()
        {
            PrimeroBtn.Enabled = true;
            SiguienteBtn.Enabled = true;
            UltimoBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
        }

        public void DeshabilitarPaginacion()
        {
            PrimeroBtn.Enabled = false;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            AnteriorBtn.Enabled = false;
        }

        private void Bitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.MyProject.Forms.Principal.BitacoraSMI.Enabled = true;
        }

        private void Bitacora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "106");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.E)
            {
                ExportarAXLSToolStripMenuItem.PerformClick();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.D)
            {
                DepurarBtn.PerformClick();
            }
        }

        private void LimpiarControles()
        {
            // Usu
            FU.MensajeTT.Hide(FU.UsuarioCMB);
            FU.UsuarioCMB.SelectedValue = 0;
            // Com
            FC.ErrorP.SetError(FC.UsuarioCMB, "");
            FC.ErrorP.SetError(FC.DesdeComDTP, "");
            FC.ErrorP.SetError(FC.CriticidadCMB, "");
            FC.CriticidadCMB.SelectedValue = 0;
            FC.UsuarioCMB.SelectedValue = 0;
            // Criti
            FCriti.MensajeTT.Hide(FCriti.CriticidadCMB);
            FCriti.CriticidadCMB.SelectedValue = 0;
            // Fecha
            FF.ErrorP.SetError(FF.DesdeDTP, "");
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public List<BitacoraEN> PaginaSig(int NroPagActual)
        {
            NroPag += 1;
            var ListaAux = new List<BitacoraEN>();
            foreach (BitacoraEN item in ListaBitacora.Paginacion(NroPag))
            {
                var UnEvento = new BitacoraEN();
                UnEvento.CodBit = item.CodBit;
                UnEvento.Fecha = item.Fecha;
                UnEvento.Descripcion = item.Descripcion;
                UnEvento.Criticidad = item.Criticidad;
                UnEvento.Usuario = item.Usuario;
                ListaAux.Add(UnEvento);
            }

            return ListaAux;
        }

        public List<BitacoraEN> PaginaAnt(int NroPagActual)
        {
            NroPag -= 1;
            var ListaAux = new List<BitacoraEN>();
            foreach (BitacoraEN item in ListaBitacora.Paginacion(NroPag))
            {
                var UnEvento = new BitacoraEN();
                UnEvento.CodBit = item.CodBit;
                UnEvento.Fecha = item.Fecha;
                UnEvento.Descripcion = item.Descripcion;
                UnEvento.Criticidad = item.Criticidad;
                UnEvento.Usuario = item.Usuario;
                ListaAux.Add(UnEvento);
            }

            return ListaAux;
        }

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            if (NroPag > CantidadPaginas - 1)
            {
                SiguienteBtn.Enabled = false;
                UltimoBtn.Enabled = false;
            }
            else
            {
                PrimeroBtn.Enabled = true;
                AnteriorBtn.Enabled = true;
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaSig(NroPag);
                InfoPagina(NroPag);
            }
        }

        private void AnteriorBtn_Click(object sender, EventArgs e)
        {
            if (NroPag == 1)
            {
                PrimeroBtn.Enabled = false;
                AnteriorBtn.Enabled = false;
            }
            else
            {
                SiguienteBtn.Enabled = true;
                UltimoBtn.Enabled = true;
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaAnt(NroPag);
                InfoPagina(NroPag);
            }
        }

        private void PrimeroBtn_Click(object sender, EventArgs e)
        {
            NroPag = 0;
            PrimeroBtn.Enabled = false;
            AnteriorBtn.Enabled = false;
            SiguienteBtn.Enabled = true;
            UltimoBtn.Enabled = true;
            BitacoraDG.DataSource = null;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void UltimoBtn_Click(object sender, EventArgs e)
        {
            NroPag = CantidadPaginas - 1;
            SiguienteBtn.Enabled = false;
            UltimoBtn.Enabled = false;
            PrimeroBtn.Enabled = true;
            AnteriorBtn.Enabled = true;
            BitacoraDG.DataSource = null;
            BitacoraDG.DataSource = PaginaSig(NroPag);
            InfoPagina(NroPag);
        }

        private void RecargarBtn_Click(object sender, EventArgs e)
        {
            if (BitacoraDG.Rows.Count == 0)
            {
                DeshabilitarPaginacion();
                return;
            }

            if (CantidadPaginas == 1)
            {
                DeshabilitarPaginacion();
            }
            else
            {
                HabilitarPaginacion();
            }

            ListaBitacora.Clear();
            ListaBitacora.AddRange(ListaBitacoraTempGral);
            NroPag = 0;
            CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
            InfoPagina(1);
            BitacoraDG.DataSource = null;
            BitacoraDG.DataSource = PaginaSig(NroPag);
        }

        public void InfoPagina(int NroPag)
        {
            InfoPagLbl.Text = PaginaNro + " " + NroPag + " " + PaginaDe + " " + CantidadPaginas + " " + PaginaRegistros + " " + ListaBitacora.Count;
            InfoPagLbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void ExportarAXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BitacoraDG.RowCount > 0)
            {
                var Sfd = new SaveFileDialog();
                Sfd.Filter = "Excel (*.xls)|*.xls";
                Sfd.FileName = My.Resources.ArchivoIdioma.FileNameBitacoraPdfXls;
                if (Sfd.ShowDialog() == DialogResult.OK)
                {
                    var App = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook WB;
                    var WS = new Microsoft.Office.Interop.Excel.Worksheet();
                    WB = App.Workbooks.Add();
                    WS = (Microsoft.Office.Interop.Excel.Worksheet)WB.ActiveSheet;
                    for (int i = 1, loopTo = BitacoraDG.Columns.Count; i <= loopTo; i++)
                        WS.Cells[(object)1, (object)i] = BitacoraDG.Columns[i - 1].HeaderText;
                    for (int i = 0, loopTo1 = BitacoraDG.Rows.Count - 1; i <= loopTo1; i++)
                    {
                        for (int j = 0, loopTo2 = BitacoraDG.Columns.Count - 1; j <= loopTo2; j++)
                        {
                            WS.Cells[(object)(i + 2), (object)(j + 1)] = BitacoraDG.Rows[i].Cells[j].Value.ToString();
                            WS.Cells[(object)(i + 2), (object)1].Font.Color = (object)Color.Blue;
                        }
                    }

                    {
                        var withBlock = WS.get_Range(WS.Cells[(object)1, (object)1], WS.Cells[(object)1, (object)BitacoraDG.ColumnCount]).Font;
                        withBlock.Color = (object)Color.White;
                        withBlock.Bold = (object)1;
                        withBlock.Size = (object)12;
                    }

                    WS.get_Range(WS.Cells[(object)1, (object)1], WS.Cells[(object)1, (object)BitacoraDG.ColumnCount]).Interior.Color = (object)Color.Black;
                    WS.Columns.AutoFit();
                    WS.Columns.HorizontalAlignment = (object)2;
                    WB.SaveAs(Sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    WB.Close();
                    Process.Start(Sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoRegExportar, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.BitacoraFrm;
            FiltroLbl.Text = My.Resources.ArchivoIdioma.FiltroLbl;
            RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
            CodBitCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
            FechaCAB.HeaderText = My.Resources.ArchivoIdioma.FechaLbl;
            DescripcionCAB.HeaderText = My.Resources.ArchivoIdioma.DescripcionLbl;
            CriticidadCAB.HeaderText = My.Resources.ArchivoIdioma.CriticidadLbl;
            UsuarioCAB.HeaderText = My.Resources.ArchivoIdioma.UsuarioLbl;
            DepurarBtn.Text = My.Resources.ArchivoIdioma.DepurarBitacora;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(FiltroCMB, My.Resources.ArchivoIdioma.TTFiltroBitacora);
            ControlesTP.SetToolTip(SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
            ControlesTP.SetToolTip(AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
            ControlesTP.SetToolTip(UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
            ControlesTP.SetToolTip(PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
            ControlesTP.SetToolTip(RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
            ControlesTP.SetToolTip(BitacoraDG, My.Resources.ArchivoIdioma.TTListaBitacora);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void DepurarBtn_Click(object sender, EventArgs e)
        {
            var ListaRegistros = new List<BitacoraEN>();
            foreach (DataGridViewRow Fila in BitacoraDG.SelectedRows)
            {
                var Bitacora = new BitacoraEN();
                Bitacora.CodBit = Conversions.ToInteger(Fila.Cells[0].Value);
                Bitacora.Fecha = Conversions.ToDate(Fila.Cells[1].Value);
                Bitacora.Descripcion = Conversions.ToString(Fila.Cells[2].Value);
                Bitacora.Criticidad = Conversions.ToString(Fila.Cells[3].Value);
                Bitacora.Usuario = Conversions.ToString(Fila.Cells[4].Value);
                ListaRegistros.Add(Bitacora);
            }

            try
            {
                BitacoraRN.DepurarBitacora(ListaRegistros);
            }
            catch (InformationException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaBitacora.Clear();
                ListaBitacora = BitacoraRN.CargarBitacora();
                ListaBitacoraTempGral.Clear();
                ListaBitacoraTempGral.AddRange(ListaBitacora);
                NroPag = 0;
                CantidadPaginas = (int)Math.Ceiling(Convert.ToDouble(ListaBitacora.Count / 25d));
                BitacoraDG.DataSource = null;
                BitacoraDG.DataSource = PaginaSig(NroPag);
                if (BitacoraDG.Rows.Count > 0)
                {
                    InfoPagina(1);
                }
                else
                {
                    InfoPagina(0);
                }
            }
        }

        private void BitacoraDG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var so = SortOrder.None;
            ListaBitacoraActualOrdenar.Clear();
            foreach (DataGridViewRow fila in BitacoraDG.Rows)
            {
                var UnEvento = new BitacoraEN();
                UnEvento.CodBit = Conversions.ToInteger(fila.Cells[0].Value);
                UnEvento.Fecha = Conversions.ToDate(fila.Cells[1].Value);
                UnEvento.Descripcion = Conversions.ToString(fila.Cells[2].Value);
                UnEvento.Criticidad = Conversions.ToString(fila.Cells[3].Value);
                UnEvento.Usuario = Conversions.ToString(fila.Cells[4].Value);
                ListaBitacoraActualOrdenar.Add(UnEvento);
            }

            if (BitacoraDG.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None || BitacoraDG.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }
            // set SortGlyphDirection after databinding otherwise will always be none 
            Sort(BitacoraDG.Columns[e.ColumnIndex].Name, so);
            BitacoraDG.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }

        private void Sort(string column, SortOrder sortOrder__1)
        {
            switch (column ?? "")
            {
                case "FechaCAB":
                    {
                        if (true)
                        {
                            if (sortOrder__1 == SortOrder.Ascending)
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderBy(x => x.Fecha).ToList();
                            }
                            else
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderByDescending(x => x.Fecha).ToList();
                            }

                            break;
                        }

                        break;
                    }

                case "DescripcionCAB":
                    {
                        if (true)
                        {
                            if (sortOrder__1 == SortOrder.Ascending)
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderBy(x => x.Descripcion).ToList();
                            }
                            else
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderByDescending(x => x.Descripcion).ToList();
                            }

                            break;
                        }

                        break;
                    }

                case "CriticidadCAB":
                    {
                        if (true)
                        {
                            if (sortOrder__1 == SortOrder.Ascending)
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderBy(x => x.Criticidad).ToList();
                            }
                            else
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderByDescending(x => x.Criticidad).ToList();
                            }

                            break;
                        }

                        break;
                    }

                case "UsuarioCAB":
                    {
                        if (true)
                        {
                            if (sortOrder__1 == SortOrder.Ascending)
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderBy(x => x.Usuario).ToList();
                            }
                            else
                            {
                                BitacoraDG.DataSource = ListaBitacoraActualOrdenar.OrderByDescending(x => x.Usuario).ToList();
                            }

                            break;
                        }

                        break;
                    }
            }
        }
    }
}