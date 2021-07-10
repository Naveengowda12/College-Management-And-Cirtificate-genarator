namespace MarksCard
{
    partial class ResultSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultSheet));
            this.MarksDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VCDataSet3 = new MarksCard.VCDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MarksDetailsTableAdapter = new MarksCard.VCDataSet3TableAdapters.MarksDetailsTableAdapter();
            this.cmbstud = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCDataSet = new MarksCard.VCDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.courseTableAdapter = new MarksCard.VCDataSetTableAdapters.courseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.VCDataSet1 = new MarksCard.VCDataSet1();
            this.Student_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MarksDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MarksDetailsBindingSource
            // 
            this.MarksDetailsBindingSource.DataMember = "MarksDetails";
            this.MarksDetailsBindingSource.DataSource = this.VCDataSet3;
            // 
            // VCDataSet3
            // 
            this.VCDataSet3.DataSetName = "VCDataSet3";
            this.VCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MarksDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MarksCard.ResSht.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(880, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // MarksDetailsTableAdapter
            // 
            this.MarksDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbstud
            // 
            this.cmbstud.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbstud.AllowDrop = true;
            this.cmbstud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbstud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstud.DropDownHeight = 100;
            this.cmbstud.DropDownWidth = 25;
            this.cmbstud.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstud.FormattingEnabled = true;
            this.cmbstud.IntegralHeight = false;
            this.cmbstud.Location = new System.Drawing.Point(143, 16);
            this.cmbstud.Name = "cmbstud";
            this.cmbstud.Size = new System.Drawing.Size(171, 27);
            this.cmbstud.TabIndex = 93;
            this.cmbstud.SelectedIndexChanged += new System.EventHandler(this.cmbstud_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.vCDataSetBindingSource;
            // 
            // vCDataSetBindingSource
            // 
            this.vCDataSetBindingSource.DataSource = this.vCDataSet;
            this.vCDataSetBindingSource.Position = 0;
            // 
            // vCDataSet
            // 
            this.vCDataSet.DataSetName = "VCDataSet";
            this.vCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "COURSE";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 95;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // ResultSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbstud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultSheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultSheet_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultSheet_FormClosed);
            this.Load += new System.EventHandler(this.ResultSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarksDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MarksDetailsBindingSource;
        private VCDataSet3 VCDataSet3;
        private VCDataSet3TableAdapters.MarksDetailsTableAdapter MarksDetailsTableAdapter;
        public System.Windows.Forms.ComboBox cmbstud;
        private System.Windows.Forms.BindingSource vCDataSetBindingSource;
        private VCDataSet vCDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private VCDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource Student_detailsBindingSource;
        private VCDataSet1 VCDataSet1;
       // private VCDataSet1TableAdapters.Student_detailsTableAdapter Student_detailsTableAdapter;
    }
}