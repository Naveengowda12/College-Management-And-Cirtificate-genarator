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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }
        //offlinemarks.Remote lib = new offlinemarks.Remote();
        BL lib = new BL();
        IPCon ip = new IPCon();

        public void TCP_Connection()
        {
            DataSet ds = new DataSet();
            string qry = string.Format("select * from Protocol");
            ds = ip.do_NonTransaction(qry);
            string ipc = ds.Tables[0].Rows[0]["IPProtocol"].ToString();
            int port = int.Parse(ds.Tables[0].Rows[0]["Port"].ToString());
            string s = ipc.TrimEnd();
            string url = "tcp://" + s + ":" + port + "/Remote";
           // lib = (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

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
            string qutn = string.Format("select  Reg_no,Sname as StudentName,Father_Name,Mother_Name,DOB,Adm_No,c.cname,StudentNumber,SATS_NUMBER,GENDER from Student_Details s,course c where s.course_number=c.Cno");
            DS = lib.do_NonTransaction(qutn);

            dataGridView1.DataSource = DS.Tables[0];
        }
        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vCDataSet5.Student_details' table. You can move, or remove it, as needed.
            this.student_detailsTableAdapter.Fill(this.vCDataSet5.Student_details);
            TCP_Connection();
            course();
            slctstudent();

        }
        public void slctstudentbycrs()
        {
            DataSet DS = new DataSet();
            string qutn = string.Format("select  Reg_no,Sname as StudentName,Father_Name,Mother_Name,DOB,Adm_No,c.cname,StudentNumber,SATS_NUMBER,GENDER from Student_Details s,course c where s.course_number=c.Cno and c.cno="+cmbstud.SelectedValue.ToString()+";");
            DS = lib.do_NonTransaction(qutn);

            dataGridView1.DataSource = DS.Tables[0];
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            slctstudentbycrs();
        }

        public void slctstudentbyreg()
        {
            DataSet DS = new DataSet();
            string qutn = string.Format("select  Reg_no,Sname as StudentName,Father_Name,Mother_Name,DOB,Adm_No,c.cname,StudentNumber,SATS_NUMBER,GENDER from Student_Details s,course c where s.course_number=c.Cno and s.Reg_no=" + txtreg.Text+ ";");
            DS = lib.do_NonTransaction(qutn);

            dataGridView1.DataSource = DS.Tables[0];
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtreg_TextChanged(object sender, EventArgs e)
        {
            slctstudentbyreg();
        }
        public void srcbyname()
        {
            DataSet DS = new DataSet();
            string qutn = string.Format("select  Reg_no,Sname as StudentName,Father_Name,Mother_Name,DOB,Adm_No,c.cname,StudentNumber,SATS_NUMBER,GENDER from Student_Details s,course c where s.course_number=c.Cno");
            DS = lib.do_NonTransaction(qutn);
            DataView DV = DS.Tables[0].DefaultView;
            DV.RowFilter = string.Format("StudentName LIKE '{0}%' ", txtname.Text);
            dataGridView1.DataSource = DV;
            this.dataGridView1.RefreshEdit();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            srcbyname();
        }
    }
}
