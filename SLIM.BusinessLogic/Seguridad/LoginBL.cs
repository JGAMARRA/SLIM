using SLIM.DataAccess;
using SLIM.BusinessEntity.Seguridad;

namespace SLIM.BusinessLogic.Seguridad
{
    public class LoginBL
    {
        LoginDA oDA = new LoginDA();
        public Usuario GetUsuario(string usuario,string clave) {
            return oDA.GetUsuario(usuario,clave);
        }

    }
}
