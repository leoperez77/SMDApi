using SMDApi.DTO;
using SMDWebApi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SMDWebApi.Controllers
{    
    public class DsxController : ApiController
    {

        [Authorize]
        public SqlCommand Get(int id)
        {
            SqlCommand command = new SqlCommand()
            {
                Sql = id.ToString(),
                Type = 2
            };

            return command;
        }

        [Authorize]
        [Route("api/ds")]
        public DataSet Post([FromBody]SqlCommand value)
        {            
            var ds = new DataSet();
            try
            {
                ds = DataHelper.GetDataset(value);
            }
            catch (Exception ex)
            {
                throw;
            }

            
            return ds;
        }
    }
}
