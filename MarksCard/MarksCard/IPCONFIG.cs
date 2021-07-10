using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;


namespace MarksCard
{
    public partial class IPCONFIG : Form
    {
        public IPCONFIG()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        OleDbConnection con;
        OleDbCommand cmd;
        // OleDbDataAdapter adp;
        string s = "";
        Login lg = new Login();
        public void connection()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\IpConfig\IpConfig.accdb");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void loadip()
        {
            try
            {
                DataSet ds = new DataSet();
                con.Open();
                //s = txt1.Text + "." + txt2.Text + "." + txt3.Text + "." + txt4.Text;
                //cmd = new OleDbCommand("Insert into Protocol (IPProtocol,Port) values('" + s + "'," + txtport.Text + ")", con);
                cmd = new OleDbCommand("Select * from Protocol ", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var s = dr["IPProtocol"].ToString();
                    // txt1.Text = dr["IPProtocol"].ToString();
                    var results = s.Split('.');

                    txt1.Text = results[0].ToString();
                    txt2.Text = results[1].ToString();
                    txt3.Text = results[2].ToString();
                    txt4.Text = results[3].ToString();
                    txtport.Text = dr["Port"].ToString();
                }

                dr.Close();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Set IpConfig File on C Drive", "Database Error");
                Application.Exit();
            }
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                s = txt1.Text + "." + txt2.Text + "." + txt3.Text + "." + txt4.Text;
                //cmd = new OleDbCommand("Insert into Protocol (IPProtocol,Port) values('" + s + "'," + txtport.Text + ")", con);
                cmd = new OleDbCommand("Update Protocol set IPProtocol='" + s + "',Port=" + txtport.Text + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IPCONFIG_Load(object sender, EventArgs e)
        {

            string myHost = Dns.GetHostName();
          //  this.Text = "Settings " + "(System IP - " + Dns.EndGetHostEntry(myHost).AddressList[0].ToString() + ")";
            this.Text = "Settings " + "(System IP - " + Dns.GetHostByName(myHost).AddressList[0].ToString() + ")";
            connection();
            loadip();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            lg.Show();

        }

        private void IPCONFIG_FormClosed(object sender, FormClosedEventArgs e)
        {
            lg.Show();
        }
    }
}
