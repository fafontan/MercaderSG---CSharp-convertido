using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class UsuarioPatente : Form
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
            MensajeTT = new ToolTip(components);
            FLP = new FlowLayoutPanel();
            PanelSuperior = new Panel();
            PatDenegadasGB = new GroupBox();
            PatDenegadasCLB = new CheckedListBox();
            _UsuariosCMB = new ComboBox();
            _UsuariosCMB.SelectedIndexChanged += new EventHandler(UsuariosCMB_SelectedIndexChanged);
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            UsuarioLbl = new Label();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            DenPatentesGB = new GroupBox();
            DenPatentesCLB = new CheckedListBox();
            PatentesGB = new GroupBox();
            PatentesCLB = new CheckedListBox();
            PanelInferior = new Panel();
            SS = new StatusStrip();
            _InformacionLbl = new ToolStripStatusLabel();
            _InformacionLbl.Click += new EventHandler(InformacionLbl_Click);
            ControlesTP = new ToolTip(components);
            FLP.SuspendLayout();
            PanelSuperior.SuspendLayout();
            PatDenegadasGB.SuspendLayout();
            DenPatentesGB.SuspendLayout();
            PatentesGB.SuspendLayout();
            PanelInferior.SuspendLayout();
            SS.SuspendLayout();
            SuspendLayout();
            // 
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // FLP
            // 
            FLP.AutoSize = true;
            FLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FLP.Controls.Add(PanelSuperior);
            FLP.Controls.Add(PanelInferior);
            FLP.Dock = DockStyle.Fill;
            FLP.FlowDirection = FlowDirection.TopDown;
            FLP.Location = new Point(0, 0);
            FLP.Name = "FLP";
            FLP.Size = new Size(804, 359);
            FLP.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            PanelSuperior.AutoSize = true;
            PanelSuperior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSuperior.Controls.Add(PatDenegadasGB);
            PanelSuperior.Controls.Add(_UsuariosCMB);
            PanelSuperior.Controls.Add(_BuscarBtn);
            PanelSuperior.Controls.Add(UsuarioLbl);
            PanelSuperior.Controls.Add(_CancelarBtn);
            PanelSuperior.Controls.Add(_AceptarBtn);
            PanelSuperior.Controls.Add(DenPatentesGB);
            PanelSuperior.Controls.Add(PatentesGB);
            PanelSuperior.Location = new Point(3, 3);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(797, 325);
            PanelSuperior.TabIndex = 0;
            // 
            // PatDenegadasGB
            // 
            PatDenegadasGB.Controls.Add(PatDenegadasCLB);
            PatDenegadasGB.Location = new Point(267, 49);
            PatDenegadasGB.Name = "PatDenegadasGB";
            PatDenegadasGB.Size = new Size(261, 242);
            PatDenegadasGB.TabIndex = 12;
            PatDenegadasGB.TabStop = false;
            PatDenegadasGB.Text = "Patentes Denegadas (Asignar)";
            // 
            // PatDenegadasCLB
            // 
            PatDenegadasCLB.Dock = DockStyle.Fill;
            PatDenegadasCLB.FormattingEnabled = true;
            PatDenegadasCLB.Location = new Point(3, 19);
            PatDenegadasCLB.Name = "PatDenegadasCLB";
            PatDenegadasCLB.Size = new Size(255, 220);
            PatDenegadasCLB.TabIndex = 3;
            // 
            // UsuariosCMB
            // 
            _UsuariosCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            _UsuariosCMB.FormattingEnabled = true;
            _UsuariosCMB.Location = new Point(351, 10);
            _UsuariosCMB.Name = "_UsuariosCMB";
            _UsuariosCMB.Size = new Size(121, 23);
            _UsuariosCMB.TabIndex = 0;
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Image = My.Resources.Resources.search;
            _BuscarBtn.Location = new Point(478, 10);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(24, 23);
            _BuscarBtn.TabIndex = 1;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(294, 14);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(51, 15);
            UsuarioLbl.TabIndex = 14;
            UsuarioLbl.Text = "Usuario";
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(401, 298);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 6;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(313, 298);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 5;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // DenPatentesGB
            // 
            DenPatentesGB.Controls.Add(DenPatentesCLB);
            DenPatentesGB.Location = new Point(533, 49);
            DenPatentesGB.Name = "DenPatentesGB";
            DenPatentesGB.Size = new Size(261, 242);
            DenPatentesGB.TabIndex = 10;
            DenPatentesGB.TabStop = false;
            DenPatentesGB.Text = "Denegar Patentes";
            // 
            // DenPatentesCLB
            // 
            DenPatentesCLB.Dock = DockStyle.Fill;
            DenPatentesCLB.FormattingEnabled = true;
            DenPatentesCLB.Location = new Point(3, 19);
            DenPatentesCLB.Name = "DenPatentesCLB";
            DenPatentesCLB.Size = new Size(255, 220);
            DenPatentesCLB.TabIndex = 4;
            // 
            // PatentesGB
            // 
            PatentesGB.Controls.Add(PatentesCLB);
            PatentesGB.Location = new Point(3, 49);
            PatentesGB.Name = "PatentesGB";
            PatentesGB.Size = new Size(261, 242);
            PatentesGB.TabIndex = 11;
            PatentesGB.TabStop = false;
            PatentesGB.Text = "Asignar Patentes";
            // 
            // PatentesCLB
            // 
            PatentesCLB.Dock = DockStyle.Fill;
            PatentesCLB.FormattingEnabled = true;
            PatentesCLB.Location = new Point(3, 19);
            PatentesCLB.Name = "PatentesCLB";
            PatentesCLB.Size = new Size(255, 220);
            PatentesCLB.TabIndex = 2;
            // 
            // PanelInferior
            // 
            PanelInferior.AutoSize = true;
            PanelInferior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelInferior.Controls.Add(SS);
            PanelInferior.Dock = DockStyle.Bottom;
            PanelInferior.Location = new Point(3, 334);
            PanelInferior.Name = "PanelInferior";
            PanelInferior.Size = new Size(797, 22);
            PanelInferior.TabIndex = 1;
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { _InformacionLbl });
            SS.Location = new Point(0, 0);
            SS.Name = "SS";
            SS.Size = new Size(797, 22);
            SS.TabIndex = 6;
            SS.Text = "StatusStrip1";
            // 
            // InformacionLbl
            // 
            _InformacionLbl.ActiveLinkColor = Color.Blue;
            _InformacionLbl.Image = My.Resources.Resources.InfoDocE;
            _InformacionLbl.ImageAlign = ContentAlignment.MiddleRight;
            _InformacionLbl.IsLink = true;
            _InformacionLbl.Name = "_InformacionLbl";
            _InformacionLbl.Size = new Size(159, 17);
            _InformacionLbl.Text = "Resultado de la operación";
            _InformacionLbl.TextAlign = ContentAlignment.TopCenter;
            _InformacionLbl.TextImageRelation = TextImageRelation.TextBeforeImage;
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
            // UsuarioPatente
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(804, 359);
            Controls.Add(FLP);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "UsuarioPatente";
            StartPosition = FormStartPosition.CenterScreen;
            FLP.ResumeLayout(false);
            FLP.PerformLayout();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            PatDenegadasGB.ResumeLayout(false);
            DenPatentesGB.ResumeLayout(false);
            PatentesGB.ResumeLayout(false);
            PanelInferior.ResumeLayout(false);
            PanelInferior.PerformLayout();
            SS.ResumeLayout(false);
            SS.PerformLayout();
            Load += new EventHandler(UsuarioPatente_Load);
            FormClosing += new FormClosingEventHandler(UsuarioPatente_FormClosing);
            KeyDown += new KeyEventHandler(UsuarioPatente_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal ToolTip MensajeTT;
        internal FlowLayoutPanel FLP;
        internal Panel PanelSuperior;
        internal Panel PanelInferior;
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

        internal GroupBox DenPatentesGB;
        internal CheckedListBox DenPatentesCLB;
        internal GroupBox PatentesGB;
        internal CheckedListBox PatentesCLB;
        private ComboBox _UsuariosCMB;

        internal ComboBox UsuariosCMB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UsuariosCMB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UsuariosCMB != null)
                {
                    _UsuariosCMB.SelectedIndexChanged -= UsuariosCMB_SelectedIndexChanged;
                }

                _UsuariosCMB = value;
                if (_UsuariosCMB != null)
                {
                    _UsuariosCMB.SelectedIndexChanged += UsuariosCMB_SelectedIndexChanged;
                }
            }
        }

        private Button _BuscarBtn;

        internal Button BuscarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarBtn != null)
                {
                    _BuscarBtn.Click -= BuscarBtn_Click;
                }

                _BuscarBtn = value;
                if (_BuscarBtn != null)
                {
                    _BuscarBtn.Click += BuscarBtn_Click;
                }
            }
        }

        internal Label UsuarioLbl;
        internal ToolTip ControlesTP;
        internal StatusStrip SS;
        private ToolStripStatusLabel _InformacionLbl;

        internal ToolStripStatusLabel InformacionLbl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InformacionLbl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InformacionLbl != null)
                {
                    _InformacionLbl.Click -= InformacionLbl_Click;
                }

                _InformacionLbl = value;
                if (_InformacionLbl != null)
                {
                    _InformacionLbl.Click += InformacionLbl_Click;
                }
            }
        }

        internal GroupBox PatDenegadasGB;
        internal CheckedListBox PatDenegadasCLB;
    }
}