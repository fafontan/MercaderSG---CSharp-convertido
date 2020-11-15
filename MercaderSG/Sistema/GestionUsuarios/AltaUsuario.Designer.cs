using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class AltaUsuario : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            DatosGB = new GroupBox();
            FechaNacDTP = new DateTimePicker();
            TelefonosGB = new GroupBox();
            NumeroLbl = new Label();
            _TelefonoTxt = new TextBox();
            _TelefonoTxt.KeyPress += new KeyPressEventHandler(TelefonoTxt_KeyPress);
            _TelefonoTxt.TextChanged += new EventHandler(TelefonoTxt_TextChanged);
            _QuitarTelBtn = new Button();
            _QuitarTelBtn.Click += new EventHandler(QuitarTelBtn_Click);
            _AgregarTelBtn = new Button();
            _AgregarTelBtn.Click += new EventHandler(AgregarTelBtn_Click);
            _TelefonosDG = new DataGridView();
            _TelefonosDG.Click += new EventHandler(TelefonosDG_Click);
            NumeroCAB = new DataGridViewTextBoxColumn();
            FechaNacLbl = new Label();
            _NombreTxt = new TextBox();
            _NombreTxt.Validated += new EventHandler(NombreTxt_Validated);
            _NombreTxt.KeyPress += new KeyPressEventHandler(ApellidoYNombre_KeyPress);
            _NombreTxt.TextChanged += new EventHandler(NombreTxt_TextChanged);
            _ApellidoTxt = new TextBox();
            _ApellidoTxt.Validated += new EventHandler(ApellidoTxt_Validated);
            _ApellidoTxt.KeyPress += new KeyPressEventHandler(ApellidoYNombre_KeyPress);
            _ApellidoTxt.TextChanged += new EventHandler(ApellidoTxt_TextChanged);
            ApellidoLbl = new Label();
            NombreLbl = new Label();
            UsuarioGB = new GroupBox();
            IdiomaCMB = new ComboBox();
            IdiomaLbl = new Label();
            _CorreoElectronicoTxt = new TextBox();
            _CorreoElectronicoTxt.TextChanged += new EventHandler(ContraseñaTxt_TextChanged);
            _UsuarioTxt = new TextBox();
            _UsuarioTxt.KeyPress += new KeyPressEventHandler(UsuarioTxt_KeyPress);
            _UsuarioTxt.TextChanged += new EventHandler(UsuarioTxt_TextChanged);
            _UsuarioTxt.Validated += new EventHandler(UsuarioTxt_Validated);
            UsuarioLbl = new Label();
            CorreoElectronicoLbl = new Label();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            DatosGB.SuspendLayout();
            TelefonosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).BeginInit();
            UsuarioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // DatosGB
            // 
            DatosGB.Controls.Add(FechaNacDTP);
            DatosGB.Controls.Add(TelefonosGB);
            DatosGB.Controls.Add(FechaNacLbl);
            DatosGB.Controls.Add(_NombreTxt);
            DatosGB.Controls.Add(_ApellidoTxt);
            DatosGB.Controls.Add(ApellidoLbl);
            DatosGB.Controls.Add(NombreLbl);
            DatosGB.Location = new Point(13, 135);
            DatosGB.Name = "DatosGB";
            DatosGB.Size = new Size(274, 289);
            DatosGB.TabIndex = 6;
            DatosGB.TabStop = false;
            DatosGB.Text = "Datos Personales";
            // 
            // FechaNacDTP
            // 
            FechaNacDTP.Format = DateTimePickerFormat.Short;
            FechaNacDTP.Location = new Point(161, 87);
            FechaNacDTP.Name = "FechaNacDTP";
            FechaNacDTP.Size = new Size(92, 23);
            FechaNacDTP.TabIndex = 5;
            FechaNacDTP.Value = new DateTime(2013, 7, 22, 0, 0, 0, 0);
            // 
            // TelefonosGB
            // 
            TelefonosGB.Controls.Add(NumeroLbl);
            TelefonosGB.Controls.Add(_TelefonoTxt);
            TelefonosGB.Controls.Add(_QuitarTelBtn);
            TelefonosGB.Controls.Add(_AgregarTelBtn);
            TelefonosGB.Controls.Add(_TelefonosDG);
            TelefonosGB.Location = new Point(18, 116);
            TelefonosGB.Name = "TelefonosGB";
            TelefonosGB.Size = new Size(233, 161);
            TelefonosGB.TabIndex = 26;
            TelefonosGB.TabStop = false;
            TelefonosGB.Text = "Telefonos";
            // 
            // NumeroLbl
            // 
            NumeroLbl.AutoSize = true;
            NumeroLbl.Location = new Point(12, 23);
            NumeroLbl.Name = "NumeroLbl";
            NumeroLbl.Size = new Size(50, 15);
            NumeroLbl.TabIndex = 5;
            NumeroLbl.Text = "Numero";
            // 
            // TelefonoTxt
            // 
            _TelefonoTxt.Location = new Point(68, 20);
            _TelefonoTxt.Name = "_TelefonoTxt";
            _TelefonoTxt.Size = new Size(107, 23);
            _TelefonoTxt.TabIndex = 6;
            // 
            // QuitarTelBtn
            // 
            _QuitarTelBtn.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _QuitarTelBtn.Location = new Point(196, 52);
            _QuitarTelBtn.Name = "_QuitarTelBtn";
            _QuitarTelBtn.Size = new Size(29, 23);
            _QuitarTelBtn.TabIndex = 8;
            _QuitarTelBtn.Text = "-";
            _QuitarTelBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarTelBtn
            // 
            _AgregarTelBtn.Location = new Point(196, 20);
            _AgregarTelBtn.Name = "_AgregarTelBtn";
            _AgregarTelBtn.Size = new Size(29, 23);
            _AgregarTelBtn.TabIndex = 7;
            _AgregarTelBtn.Text = "+";
            _AgregarTelBtn.UseVisualStyleBackColor = true;
            // 
            // TelefonosDG
            // 
            _TelefonosDG.AllowUserToAddRows = false;
            _TelefonosDG.AllowUserToDeleteRows = false;
            _TelefonosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _TelefonosDG.Columns.AddRange(new DataGridViewColumn[] { NumeroCAB });
            _TelefonosDG.Location = new Point(14, 52);
            _TelefonosDG.Name = "_TelefonosDG";
            _TelefonosDG.Size = new Size(176, 104);
            _TelefonosDG.StandardTab = true;
            _TelefonosDG.TabIndex = 9;
            // 
            // NumeroCAB
            // 
            NumeroCAB.HeaderText = "Número";
            NumeroCAB.Name = "NumeroCAB";
            // 
            // FechaNacLbl
            // 
            FechaNacLbl.AutoSize = true;
            FechaNacLbl.Location = new Point(15, 93);
            FechaNacLbl.Name = "FechaNacLbl";
            FechaNacLbl.Size = new Size(121, 15);
            FechaNacLbl.TabIndex = 23;
            FechaNacLbl.Text = "Fecha de Nacimiento";
            // 
            // NombreTxt
            // 
            _NombreTxt.Location = new Point(97, 58);
            _NombreTxt.Name = "_NombreTxt";
            _NombreTxt.Size = new Size(156, 23);
            _NombreTxt.TabIndex = 4;
            // 
            // ApellidoTxt
            // 
            _ApellidoTxt.Location = new Point(96, 29);
            _ApellidoTxt.Name = "_ApellidoTxt";
            _ApellidoTxt.Size = new Size(157, 23);
            _ApellidoTxt.TabIndex = 3;
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(15, 29);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(53, 15);
            ApellidoLbl.TabIndex = 1;
            ApellidoLbl.Text = "Apellido";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(15, 61);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(50, 15);
            NombreLbl.TabIndex = 2;
            NombreLbl.Text = "Nombre";
            // 
            // UsuarioGB
            // 
            UsuarioGB.Controls.Add(IdiomaCMB);
            UsuarioGB.Controls.Add(IdiomaLbl);
            UsuarioGB.Controls.Add(_CorreoElectronicoTxt);
            UsuarioGB.Controls.Add(_UsuarioTxt);
            UsuarioGB.Controls.Add(UsuarioLbl);
            UsuarioGB.Controls.Add(CorreoElectronicoLbl);
            UsuarioGB.Location = new Point(13, 11);
            UsuarioGB.Name = "UsuarioGB";
            UsuarioGB.Size = new Size(274, 118);
            UsuarioGB.TabIndex = 1;
            UsuarioGB.TabStop = false;
            UsuarioGB.Text = "Usuario";
            // 
            // IdiomaCMB
            // 
            IdiomaCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            IdiomaCMB.FormattingEnabled = true;
            IdiomaCMB.Location = new Point(86, 82);
            IdiomaCMB.Name = "IdiomaCMB";
            IdiomaCMB.Size = new Size(59, 23);
            IdiomaCMB.TabIndex = 2;
            // 
            // IdiomaLbl
            // 
            IdiomaLbl.AutoSize = true;
            IdiomaLbl.Location = new Point(21, 85);
            IdiomaLbl.Name = "IdiomaLbl";
            IdiomaLbl.Size = new Size(46, 15);
            IdiomaLbl.TabIndex = 11;
            IdiomaLbl.Text = "Idioma";
            // 
            // CorreoElectronicoTxt
            // 
            _CorreoElectronicoTxt.Location = new Point(142, 50);
            _CorreoElectronicoTxt.Name = "_CorreoElectronicoTxt";
            _CorreoElectronicoTxt.Size = new Size(111, 23);
            _CorreoElectronicoTxt.TabIndex = 1;
            // 
            // UsuarioTxt
            // 
            _UsuarioTxt.Location = new Point(142, 21);
            _UsuarioTxt.Name = "_UsuarioTxt";
            _UsuarioTxt.Size = new Size(111, 23);
            _UsuarioTxt.TabIndex = 0;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(18, 25);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(112, 15);
            UsuarioLbl.TabIndex = 0;
            UsuarioLbl.Text = "Nombre de usuario";
            // 
            // CorreoElectronicoLbl
            // 
            CorreoElectronicoLbl.AutoSize = true;
            CorreoElectronicoLbl.Location = new Point(18, 53);
            CorreoElectronicoLbl.Name = "CorreoElectronicoLbl";
            CorreoElectronicoLbl.Size = new Size(109, 15);
            CorreoElectronicoLbl.TabIndex = 6;
            CorreoElectronicoLbl.Text = "Correo Electronico";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(153, 433);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 11;
            _CancelarBtn.Text = "&Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(65, 433);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 10;
            _AceptarBtn.Text = "&Aceptar";
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
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.AutoPopDelay = 5000;
            MensajeTT.InitialDelay = 1000;
            MensajeTT.ReshowDelay = 500;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // ErrorP
            // 
            ErrorP.BlinkRate = 150;
            ErrorP.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorP.ContainerControl = this;
            ErrorP.Icon = (Icon)resources.GetObject("ErrorP.Icon");
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(300, 467);
            Controls.Add(_CancelarBtn);
            Controls.Add(DatosGB);
            Controls.Add(UsuarioGB);
            Controls.Add(_AceptarBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(306, 496);
            MinimumSize = new Size(306, 496);
            Name = "AltaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            DatosGB.ResumeLayout(false);
            DatosGB.PerformLayout();
            TelefonosGB.ResumeLayout(false);
            TelefonosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).EndInit();
            UsuarioGB.ResumeLayout(false);
            UsuarioGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(AltaUsuario_Load);
            KeyDown += new KeyEventHandler(AltaUsuario_KeyDown);
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
                    _AceptarBtn.Click -= AceptarBtn_Click;
                }

                _AceptarBtn = value;
                if (_AceptarBtn != null)
                {
                    _AceptarBtn.Click += AceptarBtn_Click;
                }
            }
        }

        internal GroupBox DatosGB;
        internal GroupBox TelefonosGB;
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

        internal Label FechaNacLbl;
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
                    _NombreTxt.Validated -= NombreTxt_Validated;
                    _NombreTxt.KeyPress -= ApellidoYNombre_KeyPress;
                    _NombreTxt.TextChanged -= NombreTxt_TextChanged;
                }

                _NombreTxt = value;
                if (_NombreTxt != null)
                {
                    _NombreTxt.Validated += NombreTxt_Validated;
                    _NombreTxt.KeyPress += ApellidoYNombre_KeyPress;
                    _NombreTxt.TextChanged += NombreTxt_TextChanged;
                }
            }
        }

        private TextBox _ApellidoTxt;

        internal TextBox ApellidoTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ApellidoTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ApellidoTxt != null)
                {
                    _ApellidoTxt.Validated -= ApellidoTxt_Validated;
                    _ApellidoTxt.KeyPress -= ApellidoYNombre_KeyPress;
                    _ApellidoTxt.TextChanged -= ApellidoTxt_TextChanged;
                }

                _ApellidoTxt = value;
                if (_ApellidoTxt != null)
                {
                    _ApellidoTxt.Validated += ApellidoTxt_Validated;
                    _ApellidoTxt.KeyPress += ApellidoYNombre_KeyPress;
                    _ApellidoTxt.TextChanged += ApellidoTxt_TextChanged;
                }
            }
        }

        internal Label ApellidoLbl;
        internal Label NombreLbl;
        internal GroupBox UsuarioGB;
        internal ComboBox IdiomaCMB;
        internal Label IdiomaLbl;
        private TextBox _CorreoElectronicoTxt;

        internal TextBox CorreoElectronicoTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CorreoElectronicoTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CorreoElectronicoTxt != null)
                {
                    _CorreoElectronicoTxt.TextChanged -= ContraseñaTxt_TextChanged;
                }

                _CorreoElectronicoTxt = value;
                if (_CorreoElectronicoTxt != null)
                {
                    _CorreoElectronicoTxt.TextChanged += ContraseñaTxt_TextChanged;
                }
            }
        }

        private TextBox _UsuarioTxt;

        internal TextBox UsuarioTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UsuarioTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UsuarioTxt != null)
                {
                    _UsuarioTxt.KeyPress -= UsuarioTxt_KeyPress;
                    _UsuarioTxt.TextChanged -= UsuarioTxt_TextChanged;
                    _UsuarioTxt.Validated -= UsuarioTxt_Validated;
                }

                _UsuarioTxt = value;
                if (_UsuarioTxt != null)
                {
                    _UsuarioTxt.KeyPress += UsuarioTxt_KeyPress;
                    _UsuarioTxt.TextChanged += UsuarioTxt_TextChanged;
                    _UsuarioTxt.Validated += UsuarioTxt_Validated;
                }
            }
        }

        internal Label UsuarioLbl;
        internal Label CorreoElectronicoLbl;
        internal DateTimePicker FechaNacDTP;
        internal Label NumeroLbl;
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
                    _TelefonoTxt.KeyPress -= TelefonoTxt_KeyPress;
                    _TelefonoTxt.TextChanged -= TelefonoTxt_TextChanged;
                }

                _TelefonoTxt = value;
                if (_TelefonoTxt != null)
                {
                    _TelefonoTxt.KeyPress += TelefonoTxt_KeyPress;
                    _TelefonoTxt.TextChanged += TelefonoTxt_TextChanged;
                }
            }
        }

        internal DataGridViewTextBoxColumn NumeroCAB;
        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
        internal ErrorProvider ErrorP;
    }
}