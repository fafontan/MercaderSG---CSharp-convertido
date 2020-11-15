using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class Restore : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Restore));
            DestinoLbl = new Label();
            BuscarBtn = new Button();
            AceptarBtn = new Button();
            GuardarFD = new OpenFileDialog();
            ArchivosLB = new ListBox();
            RestaurarGB = new GroupBox();
            NuevoBtn = new Button();
            ReContraseñaZipTxt = new TextBox();
            ContraseñaZipTxt = new TextBox();
            ReContraseñaZipLbl = new Label();
            ContraseñaZipLbl = new Label();
            CancelarBtn = new Button();
            ControlesTP = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            RestaurarGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // DestinoLbl
            // 
            DestinoLbl.AutoSize = true;
            DestinoLbl.Location = new Point(6, 94);
            DestinoLbl.Name = "DestinoLbl";
            DestinoLbl.Size = new Size(127, 15);
            DestinoLbl.TabIndex = 7;
            DestinoLbl.Text = "Seleccionar Archivo/s";
            // 
            // BuscarBtn
            // 
            BuscarBtn.Image = My.Resources.Resources.RestoreE1;
            BuscarBtn.Location = new Point(139, 91);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(40, 24);
            BuscarBtn.TabIndex = 2;
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            AceptarBtn.Image = My.Resources.Resources.accept;
            AceptarBtn.Location = new Point(9, 130);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(82, 24);
            AceptarBtn.TabIndex = 3;
            AceptarBtn.Text = "&Aceptar";
            AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // GuardarFD
            // 
            GuardarFD.FileName = "OpenFileDialog1";
            // 
            // ArchivosLB
            // 
            ArchivosLB.Dock = DockStyle.Right;
            ArchivosLB.FormattingEnabled = true;
            ArchivosLB.ItemHeight = 15;
            ArchivosLB.Location = new Point(287, 19);
            ArchivosLB.Name = "ArchivosLB";
            ArchivosLB.Size = new Size(233, 138);
            ArchivosLB.TabIndex = 6;
            // 
            // RestaurarGB
            // 
            RestaurarGB.Controls.Add(NuevoBtn);
            RestaurarGB.Controls.Add(ReContraseñaZipTxt);
            RestaurarGB.Controls.Add(ContraseñaZipTxt);
            RestaurarGB.Controls.Add(ReContraseñaZipLbl);
            RestaurarGB.Controls.Add(ContraseñaZipLbl);
            RestaurarGB.Controls.Add(CancelarBtn);
            RestaurarGB.Controls.Add(DestinoLbl);
            RestaurarGB.Controls.Add(ArchivosLB);
            RestaurarGB.Controls.Add(BuscarBtn);
            RestaurarGB.Controls.Add(AceptarBtn);
            RestaurarGB.Location = new Point(12, 12);
            RestaurarGB.Name = "RestaurarGB";
            RestaurarGB.Size = new Size(523, 160);
            RestaurarGB.TabIndex = 11;
            RestaurarGB.TabStop = false;
            RestaurarGB.Text = "Restaurar";
            // 
            // NuevoBtn
            // 
            NuevoBtn.Image = My.Resources.Resources.newPage;
            NuevoBtn.Location = new Point(97, 130);
            NuevoBtn.Name = "NuevoBtn";
            NuevoBtn.Size = new Size(82, 24);
            NuevoBtn.TabIndex = 4;
            NuevoBtn.Text = "Nuevo";
            NuevoBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            NuevoBtn.UseVisualStyleBackColor = true;
            // 
            // ReContraseñaZipTxt
            // 
            ReContraseñaZipTxt.Location = new Point(148, 56);
            ReContraseñaZipTxt.Name = "ReContraseñaZipTxt";
            ReContraseñaZipTxt.PasswordChar = '*';
            ReContraseñaZipTxt.Size = new Size(119, 23);
            ReContraseñaZipTxt.TabIndex = 1;
            // 
            // ContraseñaZipTxt
            // 
            ContraseñaZipTxt.Location = new Point(103, 27);
            ContraseñaZipTxt.Name = "ContraseñaZipTxt";
            ContraseñaZipTxt.PasswordChar = '*';
            ContraseñaZipTxt.Size = new Size(164, 23);
            ContraseñaZipTxt.TabIndex = 0;
            // 
            // ReContraseñaZipLbl
            // 
            ReContraseñaZipLbl.AutoSize = true;
            ReContraseñaZipLbl.Location = new Point(6, 59);
            ReContraseñaZipLbl.Name = "ReContraseñaZipLbl";
            ReContraseñaZipLbl.Size = new Size(136, 15);
            ReContraseñaZipLbl.TabIndex = 13;
            ReContraseñaZipLbl.Text = "Re-Ingresar Contraseña";
            // 
            // ContraseñaZipLbl
            // 
            ContraseñaZipLbl.AutoSize = true;
            ContraseñaZipLbl.Location = new Point(6, 30);
            ContraseñaZipLbl.Name = "ContraseñaZipLbl";
            ContraseñaZipLbl.Size = new Size(90, 15);
            ContraseñaZipLbl.TabIndex = 12;
            ContraseñaZipLbl.Text = "Contraseña ZIP";
            // 
            // CancelarBtn
            // 
            CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            CancelarBtn.Location = new Point(185, 130);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(82, 24);
            CancelarBtn.TabIndex = 5;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelarBtn.UseVisualStyleBackColor = true;
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
            // ErrorP
            // 
            ErrorP.BlinkRate = 150;
            ErrorP.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorP.ContainerControl = this;
            ErrorP.Icon = (Icon)resources.GetObject("ErrorP.Icon");
            // 
            // Restore
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(547, 183);
            Controls.Add(RestaurarGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(553, 212);
            MinimumSize = new Size(553, 212);
            Name = "Restore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restaurar base de datos - MercaderSG";
            RestaurarGB.ResumeLayout(false);
            RestaurarGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ResumeLayout(false);
        }

        internal Label DestinoLbl;
        internal Button BuscarBtn;
        internal Button AceptarBtn;
        internal OpenFileDialog GuardarFD;
        internal ListBox ArchivosLB;
        internal GroupBox RestaurarGB;
        internal Button CancelarBtn;
        internal ToolTip ControlesTP;
        internal TextBox ReContraseñaZipTxt;
        internal TextBox ContraseñaZipTxt;
        internal Label ReContraseñaZipLbl;
        internal Label ContraseñaZipLbl;
        internal Button NuevoBtn;
        internal ErrorProvider ErrorP;
    }
}