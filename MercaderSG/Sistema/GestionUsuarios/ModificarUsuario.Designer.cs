using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ModificarUsuario : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            UsuarioLbl = new Label();
            UsuarioTxt = new TextBox();
            DatosPersonalesGB = new GroupBox();
            FechaNacDTP = new DateTimePicker();
            FechaNacLbl = new Label();
            _ApellidoTxt = new TextBox();
            _ApellidoTxt.TextChanged += new EventHandler(ApellidoTxt_TextChanged);
            _ApellidoTxt.KeyPress += new KeyPressEventHandler(ApellidoyNombreTxt_KeyPress);
            _ApellidoTxt.Validated += new EventHandler(ApellidoTxt_Validated);
            TelefonosGB = new GroupBox();
            _TelefonosDG = new DataGridView();
            _TelefonosDG.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(TelefonosDG_EditingControlShowing);
            TelefonoCAB = new DataGridViewTextBoxColumn();
            UsuarioCAB = new DataGridViewTextBoxColumn();
            NumeroCAB = new DataGridViewTextBoxColumn();
            _NombreTxt = new TextBox();
            _NombreTxt.TextChanged += new EventHandler(NombreTxt_TextChanged);
            _NombreTxt.KeyPress += new KeyPressEventHandler(ApellidoyNombreTxt_KeyPress);
            _NombreTxt.Validated += new EventHandler(NombreTxt_Validated);
            ApellidoLbl = new Label();
            NombreLbl = new Label();
            IdiomaCMB = new ComboBox();
            IdiomaLbl = new Label();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            UsuarioGB = new GroupBox();
            CorreoElectronicoTxt = new TextBox();
            CorreoElectronicoLbl = new Label();
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            DatosPersonalesGB.SuspendLayout();
            TelefonosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).BeginInit();
            UsuarioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(13, 25);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(113, 15);
            UsuarioLbl.TabIndex = 0;
            UsuarioLbl.Text = "Nombre de Usuario";
            // 
            // UsuarioTxt
            // 
            UsuarioTxt.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            UsuarioTxt.Location = new Point(125, 22);
            UsuarioTxt.Name = "UsuarioTxt";
            UsuarioTxt.ReadOnly = true;
            UsuarioTxt.Size = new Size(116, 23);
            UsuarioTxt.TabIndex = 0;
            UsuarioTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // DatosPersonalesGB
            // 
            DatosPersonalesGB.Controls.Add(FechaNacDTP);
            DatosPersonalesGB.Controls.Add(FechaNacLbl);
            DatosPersonalesGB.Controls.Add(_ApellidoTxt);
            DatosPersonalesGB.Controls.Add(TelefonosGB);
            DatosPersonalesGB.Controls.Add(_NombreTxt);
            DatosPersonalesGB.Controls.Add(ApellidoLbl);
            DatosPersonalesGB.Controls.Add(NombreLbl);
            DatosPersonalesGB.Location = new Point(12, 136);
            DatosPersonalesGB.Name = "DatosPersonalesGB";
            DatosPersonalesGB.Size = new Size(263, 275);
            DatosPersonalesGB.TabIndex = 2;
            DatosPersonalesGB.TabStop = false;
            DatosPersonalesGB.Text = "Datos Personales";
            // 
            // FechaNacDTP
            // 
            FechaNacDTP.Format = DateTimePickerFormat.Short;
            FechaNacDTP.Location = new Point(140, 83);
            FechaNacDTP.Name = "FechaNacDTP";
            FechaNacDTP.Size = new Size(101, 23);
            FechaNacDTP.TabIndex = 5;
            FechaNacDTP.Value = new DateTime(2013, 7, 22, 0, 0, 0, 0);
            // 
            // FechaNacLbl
            // 
            FechaNacLbl.AutoSize = true;
            FechaNacLbl.Location = new Point(13, 89);
            FechaNacLbl.Name = "FechaNacLbl";
            FechaNacLbl.Size = new Size(121, 15);
            FechaNacLbl.TabIndex = 33;
            FechaNacLbl.Text = "Fecha de Nacimiento";
            // 
            // ApellidoTxt
            // 
            _ApellidoTxt.Location = new Point(86, 25);
            _ApellidoTxt.Name = "_ApellidoTxt";
            _ApellidoTxt.Size = new Size(155, 23);
            _ApellidoTxt.TabIndex = 3;
            // 
            // TelefonosGB
            // 
            TelefonosGB.Controls.Add(_TelefonosDG);
            TelefonosGB.Location = new Point(6, 122);
            TelefonosGB.Name = "TelefonosGB";
            TelefonosGB.Size = new Size(250, 145);
            TelefonosGB.TabIndex = 17;
            TelefonosGB.TabStop = false;
            TelefonosGB.Text = "Telefonos";
            // 
            // TelefonosDG
            // 
            _TelefonosDG.AllowUserToAddRows = false;
            _TelefonosDG.AllowUserToDeleteRows = false;
            _TelefonosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _TelefonosDG.Columns.AddRange(new DataGridViewColumn[] { TelefonoCAB, UsuarioCAB, NumeroCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            _TelefonosDG.DefaultCellStyle = DataGridViewCellStyle1;
            _TelefonosDG.Dock = DockStyle.Fill;
            _TelefonosDG.Location = new Point(3, 19);
            _TelefonosDG.Name = "_TelefonosDG";
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _TelefonosDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            _TelefonosDG.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _TelefonosDG.Size = new Size(244, 123);
            _TelefonosDG.TabIndex = 6;
            // 
            // TelefonoCAB
            // 
            TelefonoCAB.DataPropertyName = "CodTel";
            TelefonoCAB.HeaderText = "C.Teléfono";
            TelefonoCAB.Name = "TelefonoCAB";
            TelefonoCAB.Width = 75;
            // 
            // UsuarioCAB
            // 
            UsuarioCAB.DataPropertyName = "CodEn";
            UsuarioCAB.HeaderText = "C.Usuario";
            UsuarioCAB.Name = "UsuarioCAB";
            UsuarioCAB.Visible = false;
            // 
            // NumeroCAB
            // 
            NumeroCAB.DataPropertyName = "Numero";
            NumeroCAB.HeaderText = "Número";
            NumeroCAB.Name = "NumeroCAB";
            NumeroCAB.Width = 105;
            // 
            // NombreTxt
            // 
            _NombreTxt.Location = new Point(86, 54);
            _NombreTxt.Name = "_NombreTxt";
            _NombreTxt.Size = new Size(155, 23);
            _NombreTxt.TabIndex = 4;
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(13, 28);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(53, 15);
            ApellidoLbl.TabIndex = 28;
            ApellidoLbl.Text = "Apellido";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(13, 57);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(50, 15);
            NombreLbl.TabIndex = 29;
            NombreLbl.Text = "Nombre";
            // 
            // IdiomaCMB
            // 
            IdiomaCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            IdiomaCMB.FormattingEnabled = true;
            IdiomaCMB.Location = new Point(75, 81);
            IdiomaCMB.Name = "IdiomaCMB";
            IdiomaCMB.Size = new Size(59, 23);
            IdiomaCMB.TabIndex = 2;
            // 
            // IdiomaLbl
            // 
            IdiomaLbl.AutoSize = true;
            IdiomaLbl.Location = new Point(13, 84);
            IdiomaLbl.Name = "IdiomaLbl";
            IdiomaLbl.Size = new Size(46, 15);
            IdiomaLbl.TabIndex = 34;
            IdiomaLbl.Text = "Idioma";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(143, 417);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 8;
            _CancelarBtn.Text = "&Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(55, 417);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 7;
            _AceptarBtn.Text = "&Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // UsuarioGB
            // 
            UsuarioGB.Controls.Add(CorreoElectronicoTxt);
            UsuarioGB.Controls.Add(CorreoElectronicoLbl);
            UsuarioGB.Controls.Add(IdiomaCMB);
            UsuarioGB.Controls.Add(IdiomaLbl);
            UsuarioGB.Controls.Add(UsuarioTxt);
            UsuarioGB.Controls.Add(UsuarioLbl);
            UsuarioGB.Location = new Point(12, 12);
            UsuarioGB.Name = "UsuarioGB";
            UsuarioGB.Size = new Size(263, 118);
            UsuarioGB.TabIndex = 32;
            UsuarioGB.TabStop = false;
            UsuarioGB.Text = "Usuario";
            // 
            // CorreoElectronicoTxt
            // 
            CorreoElectronicoTxt.Location = new Point(125, 52);
            CorreoElectronicoTxt.Name = "CorreoElectronicoTxt";
            CorreoElectronicoTxt.Size = new Size(116, 23);
            CorreoElectronicoTxt.TabIndex = 1;
            // 
            // CorreoElectronicoLbl
            // 
            CorreoElectronicoLbl.AutoSize = true;
            CorreoElectronicoLbl.Location = new Point(13, 55);
            CorreoElectronicoLbl.Name = "CorreoElectronicoLbl";
            CorreoElectronicoLbl.Size = new Size(109, 15);
            CorreoElectronicoLbl.TabIndex = 37;
            CorreoElectronicoLbl.Text = "Correo Electronico";
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
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(287, 447);
            Controls.Add(UsuarioGB);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(DatosPersonalesGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(293, 476);
            MinimumSize = new Size(293, 476);
            Name = "ModificarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            DatosPersonalesGB.ResumeLayout(false);
            DatosPersonalesGB.PerformLayout();
            TelefonosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).EndInit();
            UsuarioGB.ResumeLayout(false);
            UsuarioGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(ModificarUsuario_Load);
            KeyDown += new KeyEventHandler(ModificarUsuario_KeyDown);
            ResumeLayout(false);
        }

        internal Label UsuarioLbl;
        internal TextBox UsuarioTxt;
        internal GroupBox DatosPersonalesGB;
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
                    _NombreTxt.KeyPress -= ApellidoyNombreTxt_KeyPress;
                    _NombreTxt.Validated -= NombreTxt_Validated;
                }

                _NombreTxt = value;
                if (_NombreTxt != null)
                {
                    _NombreTxt.TextChanged += NombreTxt_TextChanged;
                    _NombreTxt.KeyPress += ApellidoyNombreTxt_KeyPress;
                    _NombreTxt.Validated += NombreTxt_Validated;
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
                    _ApellidoTxt.TextChanged -= ApellidoTxt_TextChanged;
                    _ApellidoTxt.KeyPress -= ApellidoyNombreTxt_KeyPress;
                    _ApellidoTxt.Validated -= ApellidoTxt_Validated;
                }

                _ApellidoTxt = value;
                if (_ApellidoTxt != null)
                {
                    _ApellidoTxt.TextChanged += ApellidoTxt_TextChanged;
                    _ApellidoTxt.KeyPress += ApellidoyNombreTxt_KeyPress;
                    _ApellidoTxt.Validated += ApellidoTxt_Validated;
                }
            }
        }

        internal Label ApellidoLbl;
        internal Label NombreLbl;
        internal ComboBox IdiomaCMB;
        internal Label IdiomaLbl;
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
                    _TelefonosDG.EditingControlShowing -= TelefonosDG_EditingControlShowing;
                }

                _TelefonosDG = value;
                if (_TelefonosDG != null)
                {
                    _TelefonosDG.EditingControlShowing += TelefonosDG_EditingControlShowing;
                }
            }
        }

        internal GroupBox UsuarioGB;
        internal TextBox CorreoElectronicoTxt;
        internal Label CorreoElectronicoLbl;
        internal DataGridViewTextBoxColumn TelefonoCAB;
        internal DataGridViewTextBoxColumn UsuarioCAB;
        internal DataGridViewTextBoxColumn NumeroCAB;
        internal DateTimePicker FechaNacDTP;
        internal Label FechaNacLbl;
        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
        internal ErrorProvider ErrorP;
    }
}