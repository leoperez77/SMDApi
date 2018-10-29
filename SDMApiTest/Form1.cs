using SMDApi.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;

namespace SDMApiTest
{
    public partial class Form1 : Form
    {
        public string Token;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            Token = textBox1.Text;
            var Command = new SMDApi.DTO.SqlCommand() { Sql = txtQuery.Text, Type = 1 };
            var res = await ApiService.Post<SMDApi.DTO.SqlCommand>("api", "ds", Command, Token);
            DataSet ds = JsonConvert.DeserializeObject<DataSet>(res.Result.ToString());

            //var ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset("Data Source = localhost; Initial Catalog = dms_smd_nueva; Uid = sa; Pwd = Mutombo3000; ", CommandType.Text, txtQuery.Text);
            //string json = JsonConvert.SerializeObject(ds, Formatting.Indented);
            //textBox1.Text = json;

            Grid1.DataSource = ds.Tables[0];
            Grid1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset("Data Source = localhost; Initial Catalog = dms_smd_nueva; Uid = sa; Pwd = Mutombo3000; ", CommandType.Text, txtQuery.Text);
            //    string json = JsonConvert.SerializeObject(ds, Formatting.Indented);
            //textBox1.Text = json;

            textBox1.Text = "{" + Environment.NewLine ;
            int index = 0;
            foreach (DataTable dt in ds.Tables)
            {
                var tx = DataTableToJSONWithStringBuilder(dt, index);
                textBox1.Text += tx + Environment.NewLine;
                index++;
                if (index < ds.Tables.Count)
                    textBox1.Text += "," + Environment.NewLine;
            }

            textBox1.Text += Environment.NewLine + "}";

            var dx = JsonConvert.DeserializeObject<DataSet>(textBox1.Text);

            Grid1.DataSource = dx.Tables[1];
            Grid1.Refresh();
        }

        public string DataTableToJSONWithStringBuilder(DataTable table, int NumTabla)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append( $@" ""Table{NumTabla}"" : [" + Environment.NewLine ) ;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{" + Environment.NewLine);
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"," + Environment.NewLine );
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            else
            {
                JSONString.Append($@" ""Table{NumTabla}"" : [" + Environment.NewLine);
                JSONString.Append("{");
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (j < table.Columns.Count - 1)
                    {
                        JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + "" + "\",");
                    }
                    else if (j == table.Columns.Count - 1)
                    {
                        JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + "" + "\"");
                    }
                }
                JSONString.Append("}");
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Tk = GetToken("http://localhost:62914/", "3990", "1234");
            //var obj = JsonConvert.DeserializeObject<SMDApi.DTO.Token>(Tk);
            
            textBox1.Text = Tk;
            // + Environment.NewLine + obj.expires + " " + obj.expires_in
        }

        static string GetToken(string url, string userName, string password)
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
    }
}
