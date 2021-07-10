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
using System.IO;
using System.Data.SqlClient;

namespace MarksCard
{
    public partial class UpdateStudent : Form
    {
        
        offlinemarks.Remote lib=new offlinemarks.Remote();
        IPCon ip = new IPCon();
        public UpdateStudent()
        {
            InitializeComponent();
        }

        public void students()
        {
            DataSet ds = new DataSet();
            string s = string.Format("select Reg_no,Sname from Student_Details;");
            ds = lib.do_NonTransaction(s);

            cmbstd.DisplayMember = "Sname";
            cmbstd.ValueMember = "Reg_no";
            cmbstd.DataSource = ds.Tables[0];
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
            lib= (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }
        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            students();
            course();
            TCP_Connection();
            
            // TODO: This line of code loads data into the 'vCDataSet4.Student_details' table. You can move, or remove it, as needed.
            //this.student_detailsTableAdapter.Fill(this.vCDataSet4.Student_details);
        }
        public void course()
        {
            DataSet ds = new DataSet();
            string s = string.Format("select Cno,cname from course;");
            ds = lib.do_NonTransaction(s);
            cmbcourse.DisplayMember = "cname";
            cmbcourse.ValueMember = "Cno";
            cmbcourse.DataSource = ds.Tables[0];

        }
        string strfn = "";
        byte[] bs;
        public void student()
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection dbCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VC;Integrated Security=true"))
                {
                    dbCon.Open();

                    SqlCommand s = new SqlCommand("(SELECT s.Reg_no,s.Sname,s.Father_Name,s.Mother_Name,s.DOB,s.Adm_No,s.Phone_Num,s.Yearofpassing ,c.cname,s.canimage ,s.StudentNumber,s.SATS_NUMBER,s.GENDER FROM Student_details s,course c where c.cno=s.course_number and s.Reg_no=" + cmbstd.SelectedValue.ToString() + ");",dbCon);
                    string res = string.Format("(SELECT s.Reg_no,s.Sname,s.Father_Name,s.Mother_Name,s.DOB,s.Adm_No,s.Phone_Num,s.Yearofpassing ,c.cname,s.canimage ,s.StudentNumber,s.SATS_NUMBER,s.GENDER FROM Student_details s,course c where c.cno=s.course_number and s.Reg_no=" + cmbstd.SelectedValue.ToString() + ");");
                    ds = lib.do_NonTransaction(res);
                    //ds = b.do_NonTransaction(res);
                    txtadmno.Text = ds.Tables[0].Rows[0]["Adm_No"].ToString();
                    txtdob.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
                    txtfn.Text = ds.Tables[0].Rows[0]["Father_Name"].ToString();
                    txtmn.Text = ds.Tables[0].Rows[0]["Mother_Name"].ToString();
                    txtnum.Text = ds.Tables[0].Rows[0]["StudentNumber"].ToString();
                    txtphn.Text = ds.Tables[0].Rows[0]["Phone_Num"].ToString();
                    cmbgend.Text = ds.Tables[0].Rows[0]["GENDER"].ToString();
                    cmbyop.Text = ds.Tables[0].Rows[0]["Yearofpassing"].ToString();
                    txtrn.Text = ds.Tables[0].Rows[0]["Reg_no"].ToString();
                    txtsats.Text = ds.Tables[0].Rows[0]["SATS_NUMBER"].ToString();
                    cmbcourse.Text = ds.Tables[0].Rows[0]["cname"].ToString();
                    SqlDataAdapter da = new SqlDataAdapter(s);
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["canimage"]);
                        pictureBox1.Image = new Bitmap(ms);
                        label4.Visible = false;
                       
                    }
                    // pictureBox1.Load(ds.Tables[0].Rows[0]["canimage"].ToString());
                    // byte[] b = (ds.Tables[0].Rows[0]["canimage"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cmbstd_SelectedIndexChanged(object sender, EventArgs e)
        {
                student(); 
            try
            {
                if (lib != null)
                {
                    strfn = Convert.ToString(DateTime.Now.ToFileTime());
                    FileStream fs = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                    fs.Write(bs, 0, bs.Length);
                    fs.Flush();
                    fs.Close();
                    pictureBox1.Image = Image.FromFile(strfn);
                    label4.Visible = false;
                }
                else
                {
                    pictureBox1.Image = pictureBox1.ErrorImage;
                }
            }
            catch (Exception)
            {
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bImageData = GetImageData();
                using (SqlConnection dbCon = new SqlConnection(@"Data Source=admin-pc\sqlexpress;Initial Catalog=VC;Integrated Security=false;User ID=ADMIN;password=Dheemu"))
                {
                    using (SqlCommand q = new SqlCommand("update student_details set Sname=@sname,Father_Name=@fname, Mother_Name=@mname,DOB=@dob,Adm_No=@admno,Phone_Num=@phno,Yearofpassing=@yop,canimage=@cimage,StudentNumber=@studnum,SATS_NUMBER=@SATSNUM ,GENDER=@GEN where Reg_no=" + cmbstd.SelectedValue.ToString() + ";", dbCon))
                    {
                        q.Parameters.AddWithValue("@sname",cmbstd.Text);

                        q.Parameters.AddWithValue("@fname", txtfn.Text);
                        q.Parameters.AddWithValue("@mname", txtmn.Text);
                        q.Parameters.AddWithValue("@dob", txtdob.Text);
                        q.Parameters.AddWithValue("@admno", txtadmno.Text);
                        q.Parameters.AddWithValue("@phno", txtphn.Text);
                        q.Parameters.AddWithValue("@yop", cmbyop.Text);
                        
                     //   q.Parameters.AddWithValue("@cno", cmbcourse.SelectedValue.ToString());
                        q.Parameters.AddWithValue("@cimage", bImageData);
                        q.Parameters.AddWithValue("@studnum", txtnum.Text);
                        q.Parameters.AddWithValue("@SATSNUM", txtsats.Text);
                        q.Parameters.AddWithValue("@GEN", cmbgend.Text);
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
         
        }
    
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
        public byte[] GetImageData()
        {

           
            FileStream fsImageStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] bImageData = new byte[fsImageStream.Length];
            fsImageStream.Read(bImageData, 0, System.Convert.ToInt32(fsImageStream.Length));
            fsImageStream.Close();
            return bImageData;
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
    }
}
