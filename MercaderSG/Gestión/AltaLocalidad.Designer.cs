using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class AltaLocalidad : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaLocalidad));
            LocalidadGB = new GroupBox();
            ProvinciaCMB = new ComboBox();
            _CodPostalTxt = new TextBox();
            _CodPostalTxt.KeyPress += new KeyPressEventHandler(CodPostalTxt_KeyPress);
            _CodPostalTxt.TextChanged += new EventHandler(CodPostalTxt_TextChanged);
            _DescripcionTxt = new TextBox();
            _DescripcionTxt.Validated += new EventHandler(DescripcionTxt_Validated);
            _DescripcionTxt.KeyPress += new KeyPressEventHandler(DescripcionTxt_KeyPress);
            _DescripcionTxt.TextChanged += new EventHandler(DescripcionTxt_TextChanged);
            ProvinciaLbl = new Label();
            CodPostalLbl = new Label();
            DescripcionLbl = new Label();
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            LocalidadGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // LocalidadGB
            // 
            LocalidadGB.Controls.Add(ProvinciaCMB);
            LocalidadGB.Controls.Add(_CodPostalTxt);
            LocalidadGB.Controls.Add(_DescripcionTxt);
            LocalidadGB.Controls.Add(ProvinciaLbl);
            LocalidadGB.Controls.Add(CodPostalLbl);
            LocalidadGB.Controls.Add(DescripcionLbl);
            LocalidadGB.Location = new Point(12, 12);
            LocalidadGB.Name = "LocalidadGB";
            LocalidadGB.Size = new Size(246, 129);
            LocalidadGB.TabIndex = 0;
            LocalidadGB.TabStop = false;
            LocalidadGB.Text = "Localidad";
            // 
            // ProvinciaCMB
            // 
            ProvinciaCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            ProvinciaCMB.FormattingEnabled = true;
            ProvinciaCMB.Location = new Point(106, 91);
            ProvinciaCMB.Name = "ProvinciaCMB";
            ProvinciaCMB.Size = new Size(119, 23);
            ProvinciaCMB.TabIndex = 3;
            // 
            // CodPostalTxt
            // 
            _CodPostalTxt.Location = new Point(106, 60);
            _CodPostalTxt.Name = "_CodPostalTxt";
            _CodPostalTxt.Size = new Size(72, 23);
            _CodPostalTxt.TabIndex = 2;
            // 
            // DescripcionTxt
            // 
            _DescripcionTxt.Location = new Point(106, 28);
            _DescripcionTxt.Name = "_DescripcionTxt";
            _DescripcionTxt.Size = new Size(119, 23);
            _DescripcionTxt.TabIndex = 1;
            // 
            // ProvinciaLbl
            // 
            ProvinciaLbl.AutoSize = true;
            ProvinciaLbl.Location = new Point(9, 91);
            ProvinciaLbl.Name = "ProvinciaLbl";
            ProvinciaLbl.Size = new Size(60, 15);
            ProvinciaLbl.TabIndex = 2;
            ProvinciaLbl.Text = "Provincia";
            // 
            // CodPostalLbl
            // 
            CodPostalLbl.AutoSize = true;
            CodPostalLbl.Location = new Point(9, 63);
            CodPostalLbl.Name = "CodPostalLbl";
            CodPostalLbl.Size = new Size(83, 15);
            CodPostalLbl.TabIndex = 1;
            CodPostalLbl.Text = "Codigo Postal";
            // 
            // DescripcionLbl
            // 
            DescripcionLbl.AutoSize = true;
            DescripcionLbl.Location = new Point(9, 31);
            DescripcionLbl.Name = "DescripcionLbl";
            DescripcionLbl.Size = new Size(73, 15);
            DescripcionLbl.TabIndex = 0;
            DescripcionLbl.Text = "Descripcion";
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(49, 147);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 4;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(137, 147);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 5;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
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
            // AltaLocalidad
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(270, 178);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(LocalidadGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(276, 207);
            MinimumSize = new Size(276, 207);
            Name = "AltaLocalidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Localidad - MercaderSG";
            LocalidadGB.ResumeLayout(false);
            LocalidadGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(AltaLocalidad_Load);
            KeyDown += new KeyEventHandler(AltaLocalidad_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox LocalidadGB;
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

        internal ComboBox ProvinciaCMB;
        private TextBox _CodPostalTxt;

        internal TextBox CodPostalTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CodPostalTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CodPostalTxt != null)
                {
                    _CodPostalTxt.KeyPress -= CodPostalTxt_KeyPress;
                    _CodPostalTxt.TextChanged -= CodPostalTxt_TextChanged;
                }

                _CodPostalTxt = value;
                if (_CodPostalTxt != null)
                {
                    _CodPostalTxt.KeyPress += CodPostalTxt_KeyPress;
                    _CodPostalTxt.TextChanged += CodPostalTxt_TextChanged;
                }
            }
        }

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
                    _DescripcionTxt.Validated -= DescripcionTxt_Validated;
                    _DescripcionTxt.KeyPress -= DescripcionTxt_KeyPress;
                    _DescripcionTxt.TextChanged -= DescripcionTxt_TextChanged;
                }

                _DescripcionTxt = value;
                if (_DescripcionTxt != null)
                {
                    _DescripcionTxt.Validated += DescripcionTxt_Validated;
                    _DescripcionTxt.KeyPress += DescripcionTxt_KeyPress;
                    _DescripcionTxt.TextChanged += DescripcionTxt_TextChanged;
                }
            }
        }

        internal Label ProvinciaLbl;
        internal Label CodPostalLbl;
        internal Label DescripcionLbl;
        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
        internal ErrorProvider ErrorP;
    }
}