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
    public partial class PrintMarks : Form
    {
        public PrintMarks()
        {
            InitializeComponent();
        }
        
        //offlinemarks.Remote lib= new offlinemarks.Remote();
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
            //lib= (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }
        private void PrintMarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VCDataSet1.Student_details' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'VCDataSet1.Student_details' table. You can move, or remove it, as needed.
            
            TCP_Connection();
            students();
            
            // TODO: This line of code loads data into the 'VCDataSet1.Student_details' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'VCDataSet.MarksDetails' table. You can move, or remove it, as needed.
          //  this.MarksDetailsTableAdapter.Fill(this.VCDataSet.MarksDetails);
            // TODO: This line of code loads data into the 'VCDataSet3.Student_details' table. You can move, or remove it, as needed.
            //this.Student_detailsTableAdapter.Fill(this.VCDataSet3.Student_details);
            // TODO: This line of code loads data into the 'VCDataSet.MarksDetails' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'VCDataSet.MarksDetails' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'VCDataSet.MarksDetails' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.Student_detailsTableAdapter.Fill(this.VCDataSet1.Student_details,int.Parse(cmbstud.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reportViewer1.PrintDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrintMarks_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void PrintMarks_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
