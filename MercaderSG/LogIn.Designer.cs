using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class LogIn : Form
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
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            UsuarioLbl = new Label();
            ContraseñaLbl = new Label();
            _UsuarioTxt = new TextBox();
            _UsuarioTxt.Validated += new EventHandler(UsuarioTxt_Validated);
            _UsuarioTxt.TextChanged += new EventHandler(UsuarioTxt_TextChanged);
            _UsuarioTxt.KeyPress += new KeyPressEventHandler(UsuarioTxt_KeyPress);
            _ContraseñaTxt = new TextBox();
            _ContraseñaTxt.KeyPress += new KeyPressEventHandler(ContraseñaTxt_KeyPress);
            _ContraseñaTxt.TextChanged += new EventHandler(ContraseñaTxt_TextChanged);
            LoginPB = new PictureBox();
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            ((System.ComponentModel.ISupportInitialize)LoginPB).BeginInit();
            SuspendLayout();
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(171, 102);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 2;
            _AceptarBtn.Text = "&Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(88, 32);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(51, 15);
            UsuarioLbl.TabIndex = 2;
            UsuarioLbl.Text = "Usuario";
            // 
            // ContraseñaLbl
            // 
            ContraseñaLbl.AutoSize = true;
            ContraseñaLbl.Location = new Point(88, 65);
            ContraseñaLbl.Name = "ContraseñaLbl";
            ContraseñaLbl.Size = new Size(70, 15);
            ContraseñaLbl.TabIndex = 3;
            ContraseñaLbl.Text = "Contraseña";
            // 
            // UsuarioTxt
            // 
            _UsuarioTxt.Location = new Point(171, 29);
            _UsuarioTxt.Name = "_UsuarioTxt";
            _UsuarioTxt.Size = new Size(168, 23);
            _UsuarioTxt.TabIndex = 0;
            // 
            // ContraseñaTxt
            // 
            _ContraseñaTxt.Location = new Point(171, 63);
            _ContraseñaTxt.Name = "_ContraseñaTxt";
            _ContraseñaTxt.PasswordChar = '*';
            _ContraseñaTxt.Size = new Size(168, 23);
            _ContraseñaTxt.TabIndex = 1;
            // 
            // LoginPB
            // 
            LoginPB.BackgroundImageLayout = ImageLayout.Stretch;
            LoginPB.Image = My.Resources.Resources.LogInE;
            LoginPB.Location = new Point(18, 22);
            LoginPB.Name = "LoginPB";
            LoginPB.Size = new Size(64, 64);
            LoginPB.TabIndex = 6;
            LoginPB.TabStop = false;
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
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(257, 102);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 7;
            _CancelarBtn.Text = "&Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(359, 142);
            Controls.Add(_CancelarBtn);
            Controls.Add(LoginPB);
            Controls.Add(UsuarioLbl);
            Controls.Add(_UsuarioTxt);
            Controls.Add(_ContraseñaTxt);
            Controls.Add(ContraseñaLbl);
            Controls.Add(_AceptarBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(365, 171);
            MinimumSize = new Size(365, 171);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión - MercaderSG";
            ((System.ComponentModel.ISupportInitialize)LoginPB).EndInit();
            Load += new EventHandler(LogIn_Load);
            KeyDown += new KeyEventHandler(LogIn_KeyDown);
            FormClosing += new FormClosingEventHandler(LogIn_FormClosing);
            ResumeLayout(false);
            PerformLayout();
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

        internal Label UsuarioLbl;
        internal Label ContraseñaLbl;
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
                    _UsuarioTxt.Validated -= UsuarioTxt_Validated;
                    _UsuarioTxt.TextChanged -= UsuarioTxt_TextChanged;
                    _UsuarioTxt.KeyPress -= UsuarioTxt_KeyPress;
                }

                _UsuarioTxt = value;
                if (_UsuarioTxt != null)
                {
                    _UsuarioTxt.Validated += UsuarioTxt_Validated;
                    _UsuarioTxt.TextChanged += UsuarioTxt_TextChanged;
                    _UsuarioTxt.KeyPress += UsuarioTxt_KeyPress;
                }
            }
        }

        private TextBox _ContraseñaTxt;

        internal TextBox ContraseñaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContraseñaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContraseñaTxt != null)
                {
                    _ContraseñaTxt.KeyPress -= ContraseñaTxt_KeyPress;
                    _ContraseñaTxt.TextChanged -= ContraseñaTxt_TextChanged;
                }

                _ContraseñaTxt = value;
                if (_ContraseñaTxt != null)
                {
                    _ContraseñaTxt.KeyPress += ContraseñaTxt_KeyPress;
                    _ContraseñaTxt.TextChanged += ContraseñaTxt_TextChanged;
                }
            }
        }

        internal PictureBox LoginPB;
        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
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
    }
}