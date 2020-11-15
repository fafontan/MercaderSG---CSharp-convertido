using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class UsuarioFamilia : Form
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
            PanelesFLP = new FlowLayoutPanel();
            PanelSuperior = new Panel();
            _UsuarioCMB = new ComboBox();
            _UsuarioCMB.SelectedIndexChanged += new EventHandler(UsuarioCMB_SelectedIndexChanged);
            _CancelarBtn = new Button();
            _CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            _AceptarBtn = new Button();
            _AceptarBtn.Click += new EventHandler(AceptarBtn_Click);
            FamiliaGB = new GroupBox();
            FamiliaCLB = new CheckedListBox();
            UsuarioLbl = new Label();
            PanelInferior = new Panel();
            SS = new StatusStrip();
            _InformacionLbl = new ToolStripStatusLabel();
            _InformacionLbl.Click += new EventHandler(ErrorLbl_Click);
            ControlesTP = new ToolTip(components);
            PanelesFLP.SuspendLayout();
            PanelSuperior.SuspendLayout();
            FamiliaGB.SuspendLayout();
            PanelInferior.SuspendLayout();
            SS.SuspendLayout();
            SuspendLayout();
            // 
            // PanelesFLP
            // 
            PanelesFLP.AutoSize = true;
            PanelesFLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelesFLP.Controls.Add(PanelSuperior);
            PanelesFLP.Controls.Add(PanelInferior);
            PanelesFLP.Dock = DockStyle.Fill;
            PanelesFLP.FlowDirection = FlowDirection.TopDown;
            PanelesFLP.Location = new Point(0, 0);
            PanelesFLP.Name = "PanelesFLP";
            PanelesFLP.Size = new Size(262, 336);
            PanelesFLP.TabIndex = 1;
            // 
            // PanelSuperior
            // 
            PanelSuperior.AutoSize = true;
            PanelSuperior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelSuperior.Controls.Add(_UsuarioCMB);
            PanelSuperior.Controls.Add(_CancelarBtn);
            PanelSuperior.Controls.Add(_AceptarBtn);
            PanelSuperior.Controls.Add(FamiliaGB);
            PanelSuperior.Controls.Add(UsuarioLbl);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(3, 3);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(255, 302);
            PanelSuperior.TabIndex = 0;
            // 
            // UsuarioCMB
            // 
            _UsuarioCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            _UsuarioCMB.FormattingEnabled = true;
            _UsuarioCMB.Location = new Point(98, 13);
            _UsuarioCMB.Name = "_UsuarioCMB";
            _UsuarioCMB.Size = new Size(121, 23);
            _UsuarioCMB.TabIndex = 0;
            // 
            // CancelarBtn
            // 
            _CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            _CancelarBtn.Location = new Point(133, 275);
            _CancelarBtn.Name = "_CancelarBtn";
            _CancelarBtn.Size = new Size(82, 24);
            _CancelarBtn.TabIndex = 3;
            _CancelarBtn.Text = "Cancelar";
            _CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            _AceptarBtn.Image = My.Resources.Resources.accept;
            _AceptarBtn.Location = new Point(45, 275);
            _AceptarBtn.Name = "_AceptarBtn";
            _AceptarBtn.Size = new Size(82, 24);
            _AceptarBtn.TabIndex = 2;
            _AceptarBtn.Text = "Aceptar";
            _AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // FamiliaGB
            // 
            FamiliaGB.Controls.Add(FamiliaCLB);
            FamiliaGB.Location = new Point(8, 42);
            FamiliaGB.Name = "FamiliaGB";
            FamiliaGB.Size = new Size(244, 227);
            FamiliaGB.TabIndex = 3;
            FamiliaGB.TabStop = false;
            FamiliaGB.Text = "Familias";
            // 
            // FamiliaCLB
            // 
            FamiliaCLB.Dock = DockStyle.Fill;
            FamiliaCLB.FormattingEnabled = true;
            FamiliaCLB.Location = new Point(3, 19);
            FamiliaCLB.Name = "FamiliaCLB";
            FamiliaCLB.Size = new Size(238, 205);
            FamiliaCLB.TabIndex = 1;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(41, 16);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(51, 15);
            UsuarioLbl.TabIndex = 0;
            UsuarioLbl.Text = "Usuario";
            // 
            // PanelInferior
            // 
            PanelInferior.AutoSize = true;
            PanelInferior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelInferior.Controls.Add(SS);
            PanelInferior.Dock = DockStyle.Bottom;
            PanelInferior.Location = new Point(3, 311);
            PanelInferior.Name = "PanelInferior";
            PanelInferior.Size = new Size(255, 22);
            PanelInferior.TabIndex = 1;
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { _InformacionLbl });
            SS.Location = new Point(0, 0);
            SS.Name = "SS";
            SS.Size = new Size(255, 22);
            SS.TabIndex = 4;
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
            // UsuarioFamilia
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(262, 336);
            Controls.Add(PanelesFLP);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "UsuarioFamilia";
            StartPosition = FormStartPosition.CenterScreen;
            PanelesFLP.ResumeLayout(false);
            PanelesFLP.PerformLayout();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            FamiliaGB.ResumeLayout(false);
            PanelInferior.ResumeLayout(false);
            PanelInferior.PerformLayout();
            SS.ResumeLayout(false);
            SS.PerformLayout();
            Load += new EventHandler(FamliaUsuario_Load);
            FormClosing += new FormClosingEventHandler(UsuarioFamilia_FormClosing);
            KeyDown += new KeyEventHandler(UsuarioFamilia_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal FlowLayoutPanel PanelesFLP;
        internal Panel PanelSuperior;
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

        internal GroupBox FamiliaGB;
        internal CheckedListBox FamiliaCLB;
        internal Label UsuarioLbl;
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

        internal Panel PanelInferior;
        internal ToolTip ControlesTP;
    }
}