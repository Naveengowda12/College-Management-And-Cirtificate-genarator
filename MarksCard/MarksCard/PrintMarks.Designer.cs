namespace MarksCard
{
    partial class PrintMarks
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintMarks));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbstud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VCDataSet1 = new MarksCard.VCDataSet1();
            this.Student_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Student_detailsTableAdapter = new MarksCard.VCDataSet1TableAdapters.Student_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 88;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 90;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 33);
            this.button4.TabIndex = 86;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(112, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 32);
            this.button3.TabIndex = 91;
            this.button3.Text = "Export to PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbstud
            // 
            this.cmbstud.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbstud.AllowDrop = true;
            this.cmbstud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbstud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstud.DropDownHeight = 100;
            this.cmbstud.DropDownWidth = 25;
            this.cmbstud.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstud.FormattingEnabled = true;
            this.cmbstud.IntegralHeight = false;
            this.cmbstud.Location = new System.Drawing.Point(17, 59);
            this.cmbstud.Name = "cmbstud";
            this.cmbstud.Size = new System.Drawing.Size(216, 26);
            this.cmbstud.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(751, 39);
            this.label2.TabIndex = 87;
            this.label2.Text = "PRINT MARKS CARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Select  Name";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Student_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MarksCard.marksreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(259, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(480, 441);
            this.reportViewer1.TabIndex = 93;
            // 
            // VCDataSet1
            // 
            this.VCDataSet1.DataSetName = "VCDataSet1";
            this.VCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Student_detailsBindingSource
            // 
            this.Student_detailsBindingSource.DataMember = "Student_details";
            this.Student_detailsBindingSource.DataSource = this.VCDataSet1;
            // 
            // Student_detailsTableAdapter
            // 
            this.Student_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // PrintMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbstud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintMarks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintMarks_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintMarks_FormClosed);
            this.Load += new System.EventHandler(this.PrintMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox cmbstud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VCDataSet1 VCDataSet1;
        private System.Windows.Forms.BindingSource Student_detailsBindingSource;
        private VCDataSet1TableAdapters.Student_detailsTableAdapter Student_detailsTableAdapter;
     //   private MarksCard.VCDataSet1TableAdapters.Student_detailsTableAdapter Student_detailsTableAdapter;
     //   private VCDataSet1TableAdapters.Student_detailsTableAdapter Student_detailsTableAdapter;
      
       // private VCDataSet VCDataSet;
        //private VCDataSetTableAdapters.MarksDetailsTableAdapter MarksDetailsTableAdapter;
    }
}