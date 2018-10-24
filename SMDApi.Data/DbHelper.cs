using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace SMDApi.Data
{
    public class DBHelper
    {
        public static SqlDataReader GetDataReader(string Sql)
        {
            DbCommand cmd = DBCommon.dbConn.GetSqlStringCommand(Sql);
            return (SqlDataReader) DBCommon.dbConn.ExecuteReader(cmd);
        }

        public static DataSet GetDataSet(string Sql)
        {
            DbCommand cmd = DBCommon.dbConn.GetSqlStringCommand(Sql.Replace("--",""));            
            return DBCommon.dbConn.ExecuteDataSet(cmd);
        }

        public static DataTable GetDataTable(string Sql)
        {
            DbCommand cmd = DBCommon.dbConn.GetSqlStringCommand(Sql.Replace("--", ""));
            DataTable dt = DBCommon.dbConn.ExecuteDataSet(cmd).Tables[0];
            dt.TableName = "result";
            return dt;
        }

        public static int Execute(string Sql)
        {
            DbCommand cmd = DBCommon.dbConn.GetSqlStringCommand(Sql);
            cmd.CommandType = System.Data.CommandType.Text;
            return DBCommon.dbConn.ExecuteNonQuery(cmd);           
        }

        public static int ExecSp(string Sp, string[] Params)
        {                    
            return DBCommon.dbConn.ExecuteNonQuery(Sp, Params);
        }      
       
    }
}
