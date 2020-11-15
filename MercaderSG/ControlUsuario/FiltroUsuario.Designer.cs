using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class FiltroUsuario : UserControl
    {

        // UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            _UsuarioCMB = new ComboBox();
            _UsuarioCMB.SelectedIndexChanged += new EventHandler(UsuarioCMB_SelectedIndexChanged);
            _BuscarUsuBtn = new Button();
            _BuscarUsuBtn.Click += new EventHandler(BuscarUsuBtn_Click);
            UsuarioLbl = new Label();
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            UsuarioGB.SuspendLayout();
            SuspendLayout();
            // 
            // UsuarioGB
            // 
            UsuarioGB.Controls.Add(_UsuarioCMB);
            UsuarioGB.Controls.Add(_BuscarUsuBtn);
            UsuarioGB.Controls.Add(UsuarioLbl);
            UsuarioGB.Location = new Point(2, 3);
            UsuarioGB.Name = "UsuarioGB";
            UsuarioGB.Size = new Size(626, 100);
            UsuarioGB.TabIndex = 1;
            UsuarioGB.TabStop = false;
            UsuarioGB.Text = "Buscar por Usuario";
            // 
            // UsuarioCMB
            // 
            _UsuarioCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            _UsuarioCMB.FormattingEnabled = true;
            _UsuarioCMB.Location = new Point(239, 40);
            _UsuarioCMB.Name = "_UsuarioCMB";
            _UsuarioCMB.Size = new Size(106, 23);
            _UsuarioCMB.TabIndex = 2;
            // 
            // BuscarUsuBtn
            // 
            _BuscarUsuBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarUsuBtn.Location = new Point(361, 35);
            _BuscarUsuBtn.Name = "_BuscarUsuBtn";
            _BuscarUsuBtn.Size = new Size(84, 30);
            _BuscarUsuBtn.TabIndex = 3;
            _BuscarUsuBtn.Text = "Buscar";
            _BuscarUsuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarUsuBtn.UseVisualStyleBackColor = true;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(182, 43);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(51, 15);
            UsuarioLbl.TabIndex = 11;
            UsuarioLbl.Text = "Usuario";
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
            // FiltroUsuario
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UsuarioGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Name = "FiltroUsuario";
            Size = new Size(629, 113);
            UsuarioGB.ResumeLayout(false);
            UsuarioGB.PerformLayout();
            Load += new EventHandler(FiltroUsuario_Load);
            ResumeLayout(false);
        }

        internal GroupBox UsuarioGB;
        private Button _BuscarUsuBtn;

        internal Button BuscarUsuBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarUsuBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarUsuBtn != null)
                {
                    _BuscarUsuBtn.Click -= BuscarUsuBtn_Click;
                }

                _BuscarUsuBtn = value;
                if (_BuscarUsuBtn != null)
                {
                    _BuscarUsuBtn.Click += BuscarUsuBtn_Click;
                }
            }
        }

        internal Label UsuarioLbl;
        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
        private ComboBox _UsuarioCMB;

        internal ComboBox UsuarioCMB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UsuarioCMB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UsuarioCMB != null)
                {
                    _UsuarioCMB.SelectedIndexChanged -= UsuarioCMB_SelectedIndexChanged;
                }

                _UsuarioCMB = value;
                if (_UsuarioCMB != null)
                {
                    _UsuarioCMB.SelectedIndexChanged += UsuarioCMB_SelectedIndexChanged;
                }
            }
        }
    }
}