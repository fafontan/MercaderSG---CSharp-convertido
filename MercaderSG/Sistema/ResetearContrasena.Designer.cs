using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ResetearContrasena : Form
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
            UsuarioGB = new GroupBox();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            UsuarioCMB = new ComboBox();
            DesbloquearPB = new PictureBox();
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            UsuarioLbl = new Label();
            ControlesTP = new ToolTip(components);
            UsuarioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DesbloquearPB).BeginInit();
            SuspendLayout();
            // 
            // UsuarioGB
            // 
            UsuarioGB.Controls.Add(_CancelarBtn);
            UsuarioGB.Controls.Add(UsuarioCMB);
            UsuarioGB.Controls.Add(DesbloquearPB);
            UsuarioGB.Controls.Add(_AceptarBtn);
            UsuarioGB.Controls.Add(UsuarioLbl);
            UsuarioGB.Location = new Point(13, 12);
            UsuarioGB.Name = "UsuarioGB";
            UsuarioGB.Size = new Size(286, 106);
            UsuarioGB.TabIndex = 4;
            UsuarioGB.TabStop = false;
            UsuarioGB.Text = "Ingresar Usuario";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(186, 74);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 2;
            _CancelarBtn.Text = "&Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // UsuarioCMB
            // 
            UsuarioCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            UsuarioCMB.FormattingEnabled = true;
            UsuarioCMB.Location = new Point(137, 34);
            UsuarioCMB.Name = "UsuarioCMB";
            UsuarioCMB.Size = new Size(131, 23);
            UsuarioCMB.TabIndex = 0;
            // 
            // DesbloquearPB
            // 
            DesbloquearPB.Image = My.Resources.Resources.Resetear48;
            DesbloquearPB.Location = new Point(18, 39);
            DesbloquearPB.Name = "DesbloquearPB";
            DesbloquearPB.Size = new Size(48, 48);
            DesbloquearPB.TabIndex = 18;
            DesbloquearPB.TabStop = false;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(98, 74);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 1;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(80, 37);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(51, 15);
            UsuarioLbl.TabIndex = 1;
            UsuarioLbl.Text = "Usuario";
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
            // ResetearContrasena
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 130);
            Controls.Add(UsuarioGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(318, 159);
            MinimizeBox = false;
            MinimumSize = new Size(318, 159);
            Name = "ResetearContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            UsuarioGB.ResumeLayout(false);
            UsuarioGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DesbloquearPB).EndInit();
            Load += new EventHandler(ResetearContrasena_Load);
            FormClosing += new FormClosingEventHandler(ResetearContrasena_FormClosing);
            KeyDown += new KeyEventHandler(ResetearContrasena_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox UsuarioGB;
        internal ComboBox UsuarioCMB;
        internal PictureBox DesbloquearPB;
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

        internal ToolTip ControlesTP;
    }
}