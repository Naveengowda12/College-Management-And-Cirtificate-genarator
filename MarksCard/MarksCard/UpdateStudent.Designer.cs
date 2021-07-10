namespace MarksCard
{
    partial class UpdateStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudent));
            this.txtsats = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbgend = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbstd = new System.Windows.Forms.ComboBox();
            this.studentdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCDataSet4 = new MarksCard.VCDataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbyop = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtadmno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vCDataSet = new MarksCard.VCDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new MarksCard.VCDataSetTableAdapters.courseTableAdapter();
            this.student_detailsTableAdapter = new MarksCard.VCDataSet4TableAdapters.Student_detailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsats
            // 
            this.txtsats.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsats.Location = new System.Drawing.Point(147, 411);
            this.txtsats.Name = "txtsats";
            this.txtsats.Size = new System.Drawing.Size(220, 26);
            this.txtsats.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 83;
            this.label13.Text = "SATS Number";
            // 
            // cmbgend
            // 
            this.cmbgend.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbgend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbgend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbgend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbgend.DropDownHeight = 100;
            this.cmbgend.DropDownWidth = 100;
            this.cmbgend.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgend.FormattingEnabled = true;
            this.cmbgend.IntegralHeight = false;
            this.cmbgend.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbgend.Location = new System.Drawing.Point(147, 374);
            this.cmbgend.Name = "cmbgend";
            this.cmbgend.Size = new System.Drawing.Size(220, 27);
            this.cmbgend.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 19);
            this.label12.TabIndex = 81;
            this.label12.Text = "Select Gender";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(148, 95);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(220, 26);
            this.txtnum.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Student Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbstd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsats);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbgend);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtnum);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmbyop);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtadmno);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtfn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtmn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtrn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtphn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtdob);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbcourse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 504);
            this.panel1.TabIndex = 14;
            // 
            // cmbstd
            // 
            this.cmbstd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbstd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstd.FormattingEnabled = true;
            this.cmbstd.Location = new System.Drawing.Point(148, 25);
            this.cmbstd.Name = "cmbstd";
            this.cmbstd.Size = new System.Drawing.Size(219, 27);
            this.cmbstd.TabIndex = 86;
            this.cmbstd.SelectedIndexChanged += new System.EventHandler(this.cmbstd_SelectedIndexChanged);
            // 
            // studentdetailsBindingSource
            // 
            this.studentdetailsBindingSource.DataMember = "Student_details";
            this.studentdetailsBindingSource.DataSource = this.vCDataSet4;
            // 
            // vCDataSet4
            // 
            this.vCDataSet4.DataSetName = "VCDataSet4";
            this.vCDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 85;
            this.label2.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 38);
            this.label4.TabIndex = 78;
            this.label4.Text = "BROWSE\r\nPHOTO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(378, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(417, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 33;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(327, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 32;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbyop
            // 
            this.cmbyop.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbyop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbyop.Location = new System.Drawing.Point(147, 343);
            this.cmbyop.Name = "cmbyop";
            this.cmbyop.Size = new System.Drawing.Size(220, 26);
            this.cmbyop.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Year pass";
            // 
            // txtadmno
            // 
            this.txtadmno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmno.Location = new System.Drawing.Point(148, 309);
            this.txtadmno.Name = "txtadmno";
            this.txtadmno.Size = new System.Drawing.Size(220, 26);
            this.txtadmno.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Admission Number";
            // 
            // txtfn
            // 
            this.txtfn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.Location = new System.Drawing.Point(147, 170);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(220, 26);
            this.txtfn.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Father Name";
            // 
            // txtmn
            // 
            this.txtmn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmn.Location = new System.Drawing.Point(148, 206);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(220, 26);
            this.txtmn.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mother Name";
            // 
            // txtrn
            // 
            this.txtrn.Enabled = false;
            this.txtrn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrn.Location = new System.Drawing.Point(147, 59);
            this.txtrn.Name = "txtrn";
            this.txtrn.Size = new System.Drawing.Size(220, 26);
            this.txtrn.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Register Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtphn
            // 
            this.txtphn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphn.Location = new System.Drawing.Point(148, 277);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(220, 26);
            this.txtphn.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone Number";
            // 
            // txtdob
            // 
            this.txtdob.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdob.Location = new System.Drawing.Point(148, 237);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(220, 26);
            this.txtdob.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date of Birth";
            // 
            // cmbcourse
            // 
            this.cmbcourse.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbcourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbcourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcourse.DataSource = this.courseBindingSource1;
            this.cmbcourse.DisplayMember = "cname";
            this.cmbcourse.DropDownHeight = 100;
            this.cmbcourse.DropDownWidth = 200;
            this.cmbcourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.IntegralHeight = false;
            this.cmbcourse.Location = new System.Drawing.Point(147, 131);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(220, 27);
            this.cmbcourse.TabIndex = 15;
            this.cmbcourse.ValueMember = "Cno";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "course";
            this.courseBindingSource1.DataSource = this.vCDataSet;
            // 
            // vCDataSet
            // 
            this.vCDataSet.DataSetName = "VCDataSet";
            this.vCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Course";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // student_detailsTableAdapter
            // 
            this.student_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 504);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtsats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbgend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker cmbyop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtadmno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtdob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private VCDataSet vCDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private VCDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ComboBox cmbstd;
        private System.Windows.Forms.Label label2;
        private VCDataSet4 vCDataSet4;
        private System.Windows.Forms.BindingSource studentdetailsBindingSource;
        private VCDataSet4TableAdapters.Student_detailsTableAdapter student_detailsTableAdapter;
    }
}