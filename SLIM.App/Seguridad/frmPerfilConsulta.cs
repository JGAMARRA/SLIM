using SLIM.BusinessLogic.Seguridad;
using System.Windows.Forms;

namespace SLIM.App.Seguridad
{
    public partial class frmPerfilConsulta : Form
    {
        PerfilBL oPerfilBL = new PerfilBL();
        public frmPerfilConsulta()
        {
            InitializeComponent();
            dgvPerfiles.DataSource = oPerfilBL.GetPerfiles();
           
        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            frmPerfil frm = new frmPerfil(0);
            frm.ShowDialog();
        }
    }
}
