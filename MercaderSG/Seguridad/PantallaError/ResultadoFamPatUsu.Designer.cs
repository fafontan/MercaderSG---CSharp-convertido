using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ResultadoFamPatUsu : Form
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
            TituloErrorLbl = new Label();
            TituloAltaLbl = new Label();
            FLP = new FlowLayoutPanel();
            InformacionPanel = new Panel();
            LblAlta = new TextBox();
            AltaPB = new PictureBox();
            AdvertenciaPanel = new Panel();
            LblError = new TextBox();
            AdvertenciaPB = new PictureBox();
            AdvertenciaPanelPatentes = new Panel();
            CausaLbl = new Label();
            LblErrorEliminarPermisos = new TextBox();
            PictureBox1 = new PictureBox();
            TituloNoAltaPermisosLbl = new Label();
            FLP.SuspendLayout();
            InformacionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AltaPB).BeginInit();
            AdvertenciaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdvertenciaPB).BeginInit();
            AdvertenciaPanelPatentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TituloErrorLbl
            // 
            TituloErrorLbl.AutoSize = true;
            TituloErrorLbl.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TituloErrorLbl.Location = new Point(9, 6);
            TituloErrorLbl.Name = "TituloErrorLbl";
            TituloErrorLbl.Size = new Size(50, 15);
            TituloErrorLbl.TabIndex = 1;
            TituloErrorLbl.Text = "tituBaja";
            // 
            // TituloAltaLbl
            // 
            TituloAltaLbl.AutoSize = true;
            TituloAltaLbl.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TituloAltaLbl.Location = new Point(9, 4);
            TituloAltaLbl.Name = "TituloAltaLbl";
            TituloAltaLbl.Size = new Size(49, 15);
            TituloAltaLbl.TabIndex = 3;
            TituloAltaLbl.Text = "tituAlta";
            // 
            // FLP
            // 
            FLP.AutoSize = true;
            FLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FLP.Controls.Add(InformacionPanel);
            FLP.Controls.Add(AdvertenciaPanel);
            FLP.Controls.Add(AdvertenciaPanelPatentes);
            FLP.Dock = DockStyle.Fill;
            FLP.FlowDirection = FlowDirection.TopDown;
            FLP.Location = new Point(0, 0);
            FLP.Name = "FLP";
            FLP.Size = new Size(278, 406);
            FLP.TabIndex = 4;
            // 
            // InformacionPanel
            // 
            InformacionPanel.AutoSize = true;
            InformacionPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InformacionPanel.BackColor = SystemColors.Control;
            InformacionPanel.Controls.Add(LblAlta);
            InformacionPanel.Controls.Add(AltaPB);
            InformacionPanel.Controls.Add(TituloAltaLbl);
            InformacionPanel.Location = new Point(5, 5);
            InformacionPanel.Margin = new Padding(5);
            InformacionPanel.Name = "InformacionPanel";
            InformacionPanel.Size = new Size(268, 115);
            InformacionPanel.TabIndex = 4;
            // 
            // LblAlta
            // 
            LblAlta.AcceptsTab = true;
            LblAlta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblAlta.Cursor = Cursors.Default;
            LblAlta.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LblAlta.Location = new Point(54, 39);
            LblAlta.Multiline = true;
            LblAlta.Name = "LblAlta";
            LblAlta.ReadOnly = true;
            LblAlta.ScrollBars = ScrollBars.Vertical;
            LblAlta.Size = new Size(211, 73);
            LblAlta.TabIndex = 7;
            // 
            // AltaPB
            // 
            AltaPB.Image = My.Resources.Resources.InformationE32;
            AltaPB.Location = new Point(12, 39);
            AltaPB.Margin = new Padding(3, 20, 3, 3);
            AltaPB.Name = "AltaPB";
            AltaPB.Size = new Size(33, 33);
            AltaPB.TabIndex = 4;
            AltaPB.TabStop = false;
            // 
            // AdvertenciaPanel
            // 
            AdvertenciaPanel.AutoSize = true;
            AdvertenciaPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AdvertenciaPanel.BackColor = SystemColors.Control;
            AdvertenciaPanel.Controls.Add(LblError);
            AdvertenciaPanel.Controls.Add(AdvertenciaPB);
            AdvertenciaPanel.Controls.Add(TituloErrorLbl);
            AdvertenciaPanel.Location = new Point(5, 130);
            AdvertenciaPanel.Margin = new Padding(5);
            AdvertenciaPanel.Name = "AdvertenciaPanel";
            AdvertenciaPanel.Size = new Size(268, 117);
            AdvertenciaPanel.TabIndex = 5;
            // 
            // LblError
            // 
            LblError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblError.Cursor = Cursors.Default;
            LblError.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LblError.Location = new Point(54, 41);
            LblError.Multiline = true;
            LblError.Name = "LblError";
            LblError.ReadOnly = true;
            LblError.ScrollBars = ScrollBars.Vertical;
            LblError.Size = new Size(211, 73);
            LblError.TabIndex = 8;
            // 
            // AdvertenciaPB
            // 
            AdvertenciaPB.Image = My.Resources.Resources.AdvertenciaE32;
            AdvertenciaPB.Location = new Point(12, 41);
            AdvertenciaPB.Margin = new Padding(3, 20, 3, 3);
            AdvertenciaPB.Name = "AdvertenciaPB";
            AdvertenciaPB.Size = new Size(33, 33);
            AdvertenciaPB.TabIndex = 2;
            AdvertenciaPB.TabStop = false;
            // 
            // AdvertenciaPanelPatentes
            // 
            AdvertenciaPanelPatentes.AutoSize = true;
            AdvertenciaPanelPatentes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AdvertenciaPanelPatentes.BackColor = SystemColors.Control;
            AdvertenciaPanelPatentes.Controls.Add(CausaLbl);
            AdvertenciaPanelPatentes.Controls.Add(LblErrorEliminarPermisos);
            AdvertenciaPanelPatentes.Controls.Add(PictureBox1);
            AdvertenciaPanelPatentes.Controls.Add(TituloNoAltaPermisosLbl);
            AdvertenciaPanelPatentes.Location = new Point(5, 257);
            AdvertenciaPanelPatentes.Margin = new Padding(5);
            AdvertenciaPanelPatentes.Name = "AdvertenciaPanelPatentes";
            AdvertenciaPanelPatentes.Size = new Size(268, 136);
            AdvertenciaPanelPatentes.TabIndex = 9;
            // 
            // CausaLbl
            // 
            CausaLbl.AutoSize = true;
            CausaLbl.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            CausaLbl.Location = new Point(9, 121);
            CausaLbl.Name = "CausaLbl";
            CausaLbl.Size = new Size(46, 15);
            CausaLbl.TabIndex = 9;
            CausaLbl.Text = "CAUSA";
            // 
            // LblErrorEliminarPermisos
            // 
            LblErrorEliminarPermisos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblErrorEliminarPermisos.Cursor = Cursors.Default;
            LblErrorEliminarPermisos.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LblErrorEliminarPermisos.Location = new Point(54, 41);
            LblErrorEliminarPermisos.Multiline = true;
            LblErrorEliminarPermisos.Name = "LblErrorEliminarPermisos";
            LblErrorEliminarPermisos.ReadOnly = true;
            LblErrorEliminarPermisos.ScrollBars = ScrollBars.Vertical;
            LblErrorEliminarPermisos.Size = new Size(211, 73);
            LblErrorEliminarPermisos.TabIndex = 8;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.AdvertenciaE32;
            PictureBox1.Location = new Point(12, 41);
            PictureBox1.Margin = new Padding(3, 20, 3, 3);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(33, 33);
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // TituloNoAltaPermisosLbl
            // 
            TituloNoAltaPermisosLbl.AutoSize = true;
            TituloNoAltaPermisosLbl.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TituloNoAltaPermisosLbl.Location = new Point(9, 6);
            TituloNoAltaPermisosLbl.Name = "TituloNoAltaPermisosLbl";
            TituloNoAltaPermisosLbl.Size = new Size(116, 15);
            TituloNoAltaPermisosLbl.TabIndex = 1;
            TituloNoAltaPermisosLbl.Text = "tituBajaNoPermisos";
            // 
            // ResultadoFamPatUsu
            // 
            AutoScaleDimensions = new SizeF(7.0f, 17.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(278, 406);
            Controls.Add(FLP);
            Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResultadoFamPatUsu";
            StartPosition = FormStartPosition.CenterScreen;
            FLP.ResumeLayout(false);
            FLP.PerformLayout();
            InformacionPanel.ResumeLayout(false);
            InformacionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AltaPB).EndInit();
            AdvertenciaPanel.ResumeLayout(false);
            AdvertenciaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdvertenciaPB).EndInit();
            AdvertenciaPanelPatentes.ResumeLayout(false);
            AdvertenciaPanelPatentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(ErrorFamPatUsu_Load);
            KeyDown += new KeyEventHandler(ResultadoFamPatUsu_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label TituloErrorLbl;
        internal Label TituloAltaLbl;
        internal FlowLayoutPanel FLP;
        internal Panel InformacionPanel;
        internal PictureBox AltaPB;
        internal Panel AdvertenciaPanel;
        internal PictureBox AdvertenciaPB;
        internal TextBox LblAlta;
        internal TextBox LblError;
        internal Panel AdvertenciaPanelPatentes;
        internal TextBox LblErrorEliminarPermisos;
        internal PictureBox PictureBox1;
        internal Label TituloNoAltaPermisosLbl;
        internal Label CausaLbl;
    }
}