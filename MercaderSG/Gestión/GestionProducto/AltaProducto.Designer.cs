using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class AltaProducto : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProducto));
            NombreLbl = new Label();
            DescripcionLbl = new Label();
            SectorLbl = new Label();
            PrecioLbl = new Label();
            CantidadLbl = new Label();
            ProductoGB = new GroupBox();
            PrecioTxt = new NumericUpDown();
            _ACBtn = new Button();
            _ACBtn.Click += new EventHandler(ACBtn_Click);
            _DescripcionTxt = new TextBox();
            _DescripcionTxt.TextChanged += new EventHandler(DescripcionTxt_TextChanged);
            _DescripcionTxt.KeyPress += new KeyPressEventHandler(DescripcionTxt_KeyPress);
            _DescripcionTxt.Validated += new EventHandler(DescripcionTxt_Validated);
            _CantidadTxt = new TextBox();
            _CantidadTxt.TextChanged += new EventHandler(CantidadTxt_TextChanged);
            _CantidadTxt.KeyPress += new KeyPressEventHandler(CantidadTxt_KeyPress);
            _NombreTxt = new TextBox();
            _NombreTxt.TextChanged += new EventHandler(NombreTxt_TextChanged);
            _NombreTxt.KeyPress += new KeyPressEventHandler(NombreTxt_KeyPress);
            SectorCMB = new ComboBox();
            ControlesTP = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            MensajeTT = new ToolTip(components);
            ProductoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrecioTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(18, 34);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(50, 15);
            NombreLbl.TabIndex = 0;
            NombreLbl.Text = "Nombre";
            // 
            // DescripcionLbl
            // 
            DescripcionLbl.AutoSize = true;
            DescripcionLbl.Location = new Point(18, 92);
            DescripcionLbl.Name = "DescripcionLbl";
            DescripcionLbl.Size = new Size(73, 15);
            DescripcionLbl.TabIndex = 1;
            DescripcionLbl.Text = "Descripcion";
            // 
            // SectorLbl
            // 
            SectorLbl.AutoSize = true;
            SectorLbl.Location = new Point(18, 63);
            SectorLbl.Name = "SectorLbl";
            SectorLbl.Size = new Size(41, 15);
            SectorLbl.TabIndex = 2;
            SectorLbl.Text = "Sector";
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Location = new Point(234, 34);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(42, 15);
            PrecioLbl.TabIndex = 3;
            PrecioLbl.Text = "Precio";
            // 
            // CantidadLbl
            // 
            CantidadLbl.AutoSize = true;
            CantidadLbl.Location = new Point(234, 63);
            CantidadLbl.Name = "CantidadLbl";
            CantidadLbl.Size = new Size(56, 15);
            CantidadLbl.TabIndex = 4;
            CantidadLbl.Text = "Cantidad";
            // 
            // ProductoGB
            // 
            ProductoGB.Controls.Add(PrecioTxt);
            ProductoGB.Controls.Add(_ACBtn);
            ProductoGB.Controls.Add(_DescripcionTxt);
            ProductoGB.Controls.Add(_CantidadTxt);
            ProductoGB.Controls.Add(_NombreTxt);
            ProductoGB.Controls.Add(SectorCMB);
            ProductoGB.Controls.Add(NombreLbl);
            ProductoGB.Controls.Add(CantidadLbl);
            ProductoGB.Controls.Add(DescripcionLbl);
            ProductoGB.Controls.Add(PrecioLbl);
            ProductoGB.Controls.Add(SectorLbl);
            ProductoGB.Location = new Point(12, 12);
            ProductoGB.Name = "ProductoGB";
            ProductoGB.Size = new Size(417, 173);
            ProductoGB.TabIndex = 0;
            ProductoGB.TabStop = false;
            ProductoGB.Text = "Datos del producto";
            // 
            // PrecioTxt
            // 
            PrecioTxt.DecimalPlaces = 2;
            PrecioTxt.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            PrecioTxt.Location = new Point(296, 32);
            PrecioTxt.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            PrecioTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(100, 23);
            PrecioTxt.TabIndex = 3;
            PrecioTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ACBtn
            // 
            _ACBtn.Font = new Font("Calibri", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _ACBtn.ForeColor = Color.SteelBlue;
            _ACBtn.Location = new Point(61, 110);
            _ACBtn.Name = "_ACBtn";
            _ACBtn.Size = new Size(28, 22);
            _ACBtn.TabIndex = 5;
            _ACBtn.Text = "AC";
            _ACBtn.UseVisualStyleBackColor = true;
            // 
            // DescripcionTxt
            // 
            _DescripcionTxt.Location = new Point(95, 89);
            _DescripcionTxt.Multiline = true;
            _DescripcionTxt.Name = "_DescripcionTxt";
            _DescripcionTxt.Size = new Size(301, 71);
            _DescripcionTxt.TabIndex = 6;
            // 
            // CantidadTxt
            // 
            _CantidadTxt.Location = new Point(296, 60);
            _CantidadTxt.Name = "_CantidadTxt";
            _CantidadTxt.Size = new Size(100, 23);
            _CantidadTxt.TabIndex = 4;
            // 
            // NombreTxt
            // 
            _NombreTxt.Location = new Point(95, 31);
            _NombreTxt.Name = "_NombreTxt";
            _NombreTxt.Size = new Size(116, 23);
            _NombreTxt.TabIndex = 1;
            // 
            // SectorCMB
            // 
            SectorCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            SectorCMB.FormattingEnabled = true;
            SectorCMB.Location = new Point(95, 60);
            SectorCMB.Name = "SectorCMB";
            SectorCMB.Size = new Size(116, 23);
            SectorCMB.TabIndex = 2;
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
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(223, 191);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 8;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(135, 191);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 7;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
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
            // AltaProducto
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(441, 221);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(ProductoGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(447, 250);
            MinimumSize = new Size(447, 250);
            Name = "AltaProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto - MercaderSG";
            ProductoGB.ResumeLayout(false);
            ProductoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrecioTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(AltaProducto_Load);
            KeyDown += new KeyEventHandler(AltaProducto_KeyDown);
            ResumeLayout(false);
        }

        internal Label NombreLbl;
        internal Label DescripcionLbl;
        internal Label SectorLbl;
        internal Label PrecioLbl;
        internal Label CantidadLbl;
        internal GroupBox ProductoGB;
        private TextBox _DescripcionTxt;

        internal TextBox DescripcionTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DescripcionTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DescripcionTxt != null)
                {
                    _DescripcionTxt.TextChanged -= DescripcionTxt_TextChanged;
                    _DescripcionTxt.KeyPress -= DescripcionTxt_KeyPress;
                    _DescripcionTxt.Validated -= DescripcionTxt_Validated;
                }

                _DescripcionTxt = value;
                if (_DescripcionTxt != null)
                {
                    _DescripcionTxt.TextChanged += DescripcionTxt_TextChanged;
                    _DescripcionTxt.KeyPress += DescripcionTxt_KeyPress;
                    _DescripcionTxt.Validated += DescripcionTxt_Validated;
                }
            }
        }

        private TextBox _CantidadTxt;

        internal TextBox CantidadTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CantidadTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CantidadTxt != null)
                {
                    _CantidadTxt.TextChanged -= CantidadTxt_TextChanged;
                    _CantidadTxt.KeyPress -= CantidadTxt_KeyPress;
                }

                _CantidadTxt = value;
                if (_CantidadTxt != null)
                {
                    _CantidadTxt.TextChanged += CantidadTxt_TextChanged;
                    _CantidadTxt.KeyPress += CantidadTxt_KeyPress;
                }
            }
        }

        private TextBox _NombreTxt;

        internal TextBox NombreTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NombreTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NombreTxt != null)
                {
                    _NombreTxt.TextChanged -= NombreTxt_TextChanged;
                    _NombreTxt.KeyPress -= NombreTxt_KeyPress;
                }

                _NombreTxt = value;
                if (_NombreTxt != null)
                {
                    _NombreTxt.TextChanged += NombreTxt_TextChanged;
                    _NombreTxt.KeyPress += NombreTxt_KeyPress;
                }
            }
        }

        internal ComboBox SectorCMB;
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

        internal ToolTip ControlesTP;
        internal ErrorProvider ErrorP;
        private Button _ACBtn;

        internal Button ACBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ACBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ACBtn != null)
                {
                    _ACBtn.Click -= ACBtn_Click;
                }

                _ACBtn = value;
                if (_ACBtn != null)
                {
                    _ACBtn.Click += ACBtn_Click;
                }
            }
        }

        internal ToolTip MensajeTT;
        internal NumericUpDown PrecioTxt;
    }
}