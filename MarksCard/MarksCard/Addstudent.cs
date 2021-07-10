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
using System.Data.SqlClient;
using System.IO;

namespace MarksCard
{
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }
        IPCon ip = new IPCon();
        //offlinemarks.Remote lib= new offlinemarks.Remote();
        public byte[] photo_aray;
        BL lib = new BL();

        
        public byte[] GetImageData()
        {

            FileStream fsImageStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] bImageData = new byte[fsImageStream.Length];
            fsImageStream.Read(bImageData, 0, System.Convert.ToInt32(fsImageStream.Length));
            fsImageStream.Close();
            return bImageData;
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txttqtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtadmno.Clear();
            txtmn.Clear();
            txtphn.Clear();
            txtrn.Clear();
            txtsn.Clear();
            txtsats.Clear();
            txtfn.Clear();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
            //this.Close();
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void course()
        {

            DataSet ds = new DataSet();
            try
            {
                string s = string.Format("Select Cno,cname from course;");
                ds = lib.do_NonTransaction(s);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbcourse.DisplayMember = "cname";
                    cmbcourse.ValueMember = "Cno";
                    cmbcourse.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
           // lib = (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }
        private void Addstudent_Load(object sender, EventArgs e)
        {
           
           
            // TODO: This line of code loads data into the 'vCDataSet.course' table. You can move, or remove it, as needed.
           // this.courseTableAdapter.Fill(this.vCDataSet.course);
            TCP_Connection();
           course();

            
        }

       public byte[] rawData;
        
   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Op = new OpenFileDialog();
                Op.Filter = "png Files(*.png)|*.png|Gif Files(*.gif)|*.gif|JPG Files(*.jpg)|*.jpg|All Files|*.*";
                Op.FilterIndex = 4;
                openFileDialog1.FileName = "SELECT";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    label4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   

            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Op = new OpenFileDialog();
                Op.Filter = "png Files(*.png)|*.png|Gif Files(*.gif)|*.gif|JPG Files(*.jpg)|*.jpg|All Files|*.*";
                Op.FilterIndex = 4;
                openFileDialog1.FileName = "SELECT";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                   
                    label4.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                byte[] bImageData = GetImageData();
                using (SqlConnection dbCon = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=VC;Integrated Security=false;User ID=ADMIN;password=Dheemu"))
                {
                    using (SqlCommand q = new SqlCommand("insert into Student_Details(Reg_no,Sname,father_Name,Mother_Name,DOB,Adm_No,Phone_Num,YearofPassing,Course_Number,canimage,StudentNumber,SATS_NUMBER,GENDER,caste,religion,NATIONALITY,SCST,CLASSLEAVE,QUALIFIED,MONTH,YEAR,DATELEAVE,CONDUCT)values(@Regno,@Sname,@fname,@mname,@dob,@admno,@phno,@yop,@cno,@cimage,@studnum,@SATSNUM,@GEND,@caste,@rel,@nat,@sc,@clslv,@qual,@mon,@yr,@dtlv,@cond)", dbCon))
                    {
                        //cmdSaveImage.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                        q.Parameters.AddWithValue("@Regno", txtrn.Text);
                        q.Parameters.AddWithValue("@Sname", txtsn.Text);
                        q.Parameters.AddWithValue("@fname", txtfn.Text);
                        q.Parameters.AddWithValue("@mname", txtmn.Text);
                        q.Parameters.AddWithValue("@dob",txtdob.Text);
                        q.Parameters.AddWithValue("@admno", txtadmno.Text);
                        q.Parameters.AddWithValue("@phno", txtphn.Text);
                        q.Parameters.AddWithValue("@yop",cmbyop.Text);
                     //   q.Parameters.AddWithValue("@fname", txtfn.Text);
                        q.Parameters.AddWithValue("@cno", cmbcourse.SelectedValue.ToString());
                        q.Parameters.AddWithValue("@cimage", bImageData);
                        q.Parameters.AddWithValue("@studnum", txtnum.Text);
                        q.Parameters.AddWithValue("@SATSNUM", txtsats.Text);
                        q.Parameters.AddWithValue("@GEND", cmbgend.Text);
                        q.Parameters.AddWithValue("@caste", txtcaste.Text);
                        q.Parameters.AddWithValue("@rel", txtrel.Text);
                        q.Parameters.AddWithValue("@nat", txtnatin.Text);
                        q.Parameters.AddWithValue("@sc", cmbsc.Text);
                        q.Parameters.AddWithValue("@clslv", txtclsleav.Text);
                        q.Parameters.AddWithValue("@qual", cmbqu.Text);
                        q.Parameters.AddWithValue("@mon", txtmonh.Text);
                        q.Parameters.AddWithValue("@yr", txtyr.Text);
                        q.Parameters.AddWithValue("@dtlv", dtleave.Text);
                        q.Parameters.AddWithValue("@cond", txtcond.Text);

                        if (dbCon.State == ConnectionState.Closed)
                            dbCon.Open();
                        q.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Successfully");

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //    try
            //{
            //    string register = string.Format("insert into Student_Details(Reg_no,Sname,father_Name,Mother_Name,DOB,Adm_No,Phone_Num,YearofPassing,Course_Number,canimage,StudentNumber)values(" + txtrn.Text + ",'" + txtsn.Text + "','" + txtfn.Text + "','" + txtmn.Text + "','" + txtdob.Text + "'," + txtadmno.Text + ",'" + txtphn.Text + "','" + cmbyop.Text + "'," + cmbcourse.SelectedValue.ToString() + ",'"+ photo_aray+ "','"+txtnum.Text+"');");
            //    if (bb.do_Transaction(register))
            //        MessageBox.Show("Inserted");
            //    //clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Addstudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        } 
    }
}
