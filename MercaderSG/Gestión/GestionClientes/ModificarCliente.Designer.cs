﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ModificarCliente : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCliente));
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
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
            _CalleTxt.KeyPress += new KeyPressEventHandler(RazonSocialCalleTxt_KeyPress);
            _CalleTxt.Validated += new EventHandler(CalleTxt_Validated);
            _NumeroTxt = new TextBox();
            _NumeroTxt.TextChanged += new EventHandler(NumeroTxt_TextChanged);
            _NumeroTxt.KeyPress += new KeyPressEventHandler(NumeroYPisoTxt_KeyPress);
            DatosGB = new GroupBox();
            _CuitTxt = new TextBox();
            _CuitTxt.TextChanged += new EventHandler(CuitTxt_TextChanged);
            _CuitTxt.KeyPress += new KeyPressEventHandler(CuitTxt_KeyPress);
            _RazonSocialTxt = new TextBox();
            _RazonSocialTxt.TextChanged += new EventHandler(RazonSocialTxt_TextChanged);
            _RazonSocialTxt.KeyPress += new KeyPressEventHandler(RazonSocialCalleTxt_KeyPress);
            _RazonSocialTxt.Validated += new EventHandler(RazonSocialTxt_Validated);
            RazonSocialLbl = new Label();
            CuitLbl = new Label();
            TelefonosGB = new GroupBox();
            _TelefonosDG = new DataGridView();
            _TelefonosDG.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(TelefonosDG_EditingControlShowing);
            TelefonoCAB = new DataGridViewTextBoxColumn();
            ClienteCAB = new DataGridViewTextBoxColumn();
            NumeroCAB = new DataGridViewTextBoxColumn();
            ErrorP = new ErrorProvider(components);
            ControlesTP = new ToolTip(components);
            DomicilioGB.SuspendLayout();
            DatosGB.SuspendLayout();
            TelefonosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(142, 469);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 13;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(54, 469);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 12;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
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
            DomicilioGB.Location = new Point(12, 107);
            DomicilioGB.Name = "DomicilioGB";
            DomicilioGB.Size = new Size(255, 180);
            DomicilioGB.TabIndex = 3;
            DomicilioGB.TabStop = false;
            DomicilioGB.Text = "Domicilio";
            // 
            // DepartamentoLbl
            // 
            DepartamentoLbl.AutoSize = true;
            DepartamentoLbl.Location = new Point(12, 147);
            DepartamentoLbl.Name = "DepartamentoLbl";
            DepartamentoLbl.Size = new Size(85, 15);
            DepartamentoLbl.TabIndex = 16;
            DepartamentoLbl.Text = "Departamento";
            // 
            // DepartamentoTxt
            // 
            _DepartamentoTxt.Location = new Point(103, 144);
            _DepartamentoTxt.Name = "_DepartamentoTxt";
            _DepartamentoTxt.Size = new Size(58, 23);
            _DepartamentoTxt.TabIndex = 9;
            // 
            // AgregarLocBtn
            // 
            _AgregarLocBtn.Location = new Point(197, 23);
            _AgregarLocBtn.Name = "_AgregarLocBtn";
            _AgregarLocBtn.Size = new Size(29, 23);
            _AgregarLocBtn.TabIndex = 5;
            _AgregarLocBtn.Text = "+";
            _AgregarLocBtn.UseVisualStyleBackColor = true;
            // 
            // CalleLbl
            // 
            CalleLbl.AutoSize = true;
            CalleLbl.Location = new Point(13, 60);
            CalleLbl.Name = "CalleLbl";
            CalleLbl.Size = new Size(35, 15);
            CalleLbl.TabIndex = 3;
            CalleLbl.Text = "Calle";
            // 
            // NumeroLbl
            // 
            NumeroLbl.AutoSize = true;
            NumeroLbl.Location = new Point(12, 90);
            NumeroLbl.Name = "NumeroLbl";
            NumeroLbl.Size = new Size(50, 15);
            NumeroLbl.TabIndex = 4;
            NumeroLbl.Text = "Numero";
            // 
            // LocalidadCMB
            // 
            LocalidadCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            LocalidadCMB.FormattingEnabled = true;
            LocalidadCMB.Location = new Point(80, 23);
            LocalidadCMB.Name = "LocalidadCMB";
            LocalidadCMB.Size = new Size(100, 23);
            LocalidadCMB.TabIndex = 4;
            // 
            // PisoLbl
            // 
            PisoLbl.AutoSize = true;
            PisoLbl.Location = new Point(12, 118);
            PisoLbl.Name = "PisoLbl";
            PisoLbl.Size = new Size(31, 15);
            PisoLbl.TabIndex = 5;
            PisoLbl.Text = "Piso";
            // 
            // PisoTxt
            // 
            _PisoTxt.Location = new Point(70, 115);
            _PisoTxt.Name = "_PisoTxt";
            _PisoTxt.Size = new Size(58, 23);
            _PisoTxt.TabIndex = 8;
            // 
            // LocalidadLbl
            // 
            LocalidadLbl.AutoSize = true;
            LocalidadLbl.Location = new Point(13, 26);
            LocalidadLbl.Name = "LocalidadLbl";
            LocalidadLbl.Size = new Size(61, 15);
            LocalidadLbl.TabIndex = 13;
            LocalidadLbl.Text = "Localidad";
            // 
            // CalleTxt
            // 
            _CalleTxt.Location = new Point(70, 57);
            _CalleTxt.Name = "_CalleTxt";
            _CalleTxt.Size = new Size(100, 23);
            _CalleTxt.TabIndex = 6;
            // 
            // NumeroTxt
            // 
            _NumeroTxt.Location = new Point(70, 86);
            _NumeroTxt.Name = "_NumeroTxt";
            _NumeroTxt.Size = new Size(58, 23);
            _NumeroTxt.TabIndex = 7;
            // 
            // DatosGB
            // 
            DatosGB.Controls.Add(_CuitTxt);
            DatosGB.Controls.Add(_RazonSocialTxt);
            DatosGB.Controls.Add(RazonSocialLbl);
            DatosGB.Controls.Add(CuitLbl);
            DatosGB.Location = new Point(12, 12);
            DatosGB.Name = "DatosGB";
            DatosGB.Size = new Size(255, 89);
            DatosGB.TabIndex = 0;
            DatosGB.TabStop = false;
            DatosGB.Text = "Datos de la Empresa";
            // 
            // CuitTxt
            // 
            _CuitTxt.Location = new Point(114, 51);
            _CuitTxt.Name = "_CuitTxt";
            _CuitTxt.ReadOnly = true;
            _CuitTxt.Size = new Size(121, 23);
            _CuitTxt.TabIndex = 2;
            // 
            // RazonSocialTxt
            // 
            _RazonSocialTxt.Location = new Point(114, 22);
            _RazonSocialTxt.Name = "_RazonSocialTxt";
            _RazonSocialTxt.Size = new Size(121, 23);
            _RazonSocialTxt.TabIndex = 1;
            // 
            // RazonSocialLbl
            // 
            RazonSocialLbl.AutoSize = true;
            RazonSocialLbl.Location = new Point(18, 25);
            RazonSocialLbl.Name = "RazonSocialLbl";
            RazonSocialLbl.Size = new Size(77, 15);
            RazonSocialLbl.TabIndex = 0;
            RazonSocialLbl.Text = "Razon Social";
            // 
            // CuitLbl
            // 
            CuitLbl.AutoSize = true;
            CuitLbl.Location = new Point(18, 54);
            CuitLbl.Name = "CuitLbl";
            CuitLbl.Size = new Size(32, 15);
            CuitLbl.TabIndex = 2;
            CuitLbl.Text = "CUIT";
            // 
            // TelefonosGB
            // 
            TelefonosGB.Controls.Add(_TelefonosDG);
            TelefonosGB.Location = new Point(12, 293);
            TelefonosGB.Name = "TelefonosGB";
            TelefonosGB.Size = new Size(255, 170);
            TelefonosGB.TabIndex = 10;
            TelefonosGB.TabStop = false;
            TelefonosGB.Text = "Telefonos";
            // 
            // TelefonosDG
            // 
            _TelefonosDG.AllowUserToAddRows = false;
            _TelefonosDG.AllowUserToDeleteRows = false;
            _TelefonosDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _TelefonosDG.Columns.AddRange(new DataGridViewColumn[] { TelefonoCAB, ClienteCAB, NumeroCAB });
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
            _TelefonosDG.Size = new Size(249, 148);
            _TelefonosDG.TabIndex = 11;
            // 
            // TelefonoCAB
            // 
            TelefonoCAB.DataPropertyName = "CodTel";
            TelefonoCAB.HeaderText = "C.Teléfono";
            TelefonoCAB.Name = "TelefonoCAB";
            TelefonoCAB.Width = 75;
            // 
            // ClienteCAB
            // 
            ClienteCAB.DataPropertyName = "CodEn";
            ClienteCAB.HeaderText = "C.Cliente";
            ClienteCAB.Name = "ClienteCAB";
            ClienteCAB.Visible = false;
            // 
            // NumeroCAB
            // 
            NumeroCAB.DataPropertyName = "Numero";
            NumeroCAB.HeaderText = "Número";
            NumeroCAB.Name = "NumeroCAB";
            NumeroCAB.Width = 117;
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
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(279, 503);
            Controls.Add(TelefonosGB);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(DomicilioGB);
            Controls.Add(DatosGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(285, 532);
            MinimumSize = new Size(285, 532);
            Name = "ModificarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Cliente - MercaderSG";
            DomicilioGB.ResumeLayout(false);
            DomicilioGB.PerformLayout();
            DatosGB.ResumeLayout(false);
            DatosGB.PerformLayout();
            TelefonosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TelefonosDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(ModificarCliente_Load);
            KeyDown += new KeyEventHandler(ModificarCliente_KeyDown);
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
                    _CalleTxt.KeyPress -= RazonSocialCalleTxt_KeyPress;
                    _CalleTxt.Validated -= CalleTxt_Validated;
                }

                _CalleTxt = value;
                if (_CalleTxt != null)
                {
                    _CalleTxt.TextChanged += CalleTxt_TextChanged;
                    _CalleTxt.KeyPress += RazonSocialCalleTxt_KeyPress;
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

        internal GroupBox DatosGB;
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

        internal GroupBox TelefonosGB;
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
                    _RazonSocialTxt.KeyPress -= RazonSocialCalleTxt_KeyPress;
                    _RazonSocialTxt.Validated -= RazonSocialTxt_Validated;
                }

                _RazonSocialTxt = value;
                if (_RazonSocialTxt != null)
                {
                    _RazonSocialTxt.TextChanged += RazonSocialTxt_TextChanged;
                    _RazonSocialTxt.KeyPress += RazonSocialCalleTxt_KeyPress;
                    _RazonSocialTxt.Validated += RazonSocialTxt_Validated;
                }
            }
        }

        internal Label CuitLbl;
        internal Label RazonSocialLbl;
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

        internal DataGridViewTextBoxColumn TelefonoCAB;
        internal DataGridViewTextBoxColumn ClienteCAB;
        internal DataGridViewTextBoxColumn NumeroCAB;
        internal ErrorProvider ErrorP;
        internal ToolTip ControlesTP;
    }
}