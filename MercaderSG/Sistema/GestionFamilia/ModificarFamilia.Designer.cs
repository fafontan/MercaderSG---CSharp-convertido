using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ModificarFamilia : Form
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
            DescripcionLbl = new Label();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            _DescripcionTxt = new TextBox();
            _DescripcionTxt.TextChanged += new EventHandler(DescripcionTxt_TextChanged);
            _DescripcionTxt.KeyPress += new KeyPressEventHandler(DescripcionTxt_KeyPress);
            _DescripcionTxt.Validated += new EventHandler(DescripcionTxt_Validated);
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            SuspendLayout();
            // 
            // DescripcionLbl
            // 
            DescripcionLbl.AutoSize = true;
            DescripcionLbl.Location = new Point(14, 20);
            DescripcionLbl.Name = "DescripcionLbl";
            DescripcionLbl.Size = new Size(73, 15);
            DescripcionLbl.TabIndex = 20;
            DescripcionLbl.Text = "Descripcion";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(201, 51);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 2;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(113, 51);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 1;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // DescripcionTxt
            // 
            _DescripcionTxt.Location = new Point(93, 17);
            _DescripcionTxt.Name = "_DescripcionTxt";
            _DescripcionTxt.Size = new Size(190, 23);
            _DescripcionTxt.TabIndex = 0;
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
            // ModificarFamilia
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(296, 92);
            Controls.Add(_CancelarBtn);
            Controls.Add(_AceptarBtn);
            Controls.Add(_DescripcionTxt);
            Controls.Add(DescripcionLbl);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(302, 121);
            MinimumSize = new Size(302, 121);
            Name = "ModificarFamilia";
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(ModificarFamilia_Load);
            KeyDown += new KeyEventHandler(ModificarFamilia_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label DescripcionLbl;
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
                    _DescripcionTxt.TextChanged -= DescripcionTxt_TextChanged;
                    _DescripcionTxt.KeyPress -= DescripcionTxt_KeyPress;
                    _DescripcionTxt.Validated -= DescripcionTxt_Validated;
                }

                _DescripcionTxt = value;
                if (_DescripcionTxt != null)
                {
                    _DescripcionTxt.TextChanged += DescripcionTxt_TextChanged;
                    _DescripcionTxt.KeyPress += DescripcionTxt_KeyPress;
                    _DescripcionTxt.Validated += DescripcionTxt_Validated;
                }
            }
        }

        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
    }
}