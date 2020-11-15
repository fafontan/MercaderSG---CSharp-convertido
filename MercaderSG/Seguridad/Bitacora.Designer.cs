using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class Bitacora : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            ExportarCMS = new ContextMenuStrip(components);
            _ExportarAXLSToolStripMenuItem = new ToolStripMenuItem();
            _ExportarAXLSToolStripMenuItem.Click += new EventHandler(ExportarAXLSToolStripMenuItem_Click);
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            PanelSuperior = new Panel();
            _DepurarBtn = new Button();
            _DepurarBtn.Click += new EventHandler(DepurarBtn_Click);
            FiltroLbl = new Label();
            _FiltroCMB = new ComboBox();
            _FiltroCMB.SelectedIndexChanged += new EventHandler(FiltroCMB_SelectedIndexChanged);
            PanelMedio = new Panel();
            PanelInferior = new Panel();
            _RecargarBtn = new Button();
            _RecargarBtn.Click += new EventHandler(RecargarBtn_Click);
            _SiguienteBtn = new Button();
            _SiguienteBtn.Click += new EventHandler(SiguienteBtn_Click);
            _AnteriorBtn = new Button();
            _AnteriorBtn.Click += new EventHandler(AnteriorBtn_Click);
            _UltimoBtn = new Button();
            _UltimoBtn.Click += new EventHandler(UltimoBtn_Click);
            _PrimeroBtn = new Button();
            _PrimeroBtn.Click += new EventHandler(PrimeroBtn_Click);
            RegistrosGB = new GroupBox();
            _BitacoraDG = new DataGridView();
            _BitacoraDG.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(BitacoraDG_ColumnHeaderMouseClick);
            CodBitCAB = new DataGridViewTextBoxColumn();
            FechaCAB = new DataGridViewTextBoxColumn();
            DescripcionCAB = new DataGridViewTextBoxColumn();
            CriticidadCAB = new DataGridViewTextBoxColumn();
            UsuarioCAB = new DataGridViewTextBoxColumn();
            PanelStatus = new Panel();
            SS = new StatusStrip();
            Parte1Lbl = new ToolStripStatusLabel();
            InfoPagLbl = new ToolStripStatusLabel();
            Parte2Lbl = new ToolStripStatusLabel();
            ExportarCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            PanelSuperior.SuspendLayout();
            PanelInferior.SuspendLayout();
            RegistrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_BitacoraDG).BeginInit();
            PanelStatus.SuspendLayout();
            SS.SuspendLayout();
            SuspendLayout();
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
            // BGW
            // 
            // 
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.AutoPopDelay = 5000;
            MensajeTT.InitialDelay = 1000;
            MensajeTT.ReshowDelay = 500;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
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
            // ErrorP
            // 
            ErrorP.BlinkRate = 150;
            ErrorP.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorP.ContainerControl = this;
            ErrorP.Icon = (Icon)resources.GetObject("ErrorP.Icon");
            // 
            // PanelSuperior
            // 
            PanelSuperior.Controls.Add(_DepurarBtn);
            PanelSuperior.Controls.Add(FiltroLbl);
            PanelSuperior.Controls.Add(_FiltroCMB);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(633, 46);
            PanelSuperior.TabIndex = 998;
            // 
            // DepurarBtn
            // 
            _DepurarBtn.Image = My.Resources.Resources.Clear;
            _DepurarBtn.Location = new Point(458, 9);
            _DepurarBtn.Name = "_DepurarBtn";
            _DepurarBtn.Size = new Size(133, 29);
            _DepurarBtn.TabIndex = 13;
            _DepurarBtn.Text = "Depurar Bitácora";
            _DepurarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _DepurarBtn.UseVisualStyleBackColor = true;
            // 
            // FiltroLbl
            // 
            FiltroLbl.AutoSize = true;
            FiltroLbl.Location = new Point(225, 16);
            FiltroLbl.Name = "FiltroLbl";
            FiltroLbl.Size = new Size(37, 15);
            FiltroLbl.TabIndex = 68;
            FiltroLbl.Text = "Filtro";
            // 
            // FiltroCMB
            // 
            _FiltroCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            _FiltroCMB.FormattingEnabled = true;
            _FiltroCMB.Location = new Point(268, 12);
            _FiltroCMB.Name = "_FiltroCMB";
            _FiltroCMB.Size = new Size(140, 23);
            _FiltroCMB.TabIndex = 0;
            // 
            // PanelMedio
            // 
            PanelMedio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelMedio.Dock = DockStyle.Top;
            PanelMedio.Location = new Point(0, 46);
            PanelMedio.Name = "PanelMedio";
            PanelMedio.Size = new Size(633, 113);
            PanelMedio.TabIndex = 999;
            // 
            // PanelInferior
            // 
            PanelInferior.Controls.Add(_RecargarBtn);
            PanelInferior.Controls.Add(_SiguienteBtn);
            PanelInferior.Controls.Add(_AnteriorBtn);
            PanelInferior.Controls.Add(_UltimoBtn);
            PanelInferior.Controls.Add(_PrimeroBtn);
            PanelInferior.Controls.Add(RegistrosGB);
            PanelInferior.Dock = DockStyle.Top;
            PanelInferior.Location = new Point(0, 159);
            PanelInferior.Name = "PanelInferior";
            PanelInferior.Size = new Size(633, 415);
            PanelInferior.TabIndex = 1000;
            // 
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(298, 383);
            _RecargarBtn.Margin = new Padding(15, 3, 15, 3);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(32, 24);
            _RecargarBtn.TabIndex = 8;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // SiguienteBtn
            // 
            _SiguienteBtn.Image = My.Resources.Resources.SiguienteE;
            _SiguienteBtn.Location = new Point(348, 383);
            _SiguienteBtn.Name = "_SiguienteBtn";
            _SiguienteBtn.Size = new Size(32, 24);
            _SiguienteBtn.TabIndex = 11;
            _SiguienteBtn.UseVisualStyleBackColor = true;
            // 
            // AnteriorBtn
            // 
            _AnteriorBtn.Image = My.Resources.Resources.AnteriorE;
            _AnteriorBtn.Location = new Point(248, 383);
            _AnteriorBtn.Name = "_AnteriorBtn";
            _AnteriorBtn.Size = new Size(32, 24);
            _AnteriorBtn.TabIndex = 10;
            _AnteriorBtn.UseVisualStyleBackColor = true;
            // 
            // UltimoBtn
            // 
            _UltimoBtn.Image = My.Resources.Resources.UltimoE;
            _UltimoBtn.Location = new Point(386, 383);
            _UltimoBtn.Name = "_UltimoBtn";
            _UltimoBtn.Size = new Size(32, 24);
            _UltimoBtn.TabIndex = 12;
            _UltimoBtn.UseVisualStyleBackColor = true;
            // 
            // PrimeroBtn
            // 
            _PrimeroBtn.Image = My.Resources.Resources.PrimeroE;
            _PrimeroBtn.Location = new Point(210, 383);
            _PrimeroBtn.Name = "_PrimeroBtn";
            _PrimeroBtn.Size = new Size(32, 24);
            _PrimeroBtn.TabIndex = 9;
            _PrimeroBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrosGB
            // 
            RegistrosGB.Controls.Add(_BitacoraDG);
            RegistrosGB.Location = new Point(3, 6);
            RegistrosGB.Name = "RegistrosGB";
            RegistrosGB.Size = new Size(626, 371);
            RegistrosGB.TabIndex = 19;
            RegistrosGB.TabStop = false;
            RegistrosGB.Text = "Registros";
            // 
            // BitacoraDG
            // 
            _BitacoraDG.AllowUserToAddRows = false;
            _BitacoraDG.AllowUserToDeleteRows = false;
            _BitacoraDG.AllowUserToResizeColumns = false;
            _BitacoraDG.AllowUserToResizeRows = false;
            _BitacoraDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _BitacoraDG.Columns.AddRange(new DataGridViewColumn[] { CodBitCAB, FechaCAB, DescripcionCAB, CriticidadCAB, UsuarioCAB });
            _BitacoraDG.ContextMenuStrip = ExportarCMS;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            _BitacoraDG.DefaultCellStyle = DataGridViewCellStyle1;
            _BitacoraDG.Dock = DockStyle.Fill;
            _BitacoraDG.Location = new Point(3, 19);
            _BitacoraDG.Name = "_BitacoraDG";
            _BitacoraDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _BitacoraDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            _BitacoraDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _BitacoraDG.Size = new Size(620, 349);
            _BitacoraDG.StandardTab = true;
            _BitacoraDG.TabIndex = 7;
            // 
            // CodBitCAB
            // 
            CodBitCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CodBitCAB.DataPropertyName = "CodBit";
            CodBitCAB.HeaderText = "Código";
            CodBitCAB.Name = "CodBitCAB";
            CodBitCAB.ReadOnly = true;
            CodBitCAB.SortMode = DataGridViewColumnSortMode.Programmatic;
            CodBitCAB.Visible = false;
            CodBitCAB.Width = 80;
            // 
            // FechaCAB
            // 
            FechaCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FechaCAB.DataPropertyName = "Fecha";
            FechaCAB.HeaderText = "Fecha";
            FechaCAB.Name = "FechaCAB";
            FechaCAB.ReadOnly = true;
            FechaCAB.SortMode = DataGridViewColumnSortMode.Programmatic;
            FechaCAB.Width = 125;
            // 
            // DescripcionCAB
            // 
            DescripcionCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DescripcionCAB.DataPropertyName = "Descripcion";
            DescripcionCAB.HeaderText = "Descripción";
            DescripcionCAB.Name = "DescripcionCAB";
            DescripcionCAB.ReadOnly = true;
            DescripcionCAB.SortMode = DataGridViewColumnSortMode.Programmatic;
            DescripcionCAB.Width = 228;
            // 
            // CriticidadCAB
            // 
            CriticidadCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CriticidadCAB.DataPropertyName = "Criticidad";
            CriticidadCAB.HeaderText = "Criticidad";
            CriticidadCAB.Name = "CriticidadCAB";
            CriticidadCAB.ReadOnly = true;
            CriticidadCAB.SortMode = DataGridViewColumnSortMode.Programmatic;
            CriticidadCAB.Width = 80;
            // 
            // UsuarioCAB
            // 
            UsuarioCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            UsuarioCAB.DataPropertyName = "Usuario";
            UsuarioCAB.HeaderText = "Usuario";
            UsuarioCAB.Name = "UsuarioCAB";
            UsuarioCAB.ReadOnly = true;
            UsuarioCAB.SortMode = DataGridViewColumnSortMode.Programmatic;
            UsuarioCAB.Width = 125;
            // 
            // PanelStatus
            // 
            PanelStatus.Controls.Add(SS);
            PanelStatus.Dock = DockStyle.Bottom;
            PanelStatus.Location = new Point(0, 572);
            PanelStatus.Name = "PanelStatus";
            PanelStatus.Size = new Size(633, 27);
            PanelStatus.TabIndex = 1001;
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { Parte1Lbl, InfoPagLbl, Parte2Lbl });
            SS.Location = new Point(0, 5);
            SS.Name = "SS";
            SS.RightToLeft = RightToLeft.No;
            SS.Size = new Size(633, 22);
            SS.TabIndex = 65;
            SS.Text = "StatusStrip1";
            // 
            // Parte1Lbl
            // 
            Parte1Lbl.Name = "Parte1Lbl";
            Parte1Lbl.Size = new Size(17, 17);
            Parte1Lbl.Text = "--";
            // 
            // InfoPagLbl
            // 
            InfoPagLbl.DisplayStyle = ToolStripItemDisplayStyle.Text;
            InfoPagLbl.Name = "InfoPagLbl";
            InfoPagLbl.Size = new Size(17, 17);
            InfoPagLbl.Text = "xx";
            // 
            // Parte2Lbl
            // 
            Parte2Lbl.Name = "Parte2Lbl";
            Parte2Lbl.Size = new Size(17, 17);
            Parte2Lbl.Text = "--";
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(633, 599);
            Controls.Add(PanelStatus);
            Controls.Add(PanelInferior);
            Controls.Add(PanelMedio);
            Controls.Add(PanelSuperior);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(639, 628);
            MinimumSize = new Size(639, 628);
            Name = "Bitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitácora - MercaderSG";
            ExportarCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            PanelInferior.ResumeLayout(false);
            RegistrosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_BitacoraDG).EndInit();
            PanelStatus.ResumeLayout(false);
            PanelStatus.PerformLayout();
            SS.ResumeLayout(false);
            SS.PerformLayout();
            Load += new EventHandler(Bitacora_Load);
            FormClosing += new FormClosingEventHandler(Bitacora_FormClosing);
            KeyDown += new KeyEventHandler(Bitacora_KeyDown);
            ResumeLayout(false);
        }

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

        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
        internal ErrorProvider ErrorP;
        internal Panel PanelInferior;
        internal Panel PanelMedio;
        internal Panel PanelSuperior;
        internal Panel PanelStatus;
        internal Label FiltroLbl;
        private ComboBox _FiltroCMB;

        internal ComboBox FiltroCMB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FiltroCMB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FiltroCMB != null)
                {
                    _FiltroCMB.SelectedIndexChanged -= FiltroCMB_SelectedIndexChanged;
                }

                _FiltroCMB = value;
                if (_FiltroCMB != null)
                {
                    _FiltroCMB.SelectedIndexChanged += FiltroCMB_SelectedIndexChanged;
                }
            }
        }

        internal GroupBox RegistrosGB;
        private DataGridView _BitacoraDG;

        internal DataGridView BitacoraDG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BitacoraDG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BitacoraDG != null)
                {
                    _BitacoraDG.ColumnHeaderMouseClick -= BitacoraDG_ColumnHeaderMouseClick;
                }

                _BitacoraDG = value;
                if (_BitacoraDG != null)
                {
                    _BitacoraDG.ColumnHeaderMouseClick += BitacoraDG_ColumnHeaderMouseClick;
                }
            }
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

        internal StatusStrip SS;
        internal ToolStripStatusLabel Parte1Lbl;
        internal ToolStripStatusLabel InfoPagLbl;
        internal ToolStripStatusLabel Parte2Lbl;
        private Button _DepurarBtn;

        internal Button DepurarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DepurarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DepurarBtn != null)
                {
                    _DepurarBtn.Click -= DepurarBtn_Click;
                }

                _DepurarBtn = value;
                if (_DepurarBtn != null)
                {
                    _DepurarBtn.Click += DepurarBtn_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn CodBitCAB;
        internal DataGridViewTextBoxColumn FechaCAB;
        internal DataGridViewTextBoxColumn DescripcionCAB;
        internal DataGridViewTextBoxColumn CriticidadCAB;
        internal DataGridViewTextBoxColumn UsuarioCAB;
    }
}