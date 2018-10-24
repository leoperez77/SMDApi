using Newtonsoft.Json;
using SMDApi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SMDApi.Client
{
    public class ApiService
    {
        public static async Task<Response> Get<T>(string urlBase, string servicePrefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = string.Format("{0}{1}", servicePrefix, controller);
                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = response.StatusCode.ToString(),
                    };
                }

                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Ok",
                    Result = list,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

        public static async Task<Response> Post<T>(string servicePrefix, string controller, T model)
        {
            Response obj = new Response();
            try
            {
                //Params.UrlService = @"http://localhost/trapi/";

                HttpClient cons = new HttpClient();
                cons.BaseAddress = new Uri(Params.UrlApi);
                cons.DefaultRequestHeaders.Accept.Clear();
                cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cons.PostAsJsonAsync(servicePrefix + "/" + controller, model);

                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Response>(content);
                    return result;
                    //obj.Result = content;
                    //obj.
                }
                else
                    return obj;


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Response PostSync<T>(string servicePrefix, string controller, T model)
        {
            Response obj = new Response();
            try
            {
                //Params.UrlService = @"http://localhost/trapi/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Params.UrlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = client.PostAsJsonAsync(servicePrefix + "/" + controller, model).Result;

                if (res.IsSuccessStatusCode)
                {
                    var content = res.Content.ReadAsStringAsync().Result;
                    //var content =  res.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var result = JsonConvert.DeserializeObject<Response>(content);
                    return result;
                    //obj.Result = content;
                    //obj.
                }
                else
                    return obj;


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataSet DeserializeDs(string json )
        {
            var ds = JsonConvert.DeserializeObject<DataSet>(json);
            foreach (DataTable dt in ds.Tables)
            {
                if (dt.Rows.Count == 1)
                {
                    bool borrar = true;
                    DataRow dr = dt.Rows[0];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (dr[i].ToString() != "" && dr[i].ToString() != "0")
                        {
                            borrar = false;
                            break;
                        }
                    }
                    if (borrar)
                        dt.Rows.Clear();
                }
            }
            ds.AcceptChanges();
            return ds;
        }

        //public static async Task<string> Post<T>(string servicePrefix, string controller, T model)
        //{
        //    try
        //    {
        //        //Params.UrlService = @"http://localhost/trapi/";

        //        HttpClient cons = new HttpClient();
        //        cons.BaseAddress = new Uri(Params.UrlApi);
        //        cons.DefaultRequestHeaders.Accept.Clear();
        //        cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage res = await cons.PostAsJsonAsync(servicePrefix + controller, model);

        //        if (res.IsSuccessStatusCode)
        //        {
        //            string content = await res.Content.ReadAsStringAsync();
        //            return content;
        //        }
        //        else
        //            return "";


        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}
    }
}
