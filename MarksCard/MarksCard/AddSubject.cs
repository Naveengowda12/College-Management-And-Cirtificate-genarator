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
    
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }
        IPCon ip = new IPCon();
        //offlinemarks.Remote lib = new offlinemarks.Remote();
        BL lib = new BL();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void TCP_Connection()
        {
            DataSet ds = new DataSet();
            string qry = string.Format("select * from Protocol");
            ds = ip.do_NonTransaction(qry);
            string ipc = ds.Tables[0].Rows[0]["IPProtocol"].ToString();
            int port = int.Parse(ds.Tables[0].Rows[0]["Port"].ToString());
            string s = ipc.TrimEnd();
            string url = "tcp://" + s + ":" + port + "/Remote";
            //lib = (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }
        private void AddSubject_Load(object sender, EventArgs e)
        {
            TCP_Connection();
            students();
            
           // course();
            
        }
        public void students()
        {
            DataSet ds = new DataSet();
            string s = string.Format("Select Reg_No,sname from Student_details;");
            ds = lib.do_NonTransaction(s);
            cmbstud.DisplayMember = "Sname";
            cmbstud.ValueMember = "Reg_No";
            cmbstud.DataSource = ds.Tables[0];
           
        }
        public void course()
        {
            DataSet ds = new DataSet();
            string s = string.Format("Select c.Cno,c.cname from course c,student_details s where s.course_number=c.cno and s.Reg_no=" + cmbstud.SelectedValue.ToString() + ";");
            ds = lib.do_NonTransaction(s);

            //cmbcourse.DisplayMember = "c.cname";
            //cmbstud.ValueMember = "c.Cno";
            cmbcourse.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            try
            {
                
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        if (s == " ")
                        {
                            s = checkedListBox1.CheckedItems[i].ToString();
                        }
                        else

                            s += checkedListBox1.CheckedItems[i].ToString()+",";
                    }
                }

                //string[] s1;
                string[] s1 = new string[1];
                s1 = s.Split(',');


                string register = string.Format("insert into StudentSubject(sno,sid1,sid2,sid3,sid4,sid5,sid6,cno) values(" + cmbstud.SelectedValue.ToString() + ",'" + s1[0] + "','" + s1[1] + "','" + s1[2] + "','" + s1[3] + "','" + s1[4] + "','" + s1[5] + "'," + cmbcourse.SelectedValue.ToString() + ");");
                if (lib.do_Transaction(register))
                    MessageBox.Show("Inserted");
                //clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            course();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
