using SMDApi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SMDWebApi.Controllers
{
    public class LoginController : ApiController
    {
        

        [Route("api/login")]
        public int Post(DTOUsuario usuario)
        {
            try
            {
                var dt = SMDApi.Data.DBHelper.GetDataTable($@"select u.id as IdUsuario, clave from v_usuario u join emp e on e.id = u.id_emp 
                    where u.codigo_usuario = '{usuario.Nombre}' and codigo_empresa = '{usuario.Empresa}'");

                if (dt.Rows.Count == 0)
                    return 0;

                if (Encripcion.SMDApi.Clases.Encripcion.Encriptar("D", dt.Rows[0]["clave"].ToString()).ToLower() == usuario.Clave.ToLower())
                    return int.Parse(dt.Rows[0]["idusuario"].ToString());
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
