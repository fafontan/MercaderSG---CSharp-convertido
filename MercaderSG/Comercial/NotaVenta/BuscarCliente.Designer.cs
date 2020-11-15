using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class BuscarCliente : Form
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
            ClienteGB = new GroupBox();
            _ClienteDG = new DataGridView();
            _ClienteDG.CellDoubleClick += new DataGridViewCellEventHandler(ClienteDG_CellDoubleClick);
            _ClienteDG.KeyDown += new KeyEventHandler(ClienteDG_KeyDown);
            CodCliCAB = new DataGridViewTextBoxColumn();
            RazonSocialCAB = new DataGridViewTextBoxColumn();
            CuitCAB = new DataGridViewTextBoxColumn();
            DireccionCAB = new DataGridViewTextBoxColumn();
            LocalidadCAB = new DataGridViewTextBoxColumn();
            _RecargarBtn = new Button();
            _RecargarBtn.Click += new EventHandler(RecargarBtn_Click);
            BuscarCmb = new ComboBox();
            BuscarPorLbl = new Label();
            BusquedaTxt = new TextBox();
            IgualLbl = new Label();
            _BuscarBtn = new Button();
            _BuscarBtn.Click += new EventHandler(BuscarBtn_Click);
            _BGW = new System.ComponentModel.BackgroundWorker();
            _BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(BGW_DoWork);
            _BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BGW_ProgressChanged);
            _BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            ClienteGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ClienteDG).BeginInit();
            SuspendLayout();
            // 
            // ClienteGB
            // 
            ClienteGB.Controls.Add(_ClienteDG);
            ClienteGB.Controls.Add(_RecargarBtn);
            ClienteGB.Controls.Add(BuscarCmb);
            ClienteGB.Controls.Add(BuscarPorLbl);
            ClienteGB.Controls.Add(BusquedaTxt);
            ClienteGB.Controls.Add(IgualLbl);
            ClienteGB.Controls.Add(_BuscarBtn);
            ClienteGB.Location = new Point(12, 12);
            ClienteGB.Name = "ClienteGB";
            ClienteGB.Size = new Size(580, 272);
            ClienteGB.TabIndex = 52;
            ClienteGB.TabStop = false;
            ClienteGB.Text = "Seleccionar Cliente";
            // 
            // ClienteDG
            // 
            _ClienteDG.AllowUserToAddRows = false;
            _ClienteDG.AllowUserToDeleteRows = false;
            _ClienteDG.AllowUserToResizeColumns = false;
            _ClienteDG.AllowUserToResizeRows = false;
            _ClienteDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _ClienteDG.Columns.AddRange(new DataGridViewColumn[] { CodCliCAB, RazonSocialCAB, CuitCAB, DireccionCAB, LocalidadCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            _ClienteDG.DefaultCellStyle = DataGridViewCellStyle1;
            _ClienteDG.Dock = DockStyle.Bottom;
            _ClienteDG.Location = new Point(3, 78);
            _ClienteDG.MultiSelect = false;
            _ClienteDG.Name = "_ClienteDG";
            _ClienteDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _ClienteDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            _ClienteDG.ScrollBars = ScrollBars.Vertical;
            _ClienteDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ClienteDG.Size = new Size(574, 191);
            _ClienteDG.StandardTab = true;
            _ClienteDG.TabIndex = 55;
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
            // RecargarBtn
            // 
            _RecargarBtn.Image = My.Resources.Resources.RecargarE;
            _RecargarBtn.Location = new Point(518, 25);
            _RecargarBtn.Margin = new Padding(15, 3, 15, 3);
            _RecargarBtn.Name = "_RecargarBtn";
            _RecargarBtn.Size = new Size(44, 28);
            _RecargarBtn.TabIndex = 3;
            _RecargarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarCmb
            // 
            BuscarCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            BuscarCmb.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarCmb.FormattingEnabled = true;
            BuscarCmb.Location = new Point(92, 29);
            BuscarCmb.Name = "BuscarCmb";
            BuscarCmb.Size = new Size(121, 23);
            BuscarCmb.TabIndex = 0;
            // 
            // BuscarPorLbl
            // 
            BuscarPorLbl.AutoSize = true;
            BuscarPorLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BuscarPorLbl.Location = new Point(19, 32);
            BuscarPorLbl.Name = "BuscarPorLbl";
            BuscarPorLbl.Size = new Size(67, 15);
            BuscarPorLbl.TabIndex = 52;
            BuscarPorLbl.Text = "Buscar por";
            // 
            // BusquedaTxt
            // 
            BusquedaTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            BusquedaTxt.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BusquedaTxt.Location = new Point(270, 29);
            BusquedaTxt.Name = "BusquedaTxt";
            BusquedaTxt.Size = new Size(122, 23);
            BusquedaTxt.TabIndex = 1;
            // 
            // IgualLbl
            // 
            IgualLbl.AutoSize = true;
            IgualLbl.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IgualLbl.Location = new Point(219, 32);
            IgualLbl.Name = "IgualLbl";
            IgualLbl.Size = new Size(45, 15);
            IgualLbl.TabIndex = 54;
            IgualLbl.Text = "igual a";
            // 
            // BuscarBtn
            // 
            _BuscarBtn.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BuscarBtn.Image = My.Resources.Resources.BuscarE;
            _BuscarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            _BuscarBtn.Location = new Point(412, 24);
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
            // MensajeTT
            // 
            MensajeTT.AutomaticDelay = 100;
            MensajeTT.AutoPopDelay = 5000;
            MensajeTT.InitialDelay = 1000;
            MensajeTT.ReshowDelay = 500;
            MensajeTT.ToolTipIcon = ToolTipIcon.Warning;
            MensajeTT.ToolTipTitle = "MercaderSG";
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(604, 296);
            Controls.Add(ClienteGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximumSize = new Size(610, 325);
            MinimizeBox = false;
            MinimumSize = new Size(610, 325);
            Name = "BuscarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            ClienteGB.ResumeLayout(false);
            ClienteGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_ClienteDG).EndInit();
            Load += new EventHandler(BuscarCliente_Load);
            KeyDown += new KeyEventHandler(BuscarCliente_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox ClienteGB;
        internal ComboBox BuscarCmb;
        internal Label BuscarPorLbl;
        internal TextBox BusquedaTxt;
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

        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
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
                    _ClienteDG.CellDoubleClick -= ClienteDG_CellDoubleClick;
                    _ClienteDG.KeyDown -= ClienteDG_KeyDown;
                }

                _ClienteDG = value;
                if (_ClienteDG != null)
                {
                    _ClienteDG.CellDoubleClick += ClienteDG_CellDoubleClick;
                    _ClienteDG.KeyDown += ClienteDG_KeyDown;
                }
            }
        }

        internal DataGridViewTextBoxColumn CodCliCAB;
        internal DataGridViewTextBoxColumn RazonSocialCAB;
        internal DataGridViewTextBoxColumn CuitCAB;
        internal DataGridViewTextBoxColumn DireccionCAB;
        internal DataGridViewTextBoxColumn LocalidadCAB;
    }
}