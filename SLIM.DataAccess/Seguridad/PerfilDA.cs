using SLIM.BusinessEntity.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLIM.DataAccess.Seguridad
{
    public class PerfilDA
    {
        SqlHelper oSHelper = new SqlHelper();
        public List<Perfil> GetPerfiles()
        {
            
            SqlDataReader sdr = oSHelper.ExecDataReader("Usp_SelectTodos_Perfil", null);
            List<Perfil> lPerfiles = new List<Perfil>();
            Perfil oPerfil = null;
            while (sdr.Read())
            {
                oPerfil = new Perfil();
                {
                    oPerfil.idPerfil = Int32.Parse(sdr[0].ToString());
                    oPerfil.nomPerfil = sdr[1].ToString();                   
                }
                lPerfiles.Add(oPerfil);
            }
            return lPerfiles;

        }
    }
}
