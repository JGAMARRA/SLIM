using SLIM.BusinessEntity.Seguridad;
using SLIM.DataAccess.Seguridad;
using System.Collections.Generic;

namespace SLIM.BusinessLogic.Seguridad
{
    public class AccesoBL
    {
        AccesoDA oDA = new AccesoDA();
        public List<Acceso> GetAccesos(int idPerfil)
        {
            return oDA.GetAccesos(idPerfil);
        }
    }
}
