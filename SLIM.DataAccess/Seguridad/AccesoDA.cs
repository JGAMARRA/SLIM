using SLIM.BusinessEntity.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SLIM.DataAccess.Seguridad
{
    public class AccesoDA
    {
        SqlHelper oSHelper = new SqlHelper();
        public List<Acceso> GetAccesos(int idPerfil)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter() {ParameterName = "@idPerfil", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value= idPerfil},
                
                //  new SqlParameter() {ParameterName = "@OutValue", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output},
            };
            SqlDataReader sdr = oSHelper.ExecDataReaderProc("Usp_SelectByIdusuario_PerfilxUsuario", parameters);
            List <Acceso> lAccesos= new List<Acceso>();
            Acceso oAcceso = null;
            while (sdr.Read())
            {
                oAcceso = new Acceso();
                {
                    oAcceso.idAcceso = Int32.Parse(sdr[0].ToString());
                    oAcceso.nomAcceso = sdr[1].ToString();
                    oAcceso.nomModulo= sdr[2].ToString();
                   oAcceso.estado= Int32.Parse(sdr[3].ToString());
                }
                lAccesos.Add(oAcceso);
            }
            return lAccesos;

        }
    }
}
