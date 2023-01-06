namespace Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RName = new System.Windows.Forms.TextBox();
            this.Rpassword = new System.Windows.Forms.TextBox();
            this.Rphone = new System.Windows.Forms.TextBox();
            this.AddressR = new System.Windows.Forms.RichTextBox();
            this.AddR = new System.Windows.Forms.Button();
            this.DeleteR = new System.Windows.Forms.Button();
            this.EditR = new System.Windows.Forms.Button();
            this.ReceDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.view = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ClearSearchButton_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(916, 209);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(155, 26);
            this.RName.TabIndex = 0;
            // 
            // Rpassword
            // 
            this.Rpassword.Location = new System.Drawing.Point(916, 241);
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.Size = new System.Drawing.Size(155, 26);
            this.Rpassword.TabIndex = 1;
            // 
            // Rphone
            // 
            this.Rphone.Location = new System.Drawing.Point(916, 273);
            this.Rphone.Name = "Rphone";
            this.Rphone.Size = new System.Drawing.Size(155, 26);
            this.Rphone.TabIndex = 2;
            // 
            // AddressR
            // 
            this.AddressR.Location = new System.Drawing.Point(916, 40);
            this.AddressR.Name = "AddressR";
            this.AddressR.Size = new System.Drawing.Size(149, 150);
            this.AddressR.TabIndex = 3;
            this.AddressR.Text = "";
            this.AddressR.TextChanged += new System.EventHandler(this.AddressR_TextChanged);
            // 
            // AddR
            // 
            this.AddR.Location = new System.Drawing.Point(916, 318);
            this.AddR.Name = "AddR";
            this.AddR.Size = new System.Drawing.Size(107, 39);
            this.AddR.TabIndex = 4;
            this.AddR.Text = "add";
            this.AddR.UseVisualStyleBackColor = true;
            this.AddR.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteR
            // 
            this.DeleteR.Location = new System.Drawing.Point(1044, 317);
            this.DeleteR.Name = "DeleteR";
            this.DeleteR.Size = new System.Drawing.Size(113, 39);
            this.DeleteR.TabIndex = 5;
            this.DeleteR.Text = "delete";
            this.DeleteR.UseVisualStyleBackColor = true;
            this.DeleteR.Click += new System.EventHandler(this.DeleteR_Click);
            // 
            // EditR
            // 
            this.EditR.Location = new System.Drawing.Point(777, 318);
            this.EditR.Name = "EditR";
            this.EditR.Size = new System.Drawing.Size(120, 38);
            this.EditR.TabIndex = 6;
            this.EditR.Text = "edit";
            this.EditR.UseVisualStyleBackColor = true;
            this.EditR.Click += new System.EventHandler(this.EditR_Click);
            // 
            // ReceDGV
            // 
            this.ReceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceDGV.Location = new System.Drawing.Point(226, 444);
            this.ReceDGV.Name = "ReceDGV";
            this.ReceDGV.RowHeadersWidth = 62;
            this.ReceDGV.RowTemplate.Height = 28;
            this.ReceDGV.Size = new System.Drawing.Size(1088, 290);
            this.ReceDGV.TabIndex = 7;
            this.ReceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceDGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final.Properties.Resources.exit_icon_4597;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1227, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(1178, 317);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(94, 39);
            this.view.TabIndex = 9;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(940, 375);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(217, 26);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ClearSearchButton_Click
            // 
            this.ClearSearchButton_Click.Location = new System.Drawing.Point(1168, 365);
            this.ClearSearchButton_Click.Name = "ClearSearchButton_Click";
            this.ClearSearchButton_Click.Size = new System.Drawing.Size(75, 36);
            this.ClearSearchButton_Click.TabIndex = 12;
            this.ClearSearchButton_Click.Text = "search";
            this.ClearSearchButton_Click.UseVisualStyleBackColor = true;
            this.ClearSearchButton_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "password";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(831, 276);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(54, 20);
            this.Phone.TabIndex = 15;
            this.Phone.Text = "phone";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "address";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 732);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doctors";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Receptionist";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Patients";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearSearchButton_Click);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.view);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReceDGV);
            this.Controls.Add(this.EditR);
            this.Controls.Add(this.DeleteR);
            this.Controls.Add(this.AddR);
            this.Controls.Add(this.AddressR);
            this.Controls.Add(this.Rphone);
            this.Controls.Add(this.Rpassword);
            this.Controls.Add(this.RName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RName;
        private System.Windows.Forms.TextBox Rpassword;
        private System.Windows.Forms.TextBox Rphone;
        private System.Windows.Forms.RichTextBox AddressR;
        private System.Windows.Forms.Button AddR;
        private System.Windows.Forms.Button DeleteR;
        private System.Windows.Forms.Button EditR;
        private System.Windows.Forms.DataGridView ReceDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ClearSearchButton_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

