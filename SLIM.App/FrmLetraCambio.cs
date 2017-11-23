using SLIM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIM.App
{
    public partial class FrmLetraCambio : Form
    {
        public FrmLetraCambio()
        {
            InitializeComponent();
        }

        private void Nuevo()
        {
            this.txtNumero.Text = "00000";
            this.txtReferenciaGirador.Text = "0000-000000";
            this.txtLugarGiro.Text = "LIMA";
            this.cboMoneda.SelectedIndex = 0;
            this.txtImporte.Clear();
            this.txtImporteLetras.Clear();
            this.txtAceptante.Clear();
            this.txtDomicilio.Clear();
            this.txtNumero.Focus();
        }

        private void FrmLetraCambio_Load(object sender, EventArgs e)
        {
            this.txtLugarGiro.CharacterCasing = CharacterCasing.Upper;
            this.txtAceptante.CharacterCasing = CharacterCasing.Upper;
            this.txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            this.Nuevo();
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            string numero = this.txtNumero.Text.Trim().PadLeft(5, '0');
            this.txtNumero.Text = numero;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtReferenciaGirador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (e.KeyChar != '-') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            string importe = this.txtImporte.Text.Trim();
            if (importe.Length == 0) return;
            this.txtImporteLetras.Text = NumeroLetras.Convertir(importe).ToUpper();
        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            string importe = this.txtImporte.Text.Trim();
            if (importe.Length == 0) return;
            decimal valor = Convert.ToDecimal(importe);
            string numero = valor.ToString("n2");
            this.txtImporte.Text = numero;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Nuevo();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Validaciones
        }
    }
}
