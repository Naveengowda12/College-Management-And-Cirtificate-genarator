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
    
    public partial class AddMarks : Form
    {
       
       // offlinemarks.Remote lib=new offlinemarks.Remote();
        BL lib = new BL();
        IPCon ip = new IPCon();
        public AddMarks()
        {
            InitializeComponent();
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
          //  lib = (offlinemarks.Remote)Activator.GetObject(typeof(offlinemarks.Remote), url);

        }
        public String name = "";
        
        public void student()
        {
            DataSet ds = new DataSet();
            string s = string.Format("(Select Reg_no,Sname from Student_Details );");
            ds = lib.do_NonTransaction(s);
            cmbstud.DisplayMember = "Sname";
            cmbstud.ValueMember = "Reg_no";
            cmbstud.DataSource = ds.Tables[0];
           

        }
        public void course()
        {
            DataSet d = new DataSet();
            string s = string.Format("Select c.Cno,c.cname from course c,student_details s where s.course_number=c.cno and s.Reg_no=" + cmbstud.SelectedValue.ToString() + ";");
            d = lib.do_NonTransaction(s);

           // cmbcourse.DisplayMember = "cname";
            //cmbstud.ValueMember = "Cno";
            cmbcourse.DataSource = d.Tables[0];

        }
        public void details()
        {
            DataSet dd = new DataSet();
            string q = string.Format("(SELECT ss.sid1,ss.sid2,ss.sid3,ss.sid4,ss.sid5,ss.sid6,c.cname from studentSubject ss,course c,Student_details sd where c.Cno=sd.course_number and sd.Reg_no=ss.sno and sd.Reg_no="+cmbstud.SelectedValue.ToString()+");");
            dd=lib.do_NonTransaction(q);
            if (dd.Tables[0].Rows.Count > 0)
            {
                lblsid1.Text = dd.Tables[0].Rows[0]["sid1"].ToString();
                lblsid2.Text = dd.Tables[0].Rows[0]["sid2"].ToString();
                lblsid3.Text = dd.Tables[0].Rows[0]["sid3"].ToString();
                lblsid4.Text = dd.Tables[0].Rows[0]["sid4"].ToString();
                lblsid5.Text = dd.Tables[0].Rows[0]["sid5"].ToString();
                lblsid6.Text = dd.Tables[0].Rows[0]["sid6"].ToString();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            course();
            details();
            txtenab();
        }
        public void txtenab()
        {
            if (cmbcourse.Text.Trim() == "PCMB" || cmbcourse.Text.Trim() == "PCMC")
            {
                txtth1.Enabled = true;
                txtth2.Enabled = true;
              
                txtth4.Enabled = true;
                txtp1.Enabled = true;
                txtp2.Enabled = true;
               
                txtp4.Enabled = true;
            }

            else if (cmbcourse.Text.Trim() == "EBAC")
            {
                txtth1.Enabled = false;
                txtth2.Enabled = false;
                txtth3.Enabled = false;
                txtp4.Enabled = true;
                txtth4.Enabled = true;
                txtp1.Enabled = false;
                txtp2.Enabled = false;
                txtp3.Enabled = false;
            }
            else
            {
                txtth1.Enabled = false;
                txtth2.Enabled = false;
                txtth3.Enabled = false;
                txtth4.Enabled = false;
                txtp1.Enabled = false;
                txtp2.Enabled = false;
                txtp3.Enabled = false;
                txtp4.Enabled = false;
                txtp4.Text = "0";
            }
            
        }

        private void AddMarks_Load(object sender, EventArgs e)
        {
            TCP_Connection();
            student();
            
            this.Refresh();
        }
        
        public String ones(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            
            switch (_Number)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
            //lblword.Text = name;
        }
        double tot = 0, avg = 0;

        public void res()
        {
                            String s = NumberToWords(int.Parse(txttot.Text.ToString())); 
                lbltot.Text = s + " " + "only";
         
        }
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int sum1 = 0,F=0;
                sum1 = Convert.ToInt32(txtsid1.Text.ToString()) + Convert.ToInt32(txtsid2.Text.ToString());
                if (sum1 > 70 && Convert.ToInt32(txtsid1.Text.ToString()) >= 30 && Convert.ToInt32(txtsid2.Text.ToString()) >= 30)
                {
                    F = 1;
                }
                else
                {
                    F = 0;
                }
                if (cmbcourse.Text.Trim() == "PCMB" || cmbcourse.Text.Trim() == "PCMC")
                {

                    if (F == 0)
                    {
                        if (Convert.ToInt32(txtth1.Text.ToString()) < 21 || Convert.ToInt32(txtth2.Text.ToString()) < 21 || Convert.ToInt32(txtsid5.Text.ToString()) < 35 || Convert.ToInt32(txtth4.Text.ToString()) < 21 || Convert.ToInt32(txtsid1.Text.ToString()) < 35 || Convert.ToInt32(txtsid2.Text.ToString()) < 35)
                        {
                            // return 0;

                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;

                            txtres.Text = "Fail";


                        }
                        else
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            if (avg >= 85 && avg <= 100)
                            {
                                txtres.Text = "DISTINCTION";
                            }
                            else if (avg >= 60 && avg < 85)
                            {
                                txtres.Text = "FIRST CLASS";
                            }
                            else if (avg >= 50 && avg < 60)
                            {
                                txtres.Text = "SECOND CLASS";
                            }
                            else if (avg >= 35 && avg < 50)
                            {
                                txtres.Text = "PASS";
                            }
                            else if (avg >= 0 && avg < 35)
                            {
                                txtres.Text = "FAIL";
                            }
                        }


                    }
                    else
                    {
                        if (Convert.ToInt32(txtth1.Text.ToString()) < 21 || Convert.ToInt32(txtth2.Text.ToString()) < 21 || Convert.ToInt32(txtsid5.Text.ToString()) < 35 || Convert.ToInt32(txtth4.Text.ToString()) < 21)
                        {
                            // return 0;

                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;

                            txtres.Text = "Fail";


                        }
                        else
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            if (avg >= 85 && avg <= 100)
                            {
                                txtres.Text = "DISTINCTION";
                            }
                            else if (avg >= 60 && avg < 85)
                            {
                                txtres.Text = "FIRST CLASS";
                            }
                            else if (avg >= 50 && avg < 60)
                            {
                                txtres.Text = "SECOND CLASS";
                            }
                            else if (avg >= 35 && avg < 50)
                            {
                                txtres.Text = "PASS";
                            }
                            else if (avg >= 0 && avg < 35)
                            {
                                txtres.Text = "FAIL";
                            }
                        }

                    }

                }
                else if (cmbcourse.Text.Trim() == "EBAC")
                {
                    if (F == 0)
                    {
                        if (Convert.ToInt32(txtsid1.Text.ToString()) < 35 || Convert.ToInt32(txtsid2.Text.ToString()) < 35 || Convert.ToInt32(txtsid3.Text.ToString()) < 35 || Convert.ToInt32(txtsid4.Text.ToString()) < 35 || Convert.ToInt32(txtsid5.Text.ToString()) < 35 || Convert.ToInt32(txtth4.Text.ToString()) < 21)
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            txtres.Text = "Fail";
                        }
                        else
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            if (avg >= 85 && avg <= 100)
                            {
                                txtres.Text = "DISTINCTION";
                            }
                            else if (avg >= 60 && avg < 85)
                            {
                                txtres.Text = "FIRST CLASS";
                            }
                            else if (avg >= 50 && avg < 60)
                            {
                                txtres.Text = "SECOND CLASS";
                            }
                            else if (avg >= 35 && avg < 50)
                            {
                                txtres.Text = "PASS";
                            }
                            else if (avg >= 0 && avg < 35)
                            {
                                txtres.Text = "FAIL";
                            }
                        }
                    }
                    else
                    {
                        if ( Convert.ToInt32(txtsid3.Text.ToString()) < 35 || Convert.ToInt32(txtsid4.Text.ToString()) < 35 || Convert.ToInt32(txtsid5.Text.ToString()) < 35 || Convert.ToInt32(txtth4.Text.ToString()) < 21 )
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            txtres.Text = "Fail";
                        }
                        else
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            if (avg >= 85 && avg <= 100)
                            {
                                txtres.Text = "DISTINCTION";
                            }
                            else if (avg >= 60 && avg < 85)
                            {
                                txtres.Text = "FIRST CLASS";
                            }
                            else if (avg >= 50 && avg < 60)
                            {
                                txtres.Text = "SECOND CLASS";
                            }
                            else if (avg >= 35 && avg < 50)
                            {
                                txtres.Text = "PASS";
                            }
                            else if (avg >= 0 && avg < 35)
                            {
                                txtres.Text = "FAIL";
                            }
                        }
                    }
                }



                else if (txtsid1.Text != "" && txtsid2.Text != "" && txtsid3.Text != "" && txtsid4.Text != "" && txtsid5.Text != "" && txtsid6.Text != "")
                {
                    if (F == 0)
                    {
                        if (Convert.ToInt32(txtsid1.Text.ToString()) < 35 || Convert.ToInt32(txtsid2.Text.ToString()) < 35 || Convert.ToInt32(txtsid3.Text.ToString()) < 35 || Convert.ToInt32(txtsid4.Text.ToString()) < 35 || Convert.ToInt32(txtsid5.Text.ToString()) < 35 || Convert.ToInt32(txtsid6.Text.ToString()) < 35)
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            txtres.Text = "Fail";
                        }
                        else
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            if (avg >= 85 && avg <= 100)
                            {
                                txtres.Text = "DISTINCTION";
                            }
                            else if (avg >= 60 && avg < 85)
                            {
                                txtres.Text = "FIRST CLASS";
                            }
                            else if (avg >= 50 && avg < 60)
                            {
                                txtres.Text = "SECOND CLASS";
                            }
                            else if (avg >= 35 && avg < 50)
                            {
                                txtres.Text = "PASS";
                            }
                            else if (avg >= 0 && avg < 35)
                            {
                                txtres.Text = "FAIL";
                            }

                        }
                    }
                    else
                    {
                        if ( Convert.ToInt32(txtsid3.Text.ToString()) < 35 || Convert.ToInt32(txtsid4.Text.ToString()) < 35 || Convert.ToInt32(txtsid5.Text.ToString()) < 35 || Convert.ToInt32(txtsid6.Text.ToString()) < 35)
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            txtres.Text = "Fail";
                        }
                        else
                        {
                            btnres.Enabled = true;
                            txttot.Text = (int.Parse(txtsid1.Text) + int.Parse(txtsid2.Text) + int.Parse(txtsid3.Text) + int.Parse(txtsid4.Text) + int.Parse(txtsid5.Text) + int.Parse(txtsid6.Text)).ToString();
                            tot = Convert.ToInt32(txttot.Text.ToString());
                            txtper.Text = (double.Parse(txttot.Text) / 6).ToString();
                            avg = tot / 6;
                            if (avg >= 85 && avg <= 100)
                            {
                                txtres.Text = "DISTINCTION";
                            }
                            else if (avg >= 60 && avg < 85)
                            {
                                txtres.Text = "FIRST CLASS";
                            }
                            else if (avg >= 50 && avg < 60)
                            {
                                txtres.Text = "SECOND CLASS";
                            }
                            else if (avg >= 35 && avg < 50)
                            {
                                txtres.Text = "PASS";
                            }
                            else if (avg >= 0 && avg < 35)
                            {
                                txtres.Text = "FAIL";
                            }

                        }
                    }
                }
                String s = NumberToWords(int.Parse(txttot.Text.ToString()));
                lbltot.Text = s + " " + "only";
                      
                     chkcrs();
                }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           this.Refresh();
        }

        public void chkcrs()
        {
            if (cmbcourse.Text.Trim() == "EBAC")
            {
                //label11.Text = txtsid1.Text;
                txtth1.Text = txtsid3.Text;
                txtth2.Text = txtsid4.Text;
                txtth3.Text = txtsid5.Text;

            }
            else if (cmbcourse.Text.Trim() == "HEBA")
            {
                txtth1.Text = txtsid3.Text;
                txtth2.Text = txtsid4.Text;
                txtth3.Text = txtsid4.Text;
                txtth4.Text =txtsid6.Text;
            }
        }
        private void txtsid6_TextChanged(object sender, EventArgs e)
        {
            
            lblw5.Text = NumberToWords(int.Parse(txtsid6.Text.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtth3.Text = txtsid5.Text;
            txtp3.Text = "0";
            try
            {
                
                
                string register = string.Format("insert into MarksDetails(sno,cno,studentType,Exam_year,Exam_month,M1,M2,M3,M4,M5,M6,Total,Perc,Res,w1,w2,w3,w4,w5,w6,totw,th1,th2,th3,th4,p1,p2,p3,p4)values(" + cmbstud.SelectedValue.ToString() + "," + cmbcourse.SelectedValue.ToString() + ",'" + cmbstype.Text + "','" + txteyr.Text + "','" + txtexmn.Text + "'," + txtsid1.Text + "," + txtsid2.Text + "," + txtsid3.Text + "," + txtsid4.Text + "," + txtsid5.Text + "," + txtsid6.Text + "," + txttot.Text + "," + txtper.Text + ",'" + txtres.Text + "','" + lblword.Text + "','" + lblw1.Text + "','" + lblw2.Text + "','" + lblw3.Text + "','" + lblw4.Text + "','" + lblw5.Text + "','" + lbltot.Text + "'," + txtth1.Text + "," + txtth2.Text + "," + txtth3.Text + "," + txtth4.Text + "," + txtp1.Text + "," + txtp2.Text + "," + txtp3.Text + "," + txtp4.Text + ");");
                if (lib.do_Transaction(register))
                    MessageBox.Show("Inserted");
                //clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtsid1_TextChanged(object sender, EventArgs e)
       {
            lblword.Text = NumberToWords(int.Parse(txtsid1.Text.ToString()));
        }

        private  String ConvertDecimals(String number)
        {
            String cd = "", digit = "", engOne = "";
            for (int i = 0; i < number.Length; i++)
            {
                digit = number[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "Zero";
                }
                else
                {
                    engOne = ones(digit);
                }
                cd += " " + engOne;
            }
            return cd;
        }

        private void txtsid2_TextChanged(object sender, EventArgs e)
        {
            lblw1.Text = NumberToWords(int.Parse(txtsid2.Text.ToString()));
        }

        private void txtsid3_TextChanged(object sender, EventArgs e)
        {
            
            lblw2.Text = NumberToWords(int.Parse(txtsid3.Text.ToString()));
        }
        public int marks(int x,int y)
        {
            int z;
            return z = x + y;
        }

        private void txtsid4_TextChanged(object sender, EventArgs e)
        {

            
            lblw3.Text = NumberToWords(int.Parse(txtsid4.Text.ToString()));
        }

        private void txtsid5_TextChanged(object sender, EventArgs e)
        {
           // lblw4.Text = ConvertDecimals(txtsid5.Text);
           
            lblw4.Text = NumberToWords(int.Parse(txtsid5.Text.ToString()));
        }




        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtth1_TextChanged(object sender, EventArgs e)
        {
            txtsid3.Text = Convert.ToInt32(marks(Convert.ToInt32(txtp1.Text.ToString()), Convert.ToInt32(txtth1.Text.ToString()))).ToString();
            
            //int x, y, z;
            //x = Convert.ToInt32(txtp1.Text.ToString());
            //y = Convert.ToInt32(txtth1.Text.ToString());
            //z = x + y;
            //txtsid3.Text = z.ToString();
        }

        private void txtth2_TextChanged(object sender, EventArgs e)
        {
            txtsid4.Text = Convert.ToInt32(marks(Convert.ToInt32(txtp2.Text.ToString()), Convert.ToInt32(txtth2.Text.ToString()))).ToString();
        }

        private void txtth3_TextChanged(object sender, EventArgs e)
        {
            //txtsid5.Text = Convert.ToInt32(marks(Convert.ToInt32(txtp3.Text.ToString()), Convert.ToInt32(txtsid5.Text.ToString()))).ToString();
        }

        private void txtth4_TextChanged(object sender, EventArgs e)
        {
            txtsid6.Text = Convert.ToInt32(marks(Convert.ToInt32(txtp4.Text.ToString()), Convert.ToInt32(txtth4.Text.ToString()))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtp1.Text = "0";
            txtp2.Text = "0";
            txtp3.Text = "0";
            txtp4.Text = "0";
            txtth1.Text = "0";
            txtth2.Text = "0";
            txtth3.Text = "0";
            txtth4.Text = "0";
        //    int.Parse(txtth1.Text.ToString() )=
            txtsid1.Text = "0";
            txtsid2.Text = "0";
            txtsid3.Text = "0";
            txtsid4.Text = "0";
            txtsid5.Text = "0";
            txtsid6.Text = "0";
            
            txttot.Clear();
            txtper.Clear();
            txtres.Clear();
        }

        private void txtth1_TextChanged_1(object sender, EventArgs e)
       {
            txtsid3.Text = Convert.ToInt32(marks(Convert.ToInt32(txtp1.Text.ToString()), Convert.ToInt32(txtth1.Text.ToString()))).ToString();
        }

        
    }
}
