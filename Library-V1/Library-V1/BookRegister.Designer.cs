namespace Library_V1
{
    partial class BookRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchIsbm = new System.Windows.Forms.Button();
            this.txtIsbnSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkyes = new System.Windows.Forms.CheckBox();
            this.btnGenCode = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLanguange = new System.Windows.Forms.ComboBox();
            this.dgBookView = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.txtTranslatorName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdBookInactive = new System.Windows.Forms.RadioButton();
            this.rdBookActive = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewIsbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mtx_LibraryDataSet3 = new Library_V1.Mtx_LibraryDataSet3();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.sectionsTableAdapter1 = new Library_V1.Mtx_LibraryDataSet3TableAdapters.SectionsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchIsbm
            // 
            this.btnSearchIsbm.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchIsbm.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSearchIsbm.FlatAppearance.BorderSize = 2;
            this.btnSearchIsbm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIsbm.ForeColor = System.Drawing.Color.White;
            this.btnSearchIsbm.Location = new System.Drawing.Point(475, 41);
            this.btnSearchIsbm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchIsbm.Name = "btnSearchIsbm";
            this.btnSearchIsbm.Size = new System.Drawing.Size(110, 39);
            this.btnSearchIsbm.TabIndex = 13;
            this.btnSearchIsbm.Text = "Search";
            this.btnSearchIsbm.UseVisualStyleBackColor = false;
            this.btnSearchIsbm.Click += new System.EventHandler(this.btnSearchIsbm_Click);
            // 
            // txtIsbnSearch
            // 
            this.txtIsbnSearch.Location = new System.Drawing.Point(125, 46);
            this.txtIsbnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIsbnSearch.Multiline = true;
            this.txtIsbnSearch.Name = "txtIsbnSearch";
            this.txtIsbnSearch.Size = new System.Drawing.Size(275, 27);
            this.txtIsbnSearch.TabIndex = 12;
            this.txtIsbnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsbnSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item Code :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearchIsbm);
            this.groupBox1.Controls.Add(this.txtIsbnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1268, 101);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Existing Books";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkyes);
            this.groupBox2.Controls.Add(this.btnGenCode);
            this.groupBox2.Controls.Add(this.btnBarcode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbLanguange);
            this.groupBox2.Controls.Add(this.dgBookView);
            this.groupBox2.Controls.Add(this.btnUpdateBook);
            this.groupBox2.Controls.Add(this.btnNewBook);
            this.groupBox2.Controls.Add(this.btnSaveBook);
            this.groupBox2.Controls.Add(this.txtTranslatorName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rdBookInactive);
            this.groupBox2.Controls.Add(this.rdBookActive);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbBookType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBookName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNewIsbn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(1268, 486);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Books";
            // 
            // chkyes
            // 
            this.chkyes.AutoSize = true;
            this.chkyes.Location = new System.Drawing.Point(617, 183);
            this.chkyes.Name = "chkyes";
            this.chkyes.Size = new System.Drawing.Size(51, 21);
            this.chkyes.TabIndex = 34;
            this.chkyes.Text = "Yes";
            this.chkyes.UseVisualStyleBackColor = true;
            this.chkyes.CheckedChanged += new System.EventHandler(this.chkyes_CheckedChanged);
            // 
            // btnGenCode
            // 
            this.btnGenCode.BackColor = System.Drawing.Color.Transparent;
            this.btnGenCode.BackgroundImage = global::Library_V1.Properties.Resources.icons8_barcode_50__1_;
            this.btnGenCode.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGenCode.FlatAppearance.BorderSize = 0;
            this.btnGenCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenCode.ForeColor = System.Drawing.Color.White;
            this.btnGenCode.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGenCode.Location = new System.Drawing.Point(404, 38);
            this.btnGenCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGenCode.Name = "btnGenCode";
            this.btnGenCode.Size = new System.Drawing.Size(53, 24);
            this.btnGenCode.TabIndex = 14;
            this.btnGenCode.UseVisualStyleBackColor = false;
            this.btnGenCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.Transparent;
            this.btnBarcode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBarcode.FlatAppearance.BorderSize = 2;
            this.btnBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.ForeColor = System.Drawing.Color.White;
            this.btnBarcode.Location = new System.Drawing.Point(1057, 174);
            this.btnBarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(191, 36);
            this.btnBarcode.TabIndex = 33;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Sub Catergory :";
            // 
            // cmbLanguange
            // 
            this.cmbLanguange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLanguange.FormattingEnabled = true;
            this.cmbLanguange.Items.AddRange(new object[] {
            "1M CAT",
            "2M CAT",
            "3M CAT",
            "4M CAT",
            "5M CAT",
            "6M CAT",
            "7M CAT",
            "8M CAT",
            "10M CAT",
            "VGA",
            "HDMI",
            "HD PORT",
            "OTHER",
            "",
            ""});
            this.cmbLanguange.Location = new System.Drawing.Point(617, 132);
            this.cmbLanguange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLanguange.Name = "cmbLanguange";
            this.cmbLanguange.Size = new System.Drawing.Size(231, 24);
            this.cmbLanguange.TabIndex = 31;
            // 
            // dgBookView
            // 
            this.dgBookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column8,
            this.Column3,
            this.Column6,
            this.Column5});
            this.dgBookView.Location = new System.Drawing.Point(19, 243);
            this.dgBookView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgBookView.Name = "dgBookView";
            this.dgBookView.RowTemplate.Height = 24;
            this.dgBookView.Size = new System.Drawing.Size(1229, 216);
            this.dgBookView.TabIndex = 17;
            this.dgBookView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookView_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.HeaderText = "ISBN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column4.HeaderText = "Book Type";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column8.HeaderText = "Book Languange";
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column3.HeaderText = "Author";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column6.HeaderText = "Translated By";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column5.HeaderText = "Book Status";
            this.Column5.Name = "Column5";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnUpdateBook.FlatAppearance.BorderSize = 2;
            this.btnUpdateBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBook.Location = new System.Drawing.Point(1159, 116);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(89, 53);
            this.btnUpdateBook.TabIndex = 29;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnNewBook
            // 
            this.btnNewBook.BackColor = System.Drawing.Color.Transparent;
            this.btnNewBook.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNewBook.FlatAppearance.BorderSize = 2;
            this.btnNewBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBook.ForeColor = System.Drawing.Color.White;
            this.btnNewBook.Location = new System.Drawing.Point(1159, 48);
            this.btnNewBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(89, 53);
            this.btnNewBook.TabIndex = 28;
            this.btnNewBook.Text = "New";
            this.btnNewBook.UseVisualStyleBackColor = false;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveBook.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSaveBook.FlatAppearance.BorderSize = 2;
            this.btnSaveBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBook.ForeColor = System.Drawing.Color.White;
            this.btnSaveBook.Location = new System.Drawing.Point(1057, 48);
            this.btnSaveBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(89, 120);
            this.btnSaveBook.TabIndex = 15;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.UseVisualStyleBackColor = false;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // txtTranslatorName
            // 
            this.txtTranslatorName.Location = new System.Drawing.Point(673, 178);
            this.txtTranslatorName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTranslatorName.Multiline = true;
            this.txtTranslatorName.Name = "txtTranslatorName";
            this.txtTranslatorName.Size = new System.Drawing.Size(334, 27);
            this.txtTranslatorName.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "If \"Other\" : ";
            // 
            // rdBookInactive
            // 
            this.rdBookInactive.AutoSize = true;
            this.rdBookInactive.Location = new System.Drawing.Point(209, 148);
            this.rdBookInactive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdBookInactive.Name = "rdBookInactive";
            this.rdBookInactive.Size = new System.Drawing.Size(109, 21);
            this.rdBookInactive.TabIndex = 24;
            this.rdBookInactive.TabStop = true;
            this.rdBookInactive.Text = "Not Available";
            this.rdBookInactive.UseVisualStyleBackColor = true;
            // 
            // rdBookActive
            // 
            this.rdBookActive.AutoSize = true;
            this.rdBookActive.Location = new System.Drawing.Point(122, 146);
            this.rdBookActive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdBookActive.Name = "rdBookActive";
            this.rdBookActive.Size = new System.Drawing.Size(83, 21);
            this.rdBookActive.TabIndex = 23;
            this.rdBookActive.TabStop = true;
            this.rdBookActive.Text = "Avialable";
            this.rdBookActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Item Status : ";
            // 
            // cmbBookType
            // 
            this.cmbBookType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Cable",
            "Convertors",
            "Keyboards",
            "Mouse",
            "RAM",
            "UPS",
            "CCTV Items",
            "Scanners",
            "Switches (Network)",
            "Tools",
            "Monitors"});
            this.cmbBookType.Location = new System.Drawing.Point(617, 88);
            this.cmbBookType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(231, 24);
            this.cmbBookType.TabIndex = 21;
            this.cmbBookType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Item Catergory : ";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(122, 88);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(275, 27);
            this.txtAuthor.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description : ";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(617, 38);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(108, 27);
            this.txtBookName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item Qty : ";
            // 
            // txtNewIsbn
            // 
            this.txtNewIsbn.Location = new System.Drawing.Point(122, 38);
            this.txtNewIsbn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNewIsbn.Multiline = true;
            this.txtNewIsbn.Name = "txtNewIsbn";
            this.txtNewIsbn.Size = new System.Drawing.Size(275, 27);
            this.txtNewIsbn.TabIndex = 15;
            this.txtNewIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewIsbn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name : ";
            // 
            // sectionsBindingSource1
            // 
            this.sectionsBindingSource1.DataMember = "Sections";
            this.sectionsBindingSource1.DataSource = this.mtx_LibraryDataSet3;
            // 
            // mtx_LibraryDataSet3
            // 
            this.mtx_LibraryDataSet3.DataSetName = "Mtx_LibraryDataSet3";
            this.mtx_LibraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Library_V1.Properties.Resources.minimize_window_24;
            this.label1.Location = new System.Drawing.Point(1201, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 18;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.Transparent;
            this.lblClose.Image = global::Library_V1.Properties.Resources.close_window_24;
            this.lblClose.Location = new System.Drawing.Point(1233, 12);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 27);
            this.lblClose.TabIndex = 17;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click_1);
            // 
            // sectionsTableAdapter1
            // 
            this.sectionsTableAdapter1.ClearBeforeFill = true;
            // 
            // BookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_V1.Properties.Resources.wallpaper2you_196278;
            this.ClientSize = new System.Drawing.Size(1283, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BookRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.BookRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchIsbm;
        private System.Windows.Forms.TextBox txtIsbnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewIsbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdBookInactive;
        private System.Windows.Forms.RadioButton rdBookActive;
        private System.Windows.Forms.TextBox txtTranslatorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.DataGridView dgBookView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLanguange;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnGenCode;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private Mtx_LibraryDataSet3 mtx_LibraryDataSet3;
        private System.Windows.Forms.BindingSource sectionsBindingSource1;
        private Mtx_LibraryDataSet3TableAdapters.SectionsTableAdapter sectionsTableAdapter1;
        private System.Windows.Forms.CheckBox chkyes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}