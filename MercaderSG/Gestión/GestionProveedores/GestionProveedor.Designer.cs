using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class GestionProveedor : Form
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
            components = new System.ComponentModel.Container();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            _RecargarBtn = new Button();
            _RecargarBtn.Click += new EventHandler(RecargarBtn_Click);
            RegistrosGB = new GroupBox();
            ProveedorDG = new DataGridView();
            _SiguienteBtn = new Button();
            _SiguienteBtn.Click += new EventHandler(SiguienteBtn_Click);
            GestionProveedoresGB = new GroupBox();
            OperacionGB = new GroupBox();
            _AgregarBtn = new Button();
            _AgregarBtn.Click += new EventHandler(AgregarBtn_Click);
            _EliminarTelBtn = new Button();
            _EliminarTelBtn.Click += new EventHandler(EliminarTelBtn_Click);
            _ModificarBtn = new Button();
            _ModificarBtn.Click += new EventHandler(ModificarBtn_Click);
            _EliminarBtn = new Button();
            _EliminarBtn.Click += new EventHandler(EliminarBtn_Click);
            _BuscarCmb = new ComboBox();
            _BuscarCmb.SelectedIndexChanged += new EventHandler(BuscarCmb_SelectedIndexChanged);
            BuscarPorLbl = new Label();
            _BusquedaTxt = new TextBox();
            _BusquedaTxt.TextChanged += new EventHandler(BusquedaTxt_TextChanged);
            IgualLbl = new Label();
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            _AnteriorBtn = new Button();
            _AnteriorBtn.Click += new EventHandler(AnteriorBtn_Click);
            _UltimoBtn = new Button();
            _UltimoBtn.Click += new EventHandler(UltimoBtn_Click);
            _PrimeroBtn = new Button();
            _PrimeroBtn.Click += new EventHandler(PrimeroBtn_Click);
            InfoPagLbl = new ToolStripStatusLabel();
            SS = new StatusStrip();
            Parte1Lbl = new ToolStripStatusLabel();
            Parte2Lbl = new ToolStripStatusLabel();
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            ExportarCMS = new ContextMenuStrip(components);
            _ExportarAXLSToolStripMenuItem = new ToolStripMenuItem();
            _ExportarAXLSToolStripMenuItem.Click += new EventHandler(ExportarAXLSToolStripMenuItem_Click);
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            CodProvCAB = new DataGridViewTextBoxColumn();
            RazonSocialCAB = new DataGridViewTextBoxColumn();
            CuitCAB = new DataGridViewTextBoxColumn();
            CorreoElectronicoCAB = new DataGridViewTextBoxColumn();
            DireccionCAB = new DataGridViewTextBoxColumn();
            RegistrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProveedorDG).BeginInit();
            GestionProveedoresGB.SuspendLayout();
            OperacionGB.SuspendLayout();
            SS.SuspendLayout();
            ExportarCMS.SuspendLayout();
            SuspendLayout();
            // 
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(302, 543);
            _RecargarBtn.Margin = new Padding(15, 3, 15, 3);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(32, 24);
            _RecargarBtn.TabIndex = 11;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrosGB
            // 
            RegistrosGB.Controls.Add(ProveedorDG);
            RegistrosGB.ForeColor = SystemColors.ControlText;
            RegistrosGB.Location = new Point(12, 159);
            RegistrosGB.Name = "RegistrosGB";
            RegistrosGB.Size = new Size(614, 375);
            RegistrosGB.TabIndex = 9;
            RegistrosGB.TabStop = false;
            RegistrosGB.Text = "Registros";
            // 
            // ProveedorDG
            // 
            ProveedorDG.AllowUserToAddRows = false;
            ProveedorDG.AllowUserToDeleteRows = false;
            ProveedorDG.AllowUserToResizeColumns = false;
            ProveedorDG.AllowUserToResizeRows = false;
            ProveedorDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProveedorDG.Columns.AddRange(new DataGridViewColumn[] { CodProvCAB, RazonSocialCAB, CuitCAB, CorreoElectronicoCAB, DireccionCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ProveedorDG.DefaultCellStyle = DataGridViewCellStyle1;
            ProveedorDG.Dock = DockStyle.Fill;
            ProveedorDG.Location = new Point(3, 19);
            ProveedorDG.MultiSelect = false;
            ProveedorDG.Name = "ProveedorDG";
            ProveedorDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProveedorDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            ProveedorDG.ScrollBars = ScrollBars.Vertical;
            ProveedorDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProveedorDG.Size = new Size(608, 353);
            ProveedorDG.StandardTab = true;
            ProveedorDG.TabIndex = 10;
            // 
            // SiguienteBtn
            // 
            _SiguienteBtn.Image = My.Resources.Resources.SiguienteE;
            _SiguienteBtn.Location = new Point(352, 543);
            _SiguienteBtn.Name = "_SiguienteBtn";
            _SiguienteBtn.Size = new Size(32, 24);
            _SiguienteBtn.TabIndex = 14;
            _SiguienteBtn.UseVisualStyleBackColor = true;
            // 
            // GestionProveedoresGB
            // 
            GestionProveedoresGB.Controls.Add(OperacionGB);
            GestionProveedoresGB.Controls.Add(_BuscarCmb);
            GestionProveedoresGB.Controls.Add(BuscarPorLbl);
            GestionProveedoresGB.Controls.Add(_BusquedaTxt);
            GestionProveedoresGB.Controls.Add(IgualLbl);
            GestionProveedoresGB.Controls.Add(_BuscarBtn);
            GestionProveedoresGB.Location = new Point(12, 12);
            GestionProveedoresGB.Name = "GestionProveedoresGB";
            GestionProveedoresGB.Size = new Size(614, 141);
            GestionProveedoresGB.TabIndex = 0;
            GestionProveedoresGB.TabStop = false;
            GestionProveedoresGB.Text = "Gestion de Proveedores";
            // 
            // OperacionGB
            // 
            OperacionGB.Controls.Add(_AgregarBtn);
            OperacionGB.Controls.Add(_EliminarTelBtn);
            OperacionGB.Controls.Add(_ModificarBtn);
            OperacionGB.Controls.Add(_EliminarBtn);
            OperacionGB.Location = new Point(9, 66);
            OperacionGB.Name = "OperacionGB";
            OperacionGB.Size = new Size(596, 61);
            OperacionGB.TabIndex = 4;
            OperacionGB.TabStop = false;
            OperacionGB.Text = "Operaciones";
            // 
            // AgregarBtn
            // 
            _AgregarBtn.Image = My.Resources.Resources.add;
            _AgregarBtn.Location = new Point(6, 22);
            _AgregarBtn.Name = "_AgregarBtn";
            _AgregarBtn.Size = new Size(135, 24);
            _AgregarBtn.TabIndex = 5;
            _AgregarBtn.Text = "Nuevo Proveedor";
            _AgregarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarTelBtn
            // 
            _EliminarTelBtn.Image = My.Resources.Resources.phone_delete;
            _EliminarTelBtn.Location = new Point(445, 22);
            _EliminarTelBtn.Name = "_EliminarTelBtn";
            _EliminarTelBtn.Size = new Size(145, 24);
            _EliminarTelBtn.TabIndex = 8;
            _EliminarTelBtn.Text = "Eliminar Telefono/s";
            _EliminarTelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarTelBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            _ModificarBtn.Image = My.Resources.Resources.pencil;
            _ModificarBtn.Location = new Point(147, 22);
            _ModificarBtn.Name = "_ModificarBtn";
            _ModificarBtn.Size = new Size(148, 24);
            _ModificarBtn.TabIndex = 6;
            _ModificarBtn.Text = "Modificar Proveedor";
            _ModificarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            _EliminarBtn.Image = My.Resources.Resources.delete;
            _EliminarBtn.Location = new Point(301, 22);
            _EliminarBtn.Name = "_EliminarBtn";
            _EliminarBtn.Size = new Size(138, 24);
            _EliminarBtn.TabIndex = 7;
            _EliminarBtn.Text = "Eliminar Proveedor";
            _EliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarCmb
            // 
            _BuscarCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            _BuscarCmb.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarCmb.FormattingEnabled = true;
            _BuscarCmb.Location = new Point(130, 31);
            _BuscarCmb.Name = "_BuscarCmb";
            _BuscarCmb.Size = new Size(121, 23);
            _BuscarCmb.TabIndex = 1;
            // 
            // BuscarPorLbl
            // 
            BuscarPorLbl.AutoSize = true;
            BuscarPorLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarPorLbl.Location = new Point(45, 34);
            BuscarPorLbl.Name = "BuscarPorLbl";
            BuscarPorLbl.Size = new Size(67, 15);
            BuscarPorLbl.TabIndex = 41;
            BuscarPorLbl.Text = "Buscar por";
            // 
            // BusquedaTxt
            // 
            _BusquedaTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            _BusquedaTxt.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BusquedaTxt.Location = new Point(332, 31);
            _BusquedaTxt.Name = "_BusquedaTxt";
            _BusquedaTxt.Size = new Size(122, 23);
            _BusquedaTxt.TabIndex = 2;
            // 
            // IgualLbl
            // 
            IgualLbl.AutoSize = true;
            IgualLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IgualLbl.Location = new Point(269, 34);
            IgualLbl.Name = "IgualLbl";
            IgualLbl.Size = new Size(45, 15);
            IgualLbl.TabIndex = 43;
            IgualLbl.Text = "igual a";
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.Location = new Point(481, 27);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(88, 30);
            _BuscarBtn.TabIndex = 3;
            _BuscarBtn.Text = "&Buscar";
            _BuscarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // AnteriorBtn
            // 
            _AnteriorBtn.Image = My.Resources.Resources.AnteriorE;
            _AnteriorBtn.Location = new Point(252, 543);
            _AnteriorBtn.Name = "_AnteriorBtn";
            _AnteriorBtn.Size = new Size(32, 24);
            _AnteriorBtn.TabIndex = 13;
            _AnteriorBtn.UseVisualStyleBackColor = true;
            // 
            // UltimoBtn
            // 
            _UltimoBtn.Image = My.Resources.Resources.UltimoE;
            _UltimoBtn.Location = new Point(390, 543);
            _UltimoBtn.Name = "_UltimoBtn";
            _UltimoBtn.Size = new Size(32, 24);
            _UltimoBtn.TabIndex = 15;
            _UltimoBtn.UseVisualStyleBackColor = true;
            // 
            // PrimeroBtn
            // 
            _PrimeroBtn.Image = My.Resources.Resources.PrimeroE;
            _PrimeroBtn.Location = new Point(214, 543);
            _PrimeroBtn.Name = "_PrimeroBtn";
            _PrimeroBtn.Size = new Size(32, 24);
            _PrimeroBtn.TabIndex = 12;
            _PrimeroBtn.UseVisualStyleBackColor = true;
            // 
            // InfoPagLbl
            // 
            InfoPagLbl.DisplayStyle = ToolStripItemDisplayStyle.Text;
            InfoPagLbl.Name = "InfoPagLbl";
            InfoPagLbl.Size = new Size(17, 17);
            InfoPagLbl.Text = "xx";
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { Parte1Lbl, InfoPagLbl, Parte2Lbl });
            SS.Location = new Point(0, 577);
            SS.Name = "SS";
            SS.RightToLeft = RightToLeft.No;
            SS.Size = new Size(637, 22);
            SS.TabIndex = 65;
            SS.Text = "StatusStrip1";
            // 
            // Parte1Lbl
            // 
            Parte1Lbl.Name = "Parte1Lbl";
            Parte1Lbl.Size = new Size(17, 17);
            Parte1Lbl.Text = "--";
            // 
            // Parte2Lbl
            // 
            Parte2Lbl.Name = "Parte2Lbl";
            Parte2Lbl.Size = new Size(17, 17);
            Parte2Lbl.Text = "--";
            // 
            // BGW
            // 
            // 
            // ExportarCMS
            // 
            ExportarCMS.Items.AddRange(new ToolStripItem[] { _ExportarAXLSToolStripMenuItem });
            ExportarCMS.Name = "ExportarCMS";
            ExportarCMS.Size = new Size(149, 26);
            // 
            // ExportarAXLSToolStripMenuItem
            // 
            _ExportarAXLSToolStripMenuItem.Image = My.Resources.Resources.ExcelE;
            _ExportarAXLSToolStripMenuItem.Name = "_ExportarAXLSToolStripMenuItem";
            _ExportarAXLSToolStripMenuItem.Size = new Size(148, 22);
            _ExportarAXLSToolStripMenuItem.Text = "Exportar a XLS";
            // 
            // ControlesTP
            // 
            ControlesTP.AutoPopDelay = 5000;
            ControlesTP.BackColor = Color.WhiteSmoke;
            ControlesTP.ForeColor = SystemColors.Highlight;
            ControlesTP.InitialDelay = 100;
            ControlesTP.ReshowDelay = 100;
            ControlesTP.ToolTipIcon = ToolTipIcon.Info;
            ControlesTP.ToolTipTitle = "MercaderSG";
            // 
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // CodProvCAB
            // 
            CodProvCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CodProvCAB.DataPropertyName = "CodProv";
            CodProvCAB.HeaderText = "Código";
            CodProvCAB.Name = "CodProvCAB";
            CodProvCAB.ReadOnly = true;
            CodProvCAB.Visible = false;
            CodProvCAB.Width = 70;
            // 
            // RazonSocialCAB
            // 
            RazonSocialCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RazonSocialCAB.DataPropertyName = "RazonSocial";
            RazonSocialCAB.HeaderText = "Razon Social";
            RazonSocialCAB.Name = "RazonSocialCAB";
            RazonSocialCAB.ReadOnly = true;
            RazonSocialCAB.Width = 115;
            // 
            // CuitCAB
            // 
            CuitCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CuitCAB.DataPropertyName = "Cuit";
            CuitCAB.HeaderText = "CUIT";
            CuitCAB.Name = "CuitCAB";
            CuitCAB.ReadOnly = true;
            CuitCAB.Width = 130;
            // 
            // CorreoElectronicoCAB
            // 
            CorreoElectronicoCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CorreoElectronicoCAB.DataPropertyName = "CorreoElectronico";
            CorreoElectronicoCAB.HeaderText = "Correo Electronico";
            CorreoElectronicoCAB.Name = "CorreoElectronicoCAB";
            CorreoElectronicoCAB.ReadOnly = true;
            CorreoElectronicoCAB.Width = 165;
            // 
            // DireccionCAB
            // 
            DireccionCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DireccionCAB.DataPropertyName = "Direccion";
            DireccionCAB.HeaderText = "Dirección";
            DireccionCAB.Name = "DireccionCAB";
            DireccionCAB.ReadOnly = true;
            DireccionCAB.Width = 137;
            // 
            // GestionProveedor
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(637, 599);
            Controls.Add(SS);
            Controls.Add(_RecargarBtn);
            Controls.Add(RegistrosGB);
            Controls.Add(_SiguienteBtn);
            Controls.Add(GestionProveedoresGB);
            Controls.Add(_AnteriorBtn);
            Controls.Add(_UltimoBtn);
            Controls.Add(_PrimeroBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(643, 628);
            MinimumSize = new Size(643, 628);
            Name = "GestionProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MercaderSG - Gestión de Proveedores";
            RegistrosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProveedorDG).EndInit();
            GestionProveedoresGB.ResumeLayout(false);
            GestionProveedoresGB.PerformLayout();
            OperacionGB.ResumeLayout(false);
            SS.ResumeLayout(false);
            SS.PerformLayout();
            ExportarCMS.ResumeLayout(false);
            Load += new EventHandler(GestionProveedor_Load);
            FormClosing += new FormClosingEventHandler(GestionProveedor_FormClosing);
            KeyDown += new KeyEventHandler(GestionProveedor_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _RecargarBtn;

        internal Button RecargarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecargarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecargarBtn != null)
                {
                    _RecargarBtn.Click -= RecargarBtn_Click;
                }

                _RecargarBtn = value;
                if (_RecargarBtn != null)
                {
                    _RecargarBtn.Click += RecargarBtn_Click;
                }
            }
        }

        internal GroupBox RegistrosGB;
        internal DataGridView ProveedorDG;
        private Button _SiguienteBtn;

        internal Button SiguienteBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SiguienteBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SiguienteBtn != null)
                {
                    _SiguienteBtn.Click -= SiguienteBtn_Click;
                }

                _SiguienteBtn = value;
                if (_SiguienteBtn != null)
                {
                    _SiguienteBtn.Click += SiguienteBtn_Click;
                }
            }
        }

        internal GroupBox GestionProveedoresGB;
        internal GroupBox OperacionGB;
        private Button _AgregarBtn;

        internal Button AgregarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AgregarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AgregarBtn != null)
                {
                    _AgregarBtn.Click -= AgregarBtn_Click;
                }

                _AgregarBtn = value;
                if (_AgregarBtn != null)
                {
                    _AgregarBtn.Click += AgregarBtn_Click;
                }
            }
        }

        private Button _EliminarTelBtn;

        internal Button EliminarTelBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EliminarTelBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EliminarTelBtn != null)
                {
                    _EliminarTelBtn.Click -= EliminarTelBtn_Click;
                }

                _EliminarTelBtn = value;
                if (_EliminarTelBtn != null)
                {
                    _EliminarTelBtn.Click += EliminarTelBtn_Click;
                }
            }
        }

        private Button _ModificarBtn;

        internal Button ModificarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ModificarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ModificarBtn != null)
                {
                    _ModificarBtn.Click -= ModificarBtn_Click;
                }

                _ModificarBtn = value;
                if (_ModificarBtn != null)
                {
                    _ModificarBtn.Click += ModificarBtn_Click;
                }
            }
        }

        private Button _EliminarBtn;

        internal Button EliminarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EliminarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EliminarBtn != null)
                {
                    _EliminarBtn.Click -= EliminarBtn_Click;
                }

                _EliminarBtn = value;
                if (_EliminarBtn != null)
                {
                    _EliminarBtn.Click += EliminarBtn_Click;
                }
            }
        }

        private ComboBox _BuscarCmb;

        internal ComboBox BuscarCmb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarCmb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarCmb != null)
                {
                    _BuscarCmb.SelectedIndexChanged -= BuscarCmb_SelectedIndexChanged;
                }

                _BuscarCmb = value;
                if (_BuscarCmb != null)
                {
                    _BuscarCmb.SelectedIndexChanged += BuscarCmb_SelectedIndexChanged;
                }
            }
        }

        internal Label BuscarPorLbl;
        private TextBox _BusquedaTxt;

        internal TextBox BusquedaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BusquedaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BusquedaTxt != null)
                {
                    _BusquedaTxt.TextChanged -= BusquedaTxt_TextChanged;
                }

                _BusquedaTxt = value;
                if (_BusquedaTxt != null)
                {
                    _BusquedaTxt.TextChanged += BusquedaTxt_TextChanged;
                }
            }
        }

        internal Label IgualLbl;
        private Button _BuscarBtn;

        internal Button BuscarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarBtn != null)
                {
                    _BuscarBtn.Click -= BuscarBtn_Click;
                }

                _BuscarBtn = value;
                if (_BuscarBtn != null)
                {
                    _BuscarBtn.Click += BuscarBtn_Click;
                }
            }
        }

        private Button _AnteriorBtn;

        internal Button AnteriorBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AnteriorBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AnteriorBtn != null)
                {
                    _AnteriorBtn.Click -= AnteriorBtn_Click;
                }

                _AnteriorBtn = value;
                if (_AnteriorBtn != null)
                {
                    _AnteriorBtn.Click += AnteriorBtn_Click;
                }
            }
        }

        private Button _UltimoBtn;

        internal Button UltimoBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UltimoBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UltimoBtn != null)
                {
                    _UltimoBtn.Click -= UltimoBtn_Click;
                }

                _UltimoBtn = value;
                if (_UltimoBtn != null)
                {
                    _UltimoBtn.Click += UltimoBtn_Click;
                }
            }
        }

        private Button _PrimeroBtn;

        internal Button PrimeroBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrimeroBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrimeroBtn != null)
                {
                    _PrimeroBtn.Click -= PrimeroBtn_Click;
                }

                _PrimeroBtn = value;
                if (_PrimeroBtn != null)
                {
                    _PrimeroBtn.Click += PrimeroBtn_Click;
                }
            }
        }

        internal ToolStripStatusLabel InfoPagLbl;
        internal StatusStrip SS;
        internal ToolStripStatusLabel Parte1Lbl;
        internal ToolStripStatusLabel Parte2Lbl;
        private System.ComponentModel.BackgroundWorker _BGW;

        internal System.ComponentModel.BackgroundWorker BGW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BGW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BGW != null)
                {
                    _BGW.DoWork -= BGW_DoWork;
                    _BGW.ProgressChanged -= BGW_ProgressChanged;
                    _BGW.RunWorkerCompleted -= BGW_RunWorkerCompleted;
                }

                _BGW = value;
                if (_BGW != null)
                {
                    _BGW.DoWork += BGW_DoWork;
                    _BGW.ProgressChanged += BGW_ProgressChanged;
                    _BGW.RunWorkerCompleted += BGW_RunWorkerCompleted;
                }
            }
        }

        internal ContextMenuStrip ExportarCMS;
        private ToolStripMenuItem _ExportarAXLSToolStripMenuItem;

        internal ToolStripMenuItem ExportarAXLSToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExportarAXLSToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExportarAXLSToolStripMenuItem != null)
                {
                    _ExportarAXLSToolStripMenuItem.Click -= ExportarAXLSToolStripMenuItem_Click;
                }

                _ExportarAXLSToolStripMenuItem = value;
                if (_ExportarAXLSToolStripMenuItem != null)
                {
                    _ExportarAXLSToolStripMenuItem.Click += ExportarAXLSToolStripMenuItem_Click;
                }
            }
        }

        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
        internal DataGridViewTextBoxColumn CodProvCAB;
        internal DataGridViewTextBoxColumn RazonSocialCAB;
        internal DataGridViewTextBoxColumn CuitCAB;
        internal DataGridViewTextBoxColumn CorreoElectronicoCAB;
        internal DataGridViewTextBoxColumn DireccionCAB;
    }
}