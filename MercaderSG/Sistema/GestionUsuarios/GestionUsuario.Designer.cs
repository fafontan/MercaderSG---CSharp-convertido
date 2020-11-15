using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class GestionUsuario : Form
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
            UsuarioDG = new DataGridView();
            ExportarCMS = new ContextMenuStrip(components);
            _ExportarAXLSToolStripMenuItem = new ToolStripMenuItem();
            _ExportarAXLSToolStripMenuItem.Click += new EventHandler(ExportarAXLSToolStripMenuItem_Click);
            SS = new StatusStrip();
            Parte1Lbl = new ToolStripStatusLabel();
            InfoPagLbl = new ToolStripStatusLabel();
            Parte2Lbl = new ToolStripStatusLabel();
            RegistrosGB = new GroupBox();
            GestionUsuariosGB = new GroupBox();
            OperacionGB = new GroupBox();
            _AgregarBtn = new Button();
            _AgregarBtn.Click += new EventHandler(AgregarBtn_Click);
            _EliminarTelBtn = new Button();
            _EliminarTelBtn.Click += new EventHandler(EliminarTelBtn_Click);
            _ModificarBtn = new Button();
            _ModificarBtn.Click += new EventHandler(ModificarBtn_Click);
            _EliminarBtn = new Button();
            _EliminarBtn.Click += new EventHandler(EliminarBtn_Click);
            BuscarCmb = new ComboBox();
            BuscarPorLbl = new Label();
            _BusquedaTxt = new TextBox();
            _BusquedaTxt.TextChanged += new EventHandler(BusquedaTxt_TextChanged);
            IgualLbl = new Label();
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            ControlesTP = new ToolTip(components);
            _RecargarBtn = new Button();
            _RecargarBtn.Click += new EventHandler(RecargarBtn_Click);
            _SiguienteBtn = new Button();
            _SiguienteBtn.Click += new EventHandler(SiguienteBtn_Click);
            _AnteriorBtn = new Button();
            _AnteriorBtn.Click += new EventHandler(AnteriorBtn_Click);
            _UltimoBtn = new Button();
            _UltimoBtn.Click += new EventHandler(UltimoBtn_Click);
            _PrimeroBtn = new Button();
            _PrimeroBtn.Click += new EventHandler(PrimeroBtn_Click);
            MensajeTT = new ToolTip(components);
            CodUsuCAB = new DataGridViewTextBoxColumn();
            UsuarioCAB = new DataGridViewTextBoxColumn();
            ApellidoCAB = new DataGridViewTextBoxColumn();
            NombreCAB = new DataGridViewTextBoxColumn();
            CorreoCAB = new DataGridViewTextBoxColumn();
            EdadCAB = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)UsuarioDG).BeginInit();
            ExportarCMS.SuspendLayout();
            SS.SuspendLayout();
            RegistrosGB.SuspendLayout();
            GestionUsuariosGB.SuspendLayout();
            OperacionGB.SuspendLayout();
            SuspendLayout();
            // 
            // UsuarioDG
            // 
            UsuarioDG.AllowUserToAddRows = false;
            UsuarioDG.AllowUserToDeleteRows = false;
            UsuarioDG.AllowUserToResizeColumns = false;
            UsuarioDG.AllowUserToResizeRows = false;
            UsuarioDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsuarioDG.Columns.AddRange(new DataGridViewColumn[] { CodUsuCAB, UsuarioCAB, ApellidoCAB, NombreCAB, CorreoCAB, EdadCAB });
            UsuarioDG.ContextMenuStrip = ExportarCMS;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            UsuarioDG.DefaultCellStyle = DataGridViewCellStyle1;
            UsuarioDG.Dock = DockStyle.Fill;
            UsuarioDG.Location = new Point(3, 19);
            UsuarioDG.MultiSelect = false;
            UsuarioDG.Name = "UsuarioDG";
            UsuarioDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UsuarioDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            UsuarioDG.ScrollBars = ScrollBars.Vertical;
            UsuarioDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsuarioDG.Size = new Size(582, 353);
            UsuarioDG.StandardTab = true;
            UsuarioDG.TabIndex = 7;
            // 
            // ExportarCMS
            // 
            ExportarCMS.Items.AddRange(new ToolStripItem[] { _ExportarAXLSToolStripMenuItem });
            ExportarCMS.Name = "ExportarCMS";
            ExportarCMS.Size = new Size(149, 26);
            // 
            // ExportarAXLSToolStripMenuItem
            // 
            _ExportarAXLSToolStripMenuItem.Image = My.Resources.Resources.ExcelE;
            _ExportarAXLSToolStripMenuItem.Name = "_ExportarAXLSToolStripMenuItem";
            _ExportarAXLSToolStripMenuItem.Size = new Size(148, 22);
            _ExportarAXLSToolStripMenuItem.Text = "Exportar a XLS";
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { Parte1Lbl, InfoPagLbl, Parte2Lbl });
            SS.Location = new Point(0, 577);
            SS.Name = "SS";
            SS.RightToLeft = RightToLeft.No;
            SS.Size = new Size(612, 22);
            SS.TabIndex = 57;
            SS.Text = "StatusStrip1";
            // 
            // Parte1Lbl
            // 
            Parte1Lbl.Name = "Parte1Lbl";
            Parte1Lbl.Size = new Size(17, 17);
            Parte1Lbl.Text = "--";
            // 
            // InfoPagLbl
            // 
            InfoPagLbl.DisplayStyle = ToolStripItemDisplayStyle.Text;
            InfoPagLbl.Name = "InfoPagLbl";
            InfoPagLbl.Size = new Size(17, 17);
            InfoPagLbl.Text = "xx";
            // 
            // Parte2Lbl
            // 
            Parte2Lbl.Name = "Parte2Lbl";
            Parte2Lbl.Size = new Size(17, 17);
            Parte2Lbl.Text = "--";
            // 
            // RegistrosGB
            // 
            RegistrosGB.Controls.Add(UsuarioDG);
            RegistrosGB.Location = new Point(12, 162);
            RegistrosGB.Name = "RegistrosGB";
            RegistrosGB.Size = new Size(588, 375);
            RegistrosGB.TabIndex = 59;
            RegistrosGB.TabStop = false;
            RegistrosGB.Text = "Registros";
            // 
            // GestionUsuariosGB
            // 
            GestionUsuariosGB.Controls.Add(OperacionGB);
            GestionUsuariosGB.Controls.Add(BuscarCmb);
            GestionUsuariosGB.Controls.Add(BuscarPorLbl);
            GestionUsuariosGB.Controls.Add(_BusquedaTxt);
            GestionUsuariosGB.Controls.Add(IgualLbl);
            GestionUsuariosGB.Controls.Add(_BuscarBtn);
            GestionUsuariosGB.Location = new Point(12, 12);
            GestionUsuariosGB.Name = "GestionUsuariosGB";
            GestionUsuariosGB.Size = new Size(588, 141);
            GestionUsuariosGB.TabIndex = 56;
            GestionUsuariosGB.TabStop = false;
            GestionUsuariosGB.Text = "Gestion de Usuarios";
            // 
            // OperacionGB
            // 
            OperacionGB.Controls.Add(_AgregarBtn);
            OperacionGB.Controls.Add(_EliminarTelBtn);
            OperacionGB.Controls.Add(_ModificarBtn);
            OperacionGB.Controls.Add(_EliminarBtn);
            OperacionGB.Location = new Point(11, 66);
            OperacionGB.Name = "OperacionGB";
            OperacionGB.Size = new Size(571, 61);
            OperacionGB.TabIndex = 56;
            OperacionGB.TabStop = false;
            OperacionGB.Text = "Operaciones";
            // 
            // AgregarBtn
            // 
            _AgregarBtn.Image = My.Resources.Resources.add;
            _AgregarBtn.Location = new Point(7, 22);
            _AgregarBtn.Name = "_AgregarBtn";
            _AgregarBtn.Size = new Size(119, 24);
            _AgregarBtn.TabIndex = 3;
            _AgregarBtn.Text = "Nuevo Usuario";
            _AgregarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarTelBtn
            // 
            _EliminarTelBtn.Image = My.Resources.Resources.phone_delete;
            _EliminarTelBtn.Location = new Point(418, 22);
            _EliminarTelBtn.Name = "_EliminarTelBtn";
            _EliminarTelBtn.Size = new Size(145, 24);
            _EliminarTelBtn.TabIndex = 6;
            _EliminarTelBtn.Text = "Eliminar Telefono/s";
            _EliminarTelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarTelBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            _ModificarBtn.Image = My.Resources.Resources.pencil;
            _ModificarBtn.Location = new Point(132, 22);
            _ModificarBtn.Name = "_ModificarBtn";
            _ModificarBtn.Size = new Size(141, 24);
            _ModificarBtn.TabIndex = 4;
            _ModificarBtn.Text = "Modificar Usuario";
            _ModificarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            _EliminarBtn.Image = My.Resources.Resources.delete;
            _EliminarBtn.Location = new Point(279, 22);
            _EliminarBtn.Name = "_EliminarBtn";
            _EliminarBtn.Size = new Size(133, 24);
            _EliminarBtn.TabIndex = 5;
            _EliminarBtn.Text = "Eliminar Usuario";
            _EliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarCmb
            // 
            BuscarCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            BuscarCmb.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarCmb.FormattingEnabled = true;
            BuscarCmb.Location = new Point(117, 31);
            BuscarCmb.Name = "BuscarCmb";
            BuscarCmb.Size = new Size(121, 23);
            BuscarCmb.TabIndex = 0;
            // 
            // BuscarPorLbl
            // 
            BuscarPorLbl.AutoSize = true;
            BuscarPorLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarPorLbl.Location = new Point(32, 34);
            BuscarPorLbl.Name = "BuscarPorLbl";
            BuscarPorLbl.Size = new Size(67, 15);
            BuscarPorLbl.TabIndex = 41;
            BuscarPorLbl.Text = "Buscar por";
            // 
            // BusquedaTxt
            // 
            _BusquedaTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            _BusquedaTxt.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BusquedaTxt.Location = new Point(319, 31);
            _BusquedaTxt.Name = "_BusquedaTxt";
            _BusquedaTxt.Size = new Size(122, 23);
            _BusquedaTxt.TabIndex = 1;
            // 
            // IgualLbl
            // 
            IgualLbl.AutoSize = true;
            IgualLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IgualLbl.Location = new Point(256, 34);
            IgualLbl.Name = "IgualLbl";
            IgualLbl.Size = new Size(45, 15);
            IgualLbl.TabIndex = 43;
            IgualLbl.Text = "igual a";
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.Location = new Point(468, 27);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(88, 30);
            _BuscarBtn.TabIndex = 2;
            _BuscarBtn.Text = "&Buscar";
            _BuscarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // BGW
            // 
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
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(290, 543);
            _RecargarBtn.Margin = new Padding(15, 3, 15, 3);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(32, 24);
            _RecargarBtn.TabIndex = 8;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // SiguienteBtn
            // 
            _SiguienteBtn.Image = My.Resources.Resources.SiguienteE;
            _SiguienteBtn.Location = new Point(340, 543);
            _SiguienteBtn.Name = "_SiguienteBtn";
            _SiguienteBtn.Size = new Size(32, 24);
            _SiguienteBtn.TabIndex = 11;
            _SiguienteBtn.UseVisualStyleBackColor = true;
            // 
            // AnteriorBtn
            // 
            _AnteriorBtn.Image = My.Resources.Resources.AnteriorE;
            _AnteriorBtn.Location = new Point(240, 543);
            _AnteriorBtn.Name = "_AnteriorBtn";
            _AnteriorBtn.Size = new Size(32, 24);
            _AnteriorBtn.TabIndex = 10;
            _AnteriorBtn.UseVisualStyleBackColor = true;
            // 
            // UltimoBtn
            // 
            _UltimoBtn.Image = My.Resources.Resources.UltimoE;
            _UltimoBtn.Location = new Point(378, 543);
            _UltimoBtn.Name = "_UltimoBtn";
            _UltimoBtn.Size = new Size(32, 24);
            _UltimoBtn.TabIndex = 12;
            _UltimoBtn.UseVisualStyleBackColor = true;
            // 
            // PrimeroBtn
            // 
            _PrimeroBtn.Image = My.Resources.Resources.PrimeroE;
            _PrimeroBtn.Location = new Point(202, 543);
            _PrimeroBtn.Name = "_PrimeroBtn";
            _PrimeroBtn.Size = new Size(32, 24);
            _PrimeroBtn.TabIndex = 9;
            _PrimeroBtn.UseVisualStyleBackColor = true;
            // 
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // CodUsuCAB
            // 
            CodUsuCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CodUsuCAB.DataPropertyName = "CodUsu";
            CodUsuCAB.HeaderText = "Código";
            CodUsuCAB.Name = "CodUsuCAB";
            CodUsuCAB.ReadOnly = true;
            CodUsuCAB.Visible = false;
            CodUsuCAB.Width = 70;
            // 
            // UsuarioCAB
            // 
            UsuarioCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            UsuarioCAB.DataPropertyName = "Usuario";
            UsuarioCAB.HeaderText = "Usuario";
            UsuarioCAB.Name = "UsuarioCAB";
            UsuarioCAB.ReadOnly = true;
            // 
            // ApellidoCAB
            // 
            ApellidoCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ApellidoCAB.DataPropertyName = "Apellido";
            ApellidoCAB.HeaderText = "Apellido";
            ApellidoCAB.Name = "ApellidoCAB";
            ApellidoCAB.ReadOnly = true;
            // 
            // NombreCAB
            // 
            NombreCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreCAB.DataPropertyName = "Nombre";
            NombreCAB.HeaderText = "Nombre";
            NombreCAB.Name = "NombreCAB";
            NombreCAB.ReadOnly = true;
            NombreCAB.Width = 105;
            // 
            // CorreoCAB
            // 
            CorreoCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CorreoCAB.DataPropertyName = "CorreoElectronico";
            CorreoCAB.HeaderText = "Correo Electronico";
            CorreoCAB.Name = "CorreoCAB";
            CorreoCAB.ReadOnly = true;
            CorreoCAB.Width = 148;
            // 
            // EdadCAB
            // 
            EdadCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            EdadCAB.DataPropertyName = "Edad";
            EdadCAB.HeaderText = "Edad";
            EdadCAB.Name = "EdadCAB";
            EdadCAB.ReadOnly = true;
            EdadCAB.Width = 65;
            // 
            // GestionUsuario
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(612, 599);
            Controls.Add(_RecargarBtn);
            Controls.Add(_SiguienteBtn);
            Controls.Add(_AnteriorBtn);
            Controls.Add(_UltimoBtn);
            Controls.Add(_PrimeroBtn);
            Controls.Add(GestionUsuariosGB);
            Controls.Add(RegistrosGB);
            Controls.Add(SS);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(618, 628);
            MinimumSize = new Size(618, 628);
            Name = "GestionUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)UsuarioDG).EndInit();
            ExportarCMS.ResumeLayout(false);
            SS.ResumeLayout(false);
            SS.PerformLayout();
            RegistrosGB.ResumeLayout(false);
            GestionUsuariosGB.ResumeLayout(false);
            GestionUsuariosGB.PerformLayout();
            OperacionGB.ResumeLayout(false);
            Load += new EventHandler(GestionUsuario_Load);
            KeyDown += new KeyEventHandler(GestionUsuario_KeyDown);
            FormClosing += new FormClosingEventHandler(GestionUsuario_FormClosing);
            ResumeLayout(false);
            PerformLayout();
        }

        internal DataGridView UsuarioDG;
        internal StatusStrip SS;
        internal ToolStripStatusLabel Parte1Lbl;
        internal ToolStripStatusLabel InfoPagLbl;
        internal ToolStripStatusLabel Parte2Lbl;
        internal GroupBox RegistrosGB;
        internal GroupBox GestionUsuariosGB;
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

        private Button _EliminarTelBtn;

        internal Button EliminarTelBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EliminarTelBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EliminarTelBtn != null)
                {
                    _EliminarTelBtn.Click -= EliminarTelBtn_Click;
                }

                _EliminarTelBtn = value;
                if (_EliminarTelBtn != null)
                {
                    _EliminarTelBtn.Click += EliminarTelBtn_Click;
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

        internal ComboBox BuscarCmb;
        internal Label BuscarPorLbl;
        private TextBox _BusquedaTxt;

        internal TextBox BusquedaTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BusquedaTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BusquedaTxt != null)
                {
                    _BusquedaTxt.TextChanged -= BusquedaTxt_TextChanged;
                }

                _BusquedaTxt = value;
                if (_BusquedaTxt != null)
                {
                    _BusquedaTxt.TextChanged += BusquedaTxt_TextChanged;
                }
            }
        }

        internal Label IgualLbl;
        private Button _BuscarBtn;

        internal Button BuscarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarBtn != null)
                {
                    _BuscarBtn.Click -= BuscarBtn_Click;
                }

                _BuscarBtn = value;
                if (_BuscarBtn != null)
                {
                    _BuscarBtn.Click += BuscarBtn_Click;
                }
            }
        }

        private System.ComponentModel.BackgroundWorker _BGW;

        internal System.ComponentModel.BackgroundWorker BGW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BGW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BGW != null)
                {
                    _BGW.DoWork -= BGW_DoWork;
                    _BGW.ProgressChanged -= BGW_ProgressChanged;
                    _BGW.RunWorkerCompleted -= BGW_RunWorkerCompleted;
                }

                _BGW = value;
                if (_BGW != null)
                {
                    _BGW.DoWork += BGW_DoWork;
                    _BGW.ProgressChanged += BGW_ProgressChanged;
                    _BGW.RunWorkerCompleted += BGW_RunWorkerCompleted;
                }
            }
        }

        internal ContextMenuStrip ExportarCMS;
        private ToolStripMenuItem _ExportarAXLSToolStripMenuItem;

        internal ToolStripMenuItem ExportarAXLSToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExportarAXLSToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExportarAXLSToolStripMenuItem != null)
                {
                    _ExportarAXLSToolStripMenuItem.Click -= ExportarAXLSToolStripMenuItem_Click;
                }

                _ExportarAXLSToolStripMenuItem = value;
                if (_ExportarAXLSToolStripMenuItem != null)
                {
                    _ExportarAXLSToolStripMenuItem.Click += ExportarAXLSToolStripMenuItem_Click;
                }
            }
        }

        internal ToolTip ControlesTP;
        private Button _RecargarBtn;

        internal Button RecargarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecargarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecargarBtn != null)
                {
                    _RecargarBtn.Click -= RecargarBtn_Click;
                }

                _RecargarBtn = value;
                if (_RecargarBtn != null)
                {
                    _RecargarBtn.Click += RecargarBtn_Click;
                }
            }
        }

        private Button _SiguienteBtn;

        internal Button SiguienteBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SiguienteBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SiguienteBtn != null)
                {
                    _SiguienteBtn.Click -= SiguienteBtn_Click;
                }

                _SiguienteBtn = value;
                if (_SiguienteBtn != null)
                {
                    _SiguienteBtn.Click += SiguienteBtn_Click;
                }
            }
        }

        private Button _AnteriorBtn;

        internal Button AnteriorBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AnteriorBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AnteriorBtn != null)
                {
                    _AnteriorBtn.Click -= AnteriorBtn_Click;
                }

                _AnteriorBtn = value;
                if (_AnteriorBtn != null)
                {
                    _AnteriorBtn.Click += AnteriorBtn_Click;
                }
            }
        }

        private Button _UltimoBtn;

        internal Button UltimoBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UltimoBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UltimoBtn != null)
                {
                    _UltimoBtn.Click -= UltimoBtn_Click;
                }

                _UltimoBtn = value;
                if (_UltimoBtn != null)
                {
                    _UltimoBtn.Click += UltimoBtn_Click;
                }
            }
        }

        private Button _PrimeroBtn;

        internal Button PrimeroBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrimeroBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrimeroBtn != null)
                {
                    _PrimeroBtn.Click -= PrimeroBtn_Click;
                }

                _PrimeroBtn = value;
                if (_PrimeroBtn != null)
                {
                    _PrimeroBtn.Click += PrimeroBtn_Click;
                }
            }
        }

        internal ToolTip MensajeTT;
        internal DataGridViewTextBoxColumn CodUsuCAB;
        internal DataGridViewTextBoxColumn UsuarioCAB;
        internal DataGridViewTextBoxColumn ApellidoCAB;
        internal DataGridViewTextBoxColumn NombreCAB;
        internal DataGridViewTextBoxColumn CorreoCAB;
        internal DataGridViewTextBoxColumn EdadCAB;
    }
}