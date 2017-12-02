using SLIM.App.Facturacion;
using SLIM.App.Seguridad;
using SLIM.BusinessEntity.Seguridad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SLIM.App
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(List<Acceso> lAccesos)
        {
            InitializeComponent();

            foreach (var item in lAccesos)
            {
                // nomAcceso de la base de datos y control del formulario principal
                // en el formulario todos los menus deben figurar como no visibles 
                if (item.estado==1) {
                
                if (item.nomModulo == "Almacen")
                {
                    if (item.nomAcceso == "Movimientos")
                    {
                        movimientosToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Consultas")
                    {
                        consultasToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Guia de Remisión")
                    {
                        imprimirGuiaRemisiónToolStripMenuItem.Visible = true;
                    }
                }
                if (item.nomModulo == "Facturacion")
                {
                    if (item.nomAcceso == "Generar Documento Pago")
                    {
                        generarFacturaToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Generar Letra")
                    {
                        generarLetraToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Consultas")
                    {
                        consultasToolStripMenuItem1.Visible = true;
                    }
                }
                if (item.nomModulo == "Mantenimiento")
                {
                    if (item.nomAcceso == "Producto")
                    {
                        productoToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Transportista")
                    {
                        transportistaToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Cliente")
                    {
                        clienteToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Proveedor")
                    {
                        proveedorToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Almacen")
                    {
                        almacenToolStripMenuItem1.Visible = true;
                    }
                    
                }
                if (item.nomModulo == "Seguridad")
                {
                    if (item.nomAcceso == "Usuarios")
                    {
                        usuariosToolStripMenuItem.Visible = true;
                    }
                    if (item.nomAcceso == "Perfiles")
                    {
                        perfilesToolStripMenuItem.Visible = true;
                    }
                }
            }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void generarLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLetraCambio frm = new FrmLetraCambio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocumentoPago frm = new frmDocumentoPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfilConsulta frm = new frmPerfilConsulta();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
