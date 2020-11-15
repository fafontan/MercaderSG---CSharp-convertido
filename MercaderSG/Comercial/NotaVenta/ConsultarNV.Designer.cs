using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ConsultarNV : Form
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
            NotaVentaCRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // NotaVentaCRV
            // 
            NotaVentaCRV.ActiveViewIndex = -1;
            NotaVentaCRV.BorderStyle = BorderStyle.FixedSingle;
            NotaVentaCRV.Cursor = Cursors.Default;
            NotaVentaCRV.Dock = DockStyle.Fill;
            NotaVentaCRV.Location = new Point(0, 0);
            NotaVentaCRV.Name = "NotaVentaCRV";
            NotaVentaCRV.Size = new Size(642, 567);
            NotaVentaCRV.TabIndex = 0;
            // 
            // ConsultarNV
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(642, 567);
            Controls.Add(NotaVentaCRV);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MinimizeBox = false;
            Name = "ConsultarNV";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(ConsultarNV_Load);
            KeyDown += new KeyEventHandler(ConsultarNV_KeyDown);
            ResumeLayout(false);
        }

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer NotaVentaCRV;
    }
}