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

        public SqlCommand Get(int id)
        {
            SqlCommand command = new SqlCommand()
            {
                Sql = id.ToString(),
                Type = 2
            };

            return command;
        }

        [Route("api/ds")]
        public DataSet Post([FromBody]SqlCommand value)
        {
            //bool HayDtVacio = false;
            var ds = new DataSet();
            try
            {
                ds = DataHelper.GetDataset(value);

                //foreach (DataTable dt in ds.Tables)
                //{
                //    if (dt.Rows.Count == 0)
                //    {
                //        HayDtVacio = true;
                //        break;
                //    }
                //}

                //if (!HayDtVacio)
                //{
                    //res.Result = ds;
                //}
                //else
                //{
                //    var obj = new DataSetSerializer();
                //    res.Result = obj.Serialize(ds);
                //}
            }
            catch (Exception ex)
            {
                //res.IsSuccess = false;
                //res.Message = ex.Message;
            }

            //res.IsSuccess = true;
            //res.Message = "";
            return ds;
        }
    }
}
