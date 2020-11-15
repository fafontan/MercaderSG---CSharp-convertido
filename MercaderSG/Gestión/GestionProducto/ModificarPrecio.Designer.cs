using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ModificarPrecio : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPrecio));
            ProductoGB = new GroupBox();
            PrecioGB = new GroupBox();
            NuevoPrecioTxt = new NumericUpDown();
            NuevoPrecioLbl = new Label();
            PrecioActualLbl = new Label();
            PrecioActualTxt = new TextBox();
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
            ProductoGB.SuspendLayout();
            PrecioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NuevoPrecioTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // ProductoGB
            // 
            ProductoGB.Controls.Add(PrecioGB);
            ProductoGB.Controls.Add(CodigoTxt);
            ProductoGB.Controls.Add(DescripcionTxt);
            ProductoGB.Controls.Add(NombreTxt);
            ProductoGB.Controls.Add(NombreLbl);
            ProductoGB.Controls.Add(DescripcionLbl);
            ProductoGB.Controls.Add(CodigoLbl);
            ProductoGB.Location = new Point(12, 12);
            ProductoGB.Name = "ProductoGB";
            ProductoGB.Size = new Size(309, 288);
            ProductoGB.TabIndex = 0;
            ProductoGB.TabStop = false;
            ProductoGB.Text = "Datos del producto";
            // 
            // PrecioGB
            // 
            PrecioGB.Controls.Add(NuevoPrecioTxt);
            PrecioGB.Controls.Add(NuevoPrecioLbl);
            PrecioGB.Controls.Add(PrecioActualLbl);
            PrecioGB.Controls.Add(PrecioActualTxt);
            PrecioGB.Location = new Point(19, 166);
            PrecioGB.Name = "PrecioGB";
            PrecioGB.Size = new Size(271, 107);
            PrecioGB.TabIndex = 4;
            PrecioGB.TabStop = false;
            PrecioGB.Text = "Nuevo Precio";
            // 
            // NuevoPrecioTxt
            // 
            NuevoPrecioTxt.DecimalPlaces = 2;
            NuevoPrecioTxt.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            NuevoPrecioTxt.Location = new Point(96, 67);
            NuevoPrecioTxt.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            NuevoPrecioTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NuevoPrecioTxt.Name = "NuevoPrecioTxt";
            NuevoPrecioTxt.Size = new Size(95, 23);
            NuevoPrecioTxt.TabIndex = 6;
            NuevoPrecioTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NuevoPrecioLbl
            // 
            NuevoPrecioLbl.AutoSize = true;
            NuevoPrecioLbl.Location = new Point(10, 69);
            NuevoPrecioLbl.Name = "NuevoPrecioLbl";
            NuevoPrecioLbl.Size = new Size(79, 15);
            NuevoPrecioLbl.TabIndex = 8;
            NuevoPrecioLbl.Text = "Nuevo Precio";
            // 
            // PrecioActualLbl
            // 
            PrecioActualLbl.AutoSize = true;
            PrecioActualLbl.Location = new Point(10, 30);
            PrecioActualLbl.Name = "PrecioActualLbl";
            PrecioActualLbl.Size = new Size(80, 15);
            PrecioActualLbl.TabIndex = 3;
            PrecioActualLbl.Text = "Precio Actual";
            // 
            // PrecioActualTxt
            // 
            PrecioActualTxt.Location = new Point(96, 27);
            PrecioActualTxt.Name = "PrecioActualTxt";
            PrecioActualTxt.ReadOnly = true;
            PrecioActualTxt.Size = new Size(95, 23);
            PrecioActualTxt.TabIndex = 5;
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
            _CancelarBtn.Location = new Point(169, 306);
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
            _AceptarBtn.Location = new Point(81, 306);
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
            // ModificarPrecio
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(333, 336);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(ProductoGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ModificarPrecio";
            StartPosition = FormStartPosition.CenterScreen;
            ProductoGB.ResumeLayout(false);
            ProductoGB.PerformLayout();
            PrecioGB.ResumeLayout(false);
            PrecioGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NuevoPrecioTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(ModificarPrecio_Load);
            KeyDown += new KeyEventHandler(ModificarPrecio_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox ProductoGB;
        internal TextBox CodigoTxt;
        internal TextBox DescripcionTxt;
        internal TextBox PrecioActualTxt;
        internal TextBox NombreTxt;
        internal Label NombreLbl;
        internal Label DescripcionLbl;
        internal Label PrecioActualLbl;
        internal Label CodigoLbl;
        internal GroupBox PrecioGB;
        internal Label NuevoPrecioLbl;
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
        internal NumericUpDown NuevoPrecioTxt;
    }
}