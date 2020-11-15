using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class Backup : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            AceptarBtn = new Button();
            BuscarBtn = new Button();
            DestinoLbl = new Label();
            VolumenLbl = new Label();
            VolumenNUD = new NumericUpDown();
            RutaTxt = new TextBox();
            AbrirFD = new FolderBrowserDialog();
            BackupGB = new GroupBox();
            ReContraseñaZipTxt = new TextBox();
            ContraseñaZipTxt = new TextBox();
            NombreZipTxt = new TextBox();
            ReContraseñaZipLbl = new Label();
            ContraseñaZipLbl = new Label();
            NombreZipLbl = new Label();
            CancelarBtn = new Button();
            MensajeTT = new ToolTip(components);
            ControlesTP = new ToolTip(components);
            ErrorP = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)VolumenNUD).BeginInit();
            BackupGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // AceptarBtn
            // 
            AceptarBtn.Image = My.Resources.Resources.accept;
            AceptarBtn.Location = new Point(83, 236);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(82, 24);
            AceptarBtn.TabIndex = 6;
            AceptarBtn.Text = "&Aceptar";
            AceptarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Image = My.Resources.Resources.folder_database;
            BuscarBtn.Location = new Point(277, 27);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(29, 24);
            BuscarBtn.TabIndex = 1;
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // DestinoLbl
            // 
            DestinoLbl.AutoSize = true;
            DestinoLbl.Location = new Point(12, 30);
            DestinoLbl.Name = "DestinoLbl";
            DestinoLbl.Size = new Size(48, 15);
            DestinoLbl.TabIndex = 2;
            DestinoLbl.Text = "Destino";
            // 
            // VolumenLbl
            // 
            VolumenLbl.AutoSize = true;
            VolumenLbl.Location = new Point(12, 180);
            VolumenLbl.Name = "VolumenLbl";
            VolumenLbl.Size = new Size(42, 15);
            VolumenLbl.TabIndex = 3;
            VolumenLbl.Text = "Partes";
            // 
            // VolumenNUD
            // 
            VolumenNUD.Location = new Point(60, 178);
            VolumenNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            VolumenNUD.Name = "VolumenNUD";
            VolumenNUD.Size = new Size(46, 23);
            VolumenNUD.TabIndex = 5;
            VolumenNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // RutaTxt
            // 
            RutaTxt.Location = new Point(95, 27);
            RutaTxt.Name = "RutaTxt";
            RutaTxt.ReadOnly = true;
            RutaTxt.Size = new Size(176, 23);
            RutaTxt.TabIndex = 0;
            // 
            // BackupGB
            // 
            BackupGB.Controls.Add(ReContraseñaZipTxt);
            BackupGB.Controls.Add(ContraseñaZipTxt);
            BackupGB.Controls.Add(NombreZipTxt);
            BackupGB.Controls.Add(ReContraseñaZipLbl);
            BackupGB.Controls.Add(ContraseñaZipLbl);
            BackupGB.Controls.Add(NombreZipLbl);
            BackupGB.Controls.Add(RutaTxt);
            BackupGB.Controls.Add(VolumenNUD);
            BackupGB.Controls.Add(BuscarBtn);
            BackupGB.Controls.Add(VolumenLbl);
            BackupGB.Controls.Add(DestinoLbl);
            BackupGB.Location = new Point(12, 12);
            BackupGB.Name = "BackupGB";
            BackupGB.Size = new Size(312, 218);
            BackupGB.TabIndex = 0;
            BackupGB.TabStop = false;
            BackupGB.Text = "Copia de Seguridad";
            // 
            // ReContraseñaZipTxt
            // 
            ReContraseñaZipTxt.Location = new Point(154, 141);
            ReContraseñaZipTxt.Name = "ReContraseñaZipTxt";
            ReContraseñaZipTxt.PasswordChar = '*';
            ReContraseñaZipTxt.Size = new Size(117, 23);
            ReContraseñaZipTxt.TabIndex = 4;
            // 
            // ContraseñaZipTxt
            // 
            ContraseñaZipTxt.Location = new Point(109, 104);
            ContraseñaZipTxt.Name = "ContraseñaZipTxt";
            ContraseñaZipTxt.PasswordChar = '*';
            ContraseñaZipTxt.Size = new Size(162, 23);
            ContraseñaZipTxt.TabIndex = 3;
            // 
            // NombreZipTxt
            // 
            NombreZipTxt.Location = new Point(109, 65);
            NombreZipTxt.Name = "NombreZipTxt";
            NombreZipTxt.Size = new Size(162, 23);
            NombreZipTxt.TabIndex = 2;
            // 
            // ReContraseñaZipLbl
            // 
            ReContraseñaZipLbl.AutoSize = true;
            ReContraseñaZipLbl.Location = new Point(12, 144);
            ReContraseñaZipLbl.Name = "ReContraseñaZipLbl";
            ReContraseñaZipLbl.Size = new Size(136, 15);
            ReContraseñaZipLbl.TabIndex = 8;
            ReContraseñaZipLbl.Text = "Re-Ingresar Contraseña";
            // 
            // ContraseñaZipLbl
            // 
            ContraseñaZipLbl.AutoSize = true;
            ContraseñaZipLbl.Location = new Point(12, 107);
            ContraseñaZipLbl.Name = "ContraseñaZipLbl";
            ContraseñaZipLbl.Size = new Size(90, 15);
            ContraseñaZipLbl.TabIndex = 7;
            ContraseñaZipLbl.Text = "Contraseña ZIP";
            // 
            // NombreZipLbl
            // 
            NombreZipLbl.AutoSize = true;
            NombreZipLbl.Location = new Point(12, 68);
            NombreZipLbl.Name = "NombreZipLbl";
            NombreZipLbl.Size = new Size(90, 15);
            NombreZipLbl.TabIndex = 6;
            NombreZipLbl.Text = "Nombre del ZIP";
            // 
            // CancelarBtn
            // 
            CancelarBtn.Image = My.Resources.Resources.CancelBtn;
            CancelarBtn.Location = new Point(171, 236);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(82, 24);
            CancelarBtn.TabIndex = 7;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.AutoPopDelay = 5000;
            MensajeTT.InitialDelay = 1000;
            MensajeTT.ReshowDelay = 500;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
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
            // Backup
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(336, 269);
            Controls.Add(BackupGB);
            Controls.Add(AceptarBtn);
            Controls.Add(CancelarBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(342, 298);
            MinimumSize = new Size(342, 298);
            Name = "Backup";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)VolumenNUD).EndInit();
            BackupGB.ResumeLayout(false);
            BackupGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ResumeLayout(false);
        }

        internal Button AceptarBtn;
        internal Button BuscarBtn;
        internal Label DestinoLbl;
        internal Label VolumenLbl;
        internal NumericUpDown VolumenNUD;
        internal TextBox RutaTxt;
        internal FolderBrowserDialog AbrirFD;
        internal GroupBox BackupGB;
        internal Button CancelarBtn;
        internal ToolTip MensajeTT;
        internal ToolTip ControlesTP;
        internal Label ReContraseñaZipLbl;
        internal Label ContraseñaZipLbl;
        internal Label NombreZipLbl;
        internal TextBox ReContraseñaZipTxt;
        internal TextBox ContraseñaZipTxt;
        internal TextBox NombreZipTxt;
        internal ErrorProvider ErrorP;
    }
}