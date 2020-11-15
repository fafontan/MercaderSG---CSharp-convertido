using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Microsoft.VisualBasic.CompilerServices;
using Servicios;

namespace MercaderSG
{
    public partial class Principal
    {
        public Principal()
        {
            InitializeComponent();
            _GestionClienteSMI.Name = "GestionClienteSMI";
            _GestionProductoSMI.Name = "GestionProductoSMI";
            _GestionProveedorSMI.Name = "GestionProveedorSMI";
            _GestionNVSMI.Name = "GestionNVSMI";
            _GenerarNVSMI.Name = "GenerarNVSMI";
            _GestionNPSMI.Name = "GestionNPSMI";
            _GenerarNPSMI.Name = "GenerarNPSMI";
            _GestionUsuarioSMI.Name = "GestionUsuarioSMI";
            _GestionFamiliaSMI.Name = "GestionFamiliaSMI";
            _DesbloquearUsuarioSMI.Name = "DesbloquearUsuarioSMI";
            _ResetearContrasenaSMI.Name = "ResetearContrasenaSMI";
            _BackupSMI.Name = "BackupSMI";
            _RestoreSMI.Name = "RestoreSMI";
            _BitacoraSMI.Name = "BitacoraSMI";
            _PatFamSMI.Name = "PatFamSMI";
            _UsuFamSMI.Name = "UsuFamSMI";
            _PatUsuSMI.Name = "PatUsuSMI";
            _RecalcularDVSMI.Name = "RecalcularDVSMI";
            _EspanolSMI.Name = "EspanolSMI";
            _InglesSMI.Name = "InglesSMI";
            _CambiarContrasenaSMI.Name = "CambiarContrasenaSMI";
            _SalirSMI.Name = "SalirSMI";
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public static List<ErrorIntegridadEN> ListaErrorInt = new List<ErrorIntegridadEN>();
        public static DataTable DtErrorIntegridad;
        public static DataTable DtErrorIntegridadDVV;
        private Autenticar UsuAut = Autenticar.Instancia();
        private StringBuilder CadenaTablas = new StringBuilder();
        private bool EstadoIntegridad = false;
        private List<string> ListaFormsNombres = new List<string>();
        private List<string> ListaFormsNombresTT = new List<string>();
        private GestionCliente GestionCliFrm = new GestionCliente();
        private GestionProveedor GestionProvFrm = new GestionProveedor();
        private GestionProducto GestionProdFrm = new GestionProducto();
        private GestionNV GestionNVFrm = new GestionNV();
        private NotaVenta NVFrm = new NotaVenta();
        private GestionNP GestionNPFrm = new GestionNP();
        private NotaPedido NPFrm = new NotaPedido();
        private GestionUsuario GestionUsuFrm = new GestionUsuario();
        private GestionFamilia GestionFamFrm = new GestionFamilia();
        private DesbloquearUsuario DesbloquearUsuFrm = new DesbloquearUsuario();
        private ResetearContrasena ResetearPassFrm = new ResetearContrasena();
        private Backup BackUpFrm = new Backup();
        private Restore RestoreFrm = new Restore();
        private Bitacora BitacoraFrm = new Bitacora();
        private FamiliaPatente PatFamFrm = new FamiliaPatente();
        private UsuarioFamilia UsuFamFrm = new UsuarioFamilia();
        private UsuarioPatente UsuPatFrm = new UsuarioPatente();
        private CambiarContrasena CambiarPass = new CambiarContrasena();
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void CargarPermisos()
        {
            GenerarNVSMI.Enabled = PermisoOK(18);
            GenerarNPSMI.Enabled = PermisoOK(21);
            DesbloquearUsuarioSMI.Enabled = PermisoOK(29);
            ResetearContrasenaSMI.Enabled = PermisoOK(30);
            BackupSMI.Enabled = PermisoOK(31);
            RestoreSMI.Enabled = PermisoOK(32);
            BitacoraSMI.Enabled = PermisoOK(33);
            UsuFamSMI.Enabled = PermisoOK(36);
            EstadoIntegridad = PermisoOK(39);
        }

        private void HabilitarBotones()
        {
            int Contador = 1;
            var ListaGestion = new List<int>();

            // GestionCli
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 1, false), Operators.ConditionalCompareObjectEqual(fila[0], 2, false)), Operators.ConditionalCompareObjectEqual(fila[0], 3, false)), Operators.ConditionalCompareObjectEqual(fila[0], 4, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionClienteSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // GestionProd
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 5, false), Operators.ConditionalCompareObjectEqual(fila[0], 6, false)), Operators.ConditionalCompareObjectEqual(fila[0], 7, false)), Operators.ConditionalCompareObjectEqual(fila[0], 8, false)), Operators.ConditionalCompareObjectEqual(fila[0], 9, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionProductoSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // GestionProv
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 10, false), Operators.ConditionalCompareObjectEqual(fila[0], 11, false)), Operators.ConditionalCompareObjectEqual(fila[0], 12, false)), Operators.ConditionalCompareObjectEqual(fila[0], 13, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionProveedorSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // GestionNV

            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 14, false), Operators.ConditionalCompareObjectEqual(fila[0], 15, false)), Operators.ConditionalCompareObjectEqual(fila[0], 16, false)), Operators.ConditionalCompareObjectEqual(fila[0], 17, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionNVSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // GestionNP
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 19, false), Operators.ConditionalCompareObjectEqual(fila[0], 20, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionNPSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // GestionUsu

            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 22, false), Operators.ConditionalCompareObjectEqual(fila[0], 23, false)), Operators.ConditionalCompareObjectEqual(fila[0], 24, false)), Operators.ConditionalCompareObjectEqual(fila[0], 25, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionUsuarioSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // GestionFam
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 26, false), Operators.ConditionalCompareObjectEqual(fila[0], 27, false)), Operators.ConditionalCompareObjectEqual(fila[0], 28, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                GestionFamiliaSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // Patente-Familia
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 34, false), Operators.ConditionalCompareObjectEqual(fila[0], 35, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                PatFamSMI.Enabled = false;
            }

            ListaGestion.Clear();

            // Patente-Usuario
            foreach (DataRow fila in UsuAut.dtPatUsu.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(fila[0], 37, false), Operators.ConditionalCompareObjectEqual(fila[0], 38, false))))
                {
                    ListaGestion.Add(Contador);
                }
            }

            if (ListaGestion.Count == 0)
            {
                PatUsuSMI.Enabled = false;
            }

            ListaGestion.Clear();
            if (GenerarNVSMI.Enabled == false & GestionNVSMI.Enabled == false)
            {
                NotaVentaSMI.Enabled = false;
            }

            if (GenerarNPSMI.Enabled == false & GestionNPSMI.Enabled == false)
            {
                NotaPedidoSMI.Enabled = false;
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

        private void ControlarIntegridad()
        {
            if (ListaErrorInt.Count > 0)
            {
                if (EstadoIntegridad == true)
                {
                    RecalcularDVSMI.Enabled = true;
                }
                else
                {
                    RecalcularDVSMI.Enabled = false;
                }

                CadenaTablas.Append(My.Resources.ArchivoIdioma.DeshabiltarForms + Environment.NewLine + Environment.NewLine);
                int Contador = 1;
                bool EstadoSistema = false;
                bool EstadoMensaje = false;
                foreach (ErrorIntegridadEN item in ListaErrorInt)
                {
                    if (item.Tabla == "Cliente")
                    {
                        if (GestionClienteSMI.Enabled == true)
                        {
                            GestionClienteSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.GestionClienteFrm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        if (GenerarNVSMI.Enabled == true)
                        {
                            GenerarNVSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.AltaNotaVentaFrm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        continue;
                    }

                    if (item.Tabla == "Producto" | item.Tabla == "Historico_Precio")
                    {
                        if (GestionProductoSMI.Enabled == true)
                        {
                            GestionProductoSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.GestionProductosFrm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        if (GenerarNPSMI.Enabled == true)
                        {
                            GenerarNPSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.AltaNotaPedidoFrm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        if (GenerarNVSMI.Enabled == true)
                        {
                            GenerarNVSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.AltaNotaVentaFrm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        continue;
                    }

                    if (item.Tabla == "Bitacora")
                    {
                        if (BitacoraSMI.Enabled == true)
                        {
                            BitacoraSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.BitacoraFrm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        continue;
                    }

                    if (item.Tabla == "Usuario")
                    {
                        if (GestionUsuarioSMI.Enabled == true)
                        {
                            GestionUsuarioSMI.Enabled = false;
                            CadenaTablas.Append(Contador + ") " + My.Resources.ArchivoIdioma.GestionUsuarioForm + Environment.NewLine);
                            EstadoMensaje = true;
                            Contador += 1;
                        }

                        continue;
                    }

                    if (item.Tabla == "Usu_Pat" | item.Tabla == "Usu_Fam" | item.Tabla == "Fam_Pat")
                    {
                        if (PatUsuSMI.Enabled == true)
                        {
                            PatUsuSMI.Enabled = false;
                        }

                        if (PatFamSMI.Enabled == true)
                        {
                            PatFamSMI.Enabled = false;
                        }

                        if (UsuFamSMI.Enabled == true)
                        {
                            UsuFamSMI.Enabled = false;
                        }

                        EstadoMensaje = false;
                        EstadoSistema = true;
                        CadenaTablas.Clear();
                        CadenaTablas.Append(My.Resources.ArchivoIdioma.SistemaBloqueadoCompleto + Environment.NewLine + My.Resources.ArchivoIdioma.SistemaBloqueadoCompleto2);
                        BloquearSistema();
                        break;
                    }
                }

                if (EstadoSistema == true)
                {
                    // CadenaTablas.Append(Environment.NewLine & My.Resources.ArchivoIdioma.ErrorIntegridadSistema)
                    MessageBox.Show(CadenaTablas.ToString(), My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (EstadoMensaje == true)
                {
                    MessageBox.Show(CadenaTablas.ToString(), My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // If EstadoMensaje = False Then
            // MessageBox.Show(My.Resources.ArchivoIdioma.HayErrorIntegridad, My.Resources.ArchivoIdioma.MsgBoxCritico, MessageBoxButtons.OK, MessageBoxIcon.Error)
            // If RecalcularDVSMI.Enabled = True Then
            // RecalcularDVSMI.PerformClick()
            // End If
            // End If
            else
            {
                RecalcularDVSMI.Enabled = false;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void Principal_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is MdiClient)
                {
                    item.BackColor = Color.WhiteSmoke;
                }
            }

            AplicarIdioma(true, ListaFormsNombres);
            if (UsuAut.dtPatUsu.Rows.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.ElUsuario + UsuAut.UsuarioLogueado + My.Resources.ArchivoIdioma.NoPermisosLogin, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BloquearSistema();
            }
            else
            {
                CargarPermisos();
                HabilitarBotones();
                ControlarIntegridad();
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void AplicarIdioma(bool Estado, List<string> ListaForms)
        {
            if (Estado)
            {
                // Principal
                Text = My.Resources.ArchivoIdioma.PrincipalForm;
                GestionSMI.Text = My.Resources.ArchivoIdioma.GestionPFrm;
                GestionClienteSMI.Text = My.Resources.ArchivoIdioma.ClientePFrm;
                GestionProductoSMI.Text = My.Resources.ArchivoIdioma.ProductoPFrm;
                GestionProveedorSMI.Text = My.Resources.ArchivoIdioma.ProveedorPFrm;
                ComercialSMI.Text = My.Resources.ArchivoIdioma.ComercialPFrm;
                NotaPedidoSMI.Text = My.Resources.ArchivoIdioma.NPPFrm;
                NotaVentaSMI.Text = My.Resources.ArchivoIdioma.NVPfrm;
                GenerarNPSMI.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
                GestionNPSMI.Text = My.Resources.ArchivoIdioma.GestionPFrm;
                GenerarNVSMI.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
                GestionNVSMI.Text = My.Resources.ArchivoIdioma.GestionPFrm;
                SistemaSMI.Text = My.Resources.ArchivoIdioma.SistemaPFrm;
                GestionUsuarioSMI.Text = My.Resources.ArchivoIdioma.GestionUsuPfrm;
                GestionFamiliaSMI.Text = My.Resources.ArchivoIdioma.GestionFamPfrm;
                DesbloquearUsuarioSMI.Text = My.Resources.ArchivoIdioma.DesbloquearPfrm;
                ResetearContrasenaSMI.Text = My.Resources.ArchivoIdioma.ResetearPfrm;
                SeguridadSMI.Text = My.Resources.ArchivoIdioma.SeguridadPfrm;
                BackupSMI.Text = My.Resources.ArchivoIdioma.BackupPfrm;
                RestoreSMI.Text = My.Resources.ArchivoIdioma.RestorePfrm;
                BitacoraSMI.Text = My.Resources.ArchivoIdioma.BitacoraPfrm;
                PatFamSMI.Text = My.Resources.ArchivoIdioma.PatFamPfrm;
                UsuFamSMI.Text = My.Resources.ArchivoIdioma.UsuFamPfrm;
                PatUsuSMI.Text = My.Resources.ArchivoIdioma.PatUsuPfrm;
                RecalcularDVSMI.Text = My.Resources.ArchivoIdioma.RecalcularPfrm;
                PanelSMI.Text = My.Resources.ArchivoIdioma.PanelPfrm;
                IdiomaSMI.Text = My.Resources.ArchivoIdioma.IdiomaPfrm;
                EspanolSMI.Text = My.Resources.ArchivoIdioma.EspanolPfrm;
                InglesSMI.Text = My.Resources.ArchivoIdioma.InglesPfrm;
                CambiarContrasenaSMI.Text = My.Resources.ArchivoIdioma.CambiarPassPfrm;
                SalirSMI.Text = My.Resources.ArchivoIdioma.SalirPfrm;
            }
            else
            {
                foreach (string item in ListaForms)
                {
                    if (item == "Principal")
                    {
                        Text = My.Resources.ArchivoIdioma.PrincipalForm;
                        GestionSMI.Text = My.Resources.ArchivoIdioma.GestionPFrm;
                        GestionClienteSMI.Text = My.Resources.ArchivoIdioma.ClientePFrm;
                        GestionProductoSMI.Text = My.Resources.ArchivoIdioma.ProductoPFrm;
                        GestionProveedorSMI.Text = My.Resources.ArchivoIdioma.ProveedorPFrm;
                        ComercialSMI.Text = My.Resources.ArchivoIdioma.ComercialPFrm;
                        NotaPedidoSMI.Text = My.Resources.ArchivoIdioma.NPPFrm;
                        NotaVentaSMI.Text = My.Resources.ArchivoIdioma.NVPfrm;
                        GenerarNPSMI.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
                        GestionNPSMI.Text = My.Resources.ArchivoIdioma.GestionPFrm;
                        GenerarNVSMI.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
                        GestionNVSMI.Text = My.Resources.ArchivoIdioma.GestionPFrm;
                        SistemaSMI.Text = My.Resources.ArchivoIdioma.SistemaPFrm;
                        GestionUsuarioSMI.Text = My.Resources.ArchivoIdioma.GestionUsuPfrm;
                        GestionFamiliaSMI.Text = My.Resources.ArchivoIdioma.GestionFamPfrm;
                        DesbloquearUsuarioSMI.Text = My.Resources.ArchivoIdioma.DesbloquearPfrm;
                        ResetearContrasenaSMI.Text = My.Resources.ArchivoIdioma.ResetearPfrm;
                        SeguridadSMI.Text = My.Resources.ArchivoIdioma.SeguridadPfrm;
                        BackupSMI.Text = My.Resources.ArchivoIdioma.BackupPfrm;
                        RestoreSMI.Text = My.Resources.ArchivoIdioma.RestorePfrm;
                        BitacoraSMI.Text = My.Resources.ArchivoIdioma.BitacoraPfrm;
                        PatFamSMI.Text = My.Resources.ArchivoIdioma.PatFamPfrm;
                        UsuFamSMI.Text = My.Resources.ArchivoIdioma.UsuFamPfrm;
                        PatUsuSMI.Text = My.Resources.ArchivoIdioma.PatUsuPfrm;
                        RecalcularDVSMI.Text = My.Resources.ArchivoIdioma.RecalcularPfrm;
                        PanelSMI.Text = My.Resources.ArchivoIdioma.PanelPfrm;
                        IdiomaSMI.Text = My.Resources.ArchivoIdioma.IdiomaPfrm;
                        EspanolSMI.Text = My.Resources.ArchivoIdioma.EspanolPfrm;
                        InglesSMI.Text = My.Resources.ArchivoIdioma.InglesPfrm;
                        CambiarContrasenaSMI.Text = My.Resources.ArchivoIdioma.CambiarPassPfrm;
                        SalirSMI.Text = My.Resources.ArchivoIdioma.SalirPfrm;
                        continue;
                    }

                    if (item == "GestionCliente")
                    {
                        if (!GestionCliFrm.IsHandleCreated)
                        {
                            GestionCliFrm = new GestionCliente();
                        }

                        GestionCliFrm.GestionClientesGB.Text = My.Resources.ArchivoIdioma.GestionClienteGB;
                        GestionCliFrm.BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
                        GestionCliFrm.BuscarCmb.Items[0] = My.Resources.ArchivoIdioma.CMBCuit;
                        GestionCliFrm.BuscarCmb.Items[1] = My.Resources.ArchivoIdioma.CMBRazonSocial;
                        GestionCliFrm.IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
                        GestionCliFrm.BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        GestionCliFrm.OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
                        GestionCliFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarCliBtn;
                        GestionCliFrm.ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarCliBtn;
                        GestionCliFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarCliBtn;
                        GestionCliFrm.EliminarTelBtn.Text = My.Resources.ArchivoIdioma.EliminarTelBtn;
                        GestionCliFrm.RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
                        GestionCliFrm.CodCliCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        GestionCliFrm.RazonSocialCAB.HeaderText = My.Resources.ArchivoIdioma.RazonSocialGral;
                        GestionCliFrm.CuitCAB.HeaderText = My.Resources.ArchivoIdioma.CuitGral;
                        GestionCliFrm.DireccionCAB.HeaderText = My.Resources.ArchivoIdioma.DireccionCAB;
                        GestionCliFrm.LocalidadCAB.HeaderText = My.Resources.ArchivoIdioma.LocalidadLbl;
                        GestionCliFrm.PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
                        GestionCliFrm.PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
                        GestionCliFrm.PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;
                        if (GestionCliFrm.ClienteDG.Rows.Count == 0)
                        {
                            GestionCliFrm.InfoPagina(0);
                        }
                        else
                        {
                            GestionCliFrm.InfoPagina(GestionCliFrm.NroPag);
                        }

                        continue;
                    }

                    if (item == "GestionProducto")
                    {
                        if (!GestionProdFrm.IsHandleCreated)
                        {
                            GestionProdFrm = new GestionProducto();
                        }

                        GestionProdFrm.Text = My.Resources.ArchivoIdioma.GestionProductosFrm;
                        GestionProdFrm.GestionProductosGB.Text = My.Resources.ArchivoIdioma.GestionProductosGB;
                        GestionProdFrm.BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
                        GestionProdFrm.BuscarCmb.Items[0] = My.Resources.ArchivoIdioma.CMBNombre;
                        GestionProdFrm.BuscarCmb.Items[1] = My.Resources.ArchivoIdioma.CMBSector;
                        GestionProdFrm.IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
                        GestionProdFrm.BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        GestionProdFrm.OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
                        GestionProdFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarProdBtn;
                        GestionProdFrm.ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarProdBtn;
                        GestionProdFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarProdBtn;
                        GestionProdFrm.MasBtn.Text = My.Resources.ArchivoIdioma.MasOpcionesBtn;
                        GestionProdFrm.ModificarStockBtn.Text = My.Resources.ArchivoIdioma.ModificarStockBtn;
                        GestionProdFrm.ModificarPrecioBtn.Text = My.Resources.ArchivoIdioma.ModificarPrecioBtn;
                        GestionProdFrm.RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
                        GestionProdFrm.CodProdCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        GestionProdFrm.NombreCAB.HeaderText = My.Resources.ArchivoIdioma.CMBNombre;
                        GestionProdFrm.PrecioUnitarioCAB.HeaderText = My.Resources.ArchivoIdioma.Precio;
                        GestionProdFrm.CantidadCAB.HeaderText = My.Resources.ArchivoIdioma.Cantidad;
                        GestionProdFrm.SectorCAB.HeaderText = My.Resources.ArchivoIdioma.CMBSector;
                        GestionProdFrm.PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
                        GestionProdFrm.PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
                        GestionProdFrm.PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;
                        if (GestionProdFrm.ProductosDG.Rows.Count == 0)
                        {
                            GestionProdFrm.InfoPagina(0);
                        }
                        else
                        {
                            GestionProdFrm.InfoPagina(GestionProdFrm.NroPag);
                        }

                        continue;
                    }

                    if (item == "GestionProveedor")
                    {
                        if (!GestionProvFrm.IsHandleCreated)
                        {
                            GestionProvFrm = new GestionProveedor();
                        }

                        GestionProvFrm.Text = My.Resources.ArchivoIdioma.GestionProveedorFrm;
                        GestionProvFrm.GestionProveedoresGB.Text = My.Resources.ArchivoIdioma.GestionProveedorGB;
                        GestionProvFrm.BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
                        GestionProvFrm.BuscarCmb.Items[0] = My.Resources.ArchivoIdioma.CMBCuit;
                        GestionProvFrm.BuscarCmb.Items[1] = My.Resources.ArchivoIdioma.CMBRazonSocial;
                        GestionProvFrm.IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
                        GestionProvFrm.BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        GestionProvFrm.OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
                        GestionProvFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarProvBtn;
                        GestionProvFrm.ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarProvBtn;
                        GestionProvFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarProvBtn;
                        GestionProvFrm.EliminarTelBtn.Text = My.Resources.ArchivoIdioma.EliminarTelBtn;
                        GestionProvFrm.RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
                        GestionProvFrm.CodProvCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        GestionProvFrm.RazonSocialCAB.HeaderText = My.Resources.ArchivoIdioma.RazonSocialGral;
                        GestionProvFrm.CuitCAB.HeaderText = My.Resources.ArchivoIdioma.CuitGral;
                        GestionProvFrm.CorreoElectronicoCAB.HeaderText = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
                        GestionProvFrm.DireccionCAB.HeaderText = My.Resources.ArchivoIdioma.DireccionCAB;
                        GestionProvFrm.PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
                        GestionProvFrm.PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
                        GestionProvFrm.PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;
                        if (GestionProvFrm.ProveedorDG.Rows.Count == 0)
                        {
                            GestionProvFrm.InfoPagina(0);
                        }
                        else
                        {
                            GestionProvFrm.InfoPagina(GestionProvFrm.NroPag);
                        }

                        continue;
                    }

                    if (item == "GestionNV")
                    {
                        if (!GestionNVFrm.IsHandleCreated)
                        {
                            GestionNVFrm = new GestionNV();
                        }

                        GestionNVFrm.Text = My.Resources.ArchivoIdioma.GestionNVFrm;
                        GestionNVFrm.AccionLbl.Text = My.Resources.ArchivoIdioma.AccionLbl;
                        GestionNVFrm.AccionCMB.Items.Clear();
                        if (GestionNVFrm.ConsultarNota == true)
                        {
                            GestionNVFrm.AccionCMB.Items.Add(My.Resources.ArchivoIdioma.ConsultarNV);
                        }

                        if (GestionNVFrm.ConsultaRemitoNV == true)
                        {
                            GestionNVFrm.AccionCMB.Items.Add(My.Resources.ArchivoIdioma.ConsultarRemNV);
                        }

                        if (GestionNVFrm.GenerarRemitoNV == true)
                        {
                            GestionNVFrm.AccionCMB.Items.Add(My.Resources.ArchivoIdioma.GenerarRemito);
                        }

                        if (GestionNVFrm.BajaNV == true)
                        {
                            GestionNVFrm.AccionCMB.Items.Add(My.Resources.ArchivoIdioma.BajaNotaVenta);
                        }

                        GestionNVFrm.AccionCMB.SelectedIndex = 0;
                        GestionNVFrm.NroNotaLbl.Text = My.Resources.ArchivoIdioma.NumeroNota;
                        GestionNVFrm.BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        GestionNVFrm.NotaGB.Text = My.Resources.ArchivoIdioma.NotaVentaGB;
                        GestionNVFrm.NroNotaCAB.HeaderText = My.Resources.ArchivoIdioma.NroNotaCAB;
                        GestionNVFrm.FechaCAB.HeaderText = My.Resources.ArchivoIdioma.FechaLbl;
                        GestionNVFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        GestionNVFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        continue;
                    }

                    if (item == "NotaVenta")
                    {
                        if (!NVFrm.IsHandleCreated)
                        {
                            NVFrm = new NotaVenta();
                        }

                        NVFrm.Text = My.Resources.ArchivoIdioma.AltaNotaVentaFrm;
                        NVFrm.ClienteGB.Text = My.Resources.ArchivoIdioma.DatosClienteGB;
                        NVFrm.CodCliLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
                        NVFrm.CuitLbl.Text = My.Resources.ArchivoIdioma.CuitGral;
                        NVFrm.DireccionLbl.Text = My.Resources.ArchivoIdioma.DireccionCAB;
                        NVFrm.RazonSocialLbl.Text = My.Resources.ArchivoIdioma.RazonSocialGral;
                        NVFrm.ActivoLbl.Text = My.Resources.ArchivoIdioma.ActivoLbl;
                        NVFrm.FechaEmiLbl.Text = My.Resources.ArchivoIdioma.FechaEmiForm;
                        NVFrm.ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
                        NVFrm.CodProdLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
                        NVFrm.NombreProdLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
                        NVFrm.DescProdLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
                        NVFrm.PrecioLbl.Text = My.Resources.ArchivoIdioma.Precio;
                        NVFrm.CantidadLbl.Text = My.Resources.ArchivoIdioma.Cantidad;
                        NVFrm.NotaVentaGB.Text = My.Resources.ArchivoIdioma.DetalleNotaVenta;
                        NVFrm.CodProdCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        NVFrm.NombreCAB.HeaderText = My.Resources.ArchivoIdioma.CMBNombre;
                        NVFrm.PrecioCAB.HeaderText = My.Resources.ArchivoIdioma.Precio;
                        NVFrm.CantidadCAB.HeaderText = My.Resources.ArchivoIdioma.Cantidad;
                        NVFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarGral;
                        NVFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarGral;
                        NVFrm.NuevoBtn.Text = My.Resources.ArchivoIdioma.NuevoGral;
                        NVFrm.TotalLbl.Text = My.Resources.ArchivoIdioma.TotalLbl;
                        NVFrm.GenerarBtn.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
                        continue;
                    }

                    if (item == "GestionNP")
                    {
                        if (!GestionNPFrm.IsHandleCreated)
                        {
                            GestionNPFrm = new GestionNP();
                        }

                        GestionNPFrm.Text = My.Resources.ArchivoIdioma.GestionNPFrm;
                        GestionNPFrm.AccionLbl.Text = My.Resources.ArchivoIdioma.AccionLbl;
                        GestionNPFrm.AccionCMB.Items.Clear();
                        if (GestionNPFrm.ConsultarNota == true)
                        {
                            GestionNPFrm.AccionCMB.Items.Add(My.Resources.ArchivoIdioma.ConsultarNP);
                        }

                        if (GestionNPFrm.BajaNP == true)
                        {
                            GestionNPFrm.AccionCMB.Items.Add(My.Resources.ArchivoIdioma.BajaNotaPed);
                        }

                        GestionNPFrm.AccionCMB.SelectedIndex = 0;
                        GestionNPFrm.NroNotaLbl.Text = My.Resources.ArchivoIdioma.NumeroNota;
                        GestionNPFrm.BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        GestionNPFrm.NotaGB.Text = My.Resources.ArchivoIdioma.NotaPedidoGB;
                        GestionNPFrm.NroNotaCAB.HeaderText = My.Resources.ArchivoIdioma.NroNotaCAB;
                        GestionNPFrm.FechaCAB.HeaderText = My.Resources.ArchivoIdioma.FechaLbl;
                        GestionNPFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        GestionNPFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        continue;
                    }

                    if (item == "NotaPedido")
                    {
                        if (!NPFrm.IsHandleCreated)
                        {
                            NPFrm = new NotaPedido();
                        }

                        NPFrm.Text = My.Resources.ArchivoIdioma.AltaNotaPedidoFrm;
                        NPFrm.ProveedorGB.Text = My.Resources.ArchivoIdioma.DatosProveedorGB;
                        NPFrm.CodProvLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
                        NPFrm.CuitLbl.Text = My.Resources.ArchivoIdioma.CuitGral;
                        NPFrm.DireccionLbl.Text = My.Resources.ArchivoIdioma.DireccionCAB;
                        NPFrm.RazonSocialLbl.Text = My.Resources.ArchivoIdioma.RazonSocialGral;
                        NPFrm.ActivoLbl.Text = My.Resources.ArchivoIdioma.ActivoLbl;
                        NPFrm.FechaEmiLbl.Text = My.Resources.ArchivoIdioma.FechaEmiForm;
                        NPFrm.ProductoGB.Text = My.Resources.ArchivoIdioma.DatosProductoGB;
                        NPFrm.CodProdLbl.Text = My.Resources.ArchivoIdioma.CodigoCAB;
                        NPFrm.NombreProdLbl.Text = My.Resources.ArchivoIdioma.CMBNombre;
                        NPFrm.DescProdLbl.Text = My.Resources.ArchivoIdioma.DescripcionLbl;
                        NPFrm.PrecioLbl.Text = My.Resources.ArchivoIdioma.Precio;
                        NPFrm.CantidadLbl.Text = My.Resources.ArchivoIdioma.Cantidad;
                        NPFrm.NotaVentaGB.Text = My.Resources.ArchivoIdioma.DetalleNotaVenta;
                        NPFrm.CodProdCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        NPFrm.NombreCAB.HeaderText = My.Resources.ArchivoIdioma.CMBNombre;
                        NPFrm.PrecioCAB.HeaderText = My.Resources.ArchivoIdioma.Precio;
                        NPFrm.CantidadCAB.HeaderText = My.Resources.ArchivoIdioma.Cantidad;
                        NPFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarGral;
                        NPFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarGral;
                        NPFrm.NuevoBtn.Text = My.Resources.ArchivoIdioma.NuevoGral;
                        NPFrm.TotalLbl.Text = My.Resources.ArchivoIdioma.TotalLbl;
                        NPFrm.GenerarBtn.Text = My.Resources.ArchivoIdioma.GenerarNotasPFrm;
                        continue;
                    }

                    if (item == "GestionUsuario")
                    {
                        if (!GestionUsuFrm.IsHandleCreated)
                        {
                            GestionUsuFrm = new GestionUsuario();
                        }

                        GestionUsuFrm.Text = My.Resources.ArchivoIdioma.GestionUsuarioForm;
                        GestionUsuFrm.GestionUsuariosGB.Text = My.Resources.ArchivoIdioma.GestionUsuariosGB;
                        GestionUsuFrm.BuscarPorLbl.Text = My.Resources.ArchivoIdioma.BuscarPorLbl;
                        GestionUsuFrm.BuscarCmb.Items[0] = My.Resources.ArchivoIdioma.CMBUsuario;
                        GestionUsuFrm.BuscarCmb.Items[1] = My.Resources.ArchivoIdioma.CMBApellido;
                        GestionUsuFrm.BuscarCmb.Items[2] = My.Resources.ArchivoIdioma.CMBNombre;
                        GestionUsuFrm.IgualLbl.Text = My.Resources.ArchivoIdioma.IgualALbl;
                        GestionUsuFrm.BuscarBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        GestionUsuFrm.OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
                        GestionUsuFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AgregarUsuBtn;
                        GestionUsuFrm.ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarUsuBtn;
                        GestionUsuFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarUsuBtn;
                        GestionUsuFrm.EliminarTelBtn.Text = My.Resources.ArchivoIdioma.EliminarTelBtn;
                        GestionUsuFrm.RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
                        GestionUsuFrm.CodUsuCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioCodigoCAB;
                        GestionUsuFrm.UsuarioCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioUsuarioCAB;
                        GestionUsuFrm.ApellidoCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioApellidoCAB;
                        GestionUsuFrm.NombreCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioNombreCAB;
                        GestionUsuFrm.CorreoCAB.HeaderText = My.Resources.ArchivoIdioma.CorreoElectronicoGral;
                        GestionUsuFrm.EdadCAB.HeaderText = My.Resources.ArchivoIdioma.DGGestionUsuarioEdadCAB;
                        GestionUsuFrm.PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
                        GestionUsuFrm.PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
                        GestionUsuFrm.PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;
                        if (GestionUsuFrm.UsuarioDG.Rows.Count == 0)
                        {
                            GestionUsuFrm.InfoPagina(0);
                        }
                        else
                        {
                            GestionUsuFrm.InfoPagina(GestionUsuFrm.NroPag);
                        }

                        continue;
                    }

                    if (item == "GestionFamilia")
                    {
                        if (!GestionFamFrm.IsHandleCreated)
                        {
                            GestionFamFrm = new GestionFamilia();
                        }

                        GestionFamFrm.Text = My.Resources.ArchivoIdioma.GestionFamiliaFrm;
                        GestionFamFrm.OperacionGB.Text = My.Resources.ArchivoIdioma.OperacionesGB;
                        GestionFamFrm.AgregarBtn.Text = My.Resources.ArchivoIdioma.AltaFamBtn;
                        GestionFamFrm.ModificarBtn.Text = My.Resources.ArchivoIdioma.ModificarFamBtn;
                        GestionFamFrm.EliminarBtn.Text = My.Resources.ArchivoIdioma.EliminarFamBtn;
                        GestionFamFrm.RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
                        GestionFamFrm.CodCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        GestionFamFrm.DescripcionCAB.HeaderText = My.Resources.ArchivoIdioma.DescripcionLbl;
                        continue;
                    }

                    if (item == "DesbloquearUsuario")
                    {
                        if (!DesbloquearUsuFrm.IsHandleCreated)
                        {
                            DesbloquearUsuFrm = new DesbloquearUsuario();
                        }

                        DesbloquearUsuFrm.Text = My.Resources.ArchivoIdioma.DesbloquearUsuarioFrm;
                        DesbloquearUsuFrm.UsuarioGB.Text = My.Resources.ArchivoIdioma.SeleccionarUsuarioGB;
                        DesbloquearUsuFrm.UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
                        DesbloquearUsuFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        DesbloquearUsuFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        continue;
                    }

                    if (item == "ResetearContrasena")
                    {
                        if (!ResetearPassFrm.IsHandleCreated)
                        {
                            ResetearPassFrm = new ResetearContrasena();
                        }

                        ResetearPassFrm.Text = My.Resources.ArchivoIdioma.ResetearContraseñaFrm;
                        ResetearPassFrm.UsuarioGB.Text = My.Resources.ArchivoIdioma.SeleccionarUsuarioGB;
                        ResetearPassFrm.UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
                        ResetearPassFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        ResetearPassFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        continue;
                    }

                    if (item == "Backup")
                    {
                        if (!BackUpFrm.IsHandleCreated)
                        {
                            BackUpFrm = new Backup();
                        }

                        BackUpFrm.Text = My.Resources.ArchivoIdioma.BackupFrm;
                        BackUpFrm.BackupGB.Text = My.Resources.ArchivoIdioma.Backup;
                        BackUpFrm.DestinoLbl.Text = My.Resources.ArchivoIdioma.DestinoLbl;
                        BackUpFrm.VolumenLbl.Text = My.Resources.ArchivoIdioma.VolumenLbl;
                        BackUpFrm.NombreZipLbl.Text = My.Resources.ArchivoIdioma.NombreZip;
                        BackUpFrm.ContraseñaZipLbl.Text = My.Resources.ArchivoIdioma.ContraseñaZip;
                        BackUpFrm.ReContraseñaZipLbl.Text = My.Resources.ArchivoIdioma.ReContraseñaZip;
                        BackUpFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        BackUpFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        continue;
                    }

                    if (item == "Restore")
                    {
                        if (!RestoreFrm.IsHandleCreated)
                        {
                            RestoreFrm = new Restore();
                        }

                        RestoreFrm.Text = My.Resources.ArchivoIdioma.RestoreFrm;
                        RestoreFrm.RestaurarGB.Text = My.Resources.ArchivoIdioma.RestoreGB;
                        RestoreFrm.DestinoLbl.Text = My.Resources.ArchivoIdioma.DestinoRestoreLbl;
                        RestoreFrm.ContraseñaZipLbl.Text = My.Resources.ArchivoIdioma.ContraseñaZip;
                        RestoreFrm.ReContraseñaZipLbl.Text = My.Resources.ArchivoIdioma.ReContraseñaZip;
                        RestoreFrm.NuevoBtn.Text = My.Resources.ArchivoIdioma.NuevoGral;
                        RestoreFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        RestoreFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        continue;
                    }

                    if (item == "Bitacora")
                    {
                        if (!BitacoraFrm.IsHandleCreated)
                        {
                            BitacoraFrm = new Bitacora();
                        }

                        BitacoraFrm.Text = My.Resources.ArchivoIdioma.BitacoraFrm;
                        BitacoraFrm.FiltroLbl.Text = My.Resources.ArchivoIdioma.FiltroLbl;
                        BitacoraFrm.FiltroCMB.Items[0] = My.Resources.ArchivoIdioma.CompletoLbl;
                        BitacoraFrm.FiltroCMB.Items[1] = My.Resources.ArchivoIdioma.UsuarioLbl;
                        BitacoraFrm.FiltroCMB.Items[2] = My.Resources.ArchivoIdioma.CriticidadLbl;
                        BitacoraFrm.FiltroCMB.Items[3] = My.Resources.ArchivoIdioma.FechaLbl;
                        BitacoraFrm.RegistrosGB.Text = My.Resources.ArchivoIdioma.RegistrosGB;
                        BitacoraFrm.CodBitCAB.HeaderText = My.Resources.ArchivoIdioma.CodigoCAB;
                        BitacoraFrm.FechaCAB.HeaderText = My.Resources.ArchivoIdioma.FechaLbl;
                        BitacoraFrm.DescripcionCAB.HeaderText = My.Resources.ArchivoIdioma.DescripcionLbl;
                        BitacoraFrm.CriticidadCAB.HeaderText = My.Resources.ArchivoIdioma.CriticidadLbl;
                        BitacoraFrm.UsuarioCAB.HeaderText = My.Resources.ArchivoIdioma.UsuarioLbl;
                        BitacoraFrm.DepurarBtn.Text = My.Resources.ArchivoIdioma.DepurarBitacora;
                        BitacoraFrm.PaginaNro = My.Resources.ArchivoIdioma.InfoPaginaPag;
                        BitacoraFrm.PaginaDe = My.Resources.ArchivoIdioma.InfoPaginaDe;
                        BitacoraFrm.PaginaRegistros = My.Resources.ArchivoIdioma.InfoPaginaReg;
                        if (BitacoraFrm.BitacoraDG.Rows.Count == 0)
                        {
                            BitacoraFrm.InfoPagina(0);
                        }
                        else
                        {
                            BitacoraFrm.InfoPagina(BitacoraFrm.NroPag);
                        }

                        // FiltroCompleto
                        BitacoraFrm.FC.CompletoGB.Text = My.Resources.ArchivoIdioma.FCompletoGB;
                        BitacoraFrm.FC.DesdeComLbl.Text = My.Resources.ArchivoIdioma.FechaDesdeLbl;
                        BitacoraFrm.FC.HastaComLbl.Text = My.Resources.ArchivoIdioma.FechaHastaLbl;
                        BitacoraFrm.FC.UsuComLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
                        BitacoraFrm.FC.CritiComLbl.Text = My.Resources.ArchivoIdioma.CriticidadLbl;
                        BitacoraFrm.FC.BuscarComBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        BitacoraFrm.FC.CriticidadCMB.DataSource = null;
                        BitacoraFrm.FC.CriticidadCMB.DataSource = BitacoraFrm.CargarComboCriticidad();
                        BitacoraFrm.FC.CriticidadCMB.DisplayMember = "Descripcion";
                        BitacoraFrm.FC.CriticidadCMB.ValueMember = "CodCriti";

                        // FiltroCriticidad
                        BitacoraFrm.FCriti.CriticidadGB.Text = My.Resources.ArchivoIdioma.CriticidadGB;
                        BitacoraFrm.FCriti.CriticidadLbl.Text = My.Resources.ArchivoIdioma.CriticidadLbl;
                        BitacoraFrm.FCriti.BuscarCritiBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        BitacoraFrm.FCriti.CriticidadCMB.DataSource = null;
                        BitacoraFrm.FCriti.CriticidadCMB.DataSource = BitacoraFrm.CargarComboCriticidad();
                        BitacoraFrm.FCriti.CriticidadCMB.DisplayMember = "Descripcion";
                        BitacoraFrm.FCriti.CriticidadCMB.ValueMember = "CodCriti";


                        // FiltroUsuario
                        BitacoraFrm.FU.UsuarioGB.Text = My.Resources.ArchivoIdioma.UsuarioGBBit;
                        BitacoraFrm.FU.UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
                        BitacoraFrm.FU.BuscarUsuBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;

                        // FiltroFechas
                        BitacoraFrm.FF.FechasGB.Text = My.Resources.ArchivoIdioma.FechasGB;
                        BitacoraFrm.FF.DesdeLbl.Text = My.Resources.ArchivoIdioma.FechaDesdeLbl;
                        BitacoraFrm.FF.HastaLbl.Text = My.Resources.ArchivoIdioma.FechaHastaLbl;
                        BitacoraFrm.FF.BuscarFechaBtn.Text = My.Resources.ArchivoIdioma.BuscarBtn;
                        continue;
                    }

                    if (item == "FamiliaPatente")
                    {
                        if (!PatFamFrm.IsHandleCreated)
                        {
                            PatFamFrm = new FamiliaPatente();
                        }

                        PatFamFrm.Text = My.Resources.ArchivoIdioma.PatenteFamiliaFrm;
                        PatFamFrm.FamiliaLbl.Text = My.Resources.ArchivoIdioma.FamiliaLbl;
                        PatFamFrm.PatentesNoGB.Text = My.Resources.ArchivoIdioma.PatentesNoFamLbl;
                        PatFamFrm.PatentesGB.Text = My.Resources.ArchivoIdioma.PatentesFamLbl;
                        PatFamFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        PatFamFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        PatFamFrm.InformacionLbl.Text = My.Resources.ArchivoIdioma.ResultadoOperacion;
                        continue;
                    }

                    if (item == "UsuarioFamilia")
                    {
                        if (!UsuFamFrm.IsHandleCreated)
                        {
                            UsuFamFrm = new UsuarioFamilia();
                        }

                        UsuFamFrm.Text = My.Resources.ArchivoIdioma.UsuarioFamiliaFrm;
                        UsuFamFrm.UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
                        UsuFamFrm.FamiliaGB.Text = My.Resources.ArchivoIdioma.FamiliasGBTiene;
                        UsuFamFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        UsuFamFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        UsuFamFrm.InformacionLbl.Text = My.Resources.ArchivoIdioma.ResultadoOperacion;
                        continue;
                    }

                    if (item == "UsuarioPatente")
                    {
                        if (!UsuPatFrm.IsHandleCreated)
                        {
                            UsuPatFrm = new UsuarioPatente();
                        }

                        UsuPatFrm.Text = My.Resources.ArchivoIdioma.UsuarioPatenteFrm;
                        UsuPatFrm.UsuarioLbl.Text = My.Resources.ArchivoIdioma.UsuarioLbl;
                        UsuPatFrm.PatentesGB.Text = My.Resources.ArchivoIdioma.PatentesUsuLbl;
                        UsuPatFrm.PatDenegadasGB.Text = My.Resources.ArchivoIdioma.PatentesDenegadasUsu;
                        UsuPatFrm.DenPatentesGB.Text = My.Resources.ArchivoIdioma.PatentesNoUsuLbl;
                        UsuPatFrm.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        UsuPatFrm.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                        UsuPatFrm.InformacionLbl.Text = My.Resources.ArchivoIdioma.ResultadoOperacion;
                        continue;
                    }

                    if (item == "CambiarContrasena")
                    {
                        if (!CambiarPass.IsHandleCreated)
                        {
                            CambiarPass = new CambiarContrasena();
                        }

                        CambiarPass.Text = My.Resources.ArchivoIdioma.CambiarContraseñaFrm;
                        CambiarPass.ContrasenaGB.Text = My.Resources.ArchivoIdioma.CambiarContraseña;
                        CambiarPass.ConAnteriorLbl.Text = My.Resources.ArchivoIdioma.ConAnteriorLbl;
                        CambiarPass.NuevaContraseñaLbl.Text = My.Resources.ArchivoIdioma.NuevaConLbl;
                        CambiarPass.ReNuevaContraseñaLbl.Text = My.Resources.ArchivoIdioma.ReNuevaConLbl;
                        CambiarPass.AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
                        CambiarPass.CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
                    }
                }
            }
        }

        private void CargarTT(List<string> ListaFormsNombreTT)
        {
            foreach (string item in ListaFormsNombreTT)
            {
                if (item == "GestionCliente")
                {
                    if (!GestionCliFrm.IsHandleCreated)
                    {
                        GestionCliFrm = new GestionCliente();
                    }

                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTClienteAltaBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.ModificarBtn, My.Resources.ArchivoIdioma.TTClienteModificarBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTClienteEliminarBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.EliminarTelBtn, My.Resources.ArchivoIdioma.TTEliminarTelBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
                    GestionCliFrm.ControlesTP.SetToolTip(GestionCliFrm.ClienteDG, My.Resources.ArchivoIdioma.TTListaClientes);
                    continue;
                }

                if (item == "GestionProducto")
                {
                    if (!GestionProdFrm.IsHandleCreated)
                    {
                        GestionProdFrm = new GestionProducto();
                    }

                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTProductoAltaBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.ModificarBtn, My.Resources.ArchivoIdioma.TTProductoModificarBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTProductoEliminarBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.MasBtn, My.Resources.ArchivoIdioma.TTMasOpciones);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
                    GestionProdFrm.ControlesTP.SetToolTip(GestionProdFrm.ProductosDG, My.Resources.ArchivoIdioma.TTListaProducto);
                    continue;
                }

                if (item == "GestionProveedor")
                {
                    if (!GestionProvFrm.IsHandleCreated)
                    {
                        GestionProvFrm = new GestionProveedor();
                    }

                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTProveedorAltaBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.ModificarBtn, My.Resources.ArchivoIdioma.TTProveedorModificarBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTProveedorEliminarBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.EliminarTelBtn, My.Resources.ArchivoIdioma.TTEliminarTelBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
                    GestionProvFrm.ControlesTP.SetToolTip(GestionProvFrm.ProveedorDG, My.Resources.ArchivoIdioma.TTListaProveedor);
                    continue;
                }

                if (item == "GestionNV")
                {
                    if (!GestionNVFrm.IsHandleCreated)
                    {
                        GestionNVFrm = new GestionNV();
                    }

                    GestionNVFrm.ControlesTP.SetToolTip(GestionNVFrm.AccionCMB, My.Resources.ArchivoIdioma.TTListaAcciones);
                    GestionNVFrm.ControlesTP.SetToolTip(GestionNVFrm.NroNotaTxt, My.Resources.ArchivoIdioma.TTNroNotaVenta);
                    GestionNVFrm.ControlesTP.SetToolTip(GestionNVFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarNotaVenta);
                    GestionNVFrm.ControlesTP.SetToolTip(GestionNVFrm.NotaVentaDG, My.Resources.ArchivoIdioma.TTListaNotaVenta);
                    GestionNVFrm.ControlesTP.SetToolTip(GestionNVFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTRealizarAccion);
                    GestionNVFrm.ControlesTP.SetToolTip(GestionNVFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "NotaVenta")
                {
                    if (!NVFrm.IsHandleCreated)
                    {
                        NVFrm = new NotaVenta();
                    }

                    NVFrm.ControlesTP.SetToolTip(NVFrm.CodCliTxt, My.Resources.ArchivoIdioma.TTCodCli);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.BuscarProdBtn, My.Resources.ArchivoIdioma.TTBuscarCliNotas);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.CuitTxt, My.Resources.ArchivoIdioma.TTCuit);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.DireccionTxt, My.Resources.ArchivoIdioma.TTDireccionCli);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.RazonSocialTxt, My.Resources.ArchivoIdioma.TTRazonSocial);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.FechaDTP, My.Resources.ArchivoIdioma.TTFechaEmisionNota);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.CodProdTxt, My.Resources.ArchivoIdioma.TTCodProd);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.BuscarProdBtn, My.Resources.ArchivoIdioma.TTBuscarProdNota);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.NombreProdTxt, My.Resources.ArchivoIdioma.TTNombreProd);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.DescProdTxt, My.Resources.ArchivoIdioma.TTDescrProd);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.PrecioTxt, My.Resources.ArchivoIdioma.TTPrecioProd);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.CantidadTxt, My.Resources.ArchivoIdioma.TTIngreseCantidad);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.DetalleDG, My.Resources.ArchivoIdioma.TTListaProductoNV);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTAgregarDetalle);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTEliminarDetalle);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.NuevoBtn, My.Resources.ArchivoIdioma.TTNuevoDetalle);
                    NVFrm.ControlesTP.SetToolTip(NVFrm.GenerarBtn, My.Resources.ArchivoIdioma.TTGenerarNotaVenta);
                    continue;
                }

                if (item == "GestionNP")
                {
                    if (!GestionNPFrm.IsHandleCreated)
                    {
                        GestionNPFrm = new GestionNP();
                    }

                    GestionNPFrm.ControlesTP.SetToolTip(GestionNPFrm.AccionCMB, My.Resources.ArchivoIdioma.TTListaAcciones);
                    GestionNPFrm.ControlesTP.SetToolTip(GestionNPFrm.NroNotaTxt, My.Resources.ArchivoIdioma.TTNroNotaPedido);
                    GestionNPFrm.ControlesTP.SetToolTip(GestionNPFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarNotaPedido);
                    GestionNPFrm.ControlesTP.SetToolTip(GestionNPFrm.NotaPedidoDG, My.Resources.ArchivoIdioma.TTListaNotaPedido);
                    GestionNPFrm.ControlesTP.SetToolTip(GestionNPFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTRealizarAccion);
                    GestionNPFrm.ControlesTP.SetToolTip(GestionNPFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "NotaPedido")
                {
                    if (!NPFrm.IsHandleCreated)
                    {
                        NPFrm = new NotaPedido();
                    }

                    NPFrm.ControlesTP.SetToolTip(NPFrm.CodProvTxt, My.Resources.ArchivoIdioma.TTCodProv);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.BuscarProdBtn, My.Resources.ArchivoIdioma.TTBuscarProvNotas);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.CuitTxt, My.Resources.ArchivoIdioma.TTCuit);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.DireccionTxt, My.Resources.ArchivoIdioma.TTDireccionProv);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.RazonSocialTxt, My.Resources.ArchivoIdioma.TTRazonSocial);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.FechaDTP, My.Resources.ArchivoIdioma.TTFechaEmisionNP);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.CodProdTxt, My.Resources.ArchivoIdioma.TTCodProd);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.BuscarProdBtn, My.Resources.ArchivoIdioma.TTBuscarProdNota);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.NombreProdTxt, My.Resources.ArchivoIdioma.TTNombreProd);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.DescProdTxt, My.Resources.ArchivoIdioma.TTDescrProd);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.PrecioTxt, My.Resources.ArchivoIdioma.TTPrecioProd);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.CantidadTxt, My.Resources.ArchivoIdioma.TTIngreseCantidad);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.DetalleDG, My.Resources.ArchivoIdioma.TTListaProductoNP);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTAgregarDetalle);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTEliminarDetalle);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.NuevoBtn, My.Resources.ArchivoIdioma.TTNuevoDetalle);
                    NPFrm.ControlesTP.SetToolTip(NPFrm.GenerarBtn, My.Resources.ArchivoIdioma.TTGenerarNotaPedido);
                    continue;
                }

                if (item == "GestionUsuario")
                {
                    if (!GestionUsuFrm.IsHandleCreated)
                    {
                        GestionUsuFrm = new GestionUsuario();
                    }

                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTUsuarioAltaBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.ModificarBtn, My.Resources.ArchivoIdioma.TTUsuarioModificarBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTUsuarioEliminarBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.EliminarTelBtn, My.Resources.ArchivoIdioma.TTEliminarTelBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
                    GestionUsuFrm.ControlesTP.SetToolTip(GestionUsuFrm.UsuarioDG, My.Resources.ArchivoIdioma.TTListaUsuarios);
                    continue;
                }

                if (item == "GestionFamilia")
                {
                    if (!GestionFamFrm.IsHandleCreated)
                    {
                        GestionFamFrm = new GestionFamilia();
                    }

                    GestionFamFrm.ControlesTP.SetToolTip(GestionFamFrm.AgregarBtn, My.Resources.ArchivoIdioma.TTAgregarFam);
                    GestionFamFrm.ControlesTP.SetToolTip(GestionFamFrm.ModificarBtn, My.Resources.ArchivoIdioma.TTModificarFam);
                    GestionFamFrm.ControlesTP.SetToolTip(GestionFamFrm.EliminarBtn, My.Resources.ArchivoIdioma.TTEliminarFam);
                    GestionFamFrm.ControlesTP.SetToolTip(GestionFamFrm.FamiliaDG, My.Resources.ArchivoIdioma.TTlistaFamilias);
                    continue;
                }

                if (item == "DesbloquearUsuario")
                {
                    if (!DesbloquearUsuFrm.IsHandleCreated)
                    {
                        DesbloquearUsuFrm = new DesbloquearUsuario();
                    }

                    DesbloquearUsuFrm.ControlesTP.SetToolTip(DesbloquearUsuFrm.UsuarioCMB, My.Resources.ArchivoIdioma.TTListaUsuBloqueados);
                    DesbloquearUsuFrm.ControlesTP.SetToolTip(DesbloquearUsuFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarDesbloquearUsu);
                    DesbloquearUsuFrm.ControlesTP.SetToolTip(DesbloquearUsuFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "ResetearContrasena")
                {
                    if (!ResetearPassFrm.IsHandleCreated)
                    {
                        ResetearPassFrm = new ResetearContrasena();
                    }

                    ResetearPassFrm.ControlesTP.SetToolTip(ResetearPassFrm.UsuarioCMB, My.Resources.ArchivoIdioma.TTListaUsuarios);
                    ResetearPassFrm.ControlesTP.SetToolTip(ResetearPassFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarResetearContraseña);
                    ResetearPassFrm.ControlesTP.SetToolTip(ResetearPassFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "Backup")
                {
                    if (!BackUpFrm.IsHandleCreated)
                    {
                        BackUpFrm = new Backup();
                    }

                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.RutaTxt, My.Resources.ArchivoIdioma.TTRuta);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarRutaBK);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.VolumenNUD, My.Resources.ArchivoIdioma.TTVolumenes);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.NombreZipTxt, My.Resources.ArchivoIdioma.TTNombreZip);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.ContraseñaZipTxt, My.Resources.ArchivoIdioma.TTContraseñaZip);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.ReContraseñaZipTxt, My.Resources.ArchivoIdioma.TTReContraseñaZip);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTGenerarBackup);
                    BackUpFrm.ControlesTP.SetToolTip(BackUpFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "Restore")
                {
                    if (!RestoreFrm.IsHandleCreated)
                    {
                        RestoreFrm = new Restore();
                    }

                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarBAK);
                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.ArchivosLB, My.Resources.ArchivoIdioma.TTArchivosBAKR);
                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.ContraseñaZipTxt, My.Resources.ArchivoIdioma.TTContraseñaZip);
                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.ReContraseñaZipTxt, My.Resources.ArchivoIdioma.TTReContraseñaZip);
                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.NuevoBtn, My.Resources.ArchivoIdioma.NuevoRestoreLimpiar);
                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTGenerarRestore);
                    RestoreFrm.ControlesTP.SetToolTip(RestoreFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "Bitacora")
                {
                    if (!BitacoraFrm.IsHandleCreated)
                    {
                        BitacoraFrm = new Bitacora();
                    }

                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.FiltroCMB, My.Resources.ArchivoIdioma.TTFiltroBitacora);
                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.SiguienteBtn, My.Resources.ArchivoIdioma.TTSiguienteBtn);
                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.AnteriorBtn, My.Resources.ArchivoIdioma.TTAnteriorBtn);
                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.UltimoBtn, My.Resources.ArchivoIdioma.TTUltimoBtn);
                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.PrimeroBtn, My.Resources.ArchivoIdioma.TTPrimeraBtn);
                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.RecargarBtn, My.Resources.ArchivoIdioma.TTRecargarBtn);
                    BitacoraFrm.ControlesTP.SetToolTip(BitacoraFrm.BitacoraDG, My.Resources.ArchivoIdioma.TTListaBitacora);

                    // FiltroCompleto
                    BitacoraFrm.FC.ControlesTP.SetToolTip(BitacoraFrm.FC.BuscarComBtn, My.Resources.ArchivoIdioma.TTBuscarCompleto);

                    // FiltroCriticidad
                    BitacoraFrm.FCriti.ControlesTP.SetToolTip(BitacoraFrm.FCriti.BuscarCritiBtn, My.Resources.ArchivoIdioma.TTBuscarCriticidad);

                    // FiltroUsuario
                    BitacoraFrm.FU.ControlesTP.SetToolTip(BitacoraFrm.FU.BuscarUsuBtn, My.Resources.ArchivoIdioma.TTBuscarUsuarios);

                    // FiltroFechas
                    BitacoraFrm.FF.ControlesTP.SetToolTip(BitacoraFrm.FF.BuscarFechaBtn, My.Resources.ArchivoIdioma.TTBuscarFechas);
                    continue;
                }

                if (item == "FamiliaPatente")
                {
                    if (!PatFamFrm.IsHandleCreated)
                    {
                        PatFamFrm = new FamiliaPatente();
                    }

                    PatFamFrm.ControlesTP.SetToolTip(PatFamFrm.FamiliaCMB, My.Resources.ArchivoIdioma.TTFamiliaCMB);
                    PatFamFrm.ControlesTP.SetToolTip(PatFamFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarFam);
                    PatFamFrm.ControlesTP.SetToolTip(PatFamFrm.PatentesCLB, My.Resources.ArchivoIdioma.TTPatentesNoFam);
                    PatFamFrm.ControlesTP.SetToolTip(PatFamFrm.DenPatentesCLB, My.Resources.ArchivoIdioma.TTPatentesFam);
                    PatFamFrm.ControlesTP.SetToolTip(PatFamFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTAltaBajaPatFam);
                    PatFamFrm.ControlesTP.SetToolTip(PatFamFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "UsuarioFamilia")
                {
                    if (!UsuFamFrm.IsHandleCreated)
                    {
                        UsuFamFrm = new UsuarioFamilia();
                    }

                    UsuFamFrm.ControlesTP.SetToolTip(UsuFamFrm.UsuarioCMB, My.Resources.ArchivoIdioma.TTListaUsuarios);
                    UsuFamFrm.ControlesTP.SetToolTip(UsuFamFrm.FamiliaCLB, My.Resources.ArchivoIdioma.TTlistaFamilias);
                    UsuFamFrm.ControlesTP.SetToolTip(UsuFamFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTAltaUsuFam);
                    UsuFamFrm.ControlesTP.SetToolTip(UsuFamFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "UsuarioPatente")
                {
                    if (!UsuPatFrm.IsHandleCreated)
                    {
                        UsuPatFrm = new UsuarioPatente();
                    }

                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.UsuariosCMB, My.Resources.ArchivoIdioma.TTListaUsuarios);
                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.BuscarBtn, My.Resources.ArchivoIdioma.TTBuscarUsuariosPat);
                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.DenPatentesCLB, My.Resources.ArchivoIdioma.TTPatentesNoUsu);
                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.PatDenegadasCLB, My.Resources.ArchivoIdioma.TTPatDenegadasUsu);
                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.PatentesCLB, My.Resources.ArchivoIdioma.TTPatentesUsu);
                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.AceptarBtn, My.Resources.ArchivoIdioma.TTAltaBajaPatUsu);
                    UsuPatFrm.ControlesTP.SetToolTip(UsuPatFrm.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                    continue;
                }

                if (item == "CambiarContrasena")
                {
                    if (!CambiarPass.IsHandleCreated)
                    {
                        CambiarPass = new CambiarContrasena();
                    }

                    CambiarPass.ControlesTP.SetToolTip(CambiarPass.ConAnteriorTxt, My.Resources.ArchivoIdioma.TTConAnterior);
                    CambiarPass.ControlesTP.SetToolTip(CambiarPass.NuevaContraseñaTxt, My.Resources.ArchivoIdioma.TTNuevaCon);
                    CambiarPass.ControlesTP.SetToolTip(CambiarPass.ReNuevaContraseñaTxt, My.Resources.ArchivoIdioma.TTConfirmarCon);
                    CambiarPass.ControlesTP.SetToolTip(CambiarPass.AceptarBtn, My.Resources.ArchivoIdioma.CambiarContraseña);
                    CambiarPass.ControlesTP.SetToolTip(CambiarPass.CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void GestionClienteSMI_Click(object sender, EventArgs e)
        {
            if (!GestionCliFrm.IsHandleCreated)
            {
                GestionCliFrm = new GestionCliente();
            }

            GestionCliFrm.MdiParent = this;
            GestionCliFrm.StartPosition = FormStartPosition.CenterScreen;
            GestionCliFrm.Show();
            GestionClienteSMI.Enabled = false;
        }

        private void GestionProveedorSMI_Click(object sender, EventArgs e)
        {
            if (!GestionProvFrm.IsHandleCreated)
            {
                GestionProvFrm = new GestionProveedor();
            }

            GestionProvFrm.MdiParent = this;
            GestionProvFrm.StartPosition = FormStartPosition.CenterScreen;
            GestionProvFrm.Show();
            GestionProveedorSMI.Enabled = false;
        }

        private void GestionProductoSMI_Click(object sender, EventArgs e)
        {
            if (!GestionProdFrm.IsHandleCreated)
            {
                GestionProdFrm = new GestionProducto();
            }

            GestionProdFrm.MdiParent = this;
            GestionProdFrm.StartPosition = FormStartPosition.CenterScreen;
            GestionProdFrm.Show();
            GestionProductoSMI.Enabled = false;
        }

        private void GestionNVSMI_Click(object sender, EventArgs e)
        {
            if (!GestionNVFrm.IsHandleCreated)
            {
                GestionNVFrm = new GestionNV();
            }

            GestionNVFrm.MdiParent = this;
            GestionNVFrm.StartPosition = FormStartPosition.CenterScreen;
            GestionNVFrm.Show();
            GestionNVSMI.Enabled = false;
        }

        private void GenerarNVSMI_Click(object sender, EventArgs e)
        {
            if (!NVFrm.IsHandleCreated)
            {
                NVFrm = new NotaVenta();
            }

            NVFrm.MdiParent = this;
            NVFrm.StartPosition = FormStartPosition.CenterScreen;
            NVFrm.Show();
            GenerarNVSMI.Enabled = false;
        }

        private void GestionNPSMI_Click(object sender, EventArgs e)
        {
            if (!GestionNPFrm.IsHandleCreated)
            {
                GestionNPFrm = new GestionNP();
            }

            GestionNPFrm.MdiParent = this;
            GestionNPFrm.StartPosition = FormStartPosition.CenterParent;
            GestionNPFrm.Show();
            GestionNPSMI.Enabled = false;
        }

        private void GenerarNPSMI_Click(object sender, EventArgs e)
        {
            if (!NPFrm.IsHandleCreated)
            {
                NPFrm = new NotaPedido();
            }

            NPFrm.MdiParent = this;
            NPFrm.StartPosition = FormStartPosition.CenterScreen;
            NPFrm.Show();
            GenerarNPSMI.Enabled = false;
        }

        private void GestionUsuarioSMI_Click(object sender, EventArgs e)
        {
            if (!GestionUsuFrm.IsHandleCreated)
            {
                GestionUsuFrm = new GestionUsuario();
            }

            GestionUsuFrm.MdiParent = this;
            GestionUsuFrm.StartPosition = FormStartPosition.CenterScreen;
            GestionUsuFrm.Show();
            GestionUsuarioSMI.Enabled = false;
        }

        private void GestionFamiliaSMI_Click(object sender, EventArgs e)
        {
            if (!GestionFamFrm.IsHandleCreated)
            {
                GestionFamFrm = new GestionFamilia();
            }

            GestionFamFrm.MdiParent = this;
            GestionFamFrm.StartPosition = FormStartPosition.CenterScreen;
            GestionFamFrm.Show();
            GestionFamiliaSMI.Enabled = false;
        }

        private void DesbloquearUsuarioSMI_Click(object sender, EventArgs e)
        {
            if (!DesbloquearUsuFrm.IsHandleCreated)
            {
                DesbloquearUsuFrm = new DesbloquearUsuario();
            }

            DesbloquearUsuFrm.MdiParent = this;
            DesbloquearUsuFrm.StartPosition = FormStartPosition.CenterScreen;
            DesbloquearUsuFrm.Show();
            if (DesbloquearUsuFrm.UsuarioCMB.Items.Count == 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.NoUsuBloqueados, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DesbloquearUsuFrm.Close();
                DesbloquearUsuarioSMI.Enabled = true;
                return;
            }

            DesbloquearUsuarioSMI.Enabled = false;
        }

        private void ResetearContrasenaSMI_Click(object sender, EventArgs e)
        {
            if (!ResetearPassFrm.IsHandleCreated)
            {
                ResetearPassFrm = new ResetearContrasena();
            }

            ResetearPassFrm.MdiParent = this;
            ResetearPassFrm.StartPosition = FormStartPosition.CenterScreen;
            ResetearPassFrm.Show();
            ResetearContrasenaSMI.Enabled = false;
        }

        private void BackupSMI_Click(object sender, EventArgs e)
        {
            if (!BackUpFrm.IsHandleCreated)
            {
                BackUpFrm = new Backup();
            }

            BackUpFrm.MdiParent = this;
            BackUpFrm.StartPosition = FormStartPosition.CenterScreen;
            BackUpFrm.Show();
            BackupSMI.Enabled = false;
        }

        private void RestoreSMI_Click(object sender, EventArgs e)
        {
            if (!RestoreFrm.IsHandleCreated)
            {
                RestoreFrm = new Restore();
            }

            RestoreFrm.MdiParent = this;
            RestoreFrm.StartPosition = FormStartPosition.CenterScreen;
            RestoreFrm.Show();
            RestoreSMI.Enabled = false;
        }

        private void BitacoraSMI_Click(object sender, EventArgs e)
        {
            if (!BitacoraFrm.IsHandleCreated)
            {
                BitacoraFrm = new Bitacora();
            }

            BitacoraFrm.MdiParent = this;
            BitacoraFrm.StartPosition = FormStartPosition.CenterScreen;
            BitacoraFrm.Show();
            BitacoraSMI.Enabled = false;
        }

        private void PatFamSMI_Click(object sender, EventArgs e)
        {
            if (!PatFamFrm.IsHandleCreated)
            {
                PatFamFrm = new FamiliaPatente();
            }

            PatFamFrm.MdiParent = this;
            PatFamFrm.StartPosition = FormStartPosition.CenterScreen;
            PatFamFrm.Show();
            PatFamSMI.Enabled = false;
        }

        private void UsuFamSMI_Click(object sender, EventArgs e)
        {
            if (!UsuFamFrm.IsHandleCreated)
            {
                UsuFamFrm = new UsuarioFamilia();
            }

            UsuFamFrm.MdiParent = this;
            UsuFamFrm.StartPosition = FormStartPosition.CenterScreen;
            UsuFamFrm.Show();
            UsuFamSMI.Enabled = false;
        }

        private void PatUsuSMI_Click(object sender, EventArgs e)
        {
            if (!UsuPatFrm.IsHandleCreated)
            {
                UsuPatFrm = new UsuarioPatente();
            }

            UsuPatFrm.MdiParent = this;
            UsuPatFrm.StartPosition = FormStartPosition.CenterScreen;
            UsuPatFrm.Show();
            PatUsuSMI.Enabled = false;
        }

        private void RecalcularDVSMI_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.PregDV, My.Resources.ArchivoIdioma.PreguntaTituDV, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {

                // DVH
                Integridad.RecalcularDVH(DtErrorIntegridad);
                // DVV
                Integridad.RecalcularDVV(DtErrorIntegridadDVV);
                MessageBox.Show(My.Resources.ArchivoIdioma.VerificoIntegridad, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecalcularDVSMI.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void EspanolSMI_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.CambiarIdiomaESP, My.Resources.ArchivoIdioma.CambiarIdioma, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                EspanolSMI.Enabled = false;
                InglesSMI.Enabled = true;
                ListaFormsNombres.Clear();
                ListaFormsNombresTT.Clear();
                foreach (Form f in Application.OpenForms)
                {
                    ListaFormsNombres.Add(f.Name);
                    ListaFormsNombresTT.Add(f.Name);
                }

                Idioma.AplicarIdioma("es-AR");
                AplicarIdioma(false, ListaFormsNombres);
                CargarTT(ListaFormsNombresTT);
            }
            else
            {
                return;
            }
        }

        private void InglesSMI_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show(My.Resources.ArchivoIdioma.CambiarIdiomaUS, My.Resources.ArchivoIdioma.CambiarIdioma, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                EspanolSMI.Enabled = true;
                InglesSMI.Enabled = false;
                ListaFormsNombres.Clear();
                ListaFormsNombresTT.Clear();
                foreach (Form f in Application.OpenForms)
                {
                    ListaFormsNombres.Add(f.Name);
                    ListaFormsNombresTT.Add(f.Name);
                }

                Idioma.AplicarIdioma("en-US");
                AplicarIdioma(false, ListaFormsNombres);
                CargarTT(ListaFormsNombresTT);
            }
            else
            {
                return;
            }
        }

        private void CambiarContrasenaSMI_Click(object sender, EventArgs e)
        {
            if (!CambiarPass.IsHandleCreated)
            {
                CambiarPass = new CambiarContrasena();
            }

            CambiarPass.MdiParent = this;
            CambiarPass.StartPosition = FormStartPosition.CenterScreen;
            CambiarPass.Show();
            CambiarContrasenaSMI.Enabled = false;
        }

        private void SalirSMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count - 1 != 0)
            {
                MessageBox.Show(My.Resources.ArchivoIdioma.FormulariosAbiertos, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                var UsuAut = Autenticar.Instancia();
                LogOut.CerrarSesion(UsuAut.UsuarioLogueado);
                Application.Exit();
                // Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-AR")

                // Dim frm As New LogIn
                // frm.Show()
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void BloquearSistema()
        {
            GestionSMI.Enabled = false;
            ComercialSMI.Enabled = false;
            if (EstadoIntegridad == true)
            {
                BackupSMI.Enabled = false;
                RestoreSMI.Enabled = false;
                BitacoraSMI.Enabled = false;
                PatFamSMI.Enabled = false;
                PatUsuSMI.Enabled = false;
                UsuFamSMI.Enabled = false;
                RecalcularDVSMI.Enabled = true;
            }
            else
            {
                SeguridadSMI.Enabled = false;
            }

            SistemaSMI.Enabled = false;
            IdiomaSMI.Enabled = false;
            CambiarContrasenaSMI.Enabled = false;
        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.G & !(GestionSMI.Enabled == false))
            {
                GestionSMI.ShowDropDown();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.C & !(ComercialSMI.Enabled == false))
            {
                ComercialSMI.ShowDropDown();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.S & !(SistemaSMI.Enabled == false))
            {
                SistemaSMI.ShowDropDown();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.Alt + (int)Keys.S & !(SeguridadSMI.Enabled == false))
            {
                SeguridadSMI.ShowDropDown();
            }

            if ((int)e.KeyData == (int)Keys.Control + (int)Keys.P & !(PanelSMI.Enabled == false))
            {
                PanelSMI.ShowDropDown();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}