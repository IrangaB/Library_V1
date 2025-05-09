namespace Library_V1
{
    partial class BarcodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeGenerator));
            this.btnGenerateBarcode = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.BtnSaveBarcode = new System.Windows.Forms.Button();
            this.txtBookNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateBarcode.FlatAppearance.BorderSize = 2;
            this.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBarcode.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBarcode.Location = new System.Drawing.Point(358, 400);
            this.btnGenerateBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(107, 44);
            this.btnGenerateBarcode.TabIndex = 15;
            this.btnGenerateBarcode.Text = "Get Barcode";
            this.btnGenerateBarcode.UseVisualStyleBackColor = false;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.BackColor = System.Drawing.Color.Transparent;
            this.picBarcode.Location = new System.Drawing.Point(12, 62);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(570, 259);
            this.picBarcode.TabIndex = 16;
            this.picBarcode.TabStop = false;
            // 
            // BtnSaveBarcode
            // 
            this.BtnSaveBarcode.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSaveBarcode.FlatAppearance.BorderSize = 2;
            this.BtnSaveBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveBarcode.ForeColor = System.Drawing.Color.White;
            this.BtnSaveBarcode.Location = new System.Drawing.Point(475, 400);
            this.BtnSaveBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveBarcode.Name = "BtnSaveBarcode";
            this.BtnSaveBarcode.Size = new System.Drawing.Size(107, 44);
            this.BtnSaveBarcode.TabIndex = 17;
            this.BtnSaveBarcode.Text = "Save";
            this.BtnSaveBarcode.UseVisualStyleBackColor = false;
            this.BtnSaveBarcode.Click += new System.EventHandler(this.BtnSaveBarcode_Click);
            // 
            // txtBookNo
            // 
            this.txtBookNo.Location = new System.Drawing.Point(149, 350);
            this.txtBookNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookNo.Multiline = true;
            this.txtBookNo.Name = "txtBookNo";
            this.txtBookNo.Size = new System.Drawing.Size(389, 27);
            this.txtBookNo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Book Number : ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Library_V1.Properties.Resources.minimize_window_24;
            this.label1.Location = new System.Drawing.Point(515, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.Transparent;
            this.lblClose.Image = global::Library_V1.Properties.Resources.close_window_24;
            this.lblClose.Location = new System.Drawing.Point(551, 9);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 27);
            this.lblClose.TabIndex = 20;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // BarcodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_V1.Properties.Resources.wallpaper2you_196278;
            this.ClientSize = new System.Drawing.Size(604, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.txtBookNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSaveBarcode);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.btnGenerateBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeGenerator";
            this.Load += new System.EventHandler(this.BarcodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateBarcode;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.Button BtnSaveBarcode;
        private System.Windows.Forms.TextBox txtBookNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
    }
}