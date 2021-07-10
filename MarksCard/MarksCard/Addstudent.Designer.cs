namespace MarksCard
{
    partial class Addstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addstudent));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vCDataSet = new MarksCard.VCDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbqu = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtcond = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtyr = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtmonh = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtleave = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbsc = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtclsleav = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnatin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtrel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcaste = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsats = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbgend = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.txtsn = new System.Windows.Forms.TextBox();
            this.txtrn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.courseTableAdapter = new MarksCard.VCDataSetTableAdapters.courseTableAdapter();
            this.vCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.cmbcourse.DropDownHeight = 100;
            this.cmbcourse.DropDownWidth = 200;
            this.cmbcourse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.IntegralHeight = false;
            this.cmbcourse.Location = new System.Drawing.Point(147, 131);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(220, 27);
            this.cmbcourse.TabIndex = 4;
            this.cmbcourse.SelectedIndexChanged += new System.EventHandler(this.cmbcourse_SelectedIndexChanged);
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
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbqu);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtcond);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtyr);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtmonh);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dtleave);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cmbsc);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtclsleav);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtnatin);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtrel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtcaste);
            this.panel1.Controls.Add(this.label14);
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
            this.panel1.Controls.Add(this.txtsn);
            this.panel1.Controls.Add(this.txtrn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtphn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtdob);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbcourse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 450);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbqu
            // 
            this.cmbqu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbqu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbqu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbqu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbqu.DropDownHeight = 100;
            this.cmbqu.DropDownWidth = 200;
            this.cmbqu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbqu.FormattingEnabled = true;
            this.cmbqu.IntegralHeight = false;
            this.cmbqu.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbqu.Location = new System.Drawing.Point(530, 347);
            this.cmbqu.Name = "cmbqu";
            this.cmbqu.Size = new System.Drawing.Size(220, 27);
            this.cmbqu.TabIndex = 103;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(434, 355);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 19);
            this.label23.TabIndex = 104;
            this.label23.Text = "QUALIFIED";
            // 
            // txtcond
            // 
            this.txtcond.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcond.Location = new System.Drawing.Point(530, 312);
            this.txtcond.Name = "txtcond";
            this.txtcond.Size = new System.Drawing.Size(220, 26);
            this.txtcond.TabIndex = 102;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(445, 315);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 19);
            this.label22.TabIndex = 101;
            this.label22.Text = "CONDUCT";
            // 
            // txtyr
            // 
            this.txtyr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyr.Location = new System.Drawing.Point(530, 277);
            this.txtyr.Name = "txtyr";
            this.txtyr.Size = new System.Drawing.Size(220, 26);
            this.txtyr.TabIndex = 100;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(461, 284);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 19);
            this.label21.TabIndex = 99;
            this.label21.Text = "YEAR";
            // 
            // txtmonh
            // 
            this.txtmonh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonh.Location = new System.Drawing.Point(528, 243);
            this.txtmonh.Name = "txtmonh";
            this.txtmonh.Size = new System.Drawing.Size(220, 26);
            this.txtmonh.TabIndex = 98;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(461, 250);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 19);
            this.label20.TabIndex = 97;
            this.label20.Text = "MONTH";
            // 
            // dtleave
            // 
            this.dtleave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtleave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtleave.Location = new System.Drawing.Point(530, 207);
            this.dtleave.Name = "dtleave";
            this.dtleave.Size = new System.Drawing.Size(220, 26);
            this.dtleave.TabIndex = 95;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(395, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 19);
            this.label19.TabIndex = 96;
            this.label19.Text = "LEAVING DATE";
            // 
            // cmbsc
            // 
            this.cmbsc.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbsc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbsc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbsc.DropDownHeight = 100;
            this.cmbsc.DropDownWidth = 200;
            this.cmbsc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsc.FormattingEnabled = true;
            this.cmbsc.IntegralHeight = false;
            this.cmbsc.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbsc.Location = new System.Drawing.Point(530, 174);
            this.cmbsc.Name = "cmbsc";
            this.cmbsc.Size = new System.Drawing.Size(220, 27);
            this.cmbsc.TabIndex = 93;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(382, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 19);
            this.label18.TabIndex = 94;
            this.label18.Text = "BELONGS TO SC/ST";
            // 
            // txtclsleav
            // 
            this.txtclsleav.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclsleav.Location = new System.Drawing.Point(528, 132);
            this.txtclsleav.Name = "txtclsleav";
            this.txtclsleav.Size = new System.Drawing.Size(220, 26);
            this.txtclsleav.TabIndex = 92;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(400, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 19);
            this.label17.TabIndex = 91;
            this.label17.Text = "CLASS LEAVING";
            // 
            // txtnatin
            // 
            this.txtnatin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnatin.Location = new System.Drawing.Point(528, 97);
            this.txtnatin.Name = "txtnatin";
            this.txtnatin.Size = new System.Drawing.Size(220, 26);
            this.txtnatin.TabIndex = 90;
            this.txtnatin.Text = "INDIAN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(409, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 19);
            this.label16.TabIndex = 89;
            this.label16.Text = "NATIONALITY";
            // 
            // txtrel
            // 
            this.txtrel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrel.Location = new System.Drawing.Point(528, 56);
            this.txtrel.Name = "txtrel";
            this.txtrel.Size = new System.Drawing.Size(220, 26);
            this.txtrel.TabIndex = 88;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(428, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 19);
            this.label15.TabIndex = 87;
            this.label15.Text = "RELIGION";
            // 
            // txtcaste
            // 
            this.txtcaste.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaste.Location = new System.Drawing.Point(528, 21);
            this.txtcaste.Name = "txtcaste";
            this.txtcaste.Size = new System.Drawing.Size(220, 26);
            this.txtcaste.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(443, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 85;
            this.label14.Text = "CASTE";
            // 
            // txtsats
            // 
            this.txtsats.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsats.Location = new System.Drawing.Point(147, 411);
            this.txtsats.Name = "txtsats";
            this.txtsats.Size = new System.Drawing.Size(220, 26);
            this.txtsats.TabIndex = 12;
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
            this.cmbgend.ItemHeight = 19;
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
            this.txtnum.Location = new System.Drawing.Point(148, 53);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(220, 26);
            this.txtnum.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Student Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(798, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "BROWSE\r\nPHOTO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(754, 11);
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
            this.button3.Location = new System.Drawing.Point(697, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 16;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbyop
            // 
            this.cmbyop.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbyop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbyop.Location = new System.Drawing.Point(147, 343);
            this.cmbyop.Name = "cmbyop";
            this.cmbyop.Size = new System.Drawing.Size(220, 26);
            this.cmbyop.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Admission date";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtadmno
            // 
            this.txtadmno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmno.Location = new System.Drawing.Point(148, 309);
            this.txtadmno.Name = "txtadmno";
            this.txtadmno.Size = new System.Drawing.Size(220, 26);
            this.txtadmno.TabIndex = 9;
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
            this.txtfn.TabIndex = 5;
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
            this.txtmn.TabIndex = 6;
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
            // txtsn
            // 
            this.txtsn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsn.Location = new System.Drawing.Point(148, 94);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(220, 26);
            this.txtsn.TabIndex = 3;
            // 
            // txtrn
            // 
            this.txtrn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrn.Location = new System.Drawing.Point(147, 17);
            this.txtrn.Name = "txtrn";
            this.txtrn.Size = new System.Drawing.Size(220, 26);
            this.txtrn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Register Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(517, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtphn
            // 
            this.txtphn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphn.Location = new System.Drawing.Point(148, 277);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(220, 26);
            this.txtphn.TabIndex = 8;
            this.txtphn.TextChanged += new System.EventHandler(this.txttqtn_TextChanged);
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
            this.txtdob.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // vCDataSetBindingSource
            // 
            this.vCDataSetBindingSource.DataSource = this.vCDataSet;
            this.vCDataSetBindingSource.Position = 0;
            // 
            // Addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Addstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addstudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Addstudent_FormClosing);
            this.Load += new System.EventHandler(this.Addstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.TextBox txtrn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtdob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadmno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker cmbyop;
        private System.Windows.Forms.Label label11;
      //  private VCDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
      //  private VCDataSet1 vCDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private VCDataSet vCDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private VCDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbgend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource vCDataSetBindingSource;
        private System.Windows.Forms.TextBox txtclsleav;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnatin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtrel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcaste;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcond;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtyr;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtmonh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtleave;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbsc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbqu;
        private System.Windows.Forms.Label label23;
        //private VCDataSet1TableAdapters.courseTableAdapter courseTableAdapter;
    }
}