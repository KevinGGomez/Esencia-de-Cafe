﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Esencia_de_cafe
{
    public class SeguridadBL
    {
        public bool Autorizar(String usuario, String contrasena)
        {
            if (usuario == "admin1" && contrasena == "1234")
            {
                return true;
            }
            else
            {
                if (usuario == "admin2" && contrasena == "123456")
                {
                    return true;

                }
            }
            return false;
        }
    }
}
