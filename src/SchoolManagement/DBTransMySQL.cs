using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class DBTransMySQL
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        ConnectionString connString = new ConnectionString();

        public DataSet list(string sql)
        {
            DataSet ds = new DataSet();
            con.ConnectionString = connString.connString2();
            da = new MySqlDataAdapter(sql, con);
            da.Fill(ds, "Data");
            con.Close();
            return ds;
        }

        public void executeSql(string sql)
        {
            con.ConnectionString = connString.connString2();
            con.Open();
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
