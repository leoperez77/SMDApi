using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace SMDWebApi.Clases
{
    public class DataSetSerializer
    {
        StringBuilder JSONString;

        public DataSetSerializer()
        {
            JSONString = new StringBuilder();
        }

        public string Serialize(DataSet ds)
        {
            JSONString.Append("{");
            int index = 0;
            foreach (DataTable dt in ds.Tables)
            {
                DataTableToJSONWithStringBuilder(dt, index);
           
                index++;
                if (index < ds.Tables.Count)
                    JSONString.Append("," );
            }

            JSONString.Append( "}");
            return JSONString.ToString();
        }



        private void DataTableToJSONWithStringBuilder(DataTable table, int NumTabla)
        {            
            if (table.Rows.Count > 0)
            {
                JSONString.Append($@" ""Table{NumTabla}"" : [" );
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{" );

                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" :  {JsonConvert.ToString(table.Rows[i][j].ToString())} ," );
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" : {JsonConvert.ToString(table.Rows[i][j].ToString())} ");
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
                JSONString.Append($@" ""Table{NumTabla}"" : [");
                JSONString.Append("{");
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    bool EsNumero = false;
                    
                    TypeCode yourTypeCode = Type.GetTypeCode(table.Columns[j].DataType);
                    switch (yourTypeCode)
                    {
                        case TypeCode.Byte:
                        case TypeCode.SByte:
                        case TypeCode.Int16:
                        case TypeCode.UInt16:
                        case TypeCode.Int32:
                        case TypeCode.UInt32:
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            {
                                EsNumero = true;                                
                                break;
                            }
                        case TypeCode.DateTime:
                            {                            
                                break;
                            }
                        case TypeCode.String:
                            {                             
                                break;
                            }
                        case TypeCode.Boolean:
                            break;
                        default:
                            {                                
                                break;
                            }
                    }

                    if (j < table.Columns.Count - 1)
                    {
                        if(EsNumero)
                            JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" : { JsonConvert.ToString(0)} ,");
                        else
                            JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" : """" ,");

                        //JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" : """" ,");
                    }
                    else if (j == table.Columns.Count - 1)
                    {
                        if (EsNumero)
                            JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" : { JsonConvert.ToString(0)} ");
                        else
                            JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}"" : """" ");

                        //JSONString.Append($@" ""{table.Columns[j].ColumnName.ToString()}""  : """" ");
                    }
                }
                JSONString.Append("}");
                JSONString.Append("]");
            }
            
        }
    }
}