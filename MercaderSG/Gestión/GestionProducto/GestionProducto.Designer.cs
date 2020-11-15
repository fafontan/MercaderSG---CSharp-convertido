using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class GestionProducto : Form
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
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            ExportarCMS = new ContextMenuStrip(components);
            ExportarAXLSToolStripMenuItem = new ToolStripMenuItem();
            RegistrosGB = new GroupBox();
            ProductosDG = new DataGridView();
            GestionProductosGB = new GroupBox();
            OperacionGB = new GroupBox();
            _MasBtn = new Button();
            _MasBtn.MouseClick += new MouseEventHandler(MasBtn_MouseClick);
            OpcionesCMS = new ContextMenuStrip(components);
            _ModificarStockBtn = new ToolStripMenuItem();
            _ModificarStockBtn.Click += new EventHandler(ModificarStockToolStripMenuItem_Click);
            _ModificarPrecioBtn = new ToolStripMenuItem();
            _ModificarPrecioBtn.Click += new EventHandler(ModificarPrecioToolStripMenuItem_Click);
            _AgregarBtn = new Button();
            _AgregarBtn.Click += new EventHandler(AgregarBtn_Click);
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
            SS = new StatusStrip();
            Parte1Lbl = new ToolStripStatusLabel();
            InfoPagLbl = new ToolStripStatusLabel();
            Parte2Lbl = new ToolStripStatusLabel();
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
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            CodProdCAB = new DataGridViewTextBoxColumn();
            NombreCAB = new DataGridViewTextBoxColumn();
            PrecioUnitarioCAB = new DataGridViewTextBoxColumn();
            CantidadCAB = new DataGridViewTextBoxColumn();
            SectorCAB = new DataGridViewTextBoxColumn();
            ExportarCMS.SuspendLayout();
            RegistrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDG).BeginInit();
            GestionProductosGB.SuspendLayout();
            OperacionGB.SuspendLayout();
            OpcionesCMS.SuspendLayout();
            SS.SuspendLayout();
            SuspendLayout();
            // 
            // BGW
            // 
            // 
            // ExportarCMS
            // 
            ExportarCMS.Items.AddRange(new ToolStripItem[] { ExportarAXLSToolStripMenuItem });
            ExportarCMS.Name = "ExportarCMS";
            ExportarCMS.Size = new Size(149, 26);
            // 
            // ExportarAXLSToolStripMenuItem
            // 
            ExportarAXLSToolStripMenuItem.Image = My.Resources.Resources.ExcelE;
            ExportarAXLSToolStripMenuItem.Name = "ExportarAXLSToolStripMenuItem";
            ExportarAXLSToolStripMenuItem.Size = new Size(148, 22);
            ExportarAXLSToolStripMenuItem.Text = "Exportar a XLS";
            // 
            // RegistrosGB
            // 
            RegistrosGB.Controls.Add(ProductosDG);
            RegistrosGB.ForeColor = SystemColors.ControlText;
            RegistrosGB.Location = new Point(12, 159);
            RegistrosGB.Name = "RegistrosGB";
            RegistrosGB.Size = new Size(576, 376);
            RegistrosGB.TabIndex = 9;
            RegistrosGB.TabStop = false;
            RegistrosGB.Text = "Registros";
            // 
            // ProductosDG
            // 
            ProductosDG.AllowUserToAddRows = false;
            ProductosDG.AllowUserToDeleteRows = false;
            ProductosDG.AllowUserToResizeColumns = false;
            ProductosDG.AllowUserToResizeRows = false;
            ProductosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDG.Columns.AddRange(new DataGridViewColumn[] { CodProdCAB, NombreCAB, PrecioUnitarioCAB, CantidadCAB, SectorCAB });
            ProductosDG.ContextMenuStrip = ExportarCMS;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ProductosDG.DefaultCellStyle = DataGridViewCellStyle1;
            ProductosDG.Dock = DockStyle.Fill;
            ProductosDG.Location = new Point(3, 19);
            ProductosDG.MultiSelect = false;
            ProductosDG.Name = "ProductosDG";
            ProductosDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductosDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            ProductosDG.ScrollBars = ScrollBars.Vertical;
            ProductosDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductosDG.Size = new Size(570, 354);
            ProductosDG.StandardTab = true;
            ProductosDG.TabIndex = 10;
            // 
            // GestionProductosGB
            // 
            GestionProductosGB.Controls.Add(OperacionGB);
            GestionProductosGB.Controls.Add(_BuscarCmb);
            GestionProductosGB.Controls.Add(BuscarPorLbl);
            GestionProductosGB.Controls.Add(_BusquedaTxt);
            GestionProductosGB.Controls.Add(IgualLbl);
            GestionProductosGB.Controls.Add(_BuscarBtn);
            GestionProductosGB.Location = new Point(12, 12);
            GestionProductosGB.Name = "GestionProductosGB";
            GestionProductosGB.Size = new Size(576, 141);
            GestionProductosGB.TabIndex = 0;
            GestionProductosGB.TabStop = false;
            GestionProductosGB.Text = "Gestion de Productos";
            // 
            // OperacionGB
            // 
            OperacionGB.Controls.Add(_MasBtn);
            OperacionGB.Controls.Add(_AgregarBtn);
            OperacionGB.Controls.Add(_ModificarBtn);
            OperacionGB.Controls.Add(_EliminarBtn);
            OperacionGB.Location = new Point(12, 68);
            OperacionGB.Name = "OperacionGB";
            OperacionGB.Size = new Size(553, 65);
            OperacionGB.TabIndex = 4;
            OperacionGB.TabStop = false;
            OperacionGB.Text = "Operaciones";
            // 
            // MasBtn
            // 
            _MasBtn.ContextMenuStrip = OpcionesCMS;
            _MasBtn.Image = My.Resources.Resources.MasOpcionesE;
            _MasBtn.Location = new Point(420, 25);
            _MasBtn.Name = "_MasBtn";
            _MasBtn.Size = new Size(125, 24);
            _MasBtn.TabIndex = 8;
            _MasBtn.Text = "Más Opciones";
            _MasBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _MasBtn.UseVisualStyleBackColor = true;
            // 
            // OpcionesCMS
            // 
            OpcionesCMS.Items.AddRange(new ToolStripItem[] { _ModificarStockBtn, _ModificarPrecioBtn });
            OpcionesCMS.LayoutStyle = ToolStripLayoutStyle.Table;
            OpcionesCMS.Name = "OpcionesCMS";
            OpcionesCMS.Size = new Size(162, 48);
            // 
            // ModificarStockBtn
            // 
            _ModificarStockBtn.Image = My.Resources.Resources.StockE;
            _ModificarStockBtn.Name = "_ModificarStockBtn";
            _ModificarStockBtn.Size = new Size(161, 22);
            _ModificarStockBtn.Text = "Modificar Stock";
            // 
            // ModificarPrecioBtn
            // 
            _ModificarPrecioBtn.Image = My.Resources.Resources.PrecioE;
            _ModificarPrecioBtn.Name = "_ModificarPrecioBtn";
            _ModificarPrecioBtn.Size = new Size(161, 22);
            _ModificarPrecioBtn.Text = "Modificar Precio";
            // 
            // AgregarBtn
            // 
            _AgregarBtn.Image = My.Resources.Resources.add;
            _AgregarBtn.Location = new Point(8, 25);
            _AgregarBtn.Name = "_AgregarBtn";
            _AgregarBtn.Size = new Size(119, 24);
            _AgregarBtn.TabIndex = 5;
            _AgregarBtn.Text = "Nuevo Producto";
            _AgregarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            _ModificarBtn.Image = My.Resources.Resources.pencil;
            _ModificarBtn.Location = new Point(130, 25);
            _ModificarBtn.Name = "_ModificarBtn";
            _ModificarBtn.Size = new Size(144, 24);
            _ModificarBtn.TabIndex = 6;
            _ModificarBtn.Text = "Modificar Producto";
            _ModificarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            _EliminarBtn.Image = My.Resources.Resources.delete;
            _EliminarBtn.Location = new Point(277, 25);
            _EliminarBtn.Name = "_EliminarBtn";
            _EliminarBtn.Size = new Size(137, 24);
            _EliminarBtn.TabIndex = 7;
            _EliminarBtn.Text = "Eliminar Producto";
            _EliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarCmb
            // 
            _BuscarCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            _BuscarCmb.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarCmb.FormattingEnabled = true;
            _BuscarCmb.Location = new Point(111, 31);
            _BuscarCmb.Name = "_BuscarCmb";
            _BuscarCmb.Size = new Size(121, 23);
            _BuscarCmb.TabIndex = 1;
            // 
            // BuscarPorLbl
            // 
            BuscarPorLbl.AutoSize = true;
            BuscarPorLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarPorLbl.Location = new Point(26, 34);
            BuscarPorLbl.Name = "BuscarPorLbl";
            BuscarPorLbl.Size = new Size(67, 15);
            BuscarPorLbl.TabIndex = 41;
            BuscarPorLbl.Text = "Buscar por";
            // 
            // BusquedaTxt
            // 
            _BusquedaTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            _BusquedaTxt.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BusquedaTxt.Location = new Point(313, 31);
            _BusquedaTxt.Name = "_BusquedaTxt";
            _BusquedaTxt.Size = new Size(122, 23);
            _BusquedaTxt.TabIndex = 2;
            // 
            // IgualLbl
            // 
            IgualLbl.AutoSize = true;
            IgualLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IgualLbl.Location = new Point(250, 34);
            IgualLbl.Name = "IgualLbl";
            IgualLbl.Size = new Size(45, 15);
            IgualLbl.TabIndex = 43;
            IgualLbl.Text = "igual a";
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.Location = new Point(462, 27);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(88, 30);
            _BuscarBtn.TabIndex = 3;
            _BuscarBtn.Text = "&Buscar";
            _BuscarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { Parte1Lbl, InfoPagLbl, Parte2Lbl });
            SS.Location = new Point(0, 577);
            SS.Name = "SS";
            SS.RightToLeft = RightToLeft.No;
            SS.Size = new Size(601, 22);
            SS.TabIndex = 62;
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
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(284, 543);
            _RecargarBtn.Margin = new Padding(15, 3, 15, 3);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(32, 24);
            _RecargarBtn.TabIndex = 11;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // SiguienteBtn
            // 
            _SiguienteBtn.Image = My.Resources.Resources.SiguienteE;
            _SiguienteBtn.Location = new Point(334, 543);
            _SiguienteBtn.Name = "_SiguienteBtn";
            _SiguienteBtn.Size = new Size(32, 24);
            _SiguienteBtn.TabIndex = 14;
            _SiguienteBtn.UseVisualStyleBackColor = true;
            // 
            // AnteriorBtn
            // 
            _AnteriorBtn.Image = My.Resources.Resources.AnteriorE;
            _AnteriorBtn.Location = new Point(234, 543);
            _AnteriorBtn.Name = "_AnteriorBtn";
            _AnteriorBtn.Size = new Size(32, 24);
            _AnteriorBtn.TabIndex = 13;
            _AnteriorBtn.UseVisualStyleBackColor = true;
            // 
            // UltimoBtn
            // 
            _UltimoBtn.Image = My.Resources.Resources.UltimoE;
            _UltimoBtn.Location = new Point(372, 543);
            _UltimoBtn.Name = "_UltimoBtn";
            _UltimoBtn.Size = new Size(32, 24);
            _UltimoBtn.TabIndex = 15;
            _UltimoBtn.UseVisualStyleBackColor = true;
            // 
            // PrimeroBtn
            // 
            _PrimeroBtn.Image = My.Resources.Resources.PrimeroE;
            _PrimeroBtn.Location = new Point(196, 543);
            _PrimeroBtn.Name = "_PrimeroBtn";
            _PrimeroBtn.Size = new Size(32, 24);
            _PrimeroBtn.TabIndex = 12;
            _PrimeroBtn.UseVisualStyleBackColor = true;
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
            // CodProdCAB
            // 
            CodProdCAB.DataPropertyName = "CodProd";
            CodProdCAB.HeaderText = "Código";
            CodProdCAB.Name = "CodProdCAB";
            CodProdCAB.ReadOnly = true;
            CodProdCAB.Visible = false;
            CodProdCAB.Width = 75;
            // 
            // NombreCAB
            // 
            NombreCAB.DataPropertyName = "Nombre";
            NombreCAB.HeaderText = "Nombre";
            NombreCAB.Name = "NombreCAB";
            NombreCAB.ReadOnly = true;
            NombreCAB.Width = 143;
            // 
            // PrecioUnitarioCAB
            // 
            PrecioUnitarioCAB.DataPropertyName = "Precio";
            PrecioUnitarioCAB.HeaderText = "Precio";
            PrecioUnitarioCAB.Name = "PrecioUnitarioCAB";
            PrecioUnitarioCAB.ReadOnly = true;
            PrecioUnitarioCAB.Width = 109;
            // 
            // CantidadCAB
            // 
            CantidadCAB.DataPropertyName = "Cantidad";
            CantidadCAB.HeaderText = "Cantidad";
            CantidadCAB.Name = "CantidadCAB";
            CantidadCAB.ReadOnly = true;
            CantidadCAB.Width = 109;
            // 
            // SectorCAB
            // 
            SectorCAB.DataPropertyName = "Sector";
            SectorCAB.HeaderText = "Sector";
            SectorCAB.Name = "SectorCAB";
            SectorCAB.ReadOnly = true;
            SectorCAB.Width = 146;
            // 
            // GestionProducto
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(601, 599);
            Controls.Add(_RecargarBtn);
            Controls.Add(RegistrosGB);
            Controls.Add(GestionProductosGB);
            Controls.Add(_SiguienteBtn);
            Controls.Add(_AnteriorBtn);
            Controls.Add(SS);
            Controls.Add(_UltimoBtn);
            Controls.Add(_PrimeroBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(607, 628);
            MinimumSize = new Size(607, 628);
            Name = "GestionProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos - MercaderSG";
            ExportarCMS.ResumeLayout(false);
            RegistrosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductosDG).EndInit();
            GestionProductosGB.ResumeLayout(false);
            GestionProductosGB.PerformLayout();
            OperacionGB.ResumeLayout(false);
            OpcionesCMS.ResumeLayout(false);
            SS.ResumeLayout(false);
            SS.PerformLayout();
            Load += new EventHandler(GestionProducto_Load);
            FormClosing += new FormClosingEventHandler(GestionProducto_FormClosing);
            KeyDown += new KeyEventHandler(GestionProducto_KeyDown);
            ResumeLayout(false);
            PerformLayout();
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
        internal ToolStripMenuItem ExportarAXLSToolStripMenuItem;
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
        internal DataGridView ProductosDG;
        internal GroupBox GestionProductosGB;
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

        internal StatusStrip SS;
        internal ToolStripStatusLabel Parte1Lbl;
        internal ToolStripStatusLabel InfoPagLbl;
        internal ToolStripStatusLabel Parte2Lbl;
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

        private Button _MasBtn;

        internal Button MasBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MasBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MasBtn != null)
                {
                    _MasBtn.MouseClick -= MasBtn_MouseClick;
                }

                _MasBtn = value;
                if (_MasBtn != null)
                {
                    _MasBtn.MouseClick += MasBtn_MouseClick;
                }
            }
        }

        internal ContextMenuStrip OpcionesCMS;
        private ToolStripMenuItem _ModificarStockBtn;

        internal ToolStripMenuItem ModificarStockBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ModificarStockBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ModificarStockBtn != null)
                {
                    _ModificarStockBtn.Click -= ModificarStockToolStripMenuItem_Click;
                }

                _ModificarStockBtn = value;
                if (_ModificarStockBtn != null)
                {
                    _ModificarStockBtn.Click += ModificarStockToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ModificarPrecioBtn;

        internal ToolStripMenuItem ModificarPrecioBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ModificarPrecioBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ModificarPrecioBtn != null)
                {
                    _ModificarPrecioBtn.Click -= ModificarPrecioToolStripMenuItem_Click;
                }

                _ModificarPrecioBtn = value;
                if (_ModificarPrecioBtn != null)
                {
                    _ModificarPrecioBtn.Click += ModificarPrecioToolStripMenuItem_Click;
                }
            }
        }

        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
        internal DataGridViewTextBoxColumn CodProdCAB;
        internal DataGridViewTextBoxColumn NombreCAB;
        internal DataGridViewTextBoxColumn PrecioUnitarioCAB;
        internal DataGridViewTextBoxColumn CantidadCAB;
        internal DataGridViewTextBoxColumn SectorCAB;
    }
}