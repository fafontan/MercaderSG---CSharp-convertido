using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MercaderSG
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BarraProgreso : Form
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
            ProgressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // ProgressBar1
            // 
            ProgressBar1.BackColor = SystemColors.Control;
            ProgressBar1.Location = new Point(12, 12);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(285, 22);
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            ProgressBar1.TabIndex = 56;
            // 
            // BarraProgreso
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(309, 46);
            Controls.Add(ProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BarraProgreso";
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(BarraProgreso_Load);
            ResumeLayout(false);
        }

        internal ProgressBar ProgressBar1;
    }
}