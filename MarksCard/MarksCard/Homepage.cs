using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;

namespace MarksCard
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string dbpath = Application.StartupPath;
        Addstudent ad = new Addstudent();
        AddSubject ads = new AddSubject();
        AddMarks am = new AddMarks();
        PrintMarks pm = new PrintMarks();
        DispStudent ds = new DispStudent();
        ResultSheet rs = new ResultSheet();
        UpdateStudent ups = new UpdateStudent();
        StudentList sl = new StudentList();
        TCS t = new TCS();
        public void formhide()
        {
            ups.Hide();
            t.Hide();
            ad.Hide();
            ads.Hide();
            am.Hide();
            pm.Hide();
            ds.Hide();
            rs.Hide();
            sl.Hide();
        }

        //public void formdispose()
        //{
        //    ups.Dispose();
        //    ds.Dispose();
        //    ad.Dispose();
        //    ads.Dispose();
        //    am.Dispose();
        //    pm.Dispose();
        //    rs.Dispose();
        //}
        private void Homepage_Load(object sender, EventArgs e)
        {
            string myHost = Dns.GetHostName();
            this.Text = "MARKS CARD " + "(System IP - " + Dns.GetHostByName(myHost).AddressList[0].ToString() + ")";
        }

        private void addQTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            ad.MdiParent = this;
            ad.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            ads.MdiParent = this;
            ads.Show();
        }

        private void addMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            am.MdiParent = this;
            am.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            pm.MdiParent = this;
            pm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            ds.MdiParent = this;
            ds.Show();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            sl.MdiParent = this;
            sl.Show();
        }

        private void resultSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            rs.MdiParent = this;
            rs.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            ups.MdiParent = this;
            ups.Show();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrintMarks p = new PrintMarks();
            ResultSheet r = new ResultSheet();
            
            p.Dispose();
            r.Dispose();
            this.Close();
            Application.Exit();
        }

        private void transferCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formhide();
            t.MdiParent = this;
            t.Show();
        }
        }
    }

