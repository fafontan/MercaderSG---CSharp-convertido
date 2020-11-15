using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class Principal : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            MenuPrincipal = new MenuStrip();
            GestionSMI = new ToolStripMenuItem();
            _GestionClienteSMI = new ToolStripMenuItem();
            _GestionClienteSMI.Click += new EventHandler(GestionClienteSMI_Click);
            _GestionProductoSMI = new ToolStripMenuItem();
            _GestionProductoSMI.Click += new EventHandler(GestionProductoSMI_Click);
            _GestionProveedorSMI = new ToolStripMenuItem();
            _GestionProveedorSMI.Click += new EventHandler(GestionProveedorSMI_Click);
            ComercialSMI = new ToolStripMenuItem();
            NotaVentaSMI = new ToolStripMenuItem();
            _GestionNVSMI = new ToolStripMenuItem();
            _GestionNVSMI.Click += new EventHandler(GestionNVSMI_Click);
            _GenerarNVSMI = new ToolStripMenuItem();
            _GenerarNVSMI.Click += new EventHandler(GenerarNVSMI_Click);
            NotaPedidoSMI = new ToolStripMenuItem();
            _GestionNPSMI = new ToolStripMenuItem();
            _GestionNPSMI.Click += new EventHandler(GestionNPSMI_Click);
            _GenerarNPSMI = new ToolStripMenuItem();
            _GenerarNPSMI.Click += new EventHandler(GenerarNPSMI_Click);
            SistemaSMI = new ToolStripMenuItem();
            _GestionUsuarioSMI = new ToolStripMenuItem();
            _GestionUsuarioSMI.Click += new EventHandler(GestionUsuarioSMI_Click);
            _GestionFamiliaSMI = new ToolStripMenuItem();
            _GestionFamiliaSMI.Click += new EventHandler(GestionFamiliaSMI_Click);
            _DesbloquearUsuarioSMI = new ToolStripMenuItem();
            _DesbloquearUsuarioSMI.Click += new EventHandler(DesbloquearUsuarioSMI_Click);
            _ResetearContrasenaSMI = new ToolStripMenuItem();
            _ResetearContrasenaSMI.Click += new EventHandler(ResetearContrasenaSMI_Click);
            SeguridadSMI = new ToolStripMenuItem();
            _BackupSMI = new ToolStripMenuItem();
            _BackupSMI.Click += new EventHandler(BackupSMI_Click);
            _RestoreSMI = new ToolStripMenuItem();
            _RestoreSMI.Click += new EventHandler(RestoreSMI_Click);
            _BitacoraSMI = new ToolStripMenuItem();
            _BitacoraSMI.Click += new EventHandler(BitacoraSMI_Click);
            _PatFamSMI = new ToolStripMenuItem();
            _PatFamSMI.Click += new EventHandler(PatFamSMI_Click);
            _UsuFamSMI = new ToolStripMenuItem();
            _UsuFamSMI.Click += new EventHandler(UsuFamSMI_Click);
            _PatUsuSMI = new ToolStripMenuItem();
            _PatUsuSMI.Click += new EventHandler(PatUsuSMI_Click);
            _RecalcularDVSMI = new ToolStripMenuItem();
            _RecalcularDVSMI.Click += new EventHandler(RecalcularDVSMI_Click);
            PanelSMI = new ToolStripMenuItem();
            IdiomaSMI = new ToolStripMenuItem();
            _EspanolSMI = new ToolStripMenuItem();
            _EspanolSMI.Click += new EventHandler(EspanolSMI_Click);
            _InglesSMI = new ToolStripMenuItem();
            _InglesSMI.Click += new EventHandler(InglesSMI_Click);
            _CambiarContrasenaSMI = new ToolStripMenuItem();
            _CambiarContrasenaSMI.Click += new EventHandler(CambiarContrasenaSMI_Click);
            _SalirSMI = new ToolStripMenuItem();
            _SalirSMI.Click += new EventHandler(SalirSMI_Click);
            MenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { GestionSMI, ComercialSMI, SistemaSMI, SeguridadSMI, PanelSMI });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(685, 24);
            MenuPrincipal.TabIndex = 1;
            MenuPrincipal.Text = "MenuStrip1";
            // 
            // GestionSMI
            // 
            GestionSMI.DropDownItems.AddRange(new ToolStripItem[] { _GestionClienteSMI, _GestionProductoSMI, _GestionProveedorSMI });
            GestionSMI.Name = "GestionSMI";
            GestionSMI.ShortcutKeyDisplayString = "";
            GestionSMI.Size = new Size(59, 20);
            GestionSMI.Text = "Gestión";
            // 
            // GestionClienteSMI
            // 
            _GestionClienteSMI.Image = My.Resources.Resources.ClienteE;
            _GestionClienteSMI.Name = "_GestionClienteSMI";
            _GestionClienteSMI.ShortcutKeyDisplayString = "";
            _GestionClienteSMI.Size = new Size(152, 22);
            _GestionClienteSMI.Text = "Clientes";
            // 
            // GestionProductoSMI
            // 
            _GestionProductoSMI.Image = My.Resources.Resources.package;
            _GestionProductoSMI.Name = "_GestionProductoSMI";
            _GestionProductoSMI.Size = new Size(152, 22);
            _GestionProductoSMI.Text = "Productos";
            // 
            // GestionProveedorSMI
            // 
            _GestionProveedorSMI.Image = My.Resources.Resources.ProveedorE;
            _GestionProveedorSMI.Name = "_GestionProveedorSMI";
            _GestionProveedorSMI.Size = new Size(152, 22);
            _GestionProveedorSMI.Text = "Proveedores";
            // 
            // ComercialSMI
            // 
            ComercialSMI.DropDownItems.AddRange(new ToolStripItem[] { NotaVentaSMI, NotaPedidoSMI });
            ComercialSMI.Name = "ComercialSMI";
            ComercialSMI.Size = new Size(73, 20);
            ComercialSMI.Text = "Comercial";
            // 
            // NotaVentaSMI
            // 
            NotaVentaSMI.DropDownItems.AddRange(new ToolStripItem[] { _GestionNVSMI, _GenerarNVSMI });
            NotaVentaSMI.Image = My.Resources.Resources.page_green;
            NotaVentaSMI.Name = "NotaVentaSMI";
            NotaVentaSMI.Size = new Size(156, 22);
            NotaVentaSMI.Text = "Nota de Venta";
            // 
            // GestionNVSMI
            // 
            _GestionNVSMI.Image = My.Resources.Resources.GestionNV;
            _GestionNVSMI.Name = "_GestionNVSMI";
            _GestionNVSMI.Size = new Size(152, 22);
            _GestionNVSMI.Text = "Gestion";
            // 
            // GenerarNVSMI
            // 
            _GenerarNVSMI.Image = My.Resources.Resources.page_add;
            _GenerarNVSMI.Name = "_GenerarNVSMI";
            _GenerarNVSMI.Size = new Size(152, 22);
            _GenerarNVSMI.Text = "Generar";
            // 
            // NotaPedidoSMI
            // 
            NotaPedidoSMI.DropDownItems.AddRange(new ToolStripItem[] { _GestionNPSMI, _GenerarNPSMI });
            NotaPedidoSMI.Image = My.Resources.Resources.page;
            NotaPedidoSMI.Name = "NotaPedidoSMI";
            NotaPedidoSMI.Size = new Size(156, 22);
            NotaPedidoSMI.Text = "Nota de Pedido";
            // 
            // GestionNPSMI
            // 
            _GestionNPSMI.Image = My.Resources.Resources.GestionNV;
            _GestionNPSMI.Name = "_GestionNPSMI";
            _GestionNPSMI.Size = new Size(152, 22);
            _GestionNPSMI.Text = "Gestion";
            // 
            // GenerarNPSMI
            // 
            _GenerarNPSMI.Image = My.Resources.Resources.page_add;
            _GenerarNPSMI.Name = "_GenerarNPSMI";
            _GenerarNPSMI.Size = new Size(152, 22);
            _GenerarNPSMI.Text = "Generar";
            // 
            // SistemaSMI
            // 
            SistemaSMI.DropDownItems.AddRange(new ToolStripItem[] { _GestionUsuarioSMI, _GestionFamiliaSMI, _DesbloquearUsuarioSMI, _ResetearContrasenaSMI });
            SistemaSMI.Name = "SistemaSMI";
            SistemaSMI.Size = new Size(60, 20);
            SistemaSMI.Text = "Sistema";
            // 
            // GestionUsuarioSMI
            // 
            _GestionUsuarioSMI.Image = My.Resources.Resources.group_user;
            _GestionUsuarioSMI.Name = "_GestionUsuarioSMI";
            _GestionUsuarioSMI.Size = new Size(183, 22);
            _GestionUsuarioSMI.Text = "Gestión de Usuarios";
            // 
            // GestionFamiliaSMI
            // 
            _GestionFamiliaSMI.Image = My.Resources.Resources.FamiliaE;
            _GestionFamiliaSMI.Name = "_GestionFamiliaSMI";
            _GestionFamiliaSMI.Size = new Size(183, 22);
            _GestionFamiliaSMI.Text = "Gestión de Familias";
            // 
            // DesbloquearUsuarioSMI
            // 
            _DesbloquearUsuarioSMI.Image = My.Resources.Resources.DesbloImg;
            _DesbloquearUsuarioSMI.Name = "_DesbloquearUsuarioSMI";
            _DesbloquearUsuarioSMI.Size = new Size(183, 22);
            _DesbloquearUsuarioSMI.Text = "Desbloquear Usuario";
            // 
            // ResetearContrasenaSMI
            // 
            _ResetearContrasenaSMI.Image = My.Resources.Resources.ResetearPass;
            _ResetearContrasenaSMI.Name = "_ResetearContrasenaSMI";
            _ResetearContrasenaSMI.Size = new Size(183, 22);
            _ResetearContrasenaSMI.Text = "Resetear Contraseña";
            // 
            // SeguridadSMI
            // 
            SeguridadSMI.DropDownItems.AddRange(new ToolStripItem[] { _BackupSMI, _RestoreSMI, _BitacoraSMI, _PatFamSMI, _UsuFamSMI, _PatUsuSMI, _RecalcularDVSMI });
            SeguridadSMI.Name = "SeguridadSMI";
            SeguridadSMI.Size = new Size(72, 20);
            SeguridadSMI.Text = "Seguridad";
            // 
            // BackupSMI
            // 
            _BackupSMI.Image = My.Resources.Resources.database_save;
            _BackupSMI.Name = "_BackupSMI";
            _BackupSMI.Size = new Size(203, 22);
            _BackupSMI.Text = "Copia de Seguridad - BD";
            // 
            // RestoreSMI
            // 
            _RestoreSMI.Image = My.Resources.Resources.RestoreE;
            _RestoreSMI.Name = "_RestoreSMI";
            _RestoreSMI.Size = new Size(203, 22);
            _RestoreSMI.Text = "Restaurar - BD";
            // 
            // BitacoraSMI
            // 
            _BitacoraSMI.Image = My.Resources.Resources.BitacoraE;
            _BitacoraSMI.Name = "_BitacoraSMI";
            _BitacoraSMI.Size = new Size(203, 22);
            _BitacoraSMI.Text = "Bitacora";
            // 
            // PatFamSMI
            // 
            _PatFamSMI.Image = My.Resources.Resources.Permisos;
            _PatFamSMI.Name = "_PatFamSMI";
            _PatFamSMI.Size = new Size(203, 22);
            _PatFamSMI.Text = "Patente - Familia";
            // 
            // UsuFamSMI
            // 
            _UsuFamSMI.Image = My.Resources.Resources.Permisos;
            _UsuFamSMI.Name = "_UsuFamSMI";
            _UsuFamSMI.Size = new Size(203, 22);
            _UsuFamSMI.Text = "Usuario - Familia";
            // 
            // PatUsuSMI
            // 
            _PatUsuSMI.Image = My.Resources.Resources.Permisos;
            _PatUsuSMI.Name = "_PatUsuSMI";
            _PatUsuSMI.Size = new Size(203, 22);
            _PatUsuSMI.Text = "Patente - Usuario";
            // 
            // RecalcularDVSMI
            // 
            _RecalcularDVSMI.Image = My.Resources.Resources.Calcular;
            _RecalcularDVSMI.Name = "_RecalcularDVSMI";
            _RecalcularDVSMI.Size = new Size(203, 22);
            _RecalcularDVSMI.Text = "Recalcular DV";
            // 
            // PanelSMI
            // 
            PanelSMI.DropDownItems.AddRange(new ToolStripItem[] { IdiomaSMI, _CambiarContrasenaSMI, _SalirSMI });
            PanelSMI.Name = "PanelSMI";
            PanelSMI.Size = new Size(48, 20);
            PanelSMI.Text = "Panel";
            // 
            // IdiomaSMI
            // 
            IdiomaSMI.DropDownItems.AddRange(new ToolStripItem[] { _EspanolSMI, _InglesSMI });
            IdiomaSMI.Image = My.Resources.Resources.IdiomaE;
            IdiomaSMI.Name = "IdiomaSMI";
            IdiomaSMI.Size = new Size(182, 22);
            IdiomaSMI.Text = "Idioma";
            // 
            // EspanolSMI
            // 
            _EspanolSMI.Image = My.Resources.Resources.ar;
            _EspanolSMI.Name = "_EspanolSMI";
            _EspanolSMI.Size = new Size(108, 22);
            _EspanolSMI.Text = "ES-AR";
            // 
            // InglesSMI
            // 
            _InglesSMI.Image = My.Resources.Resources.us;
            _InglesSMI.Name = "_InglesSMI";
            _InglesSMI.Size = new Size(108, 22);
            _InglesSMI.Text = "EN-US";
            // 
            // CambiarContrasenaSMI
            // 
            _CambiarContrasenaSMI.Image = My.Resources.Resources.CambiarPassE;
            _CambiarContrasenaSMI.Name = "_CambiarContrasenaSMI";
            _CambiarContrasenaSMI.Size = new Size(182, 22);
            _CambiarContrasenaSMI.Text = "Cambiar Contraseña";
            // 
            // SalirSMI
            // 
            _SalirSMI.Image = My.Resources.Resources.SalirE;
            _SalirSMI.Name = "_SalirSMI";
            _SalirSMI.Size = new Size(182, 22);
            _SalirSMI.Text = "Salir";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(685, 677);
            Controls.Add(MenuPrincipal);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            KeyPreview = true;
            MainMenuStrip = MenuPrincipal;
            MinimumSize = new Size(691, 706);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal - MercaderSG";
            WindowState = FormWindowState.Maximized;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            Load += new EventHandler(Principal_Load);
            FormClosing += new FormClosingEventHandler(Principal_FormClosing);
            KeyDown += new KeyEventHandler(Principal_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal MenuStrip MenuPrincipal;
        private ToolStripMenuItem _GestionClienteSMI;

        internal ToolStripMenuItem GestionClienteSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionClienteSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionClienteSMI != null)
                {
                    _GestionClienteSMI.Click -= GestionClienteSMI_Click;
                }

                _GestionClienteSMI = value;
                if (_GestionClienteSMI != null)
                {
                    _GestionClienteSMI.Click += GestionClienteSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _GestionProveedorSMI;

        internal ToolStripMenuItem GestionProveedorSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionProveedorSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionProveedorSMI != null)
                {
                    _GestionProveedorSMI.Click -= GestionProveedorSMI_Click;
                }

                _GestionProveedorSMI = value;
                if (_GestionProveedorSMI != null)
                {
                    _GestionProveedorSMI.Click += GestionProveedorSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _GestionProductoSMI;

        internal ToolStripMenuItem GestionProductoSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionProductoSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionProductoSMI != null)
                {
                    _GestionProductoSMI.Click -= GestionProductoSMI_Click;
                }

                _GestionProductoSMI = value;
                if (_GestionProductoSMI != null)
                {
                    _GestionProductoSMI.Click += GestionProductoSMI_Click;
                }
            }
        }

        internal ToolStripMenuItem ComercialSMI;
        internal ToolStripMenuItem NotaVentaSMI;
        private ToolStripMenuItem _GestionNVSMI;

        internal ToolStripMenuItem GestionNVSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionNVSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionNVSMI != null)
                {
                    _GestionNVSMI.Click -= GestionNVSMI_Click;
                }

                _GestionNVSMI = value;
                if (_GestionNVSMI != null)
                {
                    _GestionNVSMI.Click += GestionNVSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _GenerarNVSMI;

        internal ToolStripMenuItem GenerarNVSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GenerarNVSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GenerarNVSMI != null)
                {
                    _GenerarNVSMI.Click -= GenerarNVSMI_Click;
                }

                _GenerarNVSMI = value;
                if (_GenerarNVSMI != null)
                {
                    _GenerarNVSMI.Click += GenerarNVSMI_Click;
                }
            }
        }

        internal ToolStripMenuItem NotaPedidoSMI;
        private ToolStripMenuItem _GestionNPSMI;

        internal ToolStripMenuItem GestionNPSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionNPSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionNPSMI != null)
                {
                    _GestionNPSMI.Click -= GestionNPSMI_Click;
                }

                _GestionNPSMI = value;
                if (_GestionNPSMI != null)
                {
                    _GestionNPSMI.Click += GestionNPSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _GenerarNPSMI;

        internal ToolStripMenuItem GenerarNPSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GenerarNPSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GenerarNPSMI != null)
                {
                    _GenerarNPSMI.Click -= GenerarNPSMI_Click;
                }

                _GenerarNPSMI = value;
                if (_GenerarNPSMI != null)
                {
                    _GenerarNPSMI.Click += GenerarNPSMI_Click;
                }
            }
        }

        internal ToolStripMenuItem SistemaSMI;
        private ToolStripMenuItem _GestionUsuarioSMI;

        internal ToolStripMenuItem GestionUsuarioSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionUsuarioSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionUsuarioSMI != null)
                {
                    _GestionUsuarioSMI.Click -= GestionUsuarioSMI_Click;
                }

                _GestionUsuarioSMI = value;
                if (_GestionUsuarioSMI != null)
                {
                    _GestionUsuarioSMI.Click += GestionUsuarioSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _GestionFamiliaSMI;

        internal ToolStripMenuItem GestionFamiliaSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GestionFamiliaSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GestionFamiliaSMI != null)
                {
                    _GestionFamiliaSMI.Click -= GestionFamiliaSMI_Click;
                }

                _GestionFamiliaSMI = value;
                if (_GestionFamiliaSMI != null)
                {
                    _GestionFamiliaSMI.Click += GestionFamiliaSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _DesbloquearUsuarioSMI;

        internal ToolStripMenuItem DesbloquearUsuarioSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DesbloquearUsuarioSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DesbloquearUsuarioSMI != null)
                {
                    _DesbloquearUsuarioSMI.Click -= DesbloquearUsuarioSMI_Click;
                }

                _DesbloquearUsuarioSMI = value;
                if (_DesbloquearUsuarioSMI != null)
                {
                    _DesbloquearUsuarioSMI.Click += DesbloquearUsuarioSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _ResetearContrasenaSMI;

        internal ToolStripMenuItem ResetearContrasenaSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResetearContrasenaSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResetearContrasenaSMI != null)
                {
                    _ResetearContrasenaSMI.Click -= ResetearContrasenaSMI_Click;
                }

                _ResetearContrasenaSMI = value;
                if (_ResetearContrasenaSMI != null)
                {
                    _ResetearContrasenaSMI.Click += ResetearContrasenaSMI_Click;
                }
            }
        }

        internal ToolStripMenuItem SeguridadSMI;
        private ToolStripMenuItem _BackupSMI;

        internal ToolStripMenuItem BackupSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BackupSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BackupSMI != null)
                {
                    _BackupSMI.Click -= BackupSMI_Click;
                }

                _BackupSMI = value;
                if (_BackupSMI != null)
                {
                    _BackupSMI.Click += BackupSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _RestoreSMI;

        internal ToolStripMenuItem RestoreSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RestoreSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RestoreSMI != null)
                {
                    _RestoreSMI.Click -= RestoreSMI_Click;
                }

                _RestoreSMI = value;
                if (_RestoreSMI != null)
                {
                    _RestoreSMI.Click += RestoreSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _BitacoraSMI;

        internal ToolStripMenuItem BitacoraSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BitacoraSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BitacoraSMI != null)
                {
                    _BitacoraSMI.Click -= BitacoraSMI_Click;
                }

                _BitacoraSMI = value;
                if (_BitacoraSMI != null)
                {
                    _BitacoraSMI.Click += BitacoraSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _PatFamSMI;

        internal ToolStripMenuItem PatFamSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PatFamSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PatFamSMI != null)
                {
                    _PatFamSMI.Click -= PatFamSMI_Click;
                }

                _PatFamSMI = value;
                if (_PatFamSMI != null)
                {
                    _PatFamSMI.Click += PatFamSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _UsuFamSMI;

        internal ToolStripMenuItem UsuFamSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UsuFamSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UsuFamSMI != null)
                {
                    _UsuFamSMI.Click -= UsuFamSMI_Click;
                }

                _UsuFamSMI = value;
                if (_UsuFamSMI != null)
                {
                    _UsuFamSMI.Click += UsuFamSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _PatUsuSMI;

        internal ToolStripMenuItem PatUsuSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PatUsuSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PatUsuSMI != null)
                {
                    _PatUsuSMI.Click -= PatUsuSMI_Click;
                }

                _PatUsuSMI = value;
                if (_PatUsuSMI != null)
                {
                    _PatUsuSMI.Click += PatUsuSMI_Click;
                }
            }
        }

        internal ToolStripMenuItem PanelSMI;
        internal ToolStripMenuItem IdiomaSMI;
        private ToolStripMenuItem _EspanolSMI;

        internal ToolStripMenuItem EspanolSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EspanolSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EspanolSMI != null)
                {
                    _EspanolSMI.Click -= EspanolSMI_Click;
                }

                _EspanolSMI = value;
                if (_EspanolSMI != null)
                {
                    _EspanolSMI.Click += EspanolSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _InglesSMI;

        internal ToolStripMenuItem InglesSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InglesSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InglesSMI != null)
                {
                    _InglesSMI.Click -= InglesSMI_Click;
                }

                _InglesSMI = value;
                if (_InglesSMI != null)
                {
                    _InglesSMI.Click += InglesSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _CambiarContrasenaSMI;

        internal ToolStripMenuItem CambiarContrasenaSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CambiarContrasenaSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CambiarContrasenaSMI != null)
                {
                    _CambiarContrasenaSMI.Click -= CambiarContrasenaSMI_Click;
                }

                _CambiarContrasenaSMI = value;
                if (_CambiarContrasenaSMI != null)
                {
                    _CambiarContrasenaSMI.Click += CambiarContrasenaSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _SalirSMI;

        internal ToolStripMenuItem SalirSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SalirSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SalirSMI != null)
                {
                    _SalirSMI.Click -= SalirSMI_Click;
                }

                _SalirSMI = value;
                if (_SalirSMI != null)
                {
                    _SalirSMI.Click += SalirSMI_Click;
                }
            }
        }

        private ToolStripMenuItem _RecalcularDVSMI;

        internal ToolStripMenuItem RecalcularDVSMI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecalcularDVSMI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecalcularDVSMI != null)
                {
                    _RecalcularDVSMI.Click -= RecalcularDVSMI_Click;
                }

                _RecalcularDVSMI = value;
                if (_RecalcularDVSMI != null)
                {
                    _RecalcularDVSMI.Click += RecalcularDVSMI_Click;
                }
            }
        }

        internal ToolStripMenuItem GestionSMI;
    }
}