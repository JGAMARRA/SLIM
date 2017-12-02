using SLIM.BusinessLogic.Seguridad;
using System.Windows.Forms;

namespace SLIM.App.Seguridad
{
    
    public partial class frmPerfil : Form
    {
        AccesoBL oAcceso = new AccesoBL();
        public frmPerfil(int idPerfil)
        {
            InitializeComponent();
            dgvAccesos.DataSource = oAcceso.GetAccesos(idPerfil);
          //  DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
          //  checkColumn.Name = "estado";
          //  checkColumn.HeaderText = "X";
          //  checkColumn.Width = 50;
          //  checkColumn.ReadOnly = false;
          // // checkColumn.ValueType = int;
          ////  checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
          //  dgvAccesos.Columns.Add(checkColumn);
            //foreach (DataGridViewRow row in dgvAccesos.Rows)
            //{

            //    //If checked then highlight row
            //    if (int.Parse(row.Cells["estado"].Value.ToString()) == 1) {
            //        row.Selected = true;
            //    }                    

            //}

        }
    }
}
