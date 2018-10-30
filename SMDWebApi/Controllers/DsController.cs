using Newtonsoft.Json;
using SMDApi.DTO;
using SMDWebApi.Clases;
using SMDWebApi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
namespace SMDWebApi.Controllers
{
    public class DsController : ApiController
    {
        [Authorize]
        [Route("api/ds")]
        public HttpResponseMessage Post([FromBody]SqlCommand value)
        {
            bool HayDtVacio = false;
            var res = new System.Text.StringBuilder("{" + Environment.NewLine );

            try
            {
                var ds = DataHelper.GetDataset(value);

                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.Rows.Count == 0)
                    {
                        HayDtVacio = true;
                        break;
                    }
                }

                res.Append($@" ""IsSuccess"" : ""true"" ," + Environment.NewLine);
                res.Append($@" ""Message"" : """" ," + Environment.NewLine);

                if (!HayDtVacio)
                {
                    res.Append($@" ""Result"" :" + Environment.NewLine );
                    //res.Append("{" + Environment.NewLine);
                    res.Append(JsonConvert.SerializeObject(ds));
                    res.Append(Environment.NewLine); // + "}," + Environment.NewLine
                }
                else
                {
                    res.Append($@" ""Result"" :" + Environment.NewLine);
                    var obj = new DataSetSerializer();
                    res.Append(obj.Serialize(ds));
                    res.Append(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                res.Append($@" ""IsSuccess"" : ""false"" , " + Environment.NewLine);
                res.Append($@" ""Message"" : ""{ex.Message}"" " + Environment.NewLine);
            }

          
            res.Append("}" + Environment.NewLine);
            

            string yourJson = res.ToString();
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(yourJson, Encoding.UTF8, "application/json");
            return response;
        }

        
    }
}
