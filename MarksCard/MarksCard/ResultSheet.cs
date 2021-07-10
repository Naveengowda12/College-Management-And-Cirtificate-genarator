using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarksCard
{
    public partial class ResultSheet : Form
    {
        public ResultSheet()
        {
            InitializeComponent();
        }
        IPCon ip = new IPCon();
        //offlinemarks.Remote lib= new offlinemarks.Remote();
        BL lib = new BL();
        public void TCP_Connection()
        {
            DataSet ds = new DataSet();
            string qry = string.Format("select * from Protocol");
            ds = ip.do_NonTransaction(qry);
            string ipc = ds.Tables[0].Rows[0]["IPProtocol"].ToString();
            int port = int.Parse(ds.Tables[0].Rows[0]["Port"].ToString());
            string s = ipc.TrimEnd();
            string url = "tcp://" + s + ":" + port + "/Remote";
           // lib= (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

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
        private void ResultSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VCDataSet3.MarksDetails' table. You can move, or remove it, as needed.
           
                        // TODO: This line of code loads data into the 'VCDataSet3.MarksDetails' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'VCDataSet1.Student_details' table. You can move, or remove it, as needed.

            
            TCP_Connection();
            course();
            // TODO: This line of code loads data into the 'vCDataSet.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.vCDataSet.course);
            

            // TODO: This line of code loads data into the 'VCDataSet3.MarksDetails' table. You can move, or remove it, as needed.
            //this.MarksDetailsTableAdapter.Fill(this.VCDataSet3.MarksDetails);

           // this.reportViewer1.RefreshReport();
        }

        private void cmbstud_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.MarksDetailsTableAdapter.Fill(this.VCDataSet3.MarksDetails, int.Parse(cmbstud.SelectedValue.ToString()));
                // this.Student_detailsTableAdapter.Fill(this.VCDataSet1.Student_details,int.Parse(cmbstud.SelectedValue.ToString()));
                //this.MarksDetailsTableAdapter.Fill(this.VCDataSet3.MarksDetails, int.Parse(cmbstud.SelectedValue.ToString()));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResultSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void ResultSheet_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
