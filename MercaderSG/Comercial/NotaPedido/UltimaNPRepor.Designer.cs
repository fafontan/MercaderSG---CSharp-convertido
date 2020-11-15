using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class UltimaNPRepor : Form
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
            UltimaNotaPedRPV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // UltimaNotaPedRPV
            // 
            UltimaNotaPedRPV.ActiveViewIndex = -1;
            UltimaNotaPedRPV.BorderStyle = BorderStyle.FixedSingle;
            UltimaNotaPedRPV.Cursor = Cursors.Default;
            UltimaNotaPedRPV.Dock = DockStyle.Fill;
            UltimaNotaPedRPV.Location = new Point(0, 0);
            UltimaNotaPedRPV.Name = "UltimaNotaPedRPV";
            UltimaNotaPedRPV.Size = new Size(473, 471);
            UltimaNotaPedRPV.TabIndex = 0;
            // 
            // UltimaNPRepor
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(473, 471);
            Controls.Add(UltimaNotaPedRPV);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UltimaNPRepor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UltimaNPRepor";
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(UltimaNPRepor_Load);
            ResumeLayout(false);
        }

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer UltimaNotaPedRPV;
    }
}