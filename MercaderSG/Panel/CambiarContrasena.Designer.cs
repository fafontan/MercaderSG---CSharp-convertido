using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class CambiarContrasena : Form
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
            ConAnteriorLbl = new Label();
            _ConAnteriorTxt = new TextBox();
            _ConAnteriorTxt.KeyPress += new KeyPressEventHandler(ContraseñasTxts_KeyPress);
            _ConAnteriorTxt.TextChanged += new EventHandler(ConAnteriorTxt_TextChanged);
            NuevaContraseñaLbl = new Label();
            ReNuevaContraseñaLbl = new Label();
            _NuevaContraseñaTxt = new TextBox();
            _NuevaContraseñaTxt.KeyPress += new KeyPressEventHandler(ContraseñasTxts_KeyPress);
            _NuevaContraseñaTxt.TextChanged += new EventHandler(NuevaContraseñaTxt_TextChanged);
            _ReNuevaContraseñaTxt = new TextBox();
            _ReNuevaContraseñaTxt.KeyPress += new KeyPressEventHandler(ContraseñasTxts_KeyPress);
            _ReNuevaContraseñaTxt.TextChanged += new EventHandler(ReNuevaContraseñaTxt_TextChanged);
            ContrasenaGB = new GroupBox();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            ContrasenaGB.SuspendLayout();
            SuspendLayout();
            // 
            // ConAnteriorLbl
            // 
            ConAnteriorLbl.AutoSize = true;
            ConAnteriorLbl.Location = new Point(18, 29);
            ConAnteriorLbl.Name = "ConAnteriorLbl";
            ConAnteriorLbl.Size = new Size(118, 15);
            ConAnteriorLbl.TabIndex = 0;
            ConAnteriorLbl.Text = "Contraseña Anterior";
            // 
            // ConAnteriorTxt
            // 
            _ConAnteriorTxt.Location = new Point(194, 26);
            _ConAnteriorTxt.Name = "_ConAnteriorTxt";
            _ConAnteriorTxt.PasswordChar = '*';
            _ConAnteriorTxt.Size = new Size(169, 23);
            _ConAnteriorTxt.TabIndex = 1;
            // 
            // NuevaContraseñaLbl
            // 
            NuevaContraseñaLbl.AutoSize = true;
            NuevaContraseñaLbl.Location = new Point(18, 58);
            NuevaContraseñaLbl.Name = "NuevaContraseñaLbl";
            NuevaContraseñaLbl.Size = new Size(107, 15);
            NuevaContraseñaLbl.TabIndex = 3;
            NuevaContraseñaLbl.Text = "Nueva Contraseña";
            // 
            // ReNuevaContraseñaLbl
            // 
            ReNuevaContraseñaLbl.AutoSize = true;
            ReNuevaContraseñaLbl.Location = new Point(18, 87);
            ReNuevaContraseñaLbl.Name = "ReNuevaContraseñaLbl";
            ReNuevaContraseñaLbl.Size = new Size(171, 15);
            ReNuevaContraseñaLbl.TabIndex = 4;
            ReNuevaContraseñaLbl.Text = "Re-Ingresar nueva contraseña";
            // 
            // NuevaContraseñaTxt
            // 
            _NuevaContraseñaTxt.Location = new Point(194, 55);
            _NuevaContraseñaTxt.Name = "_NuevaContraseñaTxt";
            _NuevaContraseñaTxt.PasswordChar = '*';
            _NuevaContraseñaTxt.Size = new Size(169, 23);
            _NuevaContraseñaTxt.TabIndex = 2;
            // 
            // ReNuevaContraseñaTxt
            // 
            _ReNuevaContraseñaTxt.Location = new Point(194, 84);
            _ReNuevaContraseñaTxt.Name = "_ReNuevaContraseñaTxt";
            _ReNuevaContraseñaTxt.PasswordChar = '*';
            _ReNuevaContraseñaTxt.Size = new Size(169, 23);
            _ReNuevaContraseñaTxt.TabIndex = 3;
            // 
            // ContrasenaGB
            // 
            ContrasenaGB.Controls.Add(ConAnteriorLbl);
            ContrasenaGB.Controls.Add(_ReNuevaContraseñaTxt);
            ContrasenaGB.Controls.Add(_ConAnteriorTxt);
            ContrasenaGB.Controls.Add(_NuevaContraseñaTxt);
            ContrasenaGB.Controls.Add(NuevaContraseñaLbl);
            ContrasenaGB.Controls.Add(ReNuevaContraseñaLbl);
            ContrasenaGB.Location = new Point(12, 12);
            ContrasenaGB.Name = "ContrasenaGB";
            ContrasenaGB.Size = new Size(381, 124);
            ContrasenaGB.TabIndex = 0;
            ContrasenaGB.TabStop = false;
            ContrasenaGB.Text = "Cambiar Contraseña";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(206, 145);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 5;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(118, 145);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 4;
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
            // CambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(406, 178);
            Controls.Add(_CancelarBtn);
            Controls.Add(ContrasenaGB);
            Controls.Add(_AceptarBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(412, 207);
            MinimumSize = new Size(412, 207);
            Name = "CambiarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña - MercaderSG";
            ContrasenaGB.ResumeLayout(false);
            ContrasenaGB.PerformLayout();
            Load += new EventHandler(CambiarContrasena_Load);
            FormClosing += new FormClosingEventHandler(CambiarContrasena_FormClosing);
            KeyDown += new KeyEventHandler(CambiarContrasena_KeyDown);
            ResumeLayout(false);
        }

        internal Label ConAnteriorLbl;
        private TextBox _ConAnteriorTxt;

        internal TextBox ConAnteriorTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ConAnteriorTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ConAnteriorTxt != null)
                {
                    _ConAnteriorTxt.KeyPress -= ContraseñasTxts_KeyPress;
                    _ConAnteriorTxt.TextChanged -= ConAnteriorTxt_TextChanged;
                }

                _ConAnteriorTxt = value;
                if (_ConAnteriorTxt != null)
                {
                    _ConAnteriorTxt.KeyPress += ContraseñasTxts_KeyPress;
                    _ConAnteriorTxt.TextChanged += ConAnteriorTxt_TextChanged;
                }
            }
        }

        internal Label NuevaContraseñaLbl;
        internal Label ReNuevaContraseñaLbl;
        private TextBox _NuevaContraseñaTxt;

        internal TextBox NuevaContraseñaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NuevaContraseñaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NuevaContraseñaTxt != null)
                {
                    _NuevaContraseñaTxt.KeyPress -= ContraseñasTxts_KeyPress;
                    _NuevaContraseñaTxt.TextChanged -= NuevaContraseñaTxt_TextChanged;
                }

                _NuevaContraseñaTxt = value;
                if (_NuevaContraseñaTxt != null)
                {
                    _NuevaContraseñaTxt.KeyPress += ContraseñasTxts_KeyPress;
                    _NuevaContraseñaTxt.TextChanged += NuevaContraseñaTxt_TextChanged;
                }
            }
        }

        private TextBox _ReNuevaContraseñaTxt;

        internal TextBox ReNuevaContraseñaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ReNuevaContraseñaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ReNuevaContraseñaTxt != null)
                {
                    _ReNuevaContraseñaTxt.KeyPress -= ContraseñasTxts_KeyPress;
                    _ReNuevaContraseñaTxt.TextChanged -= ReNuevaContraseñaTxt_TextChanged;
                }

                _ReNuevaContraseñaTxt = value;
                if (_ReNuevaContraseñaTxt != null)
                {
                    _ReNuevaContraseñaTxt.KeyPress += ContraseñasTxts_KeyPress;
                    _ReNuevaContraseñaTxt.TextChanged += ReNuevaContraseñaTxt_TextChanged;
                }
            }
        }

        internal GroupBox ContrasenaGB;
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

        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
    }
}