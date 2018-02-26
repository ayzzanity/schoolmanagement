using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplication2
{
    class DBTransactions
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        ConnectionString connString = new ConnectionString();

        public DataSet list(string sql) {
            DataSet ds = new DataSet();
            con.ConnectionString = connString.connString();
            da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, "Data");
            con.Close();
            return ds;
        }

        public void executeSql(string sql) {
            con.ConnectionString = connString.connString();
            con.Open();
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
