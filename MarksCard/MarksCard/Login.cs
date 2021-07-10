using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using offlinemarks;

namespace MarksCard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string ipadd, ipadd1;
        public string s = "";
        //  IPCon ip = new IPCon();
       //offlinemarks.Remote lib=new offlinemarks.Remote();
        BL lib = new BL();
        IPCon ip = new IPCon();


        public string pswd = "";



        public void TCP_Connection()
        {
            DataSet ds = new DataSet();
            string qry = string.Format("select * from Protocol");
            ds = ip.do_NonTransaction(qry);
            string ipc = ds.Tables[0].Rows[0]["IPProtocol"].ToString();
            int port = int.Parse(ds.Tables[0].Rows[0]["Port"].ToString());
            s = ipc.TrimEnd();
            string url = "tcp://" + s + ":" + port + "/Remote";
            //    string url = "tcp://192.168.0.104:5555/Remote";
        //   lib = (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }

        public void conser()
        {
            //string myHost = Dns.GetHostName();

            //ipadd = Dns.GetHostByName(myHost).AddressList[0].ToString();
            try
            {
                TcpClient client = new TcpClient(s, 6666);
                NetworkStream stream = client.GetStream();

                byte[] data = new byte[50];
                int drecieved = stream.Read(data, 0, 50);

                label1.Text = ASCIIEncoding.ASCII.GetString(data, 0, drecieved);


                client.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            IPCONFIG ipc = new IPCONFIG();
            ipc.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string qry = string.Format("(Select UserName,Password from Login where Password='" + txtpasswd.Text + "')");
                ds = lib.do_NonTransaction(qry);
                var uname = ds.Tables[0].Rows[0]["UserName"].ToString();
                var Password = ds.Tables[0].Rows[0]["Password"].ToString();
                if (txtuname.Text == uname.TrimEnd() && txtpasswd.Text == Password.TrimEnd())
                {
                    conser();
                    this.Hide();
                    Homepage f1 = new Homepage();
                    //f1.paswd = txtpasswd.Text;
                    //f1.examToolStripMenuItem.Visible = false;
                   // f1.examToolStripMenuItem.Visible = false;
                    //f1.reportsToolStripMenuItem.Visible = false;
                    f1.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string myHost = Dns.GetHostName();
            this.Text = "Login " + "(System IP - " + Dns.GetHostByName(myHost).AddressList[0].ToString() + ")";
            TCP_Connection();
            txtuname.Focus();
           // cmbutype.SelectedIndex = 0;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
