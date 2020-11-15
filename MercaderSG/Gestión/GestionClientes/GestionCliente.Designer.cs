using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class GestionCliente : Form
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
            _BusquedaTxt = new TextBox();
            _BusquedaTxt.TextChanged += new EventHandler(BusquedaTxt_TextChanged);
            IgualLbl = new Label();
            _BuscarCmb = new ComboBox();
            _BuscarCmb.SelectedIndexChanged += new EventHandler(BuscarCmb_SelectedIndexChanged);
            BuscarPorLbl = new Label();
            _ClienteDG = new DataGridView();
            _ClienteDG.CellContentClick += new DataGridViewCellEventHandler(ClienteDG_CellContentClick);
            CodCliCAB = new DataGridViewTextBoxColumn();
            RazonSocialCAB = new DataGridViewTextBoxColumn();
            CuitCAB = new DataGridViewTextBoxColumn();
            DireccionCAB = new DataGridViewTextBoxColumn();
            LocalidadCAB = new DataGridViewTextBoxColumn();
            ExportarCMS = new ContextMenuStrip(components);
            _ExportarAXLSToolStripMenuItem = new ToolStripMenuItem();
            _ExportarAXLSToolStripMenuItem.Click += new EventHandler(ExportarAXLSToolStripMenuItem_Click);
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            GestionClientesGB = new GroupBox();
            _OperacionGB = new GroupBox();
            _OperacionGB.Enter += new EventHandler(OperacionGB_Enter);
            _AgregarBtn = new Button();
            _AgregarBtn.Click += new EventHandler(AgregarBtn_Click);
            _EliminarTelBtn = new Button();
            _EliminarTelBtn.Click += new EventHandler(EliminarTelBtn_Click);
            _ModificarBtn = new Button();
            _ModificarBtn.Click += new EventHandler(ModificarBtn_Click);
            _EliminarBtn = new Button();
            _EliminarBtn.Click += new EventHandler(EliminarBtn_Click);
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            RegistrosGB = new GroupBox();
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            SS = new StatusStrip();
            Parte1Lbl = new ToolStripStatusLabel();
            InfoPagLbl = new ToolStripStatusLabel();
            Parte2Lbl = new ToolStripStatusLabel();
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
            ((System.ComponentModel.ISupportInitialize)_ClienteDG).BeginInit();
            ExportarCMS.SuspendLayout();
            GestionClientesGB.SuspendLayout();
            _OperacionGB.SuspendLayout();
            RegistrosGB.SuspendLayout();
            SS.SuspendLayout();
            SuspendLayout();
            // 
            // BusquedaTxt
            // 
            _BusquedaTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            _BusquedaTxt.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BusquedaTxt.Location = new Point(313, 31);
            _BusquedaTxt.Name = "_BusquedaTxt";
            _BusquedaTxt.Size = new Size(122, 23);
            _BusquedaTxt.TabIndex = 2;
            // 
            // IgualLbl
            // 
            IgualLbl.AutoSize = true;
            IgualLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IgualLbl.Location = new Point(250, 34);
            IgualLbl.Name = "IgualLbl";
            IgualLbl.Size = new Size(45, 15);
            IgualLbl.TabIndex = 43;
            IgualLbl.Text = "igual a";
            // 
            // BuscarCmb
            // 
            _BuscarCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            _BuscarCmb.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarCmb.FormattingEnabled = true;
            _BuscarCmb.Location = new Point(111, 31);
            _BuscarCmb.Name = "_BuscarCmb";
            _BuscarCmb.Size = new Size(121, 23);
            _BuscarCmb.TabIndex = 1;
            // 
            // BuscarPorLbl
            // 
            BuscarPorLbl.AutoSize = true;
            BuscarPorLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarPorLbl.Location = new Point(26, 34);
            BuscarPorLbl.Name = "BuscarPorLbl";
            BuscarPorLbl.Size = new Size(67, 15);
            BuscarPorLbl.TabIndex = 41;
            BuscarPorLbl.Text = "Buscar por";
            // 
            // ClienteDG
            // 
            _ClienteDG.AllowUserToAddRows = false;
            _ClienteDG.AllowUserToDeleteRows = false;
            _ClienteDG.AllowUserToResizeColumns = false;
            _ClienteDG.AllowUserToResizeRows = false;
            _ClienteDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _ClienteDG.Columns.AddRange(new DataGridViewColumn[] { CodCliCAB, RazonSocialCAB, CuitCAB, DireccionCAB, LocalidadCAB });
            _ClienteDG.ContextMenuStrip = ExportarCMS;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            _ClienteDG.DefaultCellStyle = DataGridViewCellStyle1;
            _ClienteDG.Dock = DockStyle.Fill;
            _ClienteDG.Location = new Point(3, 19);
            _ClienteDG.MultiSelect = false;
            _ClienteDG.Name = "_ClienteDG";
            _ClienteDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _ClienteDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            _ClienteDG.ScrollBars = ScrollBars.Vertical;
            _ClienteDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ClienteDG.Size = new Size(570, 348);
            _ClienteDG.StandardTab = true;
            _ClienteDG.TabIndex = 10;
            // 
            // CodCliCAB
            // 
            CodCliCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CodCliCAB.DataPropertyName = "CodCli";
            CodCliCAB.HeaderText = "Código";
            CodCliCAB.Name = "CodCliCAB";
            CodCliCAB.ReadOnly = true;
            CodCliCAB.Visible = false;
            CodCliCAB.Width = 87;
            // 
            // RazonSocialCAB
            // 
            RazonSocialCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RazonSocialCAB.DataPropertyName = "RazonSocial";
            RazonSocialCAB.HeaderText = "Razon Social";
            RazonSocialCAB.Name = "RazonSocialCAB";
            RazonSocialCAB.ReadOnly = true;
            RazonSocialCAB.Width = 125;
            // 
            // CuitCAB
            // 
            CuitCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CuitCAB.DataPropertyName = "Cuit";
            CuitCAB.HeaderText = "CUIT";
            CuitCAB.Name = "CuitCAB";
            CuitCAB.ReadOnly = true;
            CuitCAB.Width = 130;
            // 
            // DireccionCAB
            // 
            DireccionCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DireccionCAB.DataPropertyName = "Direccion";
            DireccionCAB.HeaderText = "Dirección";
            DireccionCAB.Name = "DireccionCAB";
            DireccionCAB.ReadOnly = true;
            DireccionCAB.Width = 137;
            // 
            // LocalidadCAB
            // 
            LocalidadCAB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LocalidadCAB.DataPropertyName = "Localidad";
            LocalidadCAB.HeaderText = "Localidad";
            LocalidadCAB.Name = "LocalidadCAB";
            LocalidadCAB.ReadOnly = true;
            LocalidadCAB.Width = 117;
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
            _ExportarAXLSToolStripMenuItem.Name = "_Exportar";
            _ExportarAXLSToolStripMenuItem.Size = new Size(148, 22);
            _ExportarAXLSToolStripMenuItem.Text = "Exportar";
            // 
            // BGW
            // 
            // 
            // GestionClientesGB
            // 
            GestionClientesGB.Controls.Add(_OperacionGB);
            GestionClientesGB.Controls.Add(_BuscarCmb);
            GestionClientesGB.Controls.Add(BuscarPorLbl);
            GestionClientesGB.Controls.Add(_BusquedaTxt);
            GestionClientesGB.Controls.Add(IgualLbl);
            GestionClientesGB.Controls.Add(_BuscarBtn);
            GestionClientesGB.Location = new Point(12, 12);
            GestionClientesGB.Name = "GestionClientesGB";
            GestionClientesGB.Size = new Size(576, 141);
            GestionClientesGB.TabIndex = 0;
            GestionClientesGB.TabStop = false;
            GestionClientesGB.Text = "Gestion de Clientes";
            // 
            // OperacionGB
            // 
            _OperacionGB.Controls.Add(_AgregarBtn);
            _OperacionGB.Controls.Add(_EliminarTelBtn);
            _OperacionGB.Controls.Add(_ModificarBtn);
            _OperacionGB.Controls.Add(_EliminarBtn);
            _OperacionGB.Location = new Point(13, 66);
            _OperacionGB.Name = "_OperacionGB";
            _OperacionGB.Size = new Size(553, 61);
            _OperacionGB.TabIndex = 4;
            _OperacionGB.TabStop = false;
            _OperacionGB.Text = "Operaciones";
            // 
            // AgregarBtn
            // 
            _AgregarBtn.Image = My.Resources.Resources.add;
            _AgregarBtn.Location = new Point(13, 22);
            _AgregarBtn.Name = "_AgregarBtn";
            _AgregarBtn.Size = new Size(110, 24);
            _AgregarBtn.TabIndex = 5;
            _AgregarBtn.Text = "Nuevo Cliente";
            _AgregarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarTelBtn
            // 
            _EliminarTelBtn.Image = My.Resources.Resources.phone_delete;
            _EliminarTelBtn.Location = new Point(394, 22);
            _EliminarTelBtn.Name = "_EliminarTelBtn";
            _EliminarTelBtn.Size = new Size(145, 24);
            _EliminarTelBtn.TabIndex = 8;
            _EliminarTelBtn.Text = "Eliminar Telefono/s";
            _EliminarTelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarTelBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            _ModificarBtn.Image = My.Resources.Resources.pencil;
            _ModificarBtn.Location = new Point(129, 22);
            _ModificarBtn.Name = "_ModificarBtn";
            _ModificarBtn.Size = new Size(131, 24);
            _ModificarBtn.TabIndex = 6;
            _ModificarBtn.Text = "Modificar Cliente";
            _ModificarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            _EliminarBtn.Image = My.Resources.Resources.delete;
            _EliminarBtn.Location = new Point(266, 22);
            _EliminarBtn.Name = "_EliminarBtn";
            _EliminarBtn.Size = new Size(122, 24);
            _EliminarBtn.TabIndex = 7;
            _EliminarBtn.Text = "Eliminar Cliente";
            _EliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.Location = new Point(462, 27);
            _BuscarBtn.Name = "_BuscarBtn";
            _BuscarBtn.Size = new Size(88, 30);
            _BuscarBtn.TabIndex = 3;
            _BuscarBtn.Text = "&Buscar";
            _BuscarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrosGB
            // 
            RegistrosGB.Controls.Add(_ClienteDG);
            RegistrosGB.ForeColor = SystemColors.ControlText;
            RegistrosGB.Location = new Point(12, 159);
            RegistrosGB.Name = "RegistrosGB";
            RegistrosGB.Size = new Size(576, 370);
            RegistrosGB.TabIndex = 9;
            RegistrosGB.TabStop = false;
            RegistrosGB.Text = "Registros";
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
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // SS
            // 
            SS.Items.AddRange(new ToolStripItem[] { Parte1Lbl, InfoPagLbl, Parte2Lbl });
            SS.Location = new Point(0, 567);
            SS.Name = "SS";
            SS.RightToLeft = RightToLeft.No;
            SS.Size = new Size(591, 22);
            SS.TabIndex = 63;
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
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(284, 540);
            _RecargarBtn.Margin = new Padding(15, 11, 15, 11);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(32, 24);
            _RecargarBtn.TabIndex = 11;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // SiguienteBtn
            // 
            _SiguienteBtn.Image = My.Resources.Resources.SiguienteE;
            _SiguienteBtn.Location = new Point(334, 540);
            _SiguienteBtn.Margin = new Padding(3, 11, 3, 11);
            _SiguienteBtn.Name = "_SiguienteBtn";
            _SiguienteBtn.Size = new Size(32, 24);
            _SiguienteBtn.TabIndex = 14;
            _SiguienteBtn.UseVisualStyleBackColor = true;
            // 
            // AnteriorBtn
            // 
            _AnteriorBtn.Image = My.Resources.Resources.AnteriorE;
            _AnteriorBtn.Location = new Point(234, 540);
            _AnteriorBtn.Margin = new Padding(3, 11, 3, 11);
            _AnteriorBtn.Name = "_AnteriorBtn";
            _AnteriorBtn.Size = new Size(32, 24);
            _AnteriorBtn.TabIndex = 13;
            _AnteriorBtn.UseVisualStyleBackColor = true;
            // 
            // UltimoBtn
            // 
            _UltimoBtn.Image = My.Resources.Resources.UltimoE;
            _UltimoBtn.Location = new Point(372, 540);
            _UltimoBtn.Margin = new Padding(3, 11, 3, 11);
            _UltimoBtn.Name = "_UltimoBtn";
            _UltimoBtn.Size = new Size(32, 24);
            _UltimoBtn.TabIndex = 15;
            _UltimoBtn.UseVisualStyleBackColor = true;
            // 
            // PrimeroBtn
            // 
            _PrimeroBtn.Image = My.Resources.Resources.PrimeroE;
            _PrimeroBtn.Location = new Point(196, 540);
            _PrimeroBtn.Margin = new Padding(3, 11, 3, 11);
            _PrimeroBtn.Name = "_PrimeroBtn";
            _PrimeroBtn.Size = new Size(32, 24);
            _PrimeroBtn.TabIndex = 12;
            _PrimeroBtn.UseVisualStyleBackColor = true;
            // 
            // GestionCliente
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(591, 589);
            Controls.Add(SS);
            Controls.Add(_RecargarBtn);
            Controls.Add(RegistrosGB);
            Controls.Add(_SiguienteBtn);
            Controls.Add(GestionClientesGB);
            Controls.Add(_AnteriorBtn);
            Controls.Add(_UltimoBtn);
            Controls.Add(_PrimeroBtn);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(607, 628);
            MinimumSize = new Size(607, 628);
            Name = "GestionCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Clientes - MercaderSG";
            ((System.ComponentModel.ISupportInitialize)_ClienteDG).EndInit();
            ExportarCMS.ResumeLayout(false);
            GestionClientesGB.ResumeLayout(false);
            GestionClientesGB.PerformLayout();
            _OperacionGB.ResumeLayout(false);
            RegistrosGB.ResumeLayout(false);
            SS.ResumeLayout(false);
            SS.PerformLayout();
            Load += new EventHandler(GestionCliente_Load);
            FormClosing += new FormClosingEventHandler(GestionCliente_FormClosing);
            KeyDown += new KeyEventHandler(GestionCliente_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

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
        private ComboBox _BuscarCmb;

        internal ComboBox BuscarCmb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarCmb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarCmb != null)
                {
                    _BuscarCmb.SelectedIndexChanged -= BuscarCmb_SelectedIndexChanged;
                }

                _BuscarCmb = value;
                if (_BuscarCmb != null)
                {
                    _BuscarCmb.SelectedIndexChanged += BuscarCmb_SelectedIndexChanged;
                }
            }
        }

        internal Label BuscarPorLbl;
        private DataGridView _ClienteDG;

        internal DataGridView ClienteDG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ClienteDG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ClienteDG != null)
                {
                    _ClienteDG.CellContentClick -= ClienteDG_CellContentClick;
                }

                _ClienteDG = value;
                if (_ClienteDG != null)
                {
                    _ClienteDG.CellContentClick += ClienteDG_CellContentClick;
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

        internal GroupBox GestionClientesGB;
        private GroupBox _OperacionGB;

        internal GroupBox OperacionGB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OperacionGB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OperacionGB != null)
                {
                    _OperacionGB.Enter -= OperacionGB_Enter;
                }

                _OperacionGB = value;
                if (_OperacionGB != null)
                {
                    _OperacionGB.Enter += OperacionGB_Enter;
                }
            }
        }

        internal GroupBox RegistrosGB;
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
        internal ToolTip MensajeTT;
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

        internal StatusStrip SS;
        internal ToolStripStatusLabel Parte1Lbl;
        internal ToolStripStatusLabel InfoPagLbl;
        internal ToolStripStatusLabel Parte2Lbl;
        internal DataGridViewTextBoxColumn CodCliCAB;
        internal DataGridViewTextBoxColumn RazonSocialCAB;
        internal DataGridViewTextBoxColumn CuitCAB;
        internal DataGridViewTextBoxColumn DireccionCAB;
        internal DataGridViewTextBoxColumn LocalidadCAB;
    }
}