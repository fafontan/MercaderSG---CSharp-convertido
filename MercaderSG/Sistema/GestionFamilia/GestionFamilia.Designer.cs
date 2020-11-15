using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class GestionFamilia : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            OperacionGB = new GroupBox();
            _AgregarBtn = new Button();
            _AgregarBtn.Click += new EventHandler(AgregarBtn_Click);
            _ModificarBtn = new Button();
            _ModificarBtn.Click += new EventHandler(ModificarBtn_Click);
            _EliminarBtn = new Button();
            _EliminarBtn.Click += new EventHandler(EliminarBtn_Click);
            RegistrosGB = new GroupBox();
            FamiliaDG = new DataGridView();
            CodCAB = new DataGridViewTextBoxColumn();
            DescripcionCAB = new DataGridViewTextBoxColumn();
            ControlesTP = new ToolTip(components);
            OperacionGB.SuspendLayout();
            RegistrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FamiliaDG).BeginInit();
            SuspendLayout();
            // 
            // OperacionGB
            // 
            OperacionGB.Controls.Add(_AgregarBtn);
            OperacionGB.Controls.Add(_ModificarBtn);
            OperacionGB.Controls.Add(_EliminarBtn);
            OperacionGB.Location = new Point(12, 12);
            OperacionGB.Name = "OperacionGB";
            OperacionGB.Size = new Size(408, 61);
            OperacionGB.TabIndex = 0;
            OperacionGB.TabStop = false;
            OperacionGB.Text = "Operaciones";
            // 
            // AgregarBtn
            // 
            _AgregarBtn.Image = My.Resources.Resources.add;
            _AgregarBtn.Location = new Point(12, 22);
            _AgregarBtn.Name = "_AgregarBtn";
            _AgregarBtn.Size = new Size(110, 24);
            _AgregarBtn.TabIndex = 1;
            _AgregarBtn.Text = "Nueva Familia";
            _AgregarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            _ModificarBtn.Image = My.Resources.Resources.pencil;
            _ModificarBtn.Location = new Point(128, 22);
            _ModificarBtn.Name = "_ModificarBtn";
            _ModificarBtn.Size = new Size(131, 24);
            _ModificarBtn.TabIndex = 2;
            _ModificarBtn.Text = "Modificar Familia";
            _ModificarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            _EliminarBtn.Image = My.Resources.Resources.delete;
            _EliminarBtn.Location = new Point(265, 22);
            _EliminarBtn.Name = "_EliminarBtn";
            _EliminarBtn.Size = new Size(132, 24);
            _EliminarBtn.TabIndex = 3;
            _EliminarBtn.Text = "Eliminar Familia";
            _EliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrosGB
            // 
            RegistrosGB.Controls.Add(FamiliaDG);
            RegistrosGB.Location = new Point(12, 79);
            RegistrosGB.Name = "RegistrosGB";
            RegistrosGB.Size = new Size(408, 196);
            RegistrosGB.TabIndex = 58;
            RegistrosGB.TabStop = false;
            RegistrosGB.Text = "Registros";
            // 
            // FamiliaDG
            // 
            FamiliaDG.AllowUserToAddRows = false;
            FamiliaDG.AllowUserToDeleteRows = false;
            FamiliaDG.AllowUserToResizeColumns = false;
            FamiliaDG.AllowUserToResizeRows = false;
            FamiliaDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FamiliaDG.Columns.AddRange(new DataGridViewColumn[] { CodCAB, DescripcionCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            FamiliaDG.DefaultCellStyle = DataGridViewCellStyle1;
            FamiliaDG.Dock = DockStyle.Fill;
            FamiliaDG.Location = new Point(3, 19);
            FamiliaDG.MultiSelect = false;
            FamiliaDG.Name = "FamiliaDG";
            FamiliaDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            FamiliaDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            FamiliaDG.ScrollBars = ScrollBars.Vertical;
            FamiliaDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FamiliaDG.Size = new Size(402, 174);
            FamiliaDG.StandardTab = true;
            FamiliaDG.TabIndex = 4;
            // 
            // CodCAB
            // 
            CodCAB.DataPropertyName = "CodFam";
            CodCAB.HeaderText = "Código";
            CodCAB.Name = "CodCAB";
            CodCAB.ReadOnly = true;
            // 
            // DescripcionCAB
            // 
            DescripcionCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DescripcionCAB.DataPropertyName = "Descripcion";
            DescripcionCAB.HeaderText = "Descripcion";
            DescripcionCAB.Name = "DescripcionCAB";
            DescripcionCAB.ReadOnly = true;
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
            // GestionFamilia
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(433, 288);
            Controls.Add(RegistrosGB);
            Controls.Add(OperacionGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(439, 317);
            MinimumSize = new Size(439, 317);
            Name = "GestionFamilia";
            StartPosition = FormStartPosition.CenterScreen;
            OperacionGB.ResumeLayout(false);
            RegistrosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FamiliaDG).EndInit();
            Load += new EventHandler(GestionFamilia_Load);
            FormClosing += new FormClosingEventHandler(GestionFamilia_FormClosing);
            KeyDown += new KeyEventHandler(GestionFamilia_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox OperacionGB;
        private Button _AgregarBtn;

        internal Button AgregarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AgregarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AgregarBtn != null)
                {
                    _AgregarBtn.Click -= AgregarBtn_Click;
                }

                _AgregarBtn = value;
                if (_AgregarBtn != null)
                {
                    _AgregarBtn.Click += AgregarBtn_Click;
                }
            }
        }

        private Button _ModificarBtn;

        internal Button ModificarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ModificarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ModificarBtn != null)
                {
                    _ModificarBtn.Click -= ModificarBtn_Click;
                }

                _ModificarBtn = value;
                if (_ModificarBtn != null)
                {
                    _ModificarBtn.Click += ModificarBtn_Click;
                }
            }
        }

        private Button _EliminarBtn;

        internal Button EliminarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EliminarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EliminarBtn != null)
                {
                    _EliminarBtn.Click -= EliminarBtn_Click;
                }

                _EliminarBtn = value;
                if (_EliminarBtn != null)
                {
                    _EliminarBtn.Click += EliminarBtn_Click;
                }
            }
        }

        internal GroupBox RegistrosGB;
        internal DataGridView FamiliaDG;
        internal ToolTip ControlesTP;
        internal DataGridViewTextBoxColumn CodCAB;
        internal DataGridViewTextBoxColumn DescripcionCAB;
    }
}