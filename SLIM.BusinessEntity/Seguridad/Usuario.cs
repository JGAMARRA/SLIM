using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLIM.BusinessEntity.Seguridad
{
    public class Usuario
    {
        int id;
        string nomUsuario;
        string clvUsuario;
        int estado;

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string ClvUsuario
        {
            get
            {
                return clvUsuario;
            }

            set
            {
                clvUsuario = value;
            }
        }

        public string NomUsuario
        {
            get
            {
                return nomUsuario;
            }

            set
            {
                nomUsuario = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
