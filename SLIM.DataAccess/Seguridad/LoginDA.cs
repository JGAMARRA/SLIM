using SLIM.BusinessEntity.Seguridad;
using System;
using System.Data;
using System.Data.SqlClient;


namespace SLIM.DataAccess
{
    public class LoginDA
    {
        SqlHelper oSHelper = new SqlHelper();
        public Usuario GetUsuario(string usuario, string clave)
        {

            ADONetHelper.SqlServer.SqlServerClient sql;
            //sql.ConnectionString = "";
            //sql.ExecuteNonQuery("");

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter() {ParameterName = "@usuario", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value= usuario},
                new SqlParameter() {ParameterName = "@clave", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = clave},
                //  new SqlParameter() {ParameterName = "@OutValue", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output},
            };
            SqlDataReader sdr = oSHelper.ExecDataReaderProc("Usp_SelectById_Usuario", parameters);
            Usuario oUsuario = null;
            while (sdr.Read())
            {
                 oUsuario=new Usuario();
                {oUsuario.id= Int32.Parse(sdr[0].ToString());
                    oUsuario.nomUsuario= sdr[1].ToString();
                    oUsuario.clvUsuario= sdr[2].ToString();
                    oUsuario.idPerfil = Int32.Parse(sdr[3].ToString());
                    oUsuario.estado= Int32.Parse(sdr[4].ToString());
                }
            }
            return oUsuario;

        }
    }
}
