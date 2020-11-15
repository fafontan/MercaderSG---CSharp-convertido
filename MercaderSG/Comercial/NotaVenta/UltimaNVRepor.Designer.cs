using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class UltimaNVRepor : Form
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
            UltimaNotaRPV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // UltimaNotaRPV
            // 
            UltimaNotaRPV.ActiveViewIndex = -1;
            UltimaNotaRPV.BorderStyle = BorderStyle.FixedSingle;
            UltimaNotaRPV.Cursor = Cursors.Default;
            UltimaNotaRPV.Dock = DockStyle.Fill;
            UltimaNotaRPV.Location = new Point(0, 0);
            UltimaNotaRPV.Name = "UltimaNotaRPV";
            UltimaNotaRPV.Size = new Size(656, 507);
            UltimaNotaRPV.TabIndex = 0;
            UltimaNotaRPV.ToolPanelWidth = 233;
            // 
            // UltimaNVRepor
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(656, 507);
            Controls.Add(UltimaNotaRPV);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "UltimaNVRepor";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(ReportesNV_Load);
            KeyDown += new KeyEventHandler(UltimaNVRepor_KeyDown);
            ResumeLayout(false);
        }

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer UltimaNotaRPV;
    }
}