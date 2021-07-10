using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Net;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Threading;


namespace MARKSSERVER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dbname = "VC";
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        TcpServerChannel server = new TcpServerChannel(5555);
        //TcpClient clientSocket = default(TcpClient);

        public TcpListener tcp = null;
        Socket client = null;
        public Thread thread;

        private void service()
        {
            while (thread.IsAlive)
            {

                client = tcp.AcceptSocket();
                string s = client.RemoteEndPoint.ToString();
                int no = s.IndexOf(":");
                s = s.Remove(no);

                ListViewItem L = new ListViewItem(s);
                //foreach (var item in s)
                //{
                L.SubItems.Add(DateTime.Now.ToString());

                CheckForIllegalCrossThreadCalls = false;
                listView1.Items.Add(L);
                //}
                // listView1.Items.Add(L.ToString());

                //client.Send(ASCIIEncoding.ASCII.GetBytes("mice"));
                client.Close();


            }
        }
        
     
        private void Form1_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("Client Ip-Address", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Start Time", 210, HorizontalAlignment.Left);
            label2.Text = server.GetChannelUri();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(offlinemarks.Remote), "Remote", WellKnownObjectMode.SingleCall);
            button1.Enabled = false;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = " Marks Server Running";
            notifyIcon1.BalloonTipTitle = "Server";
            notifyIcon1.ShowBalloonTip(100);
            tcp = new TcpListener(6666);
            tcp.Start();
            thread = new Thread(new ThreadStart(service));
            thread.Start();
            //this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object s = MessageBox.Show("Are you sure want to take Back Up", "Alert", MessageBoxButtons.YesNo);
            if (s.ToString() == "Yes")
            {
                sqlcon.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VC;Integrated Security=True;MultipleActiveResultSets=True;";
                string destdir = "D:\\MARKSDATA";

                //Check that directory already there otherwise create 
                if (!System.IO.Directory.Exists(destdir))
                {
                    System.IO.Directory.CreateDirectory("D:\\MARKSDATA");
                }
                try
                {
                    //Open connection
                    sqlcon.Open();
                    //query to take backup database
                    sqlcmd = new SqlCommand("backup database  " + dbname + " to disk='" + destdir + "\\" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".Bak'", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    //Close connection
                    sqlcon.Close();
                    sqlcon.Dispose();
                    MessageBox.Show("Backup Created Sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                if (button1.Enabled == false)
                {
                    thread.Abort();

                    tcp.Stop();
                    //  client.Close();
                }
                this.Dispose();
                Application.Exit();
                e.Cancel = false;
            }         
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (button1.Enabled == false)
            {
                thread.Abort();
                //client.Close();
                tcp.Stop();
                
               
            }
            this.Dispose();
            Application.Exit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Yes)
                {
                    if (button1.Enabled == false)
                    {

                        tcp.Stop();
                        //     Application.Exit();

                        thread.Abort();


                        //  client.Close();
                    }
                    Application.Exit();

                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        }






    }

