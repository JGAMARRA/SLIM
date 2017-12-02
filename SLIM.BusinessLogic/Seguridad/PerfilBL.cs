using SLIM.BusinessEntity.Seguridad;
using SLIM.DataAccess.Seguridad;
using System.Collections.Generic;

namespace SLIM.BusinessLogic.Seguridad
{
    public class PerfilBL
    {
        PerfilDA oDA = new PerfilDA();
        public List<Perfil> GetPerfiles()
        {
            return oDA.GetPerfiles();
        }
    }
}
