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
    public partial class TCS : Form
    {
        public TCS()
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
            //lib = (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }
        public void students()
        {
            DataSet ds = new DataSet();
            string s = string.Format("Select Reg_No,sname from Student_details;");
            ds = lib.do_NonTransaction(s);
            //ds = bs.do_NonTransaction(s);
            cmbstud.DisplayMember = "Sname";
            cmbstud.ValueMember = "Reg_No";
            cmbstud.DataSource = ds.Tables[0];

        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Student_detailsTableAdapter.Fill(this.VCDataSet6.Student_details,int.Parse(cmbstud.SelectedValue.ToString()));
            //this.Student_detailsTableAdapter.Fill(this.VCDataSet6.Student_details, int.Parse(cmbstud.SelectedValue.ToString()));
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            //this.Student_detailsTableAdapter.Fill(this.VCDataSet6.Student_details ,int.Parse(cmbstud.SelectedValue.ToString()));
            this.student_detailsTableAdapter.Fill(this.vCDataSet7.Student_details, int.Parse(cmbstud.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void TCS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vCDataSet7.Student_details' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'VCDataSet7.Student_details' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'VCDataSet6.Student_details' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'VCDataSet6.Student_details' table. You can move, or remove it, as needed.
           // this.Student_detailsTableAdapter.Fill(this.VCDataSet6.Student_details);
            // TODO: This line of code loads data into the 'VCDataSet6.Student_details' table. You can move, or remove it, as needed.
                      // TODO: This line of code loads data into the 'VCDataSet6.Student_details' table. You can move, or remove it, as needed.
           // this.Student_detailsTableAdapter.Fill(this.VCDataSet6.Student_details);
            TCP_Connection();
            students();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
