using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class ConsultarNP : Form
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
            NotaPedidoCRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // NotaPedidoCRV
            // 
            NotaPedidoCRV.ActiveViewIndex = -1;
            NotaPedidoCRV.BorderStyle = BorderStyle.FixedSingle;
            NotaPedidoCRV.Cursor = Cursors.Default;
            NotaPedidoCRV.Dock = DockStyle.Fill;
            NotaPedidoCRV.Location = new Point(0, 0);
            NotaPedidoCRV.Name = "NotaPedidoCRV";
            NotaPedidoCRV.Size = new Size(609, 546);
            NotaPedidoCRV.TabIndex = 0;
            // 
            // ConsultarNP
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(609, 546);
            Controls.Add(NotaPedidoCRV);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConsultarNP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarNP";
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(ConsultarNP_Load);
            ResumeLayout(false);
        }

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer NotaPedidoCRV;
    }
}