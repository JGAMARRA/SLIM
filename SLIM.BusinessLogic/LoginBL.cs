﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLIM.DataAccess;
using SLIM.BusinessEntity;
namespace SLIM.BusinessLogic
{
    public class LoginBL
    {
        LoginDA oDA = new LoginDA();
        public Usuario GetUsuario(string usuario,string clave) {
            return oDA.GetUsuario(usuario,clave);
        }
    }
}