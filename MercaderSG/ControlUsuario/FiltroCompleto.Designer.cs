using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class FiltroCompleto : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroCompleto));
            CompletoGB = new GroupBox();
            CriticidadCMB = new ComboBox();
            UsuarioCMB = new ComboBox();
            HastaComDTP = new DateTimePicker();
            _DesdeComDTP = new DateTimePicker();
            _DesdeComDTP.ValueChanged += new EventHandler(DesdeComDTP_ValueChanged);
            _BuscarComBtn = new Button();
            _BuscarComBtn.Click += new EventHandler(BuscarComBtn_Click);
            CritiComLbl = new Label();
            UsuComLbl = new Label();
            HastaComLbl = new Label();
            DesdeComLbl = new Label();
            ErrorP = new ErrorProvider(components);
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            CompletoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // CompletoGB
            // 
            CompletoGB.Controls.Add(CriticidadCMB);
            CompletoGB.Controls.Add(UsuarioCMB);
            CompletoGB.Controls.Add(HastaComDTP);
            CompletoGB.Controls.Add(_DesdeComDTP);
            CompletoGB.Controls.Add(_BuscarComBtn);
            CompletoGB.Controls.Add(CritiComLbl);
            CompletoGB.Controls.Add(UsuComLbl);
            CompletoGB.Controls.Add(HastaComLbl);
            CompletoGB.Controls.Add(DesdeComLbl);
            CompletoGB.Location = new Point(3, 3);
            CompletoGB.Name = "CompletoGB";
            CompletoGB.Size = new Size(626, 100);
            CompletoGB.TabIndex = 1;
            CompletoGB.TabStop = false;
            CompletoGB.Text = "Filtro Completo";
            // 
            // CriticidadCMB
            // 
            CriticidadCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            CriticidadCMB.FormattingEnabled = true;
            CriticidadCMB.Location = new Point(337, 69);
            CriticidadCMB.Name = "CriticidadCMB";
            CriticidadCMB.Size = new Size(100, 23);
            CriticidadCMB.TabIndex = 5;
            // 
            // UsuarioCMB
            // 
            UsuarioCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            UsuarioCMB.FormattingEnabled = true;
            UsuarioCMB.Location = new Point(147, 69);
            UsuarioCMB.Name = "UsuarioCMB";
            UsuarioCMB.Size = new Size(100, 23);
            UsuarioCMB.TabIndex = 4;
            // 
            // HastaComDTP
            // 
            HastaComDTP.Checked = false;
            HastaComDTP.Format = DateTimePickerFormat.Short;
            HastaComDTP.Location = new Point(337, 27);
            HastaComDTP.Name = "HastaComDTP";
            HastaComDTP.Size = new Size(100, 23);
            HastaComDTP.TabIndex = 3;
            // 
            // DesdeComDTP
            // 
            _DesdeComDTP.Checked = false;
            _DesdeComDTP.Format = DateTimePickerFormat.Short;
            _DesdeComDTP.Location = new Point(147, 27);
            _DesdeComDTP.Name = "_DesdeComDTP";
            _DesdeComDTP.Size = new Size(100, 23);
            _DesdeComDTP.TabIndex = 2;
            // 
            // BuscarComBtn
            // 
            _BuscarComBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarComBtn.Location = new Point(452, 46);
            _BuscarComBtn.Name = "_BuscarComBtn";
            _BuscarComBtn.Size = new Size(84, 30);
            _BuscarComBtn.TabIndex = 6;
            _BuscarComBtn.Text = "Buscar";
            _BuscarComBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarComBtn.UseVisualStyleBackColor = true;
            // 
            // CritiComLbl
            // 
            CritiComLbl.AutoSize = true;
            CritiComLbl.Location = new Point(266, 72);
            CritiComLbl.Name = "CritiComLbl";
            CritiComLbl.Size = new Size(61, 15);
            CritiComLbl.TabIndex = 3;
            CritiComLbl.Text = "Criticidad";
            // 
            // UsuComLbl
            // 
            UsuComLbl.AutoSize = true;
            UsuComLbl.Location = new Point(90, 72);
            UsuComLbl.Name = "UsuComLbl";
            UsuComLbl.Size = new Size(51, 15);
            UsuComLbl.TabIndex = 2;
            UsuComLbl.Text = "Usuario";
            // 
            // HastaComLbl
            // 
            HastaComLbl.AutoSize = true;
            HastaComLbl.Location = new Point(268, 33);
            HastaComLbl.Name = "HastaComLbl";
            HastaComLbl.Size = new Size(39, 15);
            HastaComLbl.TabIndex = 1;
            HastaComLbl.Text = "Hasta";
            // 
            // DesdeComLbl
            // 
            DesdeComLbl.AutoSize = true;
            DesdeComLbl.Location = new Point(90, 33);
            DesdeComLbl.Name = "DesdeComLbl";
            DesdeComLbl.Size = new Size(40, 15);
            DesdeComLbl.TabIndex = 0;
            DesdeComLbl.Text = "Desde";
            // 
            // ErrorP
            // 
            ErrorP.BlinkRate = 150;
            ErrorP.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorP.ContainerControl = this;
            ErrorP.Icon = (Icon)resources.GetObject("ErrorP.Icon");
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
            // FiltroCompleto
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CompletoGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Name = "FiltroCompleto";
            Size = new Size(629, 113);
            CompletoGB.ResumeLayout(false);
            CompletoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(FiltroCompleto_Load);
            ResumeLayout(false);
        }

        internal GroupBox CompletoGB;
        internal DateTimePicker HastaComDTP;
        private DateTimePicker _DesdeComDTP;

        internal DateTimePicker DesdeComDTP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DesdeComDTP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DesdeComDTP != null)
                {
                    _DesdeComDTP.ValueChanged -= DesdeComDTP_ValueChanged;
                }

                _DesdeComDTP = value;
                if (_DesdeComDTP != null)
                {
                    _DesdeComDTP.ValueChanged += DesdeComDTP_ValueChanged;
                }
            }
        }

        private Button _BuscarComBtn;

        internal Button BuscarComBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarComBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarComBtn != null)
                {
                    _BuscarComBtn.Click -= BuscarComBtn_Click;
                }

                _BuscarComBtn = value;
                if (_BuscarComBtn != null)
                {
                    _BuscarComBtn.Click += BuscarComBtn_Click;
                }
            }
        }

        internal Label CritiComLbl;
        internal Label UsuComLbl;
        internal Label HastaComLbl;
        internal Label DesdeComLbl;
        internal ErrorProvider ErrorP;
        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
        internal ComboBox UsuarioCMB;
        internal ComboBox CriticidadCMB;
    }
}