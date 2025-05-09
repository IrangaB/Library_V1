namespace Library_V1
{
    partial class NotIssueReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.notIssuedDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notIssuedDS = new Library_V1.NotIssuedDS();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Library_V1.NotIssuedDSTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notIssuedDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notIssuedDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.notIssuedDSBindingSource;
            // 
            // notIssuedDSBindingSource
            // 
            this.notIssuedDSBindingSource.DataSource = this.notIssuedDS;
            this.notIssuedDSBindingSource.Position = 0;
            // 
            // notIssuedDS
            // 
            this.notIssuedDS.DataSetName = "NotIssuedDS";
            this.notIssuedDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.notIssuedDSBindingSource;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Library_V1.Properties.Resources.minimize_window_24;
            this.label1.Location = new System.Drawing.Point(1509, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 12;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.Transparent;
            this.lblClose.Image = global::Library_V1.Properties.Resources.close_window_24;
            this.lblClose.Location = new System.Drawing.Point(1541, 9);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 27);
            this.lblClose.TabIndex = 11;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "NotIssueBooksDS";
            reportDataSource2.Value = this.dataTable1BindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library_V1.Reports.rptNotReturned.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1573, 645);
            this.reportViewer1.TabIndex = 13;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.notIssuedDS;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.notIssuedDSBindingSource;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // NotIssueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_V1.Properties.Resources.wallpaper2you_196278;
            this.ClientSize = new System.Drawing.Size(1597, 715);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotIssueReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotIssueReport";
            this.Load += new System.EventHandler(this.NotIssueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notIssuedDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notIssuedDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource notIssuedDSBindingSource;
        private NotIssuedDS notIssuedDS;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private NotIssuedDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
    }
}