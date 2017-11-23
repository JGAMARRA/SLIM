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

        private void FrmLetraCambio_Load(object sender, EventArgs e)
        {
            this.txtNumero.Text = "00000";
            this.txtReferenciaGirador.Text = "0000-000000";
            this.txtLugarGiro.Text = "LIMA";
            this.cboMoneda.SelectedIndex = 0;
            this.txtLugarGiro.CharacterCasing = CharacterCasing.Upper;
            this.txtAceptante.CharacterCasing = CharacterCasing.Upper;
            this.txtDomicilio.CharacterCasing = CharacterCasing.Upper;
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
            string numero = this.txtImporte.Text.Trim();
            this.txtImporteLetras.Text = NumeroLetras.Convertir(numero).ToUpper();
        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            string texto = this.txtImporte.Text.Trim();
            decimal importe = Convert.ToDecimal(texto);
            string numero = importe.ToString("n2");
            this.txtImporte.Text = numero;
        }
    }
}
