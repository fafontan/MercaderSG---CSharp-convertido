using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class FamiliaPatente : Form
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
            PanelFLP = new FlowLayoutPanel();
            PanelSuperior = new Panel();
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            PatentesGB = new GroupBox();
            DenPatentesCLB = new CheckedListBox();
            FamiliaCMB = new ComboBox();
            FamiliaLbl = new Label();
            PatentesNoGB = new GroupBox();
            PatentesCLB = new CheckedListBox();
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            PanelInferior = new Panel();
            SS = new StatusStrip();
            _InformacionLbl = new ToolStripStatusLabel();
            _InformacionLbl.Click += new EventHandler(ErrorLbl_Click);
            ControlesTP = new ToolTip(components);
            PanelFLP.SuspendLayout();
            PanelSuperior.SuspendLayout();
            PatentesGB.SuspendLayout();
            PatentesNoGB.SuspendLayout();
            PanelInferior.SuspendLayout();
            SS.SuspendLayout();
            SuspendLayout();
            // 
            // PanelFLP
            // 
            PanelFLP.AutoSize = true;
            PanelFLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelFLP.Controls.Add(PanelSuperior);
            PanelFLP.Controls.Add(PanelInferior);
            PanelFLP.Dock = DockStyle.Fill;
            PanelFLP.FlowDirection = FlowDirection.TopDown;
            PanelFLP.Location = new Point(0, 0);
            PanelFLP.Name = "PanelFLP";
            PanelFLP.Size = new Size(558, 345);
            PanelFLP.TabIndex = 23;
            // 
            // PanelSuperior
            // 
            PanelSuperior.AutoSize = true;
            PanelSuperior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSuperior.Controls.Add(_BuscarBtn);
            PanelSuperior.Controls.Add(PatentesGB);
            PanelSuperior.Controls.Add(FamiliaCMB);
            PanelSuperior.Controls.Add(FamiliaLbl);
            PanelSuperior.Controls.Add(PatentesNoGB);
            PanelSuperior.Controls.Add(_CancelarBtn);
            PanelSuperior.Controls.Add(_AceptarBtn);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(3, 3);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(550, 311);
            PanelSuperior.TabIndex = 21;
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Image = My.Resources.Resources.search;
            _BuscarBtn.Location = new Point(354, 9);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(24, 23);
            _BuscarBtn.TabIndex = 1;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // PatentesGB
            // 
            PatentesGB.Controls.Add(DenPatentesCLB);
            PatentesGB.Location = new Point(278, 38);
            PatentesGB.Name = "PatentesGB";
            PatentesGB.Size = new Size(269, 240);
            PatentesGB.TabIndex = 7;
            PatentesGB.TabStop = false;
            PatentesGB.Text = "Patentes que posee la familia (Baja)";
            // 
            // DenPatentesCLB
            // 
            DenPatentesCLB.Dock = DockStyle.Fill;
            DenPatentesCLB.FormattingEnabled = true;
            DenPatentesCLB.Location = new Point(3, 19);
            DenPatentesCLB.Name = "DenPatentesCLB";
            DenPatentesCLB.Size = new Size(263, 218);
            DenPatentesCLB.TabIndex = 3;
            // 
            // FamiliaCMB
            // 
            FamiliaCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            FamiliaCMB.FormattingEnabled = true;
            FamiliaCMB.Location = new Point(227, 9);
            FamiliaCMB.Name = "FamiliaCMB";
            FamiliaCMB.Size = new Size(121, 23);
            FamiliaCMB.TabIndex = 0;
            // 
            // FamiliaLbl
            // 
            FamiliaLbl.AutoSize = true;
            FamiliaLbl.Location = new Point(172, 12);
            FamiliaLbl.Name = "FamiliaLbl";
            FamiliaLbl.Size = new Size(49, 15);
            FamiliaLbl.TabIndex = 5;
            FamiliaLbl.Text = "Familia";
            // 
            // PatentesNoGB
            // 
            PatentesNoGB.Controls.Add(PatentesCLB);
            PatentesNoGB.Location = new Point(3, 38);
            PatentesNoGB.Name = "PatentesNoGB";
            PatentesNoGB.Size = new Size(269, 240);
            PatentesNoGB.TabIndex = 0;
            PatentesNoGB.TabStop = false;
            PatentesNoGB.Text = "Patentes que no posee la familia (Alta)";
            // 
            // PatentesCLB
            // 
            PatentesCLB.Dock = DockStyle.Fill;
            PatentesCLB.FormattingEnabled = true;
            PatentesCLB.Location = new Point(3, 19);
            PatentesCLB.Name = "PatentesCLB";
            PatentesCLB.Size = new Size(263, 218);
            PatentesCLB.TabIndex = 2;
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(279, 284);
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
            _AceptarBtn.Location = new Point(191, 284);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 4;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // PanelInferior
            // 
            PanelInferior.Controls.Add(SS);
            PanelInferior.Dock = DockStyle.Bottom;
            PanelInferior.Location = new Point(3, 320);
            PanelInferior.Name = "PanelInferior";
            PanelInferior.Size = new Size(550, 22);
            PanelInferior.TabIndex = 23;
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { _InformacionLbl });
            SS.Location = new Point(0, 0);
            SS.Name = "SS";
            SS.Size = new Size(550, 22);
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
            // FamiliaPatente
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(558, 345);
            Controls.Add(PanelFLP);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FamiliaPatente";
            StartPosition = FormStartPosition.CenterScreen;
            PanelFLP.ResumeLayout(false);
            PanelFLP.PerformLayout();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            PatentesGB.ResumeLayout(false);
            PatentesNoGB.ResumeLayout(false);
            PanelInferior.ResumeLayout(false);
            PanelInferior.PerformLayout();
            SS.ResumeLayout(false);
            SS.PerformLayout();
            Load += new EventHandler(FamiliaPatente_Load);
            FormClosing += new FormClosingEventHandler(FamiliaPatente_FormClosing);
            KeyDown += new KeyEventHandler(FamiliaPatente_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal FlowLayoutPanel PanelFLP;
        internal Panel PanelInferior;
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
                    _InformacionLbl.Click -= ErrorLbl_Click;
                }

                _InformacionLbl = value;
                if (_InformacionLbl != null)
                {
                    _InformacionLbl.Click += ErrorLbl_Click;
                }
            }
        }

        internal Panel PanelSuperior;
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

        internal GroupBox PatentesGB;
        internal CheckedListBox DenPatentesCLB;
        internal ComboBox FamiliaCMB;
        internal Label FamiliaLbl;
        internal GroupBox PatentesNoGB;
        internal CheckedListBox PatentesCLB;
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

        internal ToolTip ControlesTP;
    }
}