using System.Data;
using MySql.Data.MySqlClient;

namespace WachtrijApp
{
    class SqlDbConnection
    {
        private MySqlConnection _con;
        public MySqlCommand Cmd;
        private MySqlDataAdapter _da;
        private DataTable _dt;
        
        
        public SqlDbConnection()
        {
            //Connectie wordt gemaakt.
            //externe database
            // _con = new MySqlConnection("Server=remotemysql.com; port=3306;  Database=sPjBjePdtf; username=sPjBjePdtf; password=DvLp0RVQAX");

            //locale database
            _con = new MySqlConnection("Server=localhost;  Database=sPjBjePdtf; username=root; password= ");

            _con.Close();
            _con.Open();

        }
        //Query wordt gemaakt naar command
        public void SqlQuery(string queryText)
        {
            Cmd = new MySqlCommand(queryText, _con);
        }
        //Query wordt uitgevoerd en krijgt informatie terug
        public DataTable QueryEx()
        {
            _da = new MySqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);

            return _dt;
        }
        //Query wordt uitgevoerd met geen resultaat
        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}
