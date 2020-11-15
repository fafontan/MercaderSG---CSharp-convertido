using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class EliminarTelProveedor : Form
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
            _AceptarBtn.Click += new EventHandler(EliminarBtn_Click);
            TelefonosGB = new GroupBox();
            _TelefonosDG = new DataGridView();
            _TelefonosDG.KeyDown += new KeyEventHandler(TelefonosDG_KeyDown);
            CodTelCAB = new DataGridViewTextBoxColumn();
            CodProvCAB = new DataGridViewTextBoxColumn();
            NumeroCAB = new DataGridViewTextBoxColumn();
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            TelefonosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).BeginInit();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            _CancelarBtn.ForeColor = Color.Black;
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(203, 151);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 3;
            _CancelarBtn.Text = "&Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.ForeColor = Color.Black;
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(115, 151);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 2;
            _AceptarBtn.Text = "&Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // TelefonosGB
            // 
            TelefonosGB.Controls.Add(_TelefonosDG);
            TelefonosGB.Location = new Point(14, 14);
            TelefonosGB.Margin = new Padding(5);
            TelefonosGB.Name = "TelefonosGB";
            TelefonosGB.Padding = new Padding(5);
            TelefonosGB.Size = new Size(372, 129);
            TelefonosGB.TabIndex = 0;
            TelefonosGB.TabStop = false;
            TelefonosGB.Text = "Telefonos";
            // 
            // TelefonosDG
            // 
            _TelefonosDG.AllowUserToAddRows = false;
            _TelefonosDG.AllowUserToDeleteRows = false;
            _TelefonosDG.AllowUserToResizeRows = false;
            _TelefonosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _TelefonosDG.Columns.AddRange(new DataGridViewColumn[] { CodTelCAB, CodProvCAB, NumeroCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            _TelefonosDG.DefaultCellStyle = DataGridViewCellStyle1;
            _TelefonosDG.Dock = DockStyle.Bottom;
            _TelefonosDG.Location = new Point(5, 16);
            _TelefonosDG.MultiSelect = false;
            _TelefonosDG.Name = "_TelefonosDG";
            _TelefonosDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _TelefonosDG.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _TelefonosDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _TelefonosDG.Size = new Size(362, 108);
            _TelefonosDG.StandardTab = true;
            _TelefonosDG.TabIndex = 1;
            // 
            // CodTelCAB
            // 
            CodTelCAB.DataPropertyName = "CodTel";
            CodTelCAB.HeaderText = "C.Telefono";
            CodTelCAB.Name = "CodTelCAB";
            CodTelCAB.ReadOnly = true;
            // 
            // CodProvCAB
            // 
            CodProvCAB.DataPropertyName = "CodEn";
            CodProvCAB.HeaderText = "C.Proveedor";
            CodProvCAB.Name = "CodProvCAB";
            CodProvCAB.ReadOnly = true;
            // 
            // NumeroCAB
            // 
            NumeroCAB.DataPropertyName = "Numero";
            NumeroCAB.HeaderText = "Número";
            NumeroCAB.Name = "NumeroCAB";
            NumeroCAB.ReadOnly = true;
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
            // EliminarTelProveedor
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(400, 184);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(TelefonosGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "EliminarTelProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar número de teléfono - MercaderS";
            TelefonosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).EndInit();
            Load += new EventHandler(EliminarTelProveedor_Load);
            KeyDown += new KeyEventHandler(EliminarTelProveedor_KeyDown);
            ResumeLayout(false);
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
                    _AceptarBtn.Click -= EliminarBtn_Click;
                }

                _AceptarBtn = value;
                if (_AceptarBtn != null)
                {
                    _AceptarBtn.Click += EliminarBtn_Click;
                }
            }
        }

        internal GroupBox TelefonosGB;
        private DataGridView _TelefonosDG;

        internal DataGridView TelefonosDG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TelefonosDG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TelefonosDG != null)
                {
                    _TelefonosDG.KeyDown -= TelefonosDG_KeyDown;
                }

                _TelefonosDG = value;
                if (_TelefonosDG != null)
                {
                    _TelefonosDG.KeyDown += TelefonosDG_KeyDown;
                }
            }
        }

        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
        internal DataGridViewTextBoxColumn CodTelCAB;
        internal DataGridViewTextBoxColumn CodProvCAB;
        internal DataGridViewTextBoxColumn NumeroCAB;
    }
}