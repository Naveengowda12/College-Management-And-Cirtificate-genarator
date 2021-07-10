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





namespace MarksCard
{
    class IPCon:MarshalByRefObject
    {
    

     string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\IpConfig\IpConfig.accdb";
        

         OleDbConnection oledbCon = null;
        
         OleDbCommand oledbCmd = null;
       OleDbDataAdapter oledbAdap = null;


        public DataSet do_NonTransaction(string sql)
        {
            oledbCon = new OleDbConnection(conn);

            if (oledbCon.State == System.Data.ConnectionState.Open)
                oledbCon.Close();

            oledbCon.Open();
            oledbCmd = new OleDbCommand(sql, oledbCon);
            oledbAdap = new OleDbDataAdapter(oledbCmd);
            DataSet ds = new DataSet();
            oledbAdap.Fill(ds);
            oledbCon.Close();
            return ds;
        }
    }
}

