using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WachtrijApp
{
    class SqlDbConnection
    {
        private MySqlConnection _con;
        public MySqlCommand Cmd;


        public SqlDbConnection()
        {
            _con = new MySqlConnection("Server = localhost; Database = WachtrijApp; username = root; password = ");
            _con.Open();

        }

        public void SqlQuery(string queryText)
        {
            Cmd = new MySqlCommand(queryText, _con);
        }

        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }

     
    }
}
