using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLIM.BusinessLogic;
using SLIM.BusinessEntity;
namespace SLIM.App
{
    public partial class frmLogin : Form
    {
        LoginBL oLogin = new LoginBL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario oUsuario=oLogin.GetUsuario(txtUsuario.Text.TrimEnd(),txtClave.Text.TrimEnd());
            if (oUsuario != null)
            {
                Form frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else {
                MessageBox.Show("Usuario no existe",
    "SLIM",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
