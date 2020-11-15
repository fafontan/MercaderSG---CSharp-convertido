using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MercaderSG
{
    [DesignerGenerated()]
    public partial class NotaPedido : Form
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
            ProveedorGB = new GroupBox();
            EstadoCB = new CheckBox();
            FechaDTP = new DateTimePicker();
            FechaEmiLbl = new Label();
            ActivoLbl = new Label();
            DireccionLbl = new Label();
            DireccionTxt = new TextBox();
            CuitTxt = new TextBox();
            CuitLbl = new Label();
            RazonSocialTxt = new TextBox();
            RazonSocialLbl = new Label();
            _BuscarCliBtn = new Button();
            _BuscarCliBtn.Click += new EventHandler(BuscarCliBtn_Click);
            CodProvTxt = new TextBox();
            CodProvLbl = new Label();
            ProductoGB = new GroupBox();
            PrecioTxt = new TextBox();
            CantidadTxt = new TextBox();
            CantidadLbl = new Label();
            PrecioLbl = new Label();
            DescProdTxt = new TextBox();
            DescProdLbl = new Label();
            NombreProdTxt = new TextBox();
            NombreProdLbl = new Label();
            _BuscarProdBtn = new Button();
            _BuscarProdBtn.Click += new EventHandler(BuscarProdBtn_Click);
            CodProdTxt = new TextBox();
            CodProdLbl = new Label();
            NotaVentaGB = new GroupBox();
            _GenerarBtn = new Button();
            _GenerarBtn.Click += new EventHandler(GenerarBtn_Click);
            DetalleDG = new DataGridView();
            CodProdCAB = new DataGridViewTextBoxColumn();
            NombreCAB = new DataGridViewTextBoxColumn();
            PrecioCAB = new DataGridViewTextBoxColumn();
            CantidadCAB = new DataGridViewTextBoxColumn();
            _NuevoBtn = new Button();
            _NuevoBtn.Click += new EventHandler(NuevoBtn_Click);
            _EliminarBtn = new Button();
            _EliminarBtn.Click += new EventHandler(EliminarBtn_Click);
            TotalTxt = new TextBox();
            _AgregarBtn = new Button();
            _AgregarBtn.Click += new EventHandler(AgregarBtn_Click);
            TotalLbl = new Label();
            ControlesTP = new ToolTip(components);
            MensajeTT = new ToolTip(components);
            ProveedorGB.SuspendLayout();
            ProductoGB.SuspendLayout();
            NotaVentaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DetalleDG).BeginInit();
            SuspendLayout();
            // 
            // ProveedorGB
            // 
            ProveedorGB.Controls.Add(EstadoCB);
            ProveedorGB.Controls.Add(FechaDTP);
            ProveedorGB.Controls.Add(FechaEmiLbl);
            ProveedorGB.Controls.Add(ActivoLbl);
            ProveedorGB.Controls.Add(DireccionLbl);
            ProveedorGB.Controls.Add(DireccionTxt);
            ProveedorGB.Controls.Add(CuitTxt);
            ProveedorGB.Controls.Add(CuitLbl);
            ProveedorGB.Controls.Add(RazonSocialTxt);
            ProveedorGB.Controls.Add(RazonSocialLbl);
            ProveedorGB.Controls.Add(_BuscarCliBtn);
            ProveedorGB.Controls.Add(CodProvTxt);
            ProveedorGB.Controls.Add(CodProvLbl);
            ProveedorGB.Location = new Point(12, 12);
            ProveedorGB.Name = "ProveedorGB";
            ProveedorGB.Size = new Size(630, 124);
            ProveedorGB.TabIndex = 12;
            ProveedorGB.TabStop = false;
            ProveedorGB.Text = "Datos Proveedor";
            // 
            // EstadoCB
            // 
            EstadoCB.AutoCheck = false;
            EstadoCB.AutoSize = true;
            EstadoCB.FlatStyle = FlatStyle.Flat;
            EstadoCB.ForeColor = Color.SteelBlue;
            EstadoCB.Location = new Point(469, 36);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(12, 11);
            EstadoCB.TabIndex = 5;
            EstadoCB.UseVisualStyleBackColor = true;
            // 
            // FechaDTP
            // 
            FechaDTP.Format = DateTimePickerFormat.Short;
            FechaDTP.Location = new Point(522, 74);
            FechaDTP.Name = "FechaDTP";
            FechaDTP.Size = new Size(90, 23);
            FechaDTP.TabIndex = 6;
            // 
            // FechaEmiLbl
            // 
            FechaEmiLbl.AutoSize = true;
            FechaEmiLbl.Location = new Point(417, 77);
            FechaEmiLbl.Name = "FechaEmiLbl";
            FechaEmiLbl.Size = new Size(86, 15);
            FechaEmiLbl.TabIndex = 11;
            FechaEmiLbl.Text = "Fecha Emision";
            // 
            // ActivoLbl
            // 
            ActivoLbl.AutoSize = true;
            ActivoLbl.Location = new Point(417, 34);
            ActivoLbl.Name = "ActivoLbl";
            ActivoLbl.Size = new Size(44, 15);
            ActivoLbl.TabIndex = 13;
            ActivoLbl.Text = "Estado";
            // 
            // DireccionLbl
            // 
            DireccionLbl.AutoSize = true;
            DireccionLbl.Location = new Point(204, 32);
            DireccionLbl.Name = "DireccionLbl";
            DireccionLbl.Size = new Size(60, 15);
            DireccionLbl.TabIndex = 10;
            DireccionLbl.Text = "Direccion";
            // 
            // DireccionTxt
            // 
            DireccionTxt.Location = new Point(297, 29);
            DireccionTxt.Name = "DireccionTxt";
            DireccionTxt.ReadOnly = true;
            DireccionTxt.Size = new Size(100, 23);
            DireccionTxt.TabIndex = 3;
            // 
            // CuitTxt
            // 
            CuitTxt.Location = new Point(80, 74);
            CuitTxt.Name = "CuitTxt";
            CuitTxt.ReadOnly = true;
            CuitTxt.Size = new Size(100, 23);
            CuitTxt.TabIndex = 2;
            // 
            // CuitLbl
            // 
            CuitLbl.AutoSize = true;
            CuitLbl.Location = new Point(19, 77);
            CuitLbl.Name = "CuitLbl";
            CuitLbl.Size = new Size(32, 15);
            CuitLbl.TabIndex = 5;
            CuitLbl.Text = "CUIT";
            // 
            // RazonSocialTxt
            // 
            RazonSocialTxt.Location = new Point(297, 74);
            RazonSocialTxt.Name = "RazonSocialTxt";
            RazonSocialTxt.ReadOnly = true;
            RazonSocialTxt.Size = new Size(100, 23);
            RazonSocialTxt.TabIndex = 4;
            // 
            // RazonSocialLbl
            // 
            RazonSocialLbl.AutoSize = true;
            RazonSocialLbl.Location = new Point(204, 77);
            RazonSocialLbl.Name = "RazonSocialLbl";
            RazonSocialLbl.Size = new Size(77, 15);
            RazonSocialLbl.TabIndex = 3;
            RazonSocialLbl.Text = "Razon Social";
            // 
            // BuscarCliBtn
            // 
            _BuscarCliBtn.Image = My.Resources.Resources.search;
            _BuscarCliBtn.Location = new Point(144, 29);
            _BuscarCliBtn.Name = "_BuscarCliBtn";
            _BuscarCliBtn.Size = new Size(36, 23);
            _BuscarCliBtn.TabIndex = 1;
            _BuscarCliBtn.UseVisualStyleBackColor = true;
            // 
            // CodProvTxt
            // 
            CodProvTxt.Location = new Point(80, 29);
            CodProvTxt.Name = "CodProvTxt";
            CodProvTxt.ReadOnly = true;
            CodProvTxt.Size = new Size(58, 23);
            CodProvTxt.TabIndex = 0;
            // 
            // CodProvLbl
            // 
            CodProvLbl.AutoSize = true;
            CodProvLbl.Location = new Point(19, 32);
            CodProvLbl.Name = "CodProvLbl";
            CodProvLbl.Size = new Size(45, 15);
            CodProvLbl.TabIndex = 0;
            CodProvLbl.Text = "Codigo";
            // 
            // ProductoGB
            // 
            ProductoGB.Controls.Add(PrecioTxt);
            ProductoGB.Controls.Add(CantidadTxt);
            ProductoGB.Controls.Add(CantidadLbl);
            ProductoGB.Controls.Add(PrecioLbl);
            ProductoGB.Controls.Add(DescProdTxt);
            ProductoGB.Controls.Add(DescProdLbl);
            ProductoGB.Controls.Add(NombreProdTxt);
            ProductoGB.Controls.Add(NombreProdLbl);
            ProductoGB.Controls.Add(_BuscarProdBtn);
            ProductoGB.Controls.Add(CodProdTxt);
            ProductoGB.Controls.Add(CodProdLbl);
            ProductoGB.Location = new Point(12, 142);
            ProductoGB.Name = "ProductoGB";
            ProductoGB.Size = new Size(630, 118);
            ProductoGB.TabIndex = 15;
            ProductoGB.TabStop = false;
            ProductoGB.Text = "Datos Producto";
            // 
            // PrecioTxt
            // 
            PrecioTxt.Location = new Point(544, 28);
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.ReadOnly = true;
            PrecioTxt.Size = new Size(68, 23);
            PrecioTxt.TabIndex = 11;
            // 
            // CantidadTxt
            // 
            CantidadTxt.Location = new Point(544, 75);
            CantidadTxt.Name = "CantidadTxt";
            CantidadTxt.Size = new Size(68, 23);
            CantidadTxt.TabIndex = 12;
            // 
            // CantidadLbl
            // 
            CantidadLbl.AutoSize = true;
            CantidadLbl.Location = new Point(482, 78);
            CantidadLbl.Name = "CantidadLbl";
            CantidadLbl.Size = new Size(56, 15);
            CantidadLbl.TabIndex = 13;
            CantidadLbl.Text = "Cantidad";
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Location = new Point(482, 33);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(42, 15);
            PrecioLbl.TabIndex = 12;
            PrecioLbl.Text = "Precio";
            // 
            // DescProdTxt
            // 
            DescProdTxt.Location = new Point(287, 31);
            DescProdTxt.Multiline = true;
            DescProdTxt.Name = "DescProdTxt";
            DescProdTxt.ReadOnly = true;
            DescProdTxt.Size = new Size(158, 68);
            DescProdTxt.TabIndex = 10;
            // 
            // DescProdLbl
            // 
            DescProdLbl.AutoSize = true;
            DescProdLbl.Location = new Point(208, 32);
            DescProdLbl.Name = "DescProdLbl";
            DescProdLbl.Size = new Size(73, 15);
            DescProdLbl.TabIndex = 10;
            DescProdLbl.Text = "Descripcion";
            // 
            // NombreProdTxt
            // 
            NombreProdTxt.Location = new Point(80, 76);
            NombreProdTxt.Name = "NombreProdTxt";
            NombreProdTxt.ReadOnly = true;
            NombreProdTxt.Size = new Size(100, 23);
            NombreProdTxt.TabIndex = 9;
            // 
            // NombreProdLbl
            // 
            NombreProdLbl.AutoSize = true;
            NombreProdLbl.Location = new Point(21, 79);
            NombreProdLbl.Name = "NombreProdLbl";
            NombreProdLbl.Size = new Size(50, 15);
            NombreProdLbl.TabIndex = 8;
            NombreProdLbl.Text = "Nombre";
            // 
            // BuscarProdBtn
            // 
            _BuscarProdBtn.Image = My.Resources.Resources.search;
            _BuscarProdBtn.Location = new Point(144, 28);
            _BuscarProdBtn.Name = "_BuscarProdBtn";
            _BuscarProdBtn.Size = new Size(36, 23);
            _BuscarProdBtn.TabIndex = 8;
            _BuscarProdBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BuscarProdBtn.UseVisualStyleBackColor = true;
            // 
            // CodProdTxt
            // 
            CodProdTxt.Location = new Point(80, 28);
            CodProdTxt.Name = "CodProdTxt";
            CodProdTxt.ReadOnly = true;
            CodProdTxt.Size = new Size(58, 23);
            CodProdTxt.TabIndex = 7;
            // 
            // CodProdLbl
            // 
            CodProdLbl.AutoSize = true;
            CodProdLbl.Location = new Point(19, 31);
            CodProdLbl.Name = "CodProdLbl";
            CodProdLbl.Size = new Size(45, 15);
            CodProdLbl.TabIndex = 5;
            CodProdLbl.Text = "Codigo";
            // 
            // NotaVentaGB
            // 
            NotaVentaGB.Controls.Add(_GenerarBtn);
            NotaVentaGB.Controls.Add(DetalleDG);
            NotaVentaGB.Controls.Add(_NuevoBtn);
            NotaVentaGB.Controls.Add(_EliminarBtn);
            NotaVentaGB.Controls.Add(TotalTxt);
            NotaVentaGB.Controls.Add(_AgregarBtn);
            NotaVentaGB.Controls.Add(TotalLbl);
            NotaVentaGB.Location = new Point(12, 266);
            NotaVentaGB.Name = "NotaVentaGB";
            NotaVentaGB.Size = new Size(630, 195);
            NotaVentaGB.TabIndex = 16;
            NotaVentaGB.TabStop = false;
            NotaVentaGB.Text = "Detalle Nota de Venta";
            // 
            // GenerarBtn
            // 
            _GenerarBtn.Image = My.Resources.Resources.accept;
            _GenerarBtn.Location = new Point(504, 163);
            _GenerarBtn.Name = "_GenerarBtn";
            _GenerarBtn.Size = new Size(92, 23);
            _GenerarBtn.TabIndex = 18;
            _GenerarBtn.Text = "Generar";
            _GenerarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _GenerarBtn.UseVisualStyleBackColor = true;
            // 
            // DetalleDG
            // 
            DetalleDG.AllowUserToAddRows = false;
            DetalleDG.AllowUserToDeleteRows = false;
            DetalleDG.AllowUserToResizeColumns = false;
            DetalleDG.AllowUserToResizeRows = false;
            DetalleDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetalleDG.Columns.AddRange(new DataGridViewColumn[] { CodProdCAB, NombreCAB, PrecioCAB, CantidadCAB });
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DetalleDG.DefaultCellStyle = DataGridViewCellStyle1;
            DetalleDG.Dock = DockStyle.Left;
            DetalleDG.Location = new Point(3, 19);
            DetalleDG.MultiSelect = false;
            DetalleDG.Name = "DetalleDG";
            DetalleDG.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DetalleDG.RowsDefaultCellStyle = DataGridViewCellStyle2;
            DetalleDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DetalleDG.Size = new Size(461, 173);
            DetalleDG.TabIndex = 13;
            // 
            // CodProdCAB
            // 
            CodProdCAB.DataPropertyName = "CodProd";
            CodProdCAB.HeaderText = "Código";
            CodProdCAB.Name = "CodProdCAB";
            CodProdCAB.ReadOnly = true;
            // 
            // NombreCAB
            // 
            NombreCAB.DataPropertyName = "NombreProducto";
            NombreCAB.HeaderText = "Nombre";
            NombreCAB.Name = "NombreCAB";
            NombreCAB.ReadOnly = true;
            // 
            // PrecioCAB
            // 
            PrecioCAB.DataPropertyName = "Precio";
            PrecioCAB.HeaderText = "Precio";
            PrecioCAB.Name = "PrecioCAB";
            PrecioCAB.ReadOnly = true;
            // 
            // CantidadCAB
            // 
            CantidadCAB.DataPropertyName = "Cantidad";
            CantidadCAB.HeaderText = "Cantidad";
            CantidadCAB.Name = "CantidadCAB";
            CantidadCAB.ReadOnly = true;
            // 
            // NuevoBtn
            // 
            _NuevoBtn.Image = My.Resources.Resources.newPage;
            _NuevoBtn.Location = new Point(504, 80);
            _NuevoBtn.Name = "_NuevoBtn";
            _NuevoBtn.Size = new Size(92, 24);
            _NuevoBtn.TabIndex = 16;
            _NuevoBtn.Text = "Nuevo";
            _NuevoBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _NuevoBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            _EliminarBtn.Image = My.Resources.Resources.delete;
            _EliminarBtn.Location = new Point(504, 51);
            _EliminarBtn.Name = "_EliminarBtn";
            _EliminarBtn.Size = new Size(92, 24);
            _EliminarBtn.TabIndex = 15;
            _EliminarBtn.Text = "Eliminar";
            _EliminarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // TotalTxt
            // 
            TotalTxt.Location = new Point(504, 134);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.ReadOnly = true;
            TotalTxt.Size = new Size(92, 23);
            TotalTxt.TabIndex = 17;
            TotalTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // AgregarBtn
            // 
            _AgregarBtn.Image = My.Resources.Resources.add;
            _AgregarBtn.Location = new Point(504, 21);
            _AgregarBtn.Name = "_AgregarBtn";
            _AgregarBtn.Size = new Size(92, 24);
            _AgregarBtn.TabIndex = 14;
            _AgregarBtn.Text = "Agregar";
            _AgregarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            _AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Location = new Point(532, 116);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(39, 15);
            TotalLbl.TabIndex = 3;
            TotalLbl.Text = "TOTAL";
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
            // NotaPedido
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(655, 473);
            Controls.Add(NotaVentaGB);
            Controls.Add(ProductoGB);
            Controls.Add(ProveedorGB);
            Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(661, 502);
            MinimumSize = new Size(661, 502);
            Name = "NotaPedido";
            ProveedorGB.ResumeLayout(false);
            ProveedorGB.PerformLayout();
            ProductoGB.ResumeLayout(false);
            ProductoGB.PerformLayout();
            NotaVentaGB.ResumeLayout(false);
            NotaVentaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DetalleDG).EndInit();
            Load += new EventHandler(NotaPedido_Load);
            FormClosing += new FormClosingEventHandler(NotaPedido_FormClosing);
            KeyDown += new KeyEventHandler(NotaPedido_KeyDown);
            ResumeLayout(false);
        }

        internal GroupBox ProveedorGB;
        internal CheckBox EstadoCB;
        internal DateTimePicker FechaDTP;
        internal Label FechaEmiLbl;
        internal Label ActivoLbl;
        internal Label DireccionLbl;
        internal TextBox DireccionTxt;
        internal TextBox CuitTxt;
        internal Label CuitLbl;
        internal TextBox RazonSocialTxt;
        internal Label RazonSocialLbl;
        private Button _BuscarCliBtn;

        internal Button BuscarCliBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarCliBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarCliBtn != null)
                {
                    _BuscarCliBtn.Click -= BuscarCliBtn_Click;
                }

                _BuscarCliBtn = value;
                if (_BuscarCliBtn != null)
                {
                    _BuscarCliBtn.Click += BuscarCliBtn_Click;
                }
            }
        }

        internal TextBox CodProvTxt;
        internal Label CodProvLbl;
        internal GroupBox ProductoGB;
        internal TextBox PrecioTxt;
        internal TextBox CantidadTxt;
        internal Label CantidadLbl;
        internal Label PrecioLbl;
        internal TextBox DescProdTxt;
        internal Label DescProdLbl;
        internal TextBox NombreProdTxt;
        internal Label NombreProdLbl;
        private Button _BuscarProdBtn;

        internal Button BuscarProdBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BuscarProdBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BuscarProdBtn != null)
                {
                    _BuscarProdBtn.Click -= BuscarProdBtn_Click;
                }

                _BuscarProdBtn = value;
                if (_BuscarProdBtn != null)
                {
                    _BuscarProdBtn.Click += BuscarProdBtn_Click;
                }
            }
        }

        internal TextBox CodProdTxt;
        internal Label CodProdLbl;
        internal GroupBox NotaVentaGB;
        private Button _GenerarBtn;

        internal Button GenerarBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GenerarBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GenerarBtn != null)
                {
                    _GenerarBtn.Click -= GenerarBtn_Click;
                }

                _GenerarBtn = value;
                if (_GenerarBtn != null)
                {
                    _GenerarBtn.Click += GenerarBtn_Click;
                }
            }
        }

        internal DataGridView DetalleDG;
        internal DataGridViewTextBoxColumn CodProdCAB;
        internal DataGridViewTextBoxColumn NombreCAB;
        internal DataGridViewTextBoxColumn PrecioCAB;
        internal DataGridViewTextBoxColumn CantidadCAB;
        private Button _NuevoBtn;

        internal Button NuevoBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NuevoBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NuevoBtn != null)
                {
                    _NuevoBtn.Click -= NuevoBtn_Click;
                }

                _NuevoBtn = value;
                if (_NuevoBtn != null)
                {
                    _NuevoBtn.Click += NuevoBtn_Click;
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

        internal TextBox TotalTxt;
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

        internal Label TotalLbl;
        internal ToolTip ControlesTP;
        internal ToolTip MensajeTT;
    }
}