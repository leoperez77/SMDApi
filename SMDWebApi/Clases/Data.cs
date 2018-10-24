using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SMDApi.Data;
using Newtonsoft.Json;
using SMDApi.DTO;

namespace SMDWebApi.Data
{
    public class DataHelper
    {     
        public static DataTable GetDt(SqlCommand value)
        {
            return DBHelper.GetDataTable(value.Sql);           
        }

        public static int Exec(SqlCommand sql)
        {
            return DBHelper.Execute(sql.Sql);
        }

        public static DataSet GetDataset(SqlCommand sqlCommand)
        {
            return DBHelper.GetDataSet(sqlCommand.Sql);
        }
       
    }
}
