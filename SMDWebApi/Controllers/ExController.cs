using SMDApi.DTO;
using SMDWebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SMDWebApi.Controllers
{
    public class ExController : ApiController
    {
        [Route("api/ex")]
        public Response Post([FromBody]SqlCommand value)
        {
            var res = new Response();
            try
            {
                var i = DataHelper.Exec(value);
                res.IsSuccess = true;
                res.Result = i;
            }
            catch(Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
           
            return res;
        }
    }
}
