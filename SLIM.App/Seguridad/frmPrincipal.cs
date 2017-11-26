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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new frmMovimiento();
            //frm.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new frmGenerarDocumentoPago();
            //frm.ShowDialog();
        }

        private void stockXArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new frmConsultaStockArticulo();
            //frm.ShowDialog();
        }

        private void movimientoXArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new frmConsultaMovimientoArticulo();
            //frm.ShowDialog();
        }

        private void imprimirGuiaRemisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new frmGenerarGuia();
            //frm.ShowDialog();
        }

        private void generarLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLetraCambio frm = new FrmLetraCambio();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
