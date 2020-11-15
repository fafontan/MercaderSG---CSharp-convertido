using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ModificarProducto : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            ProductoGB = new GroupBox();
            SectorCMB = new ComboBox();
            SectorLbl = new Label();
            CodigoTxt = new TextBox();
            _DescripcionTxt = new TextBox();
            _DescripcionTxt.TextChanged += new EventHandler(DescripcionTxt_TextChanged);
            _DescripcionTxt.KeyPress += new KeyPressEventHandler(DescripcionTxt_KeyPress);
            _DescripcionTxt.Validated += new EventHandler(DescripcionTxt_Validated);
            _NombreTxt = new TextBox();
            _NombreTxt.TextChanged += new EventHandler(NombreTxt_TextChanged);
            _NombreTxt.KeyPress += new KeyPressEventHandler(NombreTxt_KeyPress);
            NombreLbl = new Label();
            DescripcionLbl = new Label();
            CodigoLbl = new Label();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            ControlesTP = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            MensajeTT = new ToolTip(components);
            ProductoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // ProductoGB
            // 
            ProductoGB.Controls.Add(SectorCMB);
            ProductoGB.Controls.Add(SectorLbl);
            ProductoGB.Controls.Add(CodigoTxt);
            ProductoGB.Controls.Add(_DescripcionTxt);
            ProductoGB.Controls.Add(_NombreTxt);
            ProductoGB.Controls.Add(NombreLbl);
            ProductoGB.Controls.Add(DescripcionLbl);
            ProductoGB.Controls.Add(CodigoLbl);
            ProductoGB.Location = new Point(12, 12);
            ProductoGB.Name = "ProductoGB";
            ProductoGB.Size = new Size(305, 203);
            ProductoGB.TabIndex = 0;
            ProductoGB.TabStop = false;
            ProductoGB.Text = "Datos del producto";
            // 
            // SectorCMB
            // 
            SectorCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            SectorCMB.FormattingEnabled = true;
            SectorCMB.Location = new Point(93, 89);
            SectorCMB.Name = "SectorCMB";
            SectorCMB.Size = new Size(116, 23);
            SectorCMB.TabIndex = 3;
            // 
            // SectorLbl
            // 
            SectorLbl.AutoSize = true;
            SectorLbl.Location = new Point(16, 92);
            SectorLbl.Name = "SectorLbl";
            SectorLbl.Size = new Size(41, 15);
            SectorLbl.TabIndex = 11;
            SectorLbl.Text = "Sector";
            // 
            // CodigoTxt
            // 
            CodigoTxt.Location = new Point(93, 31);
            CodigoTxt.Name = "CodigoTxt";
            CodigoTxt.ReadOnly = true;
            CodigoTxt.Size = new Size(116, 23);
            CodigoTxt.TabIndex = 1;
            // 
            // DescripcionTxt
            // 
            _DescripcionTxt.Location = new Point(93, 118);
            _DescripcionTxt.Multiline = true;
            _DescripcionTxt.Name = "_DescripcionTxt";
            _DescripcionTxt.Size = new Size(198, 71);
            _DescripcionTxt.TabIndex = 4;
            // 
            // NombreTxt
            // 
            _NombreTxt.Location = new Point(93, 60);
            _NombreTxt.Name = "_NombreTxt";
            _NombreTxt.Size = new Size(116, 23);
            _NombreTxt.TabIndex = 2;
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(16, 63);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(50, 15);
            NombreLbl.TabIndex = 0;
            NombreLbl.Text = "Nombre";
            // 
            // DescripcionLbl
            // 
            DescripcionLbl.AutoSize = true;
            DescripcionLbl.Location = new Point(16, 126);
            DescripcionLbl.Name = "DescripcionLbl";
            DescripcionLbl.Size = new Size(73, 15);
            DescripcionLbl.TabIndex = 1;
            DescripcionLbl.Text = "Descripcion";
            // 
            // CodigoLbl
            // 
            CodigoLbl.AutoSize = true;
            CodigoLbl.Location = new Point(16, 34);
            CodigoLbl.Name = "CodigoLbl";
            CodigoLbl.Size = new Size(45, 15);
            CodigoLbl.TabIndex = 2;
            CodigoLbl.Text = "Código";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(167, 221);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 6;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(79, 221);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 5;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
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
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.AutoPopDelay = 5000;
            MensajeTT.InitialDelay = 1000;
            MensajeTT.ReshowDelay = 500;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // ModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(329, 256);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(ProductoGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ModificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto - MercaderSG";
            ProductoGB.ResumeLayout(false);
            ProductoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(ModificarProducto_Load);
            KeyDown += new KeyEventHandler(ModificarProducto_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox ProductoGB;
        internal TextBox CodigoTxt;
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

        internal Label NombreLbl;
        internal Label DescripcionLbl;
        internal Label CodigoLbl;
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

        internal ComboBox SectorCMB;
        internal Label SectorLbl;
        internal ToolTip ControlesTP;
        internal ErrorProvider ErrorP;
        internal ToolTip MensajeTT;
    }
}