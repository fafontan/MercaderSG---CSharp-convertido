using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class GestionNP : Form
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
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            NotaGB = new GroupBox();
            NotaPedidoDG = new DataGridView();
            NroNotaCAB = new DataGridViewTextBoxColumn();
            FechaCAB = new DataGridViewTextBoxColumn();
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            _NroNotaTxt = new TextBox();
            _NroNotaTxt.TextChanged += new EventHandler(NroNotaTxt_TextChanged);
            _NroNotaTxt.KeyPress += new KeyPressEventHandler(NroNotaTxt_KeyPress);
            _NroNotaTxt.Validated += new EventHandler(NroNotaTxt_Validated);
            AccionCMB = new ComboBox();
            NroNotaLbl = new Label();
            AccionLbl = new Label();
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            NotaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotaPedidoDG).BeginInit();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(184, 271);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 5;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(96, 271);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 4;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // NotaGB
            // 
            NotaGB.Controls.Add(NotaPedidoDG);
            NotaGB.Location = new Point(14, 92);
            NotaGB.Name = "NotaGB";
            NotaGB.Size = new Size(334, 173);
            NotaGB.TabIndex = 55;
            NotaGB.TabStop = false;
            NotaGB.Text = "Notas de Pedido";
            // 
            // NotaPedidoDG
            // 
            NotaPedidoDG.AllowUserToAddRows = false;
            NotaPedidoDG.AllowUserToDeleteRows = false;
            NotaPedidoDG.AllowUserToResizeColumns = false;
            NotaPedidoDG.AllowUserToResizeRows = false;
            NotaPedidoDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotaPedidoDG.Columns.AddRange(new DataGridViewColumn[] { NroNotaCAB, FechaCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            NotaPedidoDG.DefaultCellStyle = DataGridViewCellStyle1;
            NotaPedidoDG.Dock = DockStyle.Fill;
            NotaPedidoDG.Location = new Point(3, 19);
            NotaPedidoDG.MultiSelect = false;
            NotaPedidoDG.Name = "NotaPedidoDG";
            NotaPedidoDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NotaPedidoDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            NotaPedidoDG.ScrollBars = ScrollBars.Vertical;
            NotaPedidoDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NotaPedidoDG.Size = new Size(328, 151);
            NotaPedidoDG.StandardTab = true;
            NotaPedidoDG.TabIndex = 3;
            // 
            // NroNotaCAB
            // 
            NroNotaCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NroNotaCAB.DataPropertyName = "NroNota";
            NroNotaCAB.HeaderText = "Nro_Nota";
            NroNotaCAB.Name = "NroNotaCAB";
            NroNotaCAB.ReadOnly = true;
            NroNotaCAB.Width = 140;
            // 
            // FechaCAB
            // 
            FechaCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FechaCAB.DataPropertyName = "Fecha";
            FechaCAB.HeaderText = "Fecha";
            FechaCAB.Name = "FechaCAB";
            FechaCAB.ReadOnly = true;
            FechaCAB.Width = 125;
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.Location = new Point(259, 43);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(89, 30);
            _BuscarBtn.TabIndex = 2;
            _BuscarBtn.Text = "&Buscar";
            _BuscarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // NroNotaTxt
            // 
            _NroNotaTxt.Location = new Point(116, 48);
            _NroNotaTxt.Name = "_NroNotaTxt";
            _NroNotaTxt.Size = new Size(136, 23);
            _NroNotaTxt.TabIndex = 1;
            // 
            // AccionCMB
            // 
            AccionCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            AccionCMB.FormattingEnabled = true;
            AccionCMB.Location = new Point(116, 14);
            AccionCMB.Name = "AccionCMB";
            AccionCMB.Size = new Size(136, 23);
            AccionCMB.TabIndex = 0;
            // 
            // NroNotaLbl
            // 
            NroNotaLbl.AutoSize = true;
            NroNotaLbl.Location = new Point(11, 51);
            NroNotaLbl.Name = "NroNotaLbl";
            NroNotaLbl.Size = new Size(95, 15);
            NroNotaLbl.TabIndex = 51;
            NroNotaLbl.Text = "Número de Nota";
            // 
            // AccionLbl
            // 
            AccionLbl.AutoSize = true;
            AccionLbl.Location = new Point(11, 17);
            AccionLbl.Name = "AccionLbl";
            AccionLbl.Size = new Size(44, 15);
            AccionLbl.TabIndex = 50;
            AccionLbl.Text = "Acción";
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
            // GestionNP
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 308);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(NotaGB);
            Controls.Add(_BuscarBtn);
            Controls.Add(_NroNotaTxt);
            Controls.Add(AccionCMB);
            Controls.Add(NroNotaLbl);
            Controls.Add(AccionLbl);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(364, 337);
            MinimumSize = new Size(364, 337);
            Name = "GestionNP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionNP";
            NotaGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NotaPedidoDG).EndInit();
            Load += new EventHandler(GestionNP_Load);
            FormClosing += new FormClosingEventHandler(GestionNP_FormClosing);
            KeyDown += new KeyEventHandler(GestionNP_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _CancelarBtn;

        internal Button CancelarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CancelarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CancelarBtn != null)
                {
                    _CancelarBtn.Click -= CancelarBtn_Click;
                }

                _CancelarBtn = value;
                if (_CancelarBtn != null)
                {
                    _CancelarBtn.Click += CancelarBtn_Click;
                }
            }
        }

        private Button _AceptarBtn;

        internal Button AceptarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AceptarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AceptarBtn != null)
                {
                    _AceptarBtn.Click -= AceptarBtn_Click;
                }

                _AceptarBtn = value;
                if (_AceptarBtn != null)
                {
                    _AceptarBtn.Click += AceptarBtn_Click;
                }
            }
        }

        internal GroupBox NotaGB;
        internal DataGridView NotaPedidoDG;
        internal DataGridViewTextBoxColumn NroNotaCAB;
        internal DataGridViewTextBoxColumn FechaCAB;
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

        private TextBox _NroNotaTxt;

        internal TextBox NroNotaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NroNotaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NroNotaTxt != null)
                {
                    _NroNotaTxt.TextChanged -= NroNotaTxt_TextChanged;
                    _NroNotaTxt.KeyPress -= NroNotaTxt_KeyPress;
                    _NroNotaTxt.Validated -= NroNotaTxt_Validated;
                }

                _NroNotaTxt = value;
                if (_NroNotaTxt != null)
                {
                    _NroNotaTxt.TextChanged += NroNotaTxt_TextChanged;
                    _NroNotaTxt.KeyPress += NroNotaTxt_KeyPress;
                    _NroNotaTxt.Validated += NroNotaTxt_Validated;
                }
            }
        }

        internal ComboBox AccionCMB;
        internal Label NroNotaLbl;
        internal Label AccionLbl;
        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
    }
}