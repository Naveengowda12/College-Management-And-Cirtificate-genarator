namespace MarksCard
{
    partial class TCS
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
            this.Student_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCDataSet7 = new MarksCard.VCDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.vcDataSet11 = new MarksCard.VCDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbstud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_detailsTableAdapter = new MarksCard.VCDataSet7TableAdapters.Student_detailsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Student_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_detailsBindingSource
            // 
            this.Student_detailsBindingSource.DataMember = "Student_details";
            this.Student_detailsBindingSource.DataSource = this.vCDataSet7;
            // 
            // vCDataSet7
            // 
            this.vCDataSet7.DataSetName = "VCDataSet7";
            this.vCDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-215, -89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Select  Name";
            // 
            // vcDataSet11
            // 
            this.vcDataSet11.DataSetName = "VCDataSet1";
            this.vcDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 103;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 105;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 33);
            this.button4.TabIndex = 101;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(112, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 32);
            this.button3.TabIndex = 106;
            this.button3.Text = "Export to PDF";
            this.button3.UseVisualStyleBackColor = true;
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
            this.cmbstud.Location = new System.Drawing.Point(18, 62);
            this.cmbstud.Name = "cmbstud";
            this.cmbstud.Size = new System.Drawing.Size(216, 26);
            this.cmbstud.TabIndex = 104;
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
            this.label2.Size = new System.Drawing.Size(749, 39);
            this.label2.TabIndex = 102;
            this.label2.Text = "PRINT TRANSFER CERTIFICATE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "Select  Name";
            // 
            // studentdetailsBindingSource
            // 
            this.studentdetailsBindingSource.DataMember = "Student_details";
            this.studentdetailsBindingSource.DataSource = this.vCDataSet7;
            // 
            // student_detailsTableAdapter
            // 
            this.student_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.Student_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MarksCard.TC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(240, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(509, 379);
            this.reportViewer1.TabIndex = 108;
            // 
            // TCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 433);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbstud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "TCS";
            this.Text = "TCS";
            this.Load += new System.EventHandler(this.TCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private VCDataSet1 vcDataSet11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox cmbstud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentdetailsBindingSource;
        private VCDataSet7 vCDataSet7;
        private VCDataSet7TableAdapters.Student_detailsTableAdapter student_detailsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Student_detailsBindingSource;
    }
}