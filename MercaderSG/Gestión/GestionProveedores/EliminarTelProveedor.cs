using System;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Microsoft.VisualBasic.CompilerServices;
using Negocios;

namespace MercaderSG
{
    public partial class EliminarTelProveedor
    {
        public EliminarTelProveedor()
        {
            InitializeComponent();
            _CancelarBtn.Name = "CancelarBtn";
            _AceptarBtn.Name = "AceptarBtn";
            _TelefonosDG.Name = "TelefonosDG";
        }

        public int CodProv;

        private void EliminarTelProveedor_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
            CargarTT();
            TelefonosDG.AutoGenerateColumns = false;
            try
            {
                TelefonosDG.DataSource = ProveedorRN.ObtenerTelefonoProveedor(CodProv);
            }
            catch (WarningException ex)
            {
                MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dispose();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            bool Validacion = true;
            if (TelefonosDG.Rows.Count == 0)
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.NoTelefonoDG, AceptarBtn);
                Validacion = false;
            }
            else if (TelefonosDG.SelectedRows is null)
            {
                MensajeTT.Show(My.Resources.ArchivoIdioma.NoTelSeleccionado, AceptarBtn);
                Validacion = false;
            }

            if (Validacion == true)
            {
                var UnTelefono = new TelefonoEN();
                UnTelefono.CodTel = Conversions.ToInteger(TelefonosDG.CurrentRow.Cells[0].Value);
                UnTelefono.CodEn = Conversions.ToInteger(TelefonosDG.CurrentRow.Cells[1].Value);
                UnTelefono.Numero = Conversions.ToString(TelefonosDG.CurrentRow.Cells[2].Value);
                var resultado = MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.EliminarNumeroTel, TelefonosDG.CurrentRow.Cells[2].Value), My.Resources.ArchivoIdioma.Pregunta)), My.Resources.ArchivoIdioma.MsgEliminarNumeroTel, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK & TelefonosDG.Rows.Count > 3)
                {
                    try
                    {
                        ProveedorRN.EliminarTelefonoProveedor(UnTelefono);
                    }
                    catch (InformationException ex)
                    {
                        MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (WarningException ex)
                    {
                        MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        try
                        {
                            TelefonosDG.DataSource = ProveedorRN.ObtenerTelefonoProveedor(CodProv);
                        }
                        catch (WarningException exce)
                        {
                            MessageBox.Show(exce.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Close();
                        }
                    }
                }
                else if (resultado == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    MessageBox.Show(My.Resources.ArchivoIdioma.EliminarMenosTresTelProv, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    TelefonosDG.DataSource = ProveedorRN.ObtenerTelefonoProveedor(CodProv);
                }
                catch (WarningException ex)
                {
                    MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
        }

        private void EliminarTelProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                string pathchm = Path.Combine(Application.StartupPath, "Ayuda.chm");
                Help.ShowHelp(this, pathchm, HelpNavigator.TopicId, "111");
            }
        }

        public void AplicarIdioma()
        {
            Text = My.Resources.ArchivoIdioma.EliminarTelFrm;
            TelefonosGB.Text = My.Resources.ArchivoIdioma.TelefonosGB;
            CodTelCAB.HeaderText = My.Resources.ArchivoIdioma.CodTelefono;
            CodProvCAB.HeaderText = My.Resources.ArchivoIdioma.CodProvTel;
            NumeroCAB.HeaderText = My.Resources.ArchivoIdioma.NumeroTelLbl;
            AceptarBtn.Text = My.Resources.ArchivoIdioma.AceptarBtn;
            CancelarBtn.Text = My.Resources.ArchivoIdioma.CancelarBtn;
        }

        private void CargarTT()
        {
            ControlesTP.SetToolTip(TelefonosDG, My.Resources.ArchivoIdioma.TTListaTel);
            ControlesTP.SetToolTip(AceptarBtn, My.Resources.ArchivoIdioma.TTAceptarEliTel);
            ControlesTP.SetToolTip(CancelarBtn, My.Resources.ArchivoIdioma.TTCancelarBtn);
        }

        private void TelefonosDG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool Validacion = true;
                if (TelefonosDG.Rows.Count == 0)
                {
                    MensajeTT.Show(My.Resources.ArchivoIdioma.NoTelefonoDG, AceptarBtn);
                    Validacion = false;
                }
                else if (TelefonosDG.SelectedRows is null)
                {
                    MensajeTT.Show(My.Resources.ArchivoIdioma.NoTelSeleccionado, AceptarBtn);
                    Validacion = false;
                }

                if (Validacion == true)
                {
                    try
                    {
                        var UnTelefono = new TelefonoEN();
                        UnTelefono.CodTel = Conversions.ToInteger(TelefonosDG.CurrentRow.Cells[0].Value);
                        UnTelefono.CodEn = Conversions.ToInteger(TelefonosDG.CurrentRow.Cells[1].Value);
                        UnTelefono.Numero = Conversions.ToString(TelefonosDG.CurrentRow.Cells[2].Value);
                        var resultado = MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(My.Resources.ArchivoIdioma.EliminarNumeroTel, TelefonosDG.CurrentRow.Cells[2].Value), My.Resources.ArchivoIdioma.Pregunta)), My.Resources.ArchivoIdioma.MsgEliminarNumeroTel, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (resultado == DialogResult.OK & TelefonosDG.Rows.Count > 3)
                        {
                            ProveedorRN.EliminarTelefonoProveedor(UnTelefono);
                        }
                        else if (resultado == DialogResult.Cancel)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show(My.Resources.ArchivoIdioma.EliminarMenosTresTelProv, My.Resources.ArchivoIdioma.MsgBoxAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    catch (InformationException ex)
                    {
                        MessageBox.Show(ex.Message, My.Resources.ArchivoIdioma.MsgBoxInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    TelefonosDG.DataSource = ProveedorRN.ObtenerTelefonoProveedor(CodProv);
                }
            }
        }
    }
}