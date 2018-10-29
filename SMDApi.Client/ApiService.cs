using Newtonsoft.Json;
using SMDApi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SMDApi.Client
{
    public class ApiService
    {
        private readonly string _urlBase;
        private Token token;
        private string strToken;

        public string UrlBase { get => _urlBase;}
        public string Usuario;
        public string Clave;

        public ApiService(string Url)
        {
            _urlBase = Url;
        }

        public bool Login(string Usuario, string Clave)
        {
            this.Usuario = Usuario;
            this.Clave = Clave;
            return true;
        }

        public async Task<Response> Get<T>(string urlBase, string servicePrefix, string controller)
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

        public async Task<Response> Post<T>(string servicePrefix, string controller, T model)
        {
            Response obj = new Response();
            try
            {

                HttpClient cons = new HttpClient();
                cons.BaseAddress = new Uri(Params.UrlApi);
                cons.DefaultRequestHeaders.Accept.Clear();
                cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //if (!string.IsNullOrWhiteSpace(token))
                //{
                //    var t = JsonConvert.DeserializeObject<Token>(token);
                //    cons.DefaultRequestHeaders.Add("Authorization", "Bearer " + t.access_token);
                //}

                HttpResponseMessage res = await cons.PostAsJsonAsync(servicePrefix + "/" + controller, model);

                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Response>(content);
                    return result;                    
                }
                else
                    return obj;


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Response PostSync<T>(string servicePrefix, string controller, T model)
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
                    var result = JsonConvert.DeserializeObject<Response>(content);
                    return result;
                }
                else
                    return obj;


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataSet PostSyncX<T>(string servicePrefix, string controller, T model)
        {
            Response obj = new Response();
            try
            {


                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(Params.UrlApi)
                };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = client.PostAsJsonAsync(servicePrefix + "/" + controller + "?type=xml", model).Result;

                if (res.IsSuccessStatusCode)
                {
                    var content = res.Content.ReadAsStringAsync().Result;
                    //var content =  res.Content.ReadAsStringAsync().ConfigureAwait(false);
                    DataSet dataSet = new DataSet();
                    var sr = new StringReader(content);
                    dataSet.ReadXml(sr);
                    sr.Close();

                    return dataSet;
                    //obj.Result = content;
                    //obj.
                }
                else
                    throw new Exception("Error al traer dataset en xml");

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataSet DeserializeDs(string json)
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

        private string GetToken(string url, string userName, string password)
        {
            var pairs = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>( "grant_type", "password" ),
                        new KeyValuePair<string, string>( "username", userName ),
                        new KeyValuePair<string, string> ( "Password", password )
                    };
            var content = new FormUrlEncodedContent(pairs);
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url + "Token", content).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
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
