using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLIM.BusinessEntity;
namespace SLIM.DataAccess
{
    public class LoginDA
    {
        public Usuario GetUsuario(string usuario,string clave)
        {
            Usuario oUsuario = null;
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter() {ParameterName = "@usuario", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value= usuario},
            new SqlParameter() {ParameterName = "@clave", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = clave},
          //  new SqlParameter() {ParameterName = "@OutValue", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output},
            };
            List<object> lobjs =sqlutil.executeStoredProcedure("Usp_SelectById_Usuario", parameters, "userDB");
            if (lobjs.Count>0) {
                oUsuario = new Usuario();
            oUsuario.Id = Int32.Parse(lobjs[0].ToString());
            oUsuario.NomUsuario = lobjs[1].ToString();
            oUsuario.ClvUsuario = lobjs[2].ToString();
            oUsuario.Estado = Int32.Parse(lobjs[3].ToString());
            }
            return oUsuario;
        }

    }
}
