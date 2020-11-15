using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class AltaCliente : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente));
            DatosGB = new GroupBox();
            _CuitTxt = new TextBox();
            _CuitTxt.TextChanged += new EventHandler(CuitTxt_TextChanged);
            _CuitTxt.KeyPress += new KeyPressEventHandler(CuitTxt_KeyPress);
            TelefonosGB = new GroupBox();
            NumeroTelLbl = new Label();
            _TelefonoTxt = new TextBox();
            _TelefonoTxt.TextChanged += new EventHandler(TelefonoTxt_TextChanged);
            _TelefonoTxt.KeyPress += new KeyPressEventHandler(TelefonoTxt_KeyPress);
            _QuitarTelBtn = new Button();
            _QuitarTelBtn.Click += new EventHandler(QuitarTelBtn_Click);
            _AgregarTelBtn = new Button();
            _AgregarTelBtn.Click += new EventHandler(AgregarTelBtn_Click);
            _TelefonosDG = new DataGridView();
            _TelefonosDG.Click += new EventHandler(TelefonosDG_Click);
            NumeroCAB = new DataGridViewTextBoxColumn();
            _RazonSocialTxt = new TextBox();
            _RazonSocialTxt.TextChanged += new EventHandler(RazonSocialTxt_TextChanged);
            _RazonSocialTxt.KeyPress += new KeyPressEventHandler(RazonSocialTxtCalleTxt_KeyPress);
            _RazonSocialTxt.Validated += new EventHandler(RazonSocialTxt_Validated);
            CuitLbl = new Label();
            RazonSocialLbl = new Label();
            DomicilioGB = new GroupBox();
            DepartamentoLbl = new Label();
            _DepartamentoTxt = new TextBox();
            _DepartamentoTxt.TextChanged += new EventHandler(DepartamentoTxt_TextChanged);
            _DepartamentoTxt.KeyPress += new KeyPressEventHandler(DepartamentoTxt_KeyPress);
            _DepartamentoTxt.Validated += new EventHandler(DepartamentoTxt_Validated);
            _AgregarLocBtn = new Button();
            _AgregarLocBtn.Click += new EventHandler(AgregarLocBtn_Click);
            CalleLbl = new Label();
            NumeroLbl = new Label();
            LocalidadCMB = new ComboBox();
            PisoLbl = new Label();
            _PisoTxt = new TextBox();
            _PisoTxt.TextChanged += new EventHandler(PisoTxt_TextChanged);
            _PisoTxt.KeyPress += new KeyPressEventHandler(NumeroYPisoTxt_KeyPress);
            LocalidadLbl = new Label();
            _CalleTxt = new TextBox();
            _CalleTxt.TextChanged += new EventHandler(CalleTxt_TextChanged);
            _CalleTxt.KeyPress += new KeyPressEventHandler(RazonSocialTxtCalleTxt_KeyPress);
            _CalleTxt.Validated += new EventHandler(CalleTxt_Validated);
            _NumeroTxt = new TextBox();
            _NumeroTxt.TextChanged += new EventHandler(NumeroTxt_TextChanged);
            _NumeroTxt.KeyPress += new KeyPressEventHandler(NumeroYPisoTxt_KeyPress);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            ErrorP = new ErrorProvider(components);
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            DatosGB.SuspendLayout();
            TelefonosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).BeginInit();
            DomicilioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // DatosGB
            // 
            DatosGB.Controls.Add(_CuitTxt);
            DatosGB.Controls.Add(TelefonosGB);
            DatosGB.Controls.Add(_RazonSocialTxt);
            DatosGB.Controls.Add(CuitLbl);
            DatosGB.Controls.Add(RazonSocialLbl);
            DatosGB.Location = new Point(12, 12);
            DatosGB.Name = "DatosGB";
            DatosGB.Size = new Size(257, 255);
            DatosGB.TabIndex = 0;
            DatosGB.TabStop = false;
            DatosGB.Text = "Datos de la Empresa";
            // 
            // CuitTxt
            // 
            _CuitTxt.Location = new Point(114, 55);
            _CuitTxt.Name = "_CuitTxt";
            _CuitTxt.Size = new Size(121, 23);
            _CuitTxt.TabIndex = 2;
            // 
            // TelefonosGB
            // 
            TelefonosGB.Controls.Add(NumeroTelLbl);
            TelefonosGB.Controls.Add(_TelefonoTxt);
            TelefonosGB.Controls.Add(_QuitarTelBtn);
            TelefonosGB.Controls.Add(_AgregarTelBtn);
            TelefonosGB.Controls.Add(_TelefonosDG);
            TelefonosGB.Location = new Point(10, 84);
            TelefonosGB.Name = "TelefonosGB";
            TelefonosGB.Size = new Size(231, 161);
            TelefonosGB.TabIndex = 3;
            TelefonosGB.TabStop = false;
            TelefonosGB.Text = "Telefonos";
            // 
            // NumeroTelLbl
            // 
            NumeroTelLbl.AutoSize = true;
            NumeroTelLbl.Location = new Point(7, 23);
            NumeroTelLbl.Name = "NumeroTelLbl";
            NumeroTelLbl.Size = new Size(50, 15);
            NumeroTelLbl.TabIndex = 5;
            NumeroTelLbl.Text = "Numero";
            // 
            // TelefonoTxt
            // 
            _TelefonoTxt.Location = new Point(63, 20);
            _TelefonoTxt.Name = "_TelefonoTxt";
            _TelefonoTxt.Size = new Size(111, 23);
            _TelefonoTxt.TabIndex = 4;
            // 
            // QuitarTelBtn
            // 
            _QuitarTelBtn.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _QuitarTelBtn.Location = new Point(196, 48);
            _QuitarTelBtn.Name = "_QuitarTelBtn";
            _QuitarTelBtn.Size = new Size(29, 23);
            _QuitarTelBtn.TabIndex = 6;
            _QuitarTelBtn.Text = "-";
            _QuitarTelBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarTelBtn
            // 
            _AgregarTelBtn.Location = new Point(196, 19);
            _AgregarTelBtn.Name = "_AgregarTelBtn";
            _AgregarTelBtn.Size = new Size(29, 23);
            _AgregarTelBtn.TabIndex = 5;
            _AgregarTelBtn.Text = "+";
            _AgregarTelBtn.UseVisualStyleBackColor = true;
            // 
            // TelefonosDG
            // 
            _TelefonosDG.AllowUserToAddRows = false;
            _TelefonosDG.AllowUserToDeleteRows = false;
            _TelefonosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _TelefonosDG.Columns.AddRange(new DataGridViewColumn[] { NumeroCAB });
            _TelefonosDG.Location = new Point(10, 52);
            _TelefonosDG.Name = "_TelefonosDG";
            _TelefonosDG.Size = new Size(176, 104);
            _TelefonosDG.StandardTab = true;
            _TelefonosDG.TabIndex = 7;
            // 
            // NumeroCAB
            // 
            NumeroCAB.HeaderText = "Número";
            NumeroCAB.Name = "NumeroCAB";
            // 
            // RazonSocialTxt
            // 
            _RazonSocialTxt.Location = new Point(114, 26);
            _RazonSocialTxt.Name = "_RazonSocialTxt";
            _RazonSocialTxt.Size = new Size(121, 23);
            _RazonSocialTxt.TabIndex = 1;
            // 
            // CuitLbl
            // 
            CuitLbl.AutoSize = true;
            CuitLbl.Location = new Point(16, 58);
            CuitLbl.Name = "CuitLbl";
            CuitLbl.Size = new Size(32, 15);
            CuitLbl.TabIndex = 2;
            CuitLbl.Text = "CUIT";
            // 
            // RazonSocialLbl
            // 
            RazonSocialLbl.AutoSize = true;
            RazonSocialLbl.Location = new Point(16, 29);
            RazonSocialLbl.Name = "RazonSocialLbl";
            RazonSocialLbl.Size = new Size(77, 15);
            RazonSocialLbl.TabIndex = 0;
            RazonSocialLbl.Text = "Razón Social";
            // 
            // DomicilioGB
            // 
            DomicilioGB.Controls.Add(DepartamentoLbl);
            DomicilioGB.Controls.Add(_DepartamentoTxt);
            DomicilioGB.Controls.Add(_AgregarLocBtn);
            DomicilioGB.Controls.Add(CalleLbl);
            DomicilioGB.Controls.Add(NumeroLbl);
            DomicilioGB.Controls.Add(LocalidadCMB);
            DomicilioGB.Controls.Add(PisoLbl);
            DomicilioGB.Controls.Add(_PisoTxt);
            DomicilioGB.Controls.Add(LocalidadLbl);
            DomicilioGB.Controls.Add(_CalleTxt);
            DomicilioGB.Controls.Add(_NumeroTxt);
            DomicilioGB.Location = new Point(12, 273);
            DomicilioGB.Name = "DomicilioGB";
            DomicilioGB.Size = new Size(257, 178);
            DomicilioGB.TabIndex = 8;
            DomicilioGB.TabStop = false;
            DomicilioGB.Text = "Domicilio";
            // 
            // DepartamentoLbl
            // 
            DepartamentoLbl.AutoSize = true;
            DepartamentoLbl.Location = new Point(23, 145);
            DepartamentoLbl.Name = "DepartamentoLbl";
            DepartamentoLbl.Size = new Size(85, 15);
            DepartamentoLbl.TabIndex = 16;
            DepartamentoLbl.Text = "Departamento";
            // 
            // DepartamentoTxt
            // 
            _DepartamentoTxt.Location = new Point(114, 142);
            _DepartamentoTxt.Name = "_DepartamentoTxt";
            _DepartamentoTxt.Size = new Size(58, 23);
            _DepartamentoTxt.TabIndex = 14;
            // 
            // AgregarLocBtn
            // 
            _AgregarLocBtn.Location = new Point(200, 19);
            _AgregarLocBtn.Name = "_AgregarLocBtn";
            _AgregarLocBtn.Size = new Size(29, 23);
            _AgregarLocBtn.TabIndex = 10;
            _AgregarLocBtn.Text = "+";
            _AgregarLocBtn.UseVisualStyleBackColor = true;
            // 
            // CalleLbl
            // 
            CalleLbl.AutoSize = true;
            CalleLbl.Location = new Point(22, 58);
            CalleLbl.Name = "CalleLbl";
            CalleLbl.Size = new Size(35, 15);
            CalleLbl.TabIndex = 3;
            CalleLbl.Text = "Calle";
            // 
            // NumeroLbl
            // 
            NumeroLbl.AutoSize = true;
            NumeroLbl.Location = new Point(22, 87);
            NumeroLbl.Name = "NumeroLbl";
            NumeroLbl.Size = new Size(50, 15);
            NumeroLbl.TabIndex = 4;
            NumeroLbl.Text = "Numero";
            // 
            // LocalidadCMB
            // 
            LocalidadCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            LocalidadCMB.FormattingEnabled = true;
            LocalidadCMB.Location = new Point(90, 19);
            LocalidadCMB.Name = "LocalidadCMB";
            LocalidadCMB.Size = new Size(100, 23);
            LocalidadCMB.TabIndex = 9;
            // 
            // PisoLbl
            // 
            PisoLbl.AutoSize = true;
            PisoLbl.Location = new Point(22, 116);
            PisoLbl.Name = "PisoLbl";
            PisoLbl.Size = new Size(31, 15);
            PisoLbl.TabIndex = 5;
            PisoLbl.Text = "Piso";
            // 
            // PisoTxt
            // 
            _PisoTxt.Location = new Point(80, 113);
            _PisoTxt.Name = "_PisoTxt";
            _PisoTxt.Size = new Size(58, 23);
            _PisoTxt.TabIndex = 13;
            // 
            // LocalidadLbl
            // 
            LocalidadLbl.AutoSize = true;
            LocalidadLbl.Location = new Point(23, 22);
            LocalidadLbl.Name = "LocalidadLbl";
            LocalidadLbl.Size = new Size(61, 15);
            LocalidadLbl.TabIndex = 13;
            LocalidadLbl.Text = "Localidad";
            // 
            // CalleTxt
            // 
            _CalleTxt.Location = new Point(80, 55);
            _CalleTxt.Name = "_CalleTxt";
            _CalleTxt.Size = new Size(110, 23);
            _CalleTxt.TabIndex = 11;
            // 
            // NumeroTxt
            // 
            _NumeroTxt.Location = new Point(80, 84);
            _NumeroTxt.Name = "_NumeroTxt";
            _NumeroTxt.Size = new Size(58, 23);
            _NumeroTxt.TabIndex = 12;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(55, 458);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 15;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(143, 458);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 16;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // ErrorP
            // 
            ErrorP.BlinkRate = 150;
            ErrorP.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorP.ContainerControl = this;
            ErrorP.Icon = (Icon)resources.GetObject("ErrorP.Icon");
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
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(281, 489);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(DomicilioGB);
            Controls.Add(DatosGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(287, 518);
            MinimumSize = new Size(287, 518);
            Name = "AltaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente - MercaderSG";
            DatosGB.ResumeLayout(false);
            DatosGB.PerformLayout();
            TelefonosGB.ResumeLayout(false);
            TelefonosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).EndInit();
            DomicilioGB.ResumeLayout(false);
            DomicilioGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(AltaCliente_Load);
            KeyDown += new KeyEventHandler(AltaCliente_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox DatosGB;
        private TextBox _RazonSocialTxt;

        internal TextBox RazonSocialTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RazonSocialTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RazonSocialTxt != null)
                {
                    _RazonSocialTxt.TextChanged -= RazonSocialTxt_TextChanged;
                    _RazonSocialTxt.KeyPress -= RazonSocialTxtCalleTxt_KeyPress;
                    _RazonSocialTxt.Validated -= RazonSocialTxt_Validated;
                }

                _RazonSocialTxt = value;
                if (_RazonSocialTxt != null)
                {
                    _RazonSocialTxt.TextChanged += RazonSocialTxt_TextChanged;
                    _RazonSocialTxt.KeyPress += RazonSocialTxtCalleTxt_KeyPress;
                    _RazonSocialTxt.Validated += RazonSocialTxt_Validated;
                }
            }
        }

        internal Label CuitLbl;
        internal Label RazonSocialLbl;
        internal GroupBox DomicilioGB;
        internal Label DepartamentoLbl;
        private TextBox _DepartamentoTxt;

        internal TextBox DepartamentoTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DepartamentoTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DepartamentoTxt != null)
                {
                    _DepartamentoTxt.TextChanged -= DepartamentoTxt_TextChanged;
                    _DepartamentoTxt.KeyPress -= DepartamentoTxt_KeyPress;
                    _DepartamentoTxt.Validated -= DepartamentoTxt_Validated;
                }

                _DepartamentoTxt = value;
                if (_DepartamentoTxt != null)
                {
                    _DepartamentoTxt.TextChanged += DepartamentoTxt_TextChanged;
                    _DepartamentoTxt.KeyPress += DepartamentoTxt_KeyPress;
                    _DepartamentoTxt.Validated += DepartamentoTxt_Validated;
                }
            }
        }

        private Button _AgregarLocBtn;

        internal Button AgregarLocBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AgregarLocBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AgregarLocBtn != null)
                {
                    _AgregarLocBtn.Click -= AgregarLocBtn_Click;
                }

                _AgregarLocBtn = value;
                if (_AgregarLocBtn != null)
                {
                    _AgregarLocBtn.Click += AgregarLocBtn_Click;
                }
            }
        }

        internal Label CalleLbl;
        internal Label NumeroLbl;
        internal ComboBox LocalidadCMB;
        internal Label PisoLbl;
        private TextBox _PisoTxt;

        internal TextBox PisoTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PisoTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PisoTxt != null)
                {
                    _PisoTxt.TextChanged -= PisoTxt_TextChanged;
                    _PisoTxt.KeyPress -= NumeroYPisoTxt_KeyPress;
                }

                _PisoTxt = value;
                if (_PisoTxt != null)
                {
                    _PisoTxt.TextChanged += PisoTxt_TextChanged;
                    _PisoTxt.KeyPress += NumeroYPisoTxt_KeyPress;
                }
            }
        }

        internal Label LocalidadLbl;
        private TextBox _CalleTxt;

        internal TextBox CalleTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CalleTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CalleTxt != null)
                {
                    _CalleTxt.TextChanged -= CalleTxt_TextChanged;
                    _CalleTxt.KeyPress -= RazonSocialTxtCalleTxt_KeyPress;
                    _CalleTxt.Validated -= CalleTxt_Validated;
                }

                _CalleTxt = value;
                if (_CalleTxt != null)
                {
                    _CalleTxt.TextChanged += CalleTxt_TextChanged;
                    _CalleTxt.KeyPress += RazonSocialTxtCalleTxt_KeyPress;
                    _CalleTxt.Validated += CalleTxt_Validated;
                }
            }
        }

        private TextBox _NumeroTxt;

        internal TextBox NumeroTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NumeroTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NumeroTxt != null)
                {
                    _NumeroTxt.TextChanged -= NumeroTxt_TextChanged;
                    _NumeroTxt.KeyPress -= NumeroYPisoTxt_KeyPress;
                }

                _NumeroTxt = value;
                if (_NumeroTxt != null)
                {
                    _NumeroTxt.TextChanged += NumeroTxt_TextChanged;
                    _NumeroTxt.KeyPress += NumeroYPisoTxt_KeyPress;
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

        internal GroupBox TelefonosGB;
        internal Label NumeroTelLbl;
        private TextBox _TelefonoTxt;

        internal TextBox TelefonoTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TelefonoTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TelefonoTxt != null)
                {
                    _TelefonoTxt.TextChanged -= TelefonoTxt_TextChanged;
                    _TelefonoTxt.KeyPress -= TelefonoTxt_KeyPress;
                }

                _TelefonoTxt = value;
                if (_TelefonoTxt != null)
                {
                    _TelefonoTxt.TextChanged += TelefonoTxt_TextChanged;
                    _TelefonoTxt.KeyPress += TelefonoTxt_KeyPress;
                }
            }
        }

        private Button _QuitarTelBtn;

        internal Button QuitarTelBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _QuitarTelBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_QuitarTelBtn != null)
                {
                    _QuitarTelBtn.Click -= QuitarTelBtn_Click;
                }

                _QuitarTelBtn = value;
                if (_QuitarTelBtn != null)
                {
                    _QuitarTelBtn.Click += QuitarTelBtn_Click;
                }
            }
        }

        private Button _AgregarTelBtn;

        internal Button AgregarTelBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AgregarTelBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AgregarTelBtn != null)
                {
                    _AgregarTelBtn.Click -= AgregarTelBtn_Click;
                }

                _AgregarTelBtn = value;
                if (_AgregarTelBtn != null)
                {
                    _AgregarTelBtn.Click += AgregarTelBtn_Click;
                }
            }
        }

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
                    _TelefonosDG.Click -= TelefonosDG_Click;
                }

                _TelefonosDG = value;
                if (_TelefonosDG != null)
                {
                    _TelefonosDG.Click += TelefonosDG_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn NumeroCAB;
        internal ErrorProvider ErrorP;
        private TextBox _CuitTxt;

        internal TextBox CuitTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CuitTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CuitTxt != null)
                {
                    _CuitTxt.TextChanged -= CuitTxt_TextChanged;
                    _CuitTxt.KeyPress -= CuitTxt_KeyPress;
                }

                _CuitTxt = value;
                if (_CuitTxt != null)
                {
                    _CuitTxt.TextChanged += CuitTxt_TextChanged;
                    _CuitTxt.KeyPress += CuitTxt_KeyPress;
                }
            }
        }

        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
    }
}