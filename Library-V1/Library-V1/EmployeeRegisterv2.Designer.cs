namespace Library_V1
{
    partial class EmployeeRegisterv2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegisterv2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.rdEmpInactive = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdEmpActive = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDesignation = new System.Windows.Forms.ComboBox();
            this.sectionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mtx_LibraryDataSet1 = new Library_V1.Mtx_LibraryDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.rdEmpFemale = new System.Windows.Forms.RadioButton();
            this.rdEmpMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgEmpdata = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmdDepartment = new System.Windows.Forms.ComboBox();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtx_LibraryDataSet = new Library_V1.Mtx_LibraryDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionsTableAdapter = new Library_V1.Mtx_LibraryDataSetTableAdapters.SectionsTableAdapter();
            this.mtxLibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsTableAdapter1 = new Library_V1.Mtx_LibraryDataSet1TableAdapters.SectionsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxLibraryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Library_V1.Properties.Resources.minimize_window_24;
            this.label1.Location = new System.Drawing.Point(1075, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 19;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.Transparent;
            this.lblClose.Image = global::Library_V1.Properties.Resources.close_window_24;
            this.lblClose.Location = new System.Drawing.Point(1107, 6);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 27);
            this.lblClose.TabIndex = 18;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearchEmp);
            this.groupBox1.Controls.Add(this.txtEmployee);
            this.groupBox1.Controls.Add(this.rdEmpInactive);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdEmpActive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1133, 86);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Existing Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "EPF :";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchEmp.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSearchEmp.FlatAppearance.BorderSize = 2;
            this.btnSearchEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearchEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmp.Location = new System.Drawing.Point(417, 40);
            this.btnSearchEmp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(110, 31);
            this.btnSearchEmp.TabIndex = 13;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(110, 42);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmployee.Multiline = true;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(275, 27);
            this.txtEmployee.TabIndex = 12;
            this.txtEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployee_KeyPress);
            // 
            // rdEmpInactive
            // 
            this.rdEmpInactive.AutoSize = true;
            this.rdEmpInactive.Location = new System.Drawing.Point(745, 45);
            this.rdEmpInactive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdEmpInactive.Name = "rdEmpInactive";
            this.rdEmpInactive.Size = new System.Drawing.Size(74, 21);
            this.rdEmpInactive.TabIndex = 24;
            this.rdEmpInactive.TabStop = true;
            this.rdEmpInactive.Text = "Inactive";
            this.rdEmpInactive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "EMP Status : ";
            // 
            // rdEmpActive
            // 
            this.rdEmpActive.AutoSize = true;
            this.rdEmpActive.Location = new System.Drawing.Point(684, 45);
            this.rdEmpActive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdEmpActive.Name = "rdEmpActive";
            this.rdEmpActive.Size = new System.Drawing.Size(64, 21);
            this.rdEmpActive.TabIndex = 23;
            this.rdEmpActive.TabStop = true;
            this.rdEmpActive.Text = "Active";
            this.rdEmpActive.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmdDesignation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rdEmpFemale);
            this.groupBox2.Controls.Add(this.rdEmpMale);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgEmpdata);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.cmdDepartment);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEpf);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(1133, 380);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Employees";
            // 
            // cmdDesignation
            // 
            this.cmdDesignation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectionsBindingSource1, "Designation", true));
            this.cmdDesignation.DataSource = this.sectionsBindingSource1;
            this.cmdDesignation.DisplayMember = "Designation";
            this.cmdDesignation.FormattingEnabled = true;
            this.cmdDesignation.Location = new System.Drawing.Point(110, 146);
            this.cmdDesignation.Name = "cmdDesignation";
            this.cmdDesignation.Size = new System.Drawing.Size(275, 24);
            this.cmdDesignation.TabIndex = 34;
            this.cmdDesignation.ValueMember = "Designation";
            // 
            // sectionsBindingSource1
            // 
            this.sectionsBindingSource1.DataMember = "Sections";
            this.sectionsBindingSource1.DataSource = this.mtx_LibraryDataSet1;
            // 
            // mtx_LibraryDataSet1
            // 
            this.mtx_LibraryDataSet1.DataSetName = "Mtx_LibraryDataSet1";
            this.mtx_LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Designation : ";
            // 
            // rdEmpFemale
            // 
            this.rdEmpFemale.AutoSize = true;
            this.rdEmpFemale.Location = new System.Drawing.Point(641, 144);
            this.rdEmpFemale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdEmpFemale.Name = "rdEmpFemale";
            this.rdEmpFemale.Size = new System.Drawing.Size(72, 21);
            this.rdEmpFemale.TabIndex = 32;
            this.rdEmpFemale.TabStop = true;
            this.rdEmpFemale.Text = "Female";
            this.rdEmpFemale.UseVisualStyleBackColor = true;
            // 
            // rdEmpMale
            // 
            this.rdEmpMale.AutoSize = true;
            this.rdEmpMale.Location = new System.Drawing.Point(580, 144);
            this.rdEmpMale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdEmpMale.Name = "rdEmpMale";
            this.rdEmpMale.Size = new System.Drawing.Size(56, 21);
            this.rdEmpMale.TabIndex = 31;
            this.rdEmpMale.TabStop = true;
            this.rdEmpMale.Text = "Male";
            this.rdEmpMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Gender : ";
            // 
            // dgEmpdata
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgEmpdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmpdata.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgEmpdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpdata.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgEmpdata.Location = new System.Drawing.Point(18, 200);
            this.dgEmpdata.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgEmpdata.Name = "dgEmpdata";
            this.dgEmpdata.RowTemplate.Height = 24;
            this.dgEmpdata.Size = new System.Drawing.Size(1090, 156);
            this.dgEmpdata.TabIndex = 17;
            this.dgEmpdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpdata_CellContentClick);
            this.dgEmpdata.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpdata_CellContentDoubleClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "EPF";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column8.HeaderText = "Last Name";
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Department";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Designation";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1019, 112);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 53);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(1019, 44);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 53);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(916, 44);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 120);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmdDepartment
            // 
            this.cmdDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectionsBindingSource, "Department", true));
            this.cmdDepartment.DataSource = this.sectionsBindingSource;
            this.cmdDepartment.DisplayMember = "Department";
            this.cmdDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDepartment.FormattingEnabled = true;
            this.cmdDepartment.Location = new System.Drawing.Point(580, 94);
            this.cmdDepartment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdDepartment.Name = "cmdDepartment";
            this.cmdDepartment.Size = new System.Drawing.Size(231, 24);
            this.cmdDepartment.TabIndex = 21;
            this.cmdDepartment.ValueMember = "Department";
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.mtx_LibraryDataSet;
            // 
            // mtx_LibraryDataSet
            // 
            this.mtx_LibraryDataSet.DataSetName = "Mtx_LibraryDataSet";
            this.mtx_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Deprtment : ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(110, 88);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(275, 27);
            this.txtLName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name : ";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(580, 38);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(309, 27);
            this.txtFname.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "First Name : ";
            // 
            // txtEpf
            // 
            this.txtEpf.Location = new System.Drawing.Point(110, 38);
            this.txtEpf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEpf.Multiline = true;
            this.txtEpf.Name = "txtEpf";
            this.txtEpf.Size = new System.Drawing.Size(275, 27);
            this.txtEpf.TabIndex = 15;
            this.txtEpf.TextChanged += new System.EventHandler(this.txtEpf_TextChanged);
            this.txtEpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEpf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "EPF : ";
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // mtxLibraryDataSetBindingSource
            // 
            this.mtxLibraryDataSetBindingSource.DataSource = this.mtx_LibraryDataSet;
            this.mtxLibraryDataSetBindingSource.Position = 0;
            // 
            // sectionsTableAdapter1
            // 
            this.sectionsTableAdapter1.ClearBeforeFill = true;
            // 
            // EmployeeRegisterv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_V1.Properties.Resources.wallpaper2you_196278;
            this.ClientSize = new System.Drawing.Size(1151, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeRegisterv2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookRegisterV2";
            this.Load += new System.EventHandler(this.EmployeeRegisterv2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtx_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxLibraryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgEmpdata;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdEmpInactive;
        private System.Windows.Forms.RadioButton rdEmpActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmdDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdEmpFemale;
        private System.Windows.Forms.RadioButton rdEmpMale;
        private System.Windows.Forms.Label label9;
        private Mtx_LibraryDataSet mtx_LibraryDataSet;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private Mtx_LibraryDataSetTableAdapters.SectionsTableAdapter sectionsTableAdapter;
        private System.Windows.Forms.ComboBox cmdDesignation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource mtxLibraryDataSetBindingSource;
        private Mtx_LibraryDataSet1 mtx_LibraryDataSet1;
        private System.Windows.Forms.BindingSource sectionsBindingSource1;
        private Mtx_LibraryDataSet1TableAdapters.SectionsTableAdapter sectionsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}