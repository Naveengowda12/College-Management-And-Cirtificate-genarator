using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Threading;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
namespace offlinemarks
{
    public class Remote:MarshalByRefObject
    {


        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VC;Integrated Security=false;User ID=ADMIN;password=Dheemu ";
        SqlConnection oledbCon = null;
        //OleDbConnection oledbCon = null;
        //OleDbCommand oledbCmd = null;
        SqlCommand oledbCmd = null;
        SqlDataAdapter oledbAdap = null;
        //OleDbDataAdapter oledbAdap = null;

        public bool do_Transaction(string sql)
        {
            oledbCon = new SqlConnection(connectionString);

            if (oledbCon.State == System.Data.ConnectionState.Open)
                oledbCon.Close();

            oledbCon.Open();
            oledbCmd = new SqlCommand(sql, oledbCon);
            int result = oledbCmd.ExecuteNonQuery();
            oledbCon.Close();
            if (result > 0)
                return true;
            else
                return false;

        }

        public DataSet do_NonTransaction(string sql)
        {
            oledbCon = new SqlConnection(connectionString);

            if (oledbCon.State == System.Data.ConnectionState.Open)
                oledbCon.Close();

            oledbCon.Open();
            oledbCmd = new SqlCommand(sql, oledbCon);
            oledbAdap = new SqlDataAdapter(oledbCmd);
            DataSet ds = new DataSet();
            oledbAdap.Fill(ds);
            oledbCon.Close();
            return ds;
        }

        public int do_Aggregate(string sql)
        {
            oledbCon = new SqlConnection(connectionString);

            if (oledbCon.State == System.Data.ConnectionState.Open)
                oledbCon.Close();

            oledbCon.Open();
            oledbCmd = new SqlCommand(sql, oledbCon);
            int result = int.Parse(oledbCmd.ExecuteScalar().ToString());
            oledbCon.Close();
            return result;
        }
    }
}
    


