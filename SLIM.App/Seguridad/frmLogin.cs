using SLIM.BusinessEntity.Seguridad;
using SLIM.BusinessLogic.Seguridad;
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
    public partial class frmLogin : Form
    {
        LoginBL oLogin = new LoginBL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = oLogin.GetUsuario(txtUsuario.Text.TrimEnd(), txtClave.Text.TrimEnd());
            if (oUsuario != null)
            {
                Form frm = new frmPrincipal();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no existe",
                "SLIM",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
