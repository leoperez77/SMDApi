using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
namespace SMDApi.Data
{
    public class DBCommon
    {
        public static string ConnString
        {
            get
            {
                var str =  ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                return str;
            }
        }
              
        public static SqlDatabase dbConn = new SqlDatabase(ConnString);
    

    }
}
