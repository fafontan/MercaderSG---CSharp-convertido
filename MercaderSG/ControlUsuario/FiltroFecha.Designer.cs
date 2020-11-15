using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class FiltroFecha : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroFecha));
            FechasGB = new GroupBox();
            HastaDTP = new DateTimePicker();
            _DesdeDTP = new DateTimePicker();
            _DesdeDTP.ValueChanged += new EventHandler(DesdeDTP_ValueChanged);
            _BuscarFechaBtn = new Button();
            _BuscarFechaBtn.Click += new EventHandler(BuscarFechaBtn_Click);
            HastaLbl = new Label();
            DesdeLbl = new Label();
            MensajeTT = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            ControlesTP = new ToolTip(components);
            FechasGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // FechasGB
            // 
            FechasGB.Controls.Add(HastaDTP);
            FechasGB.Controls.Add(_DesdeDTP);
            FechasGB.Controls.Add(_BuscarFechaBtn);
            FechasGB.Controls.Add(HastaLbl);
            FechasGB.Controls.Add(DesdeLbl);
            FechasGB.Location = new Point(3, 3);
            FechasGB.Name = "FechasGB";
            FechasGB.Size = new Size(626, 100);
            FechasGB.TabIndex = 1;
            FechasGB.TabStop = false;
            FechasGB.Text = "Buscar por Fechas";
            // 
            // HastaDTP
            // 
            HastaDTP.Checked = false;
            HastaDTP.Format = DateTimePickerFormat.Short;
            HastaDTP.Location = new Point(319, 37);
            HastaDTP.Name = "HastaDTP";
            HastaDTP.Size = new Size(100, 23);
            HastaDTP.TabIndex = 3;
            // 
            // DesdeDTP
            // 
            _DesdeDTP.Checked = false;
            _DesdeDTP.Format = DateTimePickerFormat.Short;
            _DesdeDTP.Location = new Point(146, 37);
            _DesdeDTP.Name = "_DesdeDTP";
            _DesdeDTP.Size = new Size(100, 23);
            _DesdeDTP.TabIndex = 2;
            // 
            // BuscarFechaBtn
            // 
            _BuscarFechaBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarFechaBtn.Location = new Point(452, 35);
            _BuscarFechaBtn.Name = "_BuscarFechaBtn";
            _BuscarFechaBtn.Size = new Size(84, 30);
            _BuscarFechaBtn.TabIndex = 4;
            _BuscarFechaBtn.Text = "Buscar";
            _BuscarFechaBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarFechaBtn.UseVisualStyleBackColor = true;
            // 
            // HastaLbl
            // 
            HastaLbl.AutoSize = true;
            HastaLbl.Location = new Point(266, 43);
            HastaLbl.Name = "HastaLbl";
            HastaLbl.Size = new Size(39, 15);
            HastaLbl.TabIndex = 12;
            HastaLbl.Text = "Hasta";
            // 
            // DesdeLbl
            // 
            DesdeLbl.AutoSize = true;
            DesdeLbl.Location = new Point(90, 43);
            DesdeLbl.Name = "DesdeLbl";
            DesdeLbl.Size = new Size(40, 15);
            DesdeLbl.TabIndex = 11;
            DesdeLbl.Text = "Desde";
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
            // FiltroFecha
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FechasGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Name = "FiltroFecha";
            Size = new Size(629, 113);
            FechasGB.ResumeLayout(false);
            FechasGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            Load += new EventHandler(FiltroFecha_Load);
            ResumeLayout(false);
        }

        internal GroupBox FechasGB;
        internal DateTimePicker HastaDTP;
        private DateTimePicker _DesdeDTP;

        internal DateTimePicker DesdeDTP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DesdeDTP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DesdeDTP != null)
                {
                    _DesdeDTP.ValueChanged -= DesdeDTP_ValueChanged;
                }

                _DesdeDTP = value;
                if (_DesdeDTP != null)
                {
                    _DesdeDTP.ValueChanged += DesdeDTP_ValueChanged;
                }
            }
        }

        private Button _BuscarFechaBtn;

        internal Button BuscarFechaBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarFechaBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarFechaBtn != null)
                {
                    _BuscarFechaBtn.Click -= BuscarFechaBtn_Click;
                }

                _BuscarFechaBtn = value;
                if (_BuscarFechaBtn != null)
                {
                    _BuscarFechaBtn.Click += BuscarFechaBtn_Click;
                }
            }
        }

        internal Label HastaLbl;
        internal Label DesdeLbl;
        internal ToolTip MensajeTT;
        internal ErrorProvider ErrorP;
        internal ToolTip ControlesTP;
    }
}