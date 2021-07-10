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
    public partial class DispStudent : Form
    {
        public DispStudent()
        {
            InitializeComponent();
        }
        //OfflineExamClass.Remote b;
        //offlinemarks.Remote lib = new offlinemarks.Remote();
        BL lib = new BL();
        IPCon ip = new IPCon();
        DataGridViewCheckBoxColumn c1;
        CheckBox ckBox;

        private void dtsent_ValueChanged(object sender, EventArgs e)
        {

        }
        public void course()
        {
            DataSet ds = new DataSet();
            string s = string.Format("select Cno,cname from course;");
            ds = lib.do_NonTransaction(s);
            cmbstud.DisplayMember = "cname";
            cmbstud.ValueMember = "Cno";
            cmbstud.DataSource = ds.Tables[0];
        }
        public void slctstudent()
        {
            DataSet DS = new DataSet();
            string qutn = string.Format("select sd.Reg_no,sd.Sname AS STUDENT_NAME,sd.DOB,sd.Father_Name,sd.Mother_Name,c.cname as cname,ss.sid1 as LANGUAGE_1,ss.sid2 AS LANGUAGE_2,ss.sid3 AS OPTINAL_1 ,ss.sid4 AS OPTIONAL_2,ss.sid5 AS OPTIONAL_3,ss.sid6  AS OPTIONAL_4 from Student_details sd,studentSubject ss,course c where sd.Reg_no=ss.sno and sd.course_number=c.Cno;");
            DS = lib.do_NonTransaction(qutn);

            dataGridView1.DataSource = DS.Tables[0];
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
        private void DispStudent_Load(object sender, EventArgs e)
        {
            TCP_Connection();   
            c1 = new DataGridViewCheckBoxColumn();

            //c1.Name = "selection";
            //c1.Name = "Select All";
            c1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.Columns.Add(c1);

            //this.dataGridView1.Rows.Add();
            //this.dataGridView1.Rows.Add();
            //this.dataGridView1.Rows.Add();
            //this.dataGridView1.Rows.Add();

            ckBox = new CheckBox();
            //Get the column header cell bounds
            Rectangle rect =
                this.dataGridView1.GetCellDisplayRectangle(0, -1, true);
            ckBox.Size = new Size(18, 18);

            rect.Y = 3;
            rect.X = rect.Location.X + 49;
            ckBox.BackColor = Color.Transparent;

            //Change the location of the CheckBox to make it stay on the header
            ckBox.Location = rect.Location;
            ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            //Add the CheckBox into the DataGridView
            this.dataGridView1.Controls.Add(ckBox);
            
            slctstudent();
            course();
            
            //this.dataGridView1.Refresh();
        }
        void ckBox_CheckedChanged(object sender, EventArgs e)
        {

            for (int j = 0; j < this.dataGridView1.RowCount; j++)
            {
                this.dataGridView1[0, j].Value = this.ckBox.Checked;

            }
            this.dataGridView1.EndEdit();

        }
        public void srcbyname()
        {
            DataSet DS = new DataSet();
            string qutn = string.Format("select sd.Reg_no,sd.Sname AS STUDENT_NAME,sd.DOB,sd.Father_Name,sd.Mother_Name,c.cname as cname,ss.sid1 as LANGUAGE_1,ss.sid2 AS LANGUAGE_2,ss.sid3 AS OPTINAL_1 ,ss.sid4 AS OPTIONAL_2,ss.sid5 AS OPTIONAL_3,ss.sid6  AS OPTIONAL_4 from Student_details sd,studentSubject ss,course c where sd.Reg_no=ss.sno and sd.course_number=c.Cno");
            DS = lib.do_NonTransaction(qutn);
            DataView DV = DS.Tables[0].DefaultView;
            DV.RowFilter = string.Format("STUDENT_NAME LIKE '{0}%' ", textBox1.Text);
            dataGridView1.DataSource = DV;
            this.dataGridView1.RefreshEdit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            srcbyname();
            this.dataGridView1.RefreshEdit();
        }

        public void srcbyreg()
        {
            DataSet DS = new DataSet();
            string qutn = string.Format("select sd.Reg_no REG_NUMBER,sd.Sname AS STUDENT_NAME,sd.DOB,sd.Father_Name,sd.Mother_Name,c.cname as cname,ss.sid1 as LANGUAGE_1,ss.sid2 AS LANGUAGE_2,ss.sid3 AS OPTINAL_1 ,ss.sid4 AS OPTIONAL_2,ss.sid5 AS OPTIONAL_3,ss.sid6  AS OPTIONAL_4 from Student_details sd,studentSubject ss,course c where sd.Reg_no=ss.sno and sd.course_number=c.Cno and REG_NUMBER="+textBox1.Text+";");
            DS = lib.do_NonTransaction(qutn);
         //   DataView DV = DS.Tables[0].DefaultView;
           // DV.RowFilter = string.Format("REG_NUMBER={0} ",textBox1.Text);
            dataGridView1.DataSource = DS;
            this.dataGridView1.RefreshEdit();
        }


        private void cmbstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //srcbyname();
            //srcbycrs();
            //this.dataGridView1.RefreshEdit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            srcbyreg();
            this.dataGridView1.RefreshEdit();
        }

    }
}
