using SIREMA.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SIREMA.Model
{
    internal class User
    {
        // CONNECTION ATTRIBUTE
        private ConnectionCls conn;

        private DataTable temp;
        private string query;

        public string _username = "";

        // CONSTRUCTOR
        public User()
        {
            conn = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        public bool login(string username, string password)
        {
            query = "SELECT * FROM user WHERE username = '" + username + "' and password = '" + password + "'";
            temp = conn.Query(query);

            if (temp.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getName(string username)
        {
            query = "SELECT username FROM user WHERE username = '" + username + "'";
            temp = conn.Query(query);

            return temp.Rows[0][0].ToString();
        }
    }
}