using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIREMA.Configuration
{
    internal class ConnectionCls : ConfigurationCls
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;

        private string link = "server=localhost;port=3306;database=sirema;uid=root;pwd=;";

        public ConnectionCls()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        public void connect()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void disconnect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public override int NonQuery(string query)
        {
            int result = -1;

            try
            {
                connect();
                cmd.Connection = conn;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                disconnect();
            }

            return result;
        }

        public override DataTable Query(string query)
        {
            DataTable result = new DataTable();

            try
            {
                connect();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                disconnect();
            }

            return result;
        }
    }
}