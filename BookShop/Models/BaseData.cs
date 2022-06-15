using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;

namespace BookShop.Models
{
    public class BaseData
    {
        SqlConnection connection;

        public BaseData()
        {
            connection = new SqlConnection("Data Source=LAPTOP-317ORP7T\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        }
        public string executeSql (string sql)
        {
            string result = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                int rows = cmd.ExecuteNonQuery();
                if(rows > -1)
                {
                    result = "Correct";
                }
                else
                {
                    result = "Incorrect";
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public DataTable getTable(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();
            }
            catch
            {
                table = null;
            }
            return table;
        }

        public static List<dynamic> ConvertToDataTable(DataTable dataTable)
        {
            var result = new List<dynamic>();
            foreach (DataRow row in dataTable.Rows)
            {
                dynamic dyn = new ExpandoObject();
                foreach (DataColumn column in dataTable.Columns)
                {
                    var dic = (IDictionary<string, object>)dyn;
                    dic[column.ColumnName] = row[column];
                }
                result.Add(dyn);
            }
            return result;
        }

    }
}
