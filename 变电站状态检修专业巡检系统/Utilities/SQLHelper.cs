using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace 变电站状态检修专业巡检系统
{
    class SqlHelper
    {
        static private string connectionString = //"server=qdm176963284.my3w.com;uid=qdm176963284;pwd=1thagainIdoy;database=qdm176963284_db";
            ConfigurationManager.AppSettings["connStr"].ToString();
        static public bool IsConnected()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        async static public Task<bool> RunSql(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                try
                {
                    var re = await cmd.ExecuteNonQueryAsync();
                    return re == 1;
                }
                catch
                {
                    return false;
                }
            }
        }

        static public object GetScalar(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                object res = cmd.ExecuteScalar();
                return res;
            }
        }

        static public DataTable GetDT(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
        }

        async static public Task<DataTable> GetDTAsync(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                await adapter.FillAsync(dataset);
                return dataset.Tables[0];
            }
        }
    }
}
