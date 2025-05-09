namespace Library_V1
{
    partial class AllBooksReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllBooksReport));
            this.bookRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mtx_LibraryDataSet2 = new Library_V1.Mtx_LibraryDataSet2();
            this.bookRegisterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookRegisterTableAdapter = new Library_V1.Mtx_LibraryDataSet2TableAdapters.BookRegisterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRegisterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookRegisterBindingSource
            // 
            this.bookRegisterBindingSource.DataMember = "BookRegister";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Library_V1.Properties.Resources.minimize_window_24;
            this.label1.Location = new System.Drawing.Point(1167, 20);
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
            this.lblClose.Location = new System.Drawing.Point(1199, 20);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 27);
            this.lblClose.TabIndex = 11;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RegistedBooks";
            reportDataSource1.Value = this.bookRegisterBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library_V1.Reports.AllEnrolledBooks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1217, 559);
            this.reportViewer1.TabIndex = 13;
            // 
            // mtx_LibraryDataSet2
            // 
            this.mtx_LibraryDataSet2.DataSetName = "Mtx_LibraryDataSet2";
            this.mtx_LibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookRegisterBindingSource1
            // 
            this.bookRegisterBindingSource1.DataMember = "BookRegister";
            this.bookRegisterBindingSource1.DataSource = this.mtx_LibraryDataSet2;
            // 
            // bookRegisterTableAdapter
            // 
            this.bookRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // AllBooksReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_V1.Properties.Resources.wallpaper2you_196278;
            this.ClientSize = new System.Drawing.Size(1241, 635);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllBooksReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllBooksReport";
            this.Load += new System.EventHandler(this.AllBooksReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRegisterBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.BindingSource bookRegisterBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Mtx_LibraryDataSet2 mtx_LibraryDataSet2;
        private System.Windows.Forms.BindingSource bookRegisterBindingSource1;
        private Mtx_LibraryDataSet2TableAdapters.BookRegisterTableAdapter bookRegisterTableAdapter;
    }
}