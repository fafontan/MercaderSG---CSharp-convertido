using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class BuscarProducto : Form
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
            ProductoGB = new GroupBox();
            _ProductosDG = new DataGridView();
            _ProductosDG.CellDoubleClick += new DataGridViewCellEventHandler(ProductosDG_CellDoubleClick);
            CodProdCAB = new DataGridViewTextBoxColumn();
            NombreCAB = new DataGridViewTextBoxColumn();
            PrecioUnitarioCAB = new DataGridViewTextBoxColumn();
            CantidadCAB = new DataGridViewTextBoxColumn();
            SectorCAB = new DataGridViewTextBoxColumn();
            BuscarCmb = new ComboBox();
            BuscarPorLbl = new Label();
            BusquedaTxt = new TextBox();
            IgualLbl = new Label();
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            ProductoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ProductosDG).BeginInit();
            SuspendLayout();
            // 
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(512, 28);
            _RecargarBtn.Margin = new Padding(17, 3, 17, 3);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(44, 28);
            _RecargarBtn.TabIndex = 3;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // ProductoGB
            // 
            ProductoGB.Controls.Add(_ProductosDG);
            ProductoGB.Controls.Add(BuscarCmb);
            ProductoGB.Controls.Add(BuscarPorLbl);
            ProductoGB.Controls.Add(BusquedaTxt);
            ProductoGB.Controls.Add(IgualLbl);
            ProductoGB.Controls.Add(_BuscarBtn);
            ProductoGB.Controls.Add(_RecargarBtn);
            ProductoGB.Location = new Point(12, 16);
            ProductoGB.Name = "ProductoGB";
            ProductoGB.Size = new Size(576, 299);
            ProductoGB.TabIndex = 65;
            ProductoGB.TabStop = false;
            ProductoGB.Text = "Seleccionar Producto";
            // 
            // ProductosDG
            // 
            _ProductosDG.AllowUserToAddRows = false;
            _ProductosDG.AllowUserToDeleteRows = false;
            _ProductosDG.AllowUserToResizeColumns = false;
            _ProductosDG.AllowUserToResizeRows = false;
            _ProductosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _ProductosDG.Columns.AddRange(new DataGridViewColumn[] { CodProdCAB, NombreCAB, PrecioUnitarioCAB, CantidadCAB, SectorCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            _ProductosDG.DefaultCellStyle = DataGridViewCellStyle1;
            _ProductosDG.Dock = DockStyle.Bottom;
            _ProductosDG.Location = new Point(3, 77);
            _ProductosDG.MultiSelect = false;
            _ProductosDG.Name = "_ProductosDG";
            _ProductosDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _ProductosDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            _ProductosDG.ScrollBars = ScrollBars.Vertical;
            _ProductosDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ProductosDG.Size = new Size(570, 219);
            _ProductosDG.StandardTab = true;
            _ProductosDG.TabIndex = 69;
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
            // BuscarCmb
            // 
            BuscarCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            BuscarCmb.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarCmb.FormattingEnabled = true;
            BuscarCmb.Location = new Point(88, 30);
            BuscarCmb.Name = "BuscarCmb";
            BuscarCmb.Size = new Size(121, 23);
            BuscarCmb.TabIndex = 0;
            // 
            // BuscarPorLbl
            // 
            BuscarPorLbl.AutoSize = true;
            BuscarPorLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarPorLbl.Location = new Point(15, 33);
            BuscarPorLbl.Name = "BuscarPorLbl";
            BuscarPorLbl.Size = new Size(67, 15);
            BuscarPorLbl.TabIndex = 66;
            BuscarPorLbl.Text = "Buscar por";
            // 
            // BusquedaTxt
            // 
            BusquedaTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            BusquedaTxt.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BusquedaTxt.Location = new Point(266, 30);
            BusquedaTxt.Name = "BusquedaTxt";
            BusquedaTxt.Size = new Size(122, 23);
            BusquedaTxt.TabIndex = 1;
            // 
            // IgualLbl
            // 
            IgualLbl.AutoSize = true;
            IgualLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IgualLbl.Location = new Point(215, 33);
            IgualLbl.Name = "IgualLbl";
            IgualLbl.Size = new Size(45, 15);
            IgualLbl.TabIndex = 68;
            IgualLbl.Text = "igual a";
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.Location = new Point(404, 26);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(88, 30);
            _BuscarBtn.TabIndex = 2;
            _BuscarBtn.Text = "&Buscar";
            _BuscarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // BGW
            // 
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
            MensajeTT.AutoPopDelay = 5000;
            MensajeTT.InitialDelay = 1000;
            MensajeTT.ReshowDelay = 500;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // BuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(601, 327);
            Controls.Add(ProductoGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(607, 356);
            MinimumSize = new Size(607, 356);
            Name = "BuscarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            ProductoGB.ResumeLayout(false);
            ProductoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_ProductosDG).EndInit();
            Load += new EventHandler(BuscarProducto_Load);
            KeyDown += new KeyEventHandler(BuscarProducto_KeyDown);
            ResumeLayout(false);
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

        internal GroupBox ProductoGB;
        internal ComboBox BuscarCmb;
        internal Label BuscarPorLbl;
        internal TextBox BusquedaTxt;
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

        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
        private DataGridView _ProductosDG;

        internal DataGridView ProductosDG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ProductosDG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ProductosDG != null)
                {
                    _ProductosDG.CellDoubleClick -= ProductosDG_CellDoubleClick;
                }

                _ProductosDG = value;
                if (_ProductosDG != null)
                {
                    _ProductosDG.CellDoubleClick += ProductosDG_CellDoubleClick;
                }
            }
        }

        internal DataGridViewTextBoxColumn CodProdCAB;
        internal DataGridViewTextBoxColumn NombreCAB;
        internal DataGridViewTextBoxColumn PrecioUnitarioCAB;
        internal DataGridViewTextBoxColumn CantidadCAB;
        internal DataGridViewTextBoxColumn SectorCAB;
    }
}