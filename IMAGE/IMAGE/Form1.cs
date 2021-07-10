using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace IMAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public byte[] GetImageData()
        {

            FileStream fsImageStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] bImageData = new byte[fsImageStream.Length];
            fsImageStream.Read(bImageData, 0, System.Convert.ToInt32(fsImageStream.Length));
            fsImageStream.Close();
            return bImageData;
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
                using (SqlConnection dbCon = new SqlConnection(@"Data Source=admin-pc\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=true"))
                {
                    using (SqlCommand cmdSaveImage = new SqlCommand("INSERT INTO [dbo].[Student] (StudentImage) VALUES (@StudentImage)", dbCon))
                    {
                        //cmdSaveImage.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                        cmdSaveImage.Parameters.AddWithValue("@StudentImage", bImageData);
                        if (dbCon.State == ConnectionState.Closed)
                            dbCon.Open();
                        cmdSaveImage.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Successfully");

                    }
                }

            }
            catch (Exception ex)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
