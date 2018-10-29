using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMDApi.Data
{
    public static class DBSecurity
    {
        public static async Task<bool> Authenticate(int IdUsuario, string Password)
        {
            return true;
        }

        public static bool Login(int IdEmpresa, string Usuario, string Clave)
        {
            return true;
        }
    }
}
