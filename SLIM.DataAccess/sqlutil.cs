using SLIM.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLIM.DataAccess
{
    class sqlutil
    {
        //public static void executeStoredProcedure(string SPName, Dictionary<string, object> parameters, string connectionStringName)
        public static List<object> executeStoredProcedure(string SPName, SqlParameter[] parameters, string connectionStringName)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["cnx"].ToString()))
            {
                using (SqlCommand cmd = new SqlCommand(SPName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        //foreach (KeyValuePair<string, object> kvp in parameters)
                        //    cmd.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.Add(parameter);
                        }

                    }
                    con.Open();
                    SqlDataReader reader= cmd.ExecuteReader();
                    List<object> contenedor = new List<object>();
                   // int i = 0;
                    Usuario u = new Usuario();
                    while (reader.Read())
                    {
                        //Console.WriteLine("\t{0}\t{1}\t{2}",
                        //    reader[0], reader[1], reader[2]);
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            contenedor.Add(reader[i]);
                        }
                       // u.Id = Int32.Parse(reader[0].ToString());
                       // u.NomUsuario = reader[1].ToString();
                        //foreach (var item in reader)
                        //{
                        //    contenedor.Add(item);
                        //}
                      
                        //string cd=reader[0].ToString();
                        //contenedor[i] = 
                       // i = i+1;

                    }
                    reader.Close();

                    //  cmd.ExecuteNonQuery();
                    // int OutVal = Convert.ToInt32(cmd.Parameters["@OutValue"].Value);
                    con.Close();
                    return contenedor;
                }
            }
        }
    }
}
