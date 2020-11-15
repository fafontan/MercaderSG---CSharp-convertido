using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ConsultarRemito : Form
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
            RemitoCRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // RemitoCRV
            // 
            RemitoCRV.ActiveViewIndex = -1;
            RemitoCRV.BorderStyle = BorderStyle.FixedSingle;
            RemitoCRV.Cursor = Cursors.Default;
            RemitoCRV.Dock = DockStyle.Fill;
            RemitoCRV.Location = new Point(0, 0);
            RemitoCRV.Name = "RemitoCRV";
            RemitoCRV.Size = new Size(577, 480);
            RemitoCRV.TabIndex = 0;
            // 
            // ConsultarRemito
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 480);
            Controls.Add(RemitoCRV);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "ConsultarRemito";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(ConsultarRemito_Load);
            KeyDown += new KeyEventHandler(ConsultarRemito_KeyDown);
            ResumeLayout(false);
        }

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer RemitoCRV;
    }
}