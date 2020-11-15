using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class FiltroCriticidad : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroCriticidad));
            CriticidadGB = new GroupBox();
            _CriticidadCMB = new ComboBox();
            _CriticidadCMB.SelectedIndexChanged += new EventHandler(CriticidadCMB_SelectedIndexChanged);
            _BuscarCritiBtn = new Button();
            _BuscarCritiBtn.Click += new EventHandler(BuscarCritiBtn_Click);
            CriticidadLbl = new Label();
            MensajeTT = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            ControlesTP = new ToolTip(components);
            CriticidadGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // CriticidadGB
            // 
            CriticidadGB.Controls.Add(_CriticidadCMB);
            CriticidadGB.Controls.Add(_BuscarCritiBtn);
            CriticidadGB.Controls.Add(CriticidadLbl);
            CriticidadGB.Location = new Point(3, 3);
            CriticidadGB.Name = "CriticidadGB";
            CriticidadGB.Size = new Size(626, 100);
            CriticidadGB.TabIndex = 1;
            CriticidadGB.TabStop = false;
            CriticidadGB.Text = "Buscar por Criticidad";
            // 
            // CriticidadCMB
            // 
            _CriticidadCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            _CriticidadCMB.FormattingEnabled = true;
            _CriticidadCMB.Location = new Point(249, 40);
            _CriticidadCMB.Name = "_CriticidadCMB";
            _CriticidadCMB.Size = new Size(100, 23);
            _CriticidadCMB.TabIndex = 2;
            // 
            // BuscarCritiBtn
            // 
            _BuscarCritiBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarCritiBtn.Location = new Point(361, 35);
            _BuscarCritiBtn.Name = "_BuscarCritiBtn";
            _BuscarCritiBtn.Size = new Size(84, 30);
            _BuscarCritiBtn.TabIndex = 3;
            _BuscarCritiBtn.Text = "Buscar";
            _BuscarCritiBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarCritiBtn.UseVisualStyleBackColor = true;
            // 
            // CriticidadLbl
            // 
            CriticidadLbl.AutoSize = true;
            CriticidadLbl.Location = new Point(182, 43);
            CriticidadLbl.Name = "CriticidadLbl";
            CriticidadLbl.Size = new Size(61, 15);
            CriticidadLbl.TabIndex = 9;
            CriticidadLbl.Text = "Criticidad";
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
            // FiltroCriticidad
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CriticidadGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Name = "FiltroCriticidad";
            Size = new Size(629, 113);
            CriticidadGB.ResumeLayout(false);
            CriticidadGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(FiltroCriticidad_Load);
            ResumeLayout(false);
        }

        internal GroupBox CriticidadGB;
        private Button _BuscarCritiBtn;

        internal Button BuscarCritiBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarCritiBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarCritiBtn != null)
                {
                    _BuscarCritiBtn.Click -= BuscarCritiBtn_Click;
                }

                _BuscarCritiBtn = value;
                if (_BuscarCritiBtn != null)
                {
                    _BuscarCritiBtn.Click += BuscarCritiBtn_Click;
                }
            }
        }

        internal Label CriticidadLbl;
        internal ToolTip MensajeTT;
        internal ErrorProvider ErrorP;
        internal ToolTip ControlesTP;
        private ComboBox _CriticidadCMB;

        internal ComboBox CriticidadCMB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CriticidadCMB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CriticidadCMB != null)
                {
                    _CriticidadCMB.SelectedIndexChanged -= CriticidadCMB_SelectedIndexChanged;
                }

                _CriticidadCMB = value;
                if (_CriticidadCMB != null)
                {
                    _CriticidadCMB.SelectedIndexChanged += CriticidadCMB_SelectedIndexChanged;
                }
            }
        }
    }
}