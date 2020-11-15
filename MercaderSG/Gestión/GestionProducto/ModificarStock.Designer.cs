using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ModificarStock : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarStock));
            ProductoGB = new GroupBox();
            CantidadGB = new GroupBox();
            CantidadNuevaTxt = new TextBox();
            CantNuevaLbl = new Label();
            CantActualLbl = new Label();
            CantActualTxt = new TextBox();
            CodigoTxt = new TextBox();
            DescripcionTxt = new TextBox();
            NombreTxt = new TextBox();
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
            _CantNuevaTxt = new TextBox();
            _CantNuevaTxt.TextChanged += new EventHandler(CantidadTxt_TextChanged);
            _CantNuevaTxt.KeyPress += new KeyPressEventHandler(CantidadTxt_KeyPress);
            CantidadLbl = new Label();
            ProductoGB.SuspendLayout();
            CantidadGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // ProductoGB
            // 
            ProductoGB.Controls.Add(CantidadGB);
            ProductoGB.Controls.Add(CodigoTxt);
            ProductoGB.Controls.Add(DescripcionTxt);
            ProductoGB.Controls.Add(NombreTxt);
            ProductoGB.Controls.Add(NombreLbl);
            ProductoGB.Controls.Add(DescripcionLbl);
            ProductoGB.Controls.Add(CodigoLbl);
            ProductoGB.Location = new Point(12, 12);
            ProductoGB.Name = "ProductoGB";
            ProductoGB.Size = new Size(310, 288);
            ProductoGB.TabIndex = 0;
            ProductoGB.TabStop = false;
            ProductoGB.Text = "Datos del producto";
            // 
            // CantidadGB
            // 
            CantidadGB.Controls.Add(CantidadNuevaTxt);
            CantidadGB.Controls.Add(CantNuevaLbl);
            CantidadGB.Controls.Add(CantActualLbl);
            CantidadGB.Controls.Add(CantActualTxt);
            CantidadGB.Location = new Point(18, 166);
            CantidadGB.Name = "CantidadGB";
            CantidadGB.Size = new Size(272, 107);
            CantidadGB.TabIndex = 4;
            CantidadGB.TabStop = false;
            CantidadGB.Text = "Stock Producto";
            // 
            // CantidadNuevaTxt
            // 
            CantidadNuevaTxt.Location = new Point(110, 66);
            CantidadNuevaTxt.Name = "CantidadNuevaTxt";
            CantidadNuevaTxt.Size = new Size(95, 23);
            CantidadNuevaTxt.TabIndex = 6;
            // 
            // CantNuevaLbl
            // 
            CantNuevaLbl.AutoSize = true;
            CantNuevaLbl.Location = new Point(10, 69);
            CantNuevaLbl.Name = "CantNuevaLbl";
            CantNuevaLbl.Size = new Size(56, 15);
            CantNuevaLbl.TabIndex = 8;
            CantNuevaLbl.Text = "Cantidad";
            // 
            // CantActualLbl
            // 
            CantActualLbl.AutoSize = true;
            CantActualLbl.Location = new Point(10, 30);
            CantActualLbl.Name = "CantActualLbl";
            CantActualLbl.Size = new Size(94, 15);
            CantActualLbl.TabIndex = 3;
            CantActualLbl.Text = "Cantidad Actual";
            // 
            // CantActualTxt
            // 
            CantActualTxt.Location = new Point(110, 27);
            CantActualTxt.Name = "CantActualTxt";
            CantActualTxt.ReadOnly = true;
            CantActualTxt.Size = new Size(95, 23);
            CantActualTxt.TabIndex = 5;
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
            DescripcionTxt.Location = new Point(93, 89);
            DescripcionTxt.Multiline = true;
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.ReadOnly = true;
            DescripcionTxt.Size = new Size(198, 71);
            DescripcionTxt.TabIndex = 3;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(93, 60);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.ReadOnly = true;
            NombreTxt.Size = new Size(116, 23);
            NombreTxt.TabIndex = 2;
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
            DescripcionLbl.Location = new Point(16, 97);
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
            _CancelarBtn.Location = new Point(170, 306);
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
            _AceptarBtn.Location = new Point(82, 306);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 7;
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
            // CantNuevaTxt
            // 
            _CantNuevaTxt.Location = new Point(110, 66);
            _CantNuevaTxt.Name = "_CantNuevaTxt";
            _CantNuevaTxt.Size = new Size(95, 20);
            _CantNuevaTxt.TabIndex = 9;
            // 
            // CantidadLbl
            // 
            CantidadLbl.AutoSize = true;
            CantidadLbl.Location = new Point(10, 69);
            CantidadLbl.Name = "CantidadLbl";
            CantidadLbl.Size = new Size(56, 15);
            CantidadLbl.TabIndex = 8;
            CantidadLbl.Text = "Cantidad";
            // 
            // ModificarStock
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(334, 336);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(ProductoGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ModificarStock";
            StartPosition = FormStartPosition.CenterScreen;
            ProductoGB.ResumeLayout(false);
            ProductoGB.PerformLayout();
            CantidadGB.ResumeLayout(false);
            CantidadGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(ModificarStock_Load);
            KeyDown += new KeyEventHandler(ModificarStock_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox ProductoGB;
        internal GroupBox CantidadGB;
        internal TextBox CantidadNuevaTxt;
        internal Label CantNuevaLbl;
        internal Label CantActualLbl;
        internal TextBox CantActualTxt;
        internal TextBox CodigoTxt;
        internal TextBox DescripcionTxt;
        internal TextBox NombreTxt;
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

        internal ToolTip ControlesTP;
        internal ErrorProvider ErrorP;
        internal ToolTip MensajeTT;
        private TextBox _CantNuevaTxt;

        internal TextBox CantNuevaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CantNuevaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CantNuevaTxt != null)
                {
                    _CantNuevaTxt.TextChanged -= CantidadTxt_TextChanged;
                    _CantNuevaTxt.KeyPress -= CantidadTxt_KeyPress;
                }

                _CantNuevaTxt = value;
                if (_CantNuevaTxt != null)
                {
                    _CantNuevaTxt.TextChanged += CantidadTxt_TextChanged;
                    _CantNuevaTxt.KeyPress += CantidadTxt_KeyPress;
                }
            }
        }

        internal Label CantidadLbl;
    }
}