﻿namespace Final
{
    partial class Form2
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
            this.Doc_name = new System.Windows.Forms.TextBox();
            this.Doc_Label_Name = new System.Windows.Forms.Label();
            this.Doc_Gender = new System.Windows.Forms.ComboBox();
            this.Doctor_Label_Pass = new System.Windows.Forms.Label();
            this.Doc_Pass = new System.Windows.Forms.TextBox();
            this.DOB_label = new System.Windows.Forms.Label();
            this.DOB_doctor = new System.Windows.Forms.DateTimePicker();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Doctor_Phone = new System.Windows.Forms.Label();
            this.Doctor_phone = new System.Windows.Forms.TextBox();
            this.Add_Docor = new System.Windows.Forms.Button();
            this.Edit_Doctor = new System.Windows.Forms.Button();
            this.Delete_Doctor = new System.Windows.Forms.Button();
            this.lebel = new System.Windows.Forms.Label();
            this.Doctor_exp = new System.Windows.Forms.TextBox();
            this.Doc_DGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Doc_name
            // 
            this.Doc_name.Location = new System.Drawing.Point(132, 48);
            this.Doc_name.Name = "Doc_name";
            this.Doc_name.Size = new System.Drawing.Size(189, 26);
            this.Doc_name.TabIndex = 0;
            // 
            // Doc_Label_Name
            // 
            this.Doc_Label_Name.AutoSize = true;
            this.Doc_Label_Name.Location = new System.Drawing.Point(43, 48);
            this.Doc_Label_Name.Name = "Doc_Label_Name";
            this.Doc_Label_Name.Size = new System.Drawing.Size(51, 20);
            this.Doc_Label_Name.TabIndex = 1;
            this.Doc_Label_Name.Text = "Name";
            this.Doc_Label_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Doc_Gender
            // 
            this.Doc_Gender.FormattingEnabled = true;
            this.Doc_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Doc_Gender.Location = new System.Drawing.Point(365, 51);
            this.Doc_Gender.Name = "Doc_Gender";
            this.Doc_Gender.Size = new System.Drawing.Size(121, 28);
            this.Doc_Gender.TabIndex = 2;
            this.Doc_Gender.Text = "Gender";
            // 
            // Doctor_Label_Pass
            // 
            this.Doctor_Label_Pass.AutoSize = true;
            this.Doctor_Label_Pass.Location = new System.Drawing.Point(531, 54);
            this.Doctor_Label_Pass.Name = "Doctor_Label_Pass";
            this.Doctor_Label_Pass.Size = new System.Drawing.Size(78, 20);
            this.Doctor_Label_Pass.TabIndex = 3;
            this.Doctor_Label_Pass.Text = "Password";
            this.Doctor_Label_Pass.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Doc_Pass
            // 
            this.Doc_Pass.Location = new System.Drawing.Point(653, 54);
            this.Doc_Pass.Name = "Doc_Pass";
            this.Doc_Pass.Size = new System.Drawing.Size(173, 26);
            this.Doc_Pass.TabIndex = 4;
            this.Doc_Pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DOB_label
            // 
            this.DOB_label.AutoSize = true;
            this.DOB_label.Location = new System.Drawing.Point(50, 112);
            this.DOB_label.Name = "DOB_label";
            this.DOB_label.Size = new System.Drawing.Size(44, 20);
            this.DOB_label.TabIndex = 6;
            this.DOB_label.Text = "DOB";
            // 
            // DOB_doctor
            // 
            this.DOB_doctor.Location = new System.Drawing.Point(132, 112);
            this.DOB_doctor.Name = "DOB_doctor";
            this.DOB_doctor.Size = new System.Drawing.Size(189, 26);
            this.DOB_doctor.TabIndex = 8;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Label_Doctor_Phone
            // 
            this.Label_Doctor_Phone.AutoSize = true;
            this.Label_Doctor_Phone.Location = new System.Drawing.Point(379, 112);
            this.Label_Doctor_Phone.Name = "Label_Doctor_Phone";
            this.Label_Doctor_Phone.Size = new System.Drawing.Size(55, 20);
            this.Label_Doctor_Phone.TabIndex = 10;
            this.Label_Doctor_Phone.Text = "Phone";
            this.Label_Doctor_Phone.Click += new System.EventHandler(this.label2_Click);
            // 
            // Doctor_phone
            // 
            this.Doctor_phone.Location = new System.Drawing.Point(456, 111);
            this.Doctor_phone.Name = "Doctor_phone";
            this.Doctor_phone.Size = new System.Drawing.Size(207, 26);
            this.Doctor_phone.TabIndex = 11;
            // 
            // Add_Docor
            // 
            this.Add_Docor.Location = new System.Drawing.Point(132, 229);
            this.Add_Docor.Name = "Add_Docor";
            this.Add_Docor.Size = new System.Drawing.Size(114, 41);
            this.Add_Docor.TabIndex = 14;
            this.Add_Docor.Text = "Add";
            this.Add_Docor.UseVisualStyleBackColor = true;
            this.Add_Docor.Click += new System.EventHandler(this.Add_Docor_Click);
            // 
            // Edit_Doctor
            // 
            this.Edit_Doctor.Location = new System.Drawing.Point(272, 229);
            this.Edit_Doctor.Name = "Edit_Doctor";
            this.Edit_Doctor.Size = new System.Drawing.Size(99, 41);
            this.Edit_Doctor.TabIndex = 15;
            this.Edit_Doctor.Text = "Edit";
            this.Edit_Doctor.UseVisualStyleBackColor = true;
            this.Edit_Doctor.Click += new System.EventHandler(this.Edit_Doctor_Click);
            // 
            // Delete_Doctor
            // 
            this.Delete_Doctor.Location = new System.Drawing.Point(400, 229);
            this.Delete_Doctor.Name = "Delete_Doctor";
            this.Delete_Doctor.Size = new System.Drawing.Size(98, 41);
            this.Delete_Doctor.TabIndex = 16;
            this.Delete_Doctor.Text = "Delete";
            this.Delete_Doctor.UseVisualStyleBackColor = true;
            this.Delete_Doctor.Click += new System.EventHandler(this.Delete_Doctor_Click);
            // 
            // lebel
            // 
            this.lebel.AutoSize = true;
            this.lebel.Location = new System.Drawing.Point(43, 180);
            this.lebel.Name = "lebel";
            this.lebel.Size = new System.Drawing.Size(88, 20);
            this.lebel.TabIndex = 17;
            this.lebel.Text = "Experience";
            // 
            // Doctor_exp
            // 
            this.Doctor_exp.Location = new System.Drawing.Point(161, 180);
            this.Doctor_exp.Name = "Doctor_exp";
            this.Doctor_exp.Size = new System.Drawing.Size(195, 26);
            this.Doctor_exp.TabIndex = 18;
            // 
            // Doc_DGV
            // 
            this.Doc_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doc_DGV.Location = new System.Drawing.Point(4, 333);
            this.Doc_DGV.Name = "Doc_DGV";
            this.Doc_DGV.RowHeadersWidth = 62;
            this.Doc_DGV.RowTemplate.Height = 28;
            this.Doc_DGV.Size = new System.Drawing.Size(983, 241);
            this.Doc_DGV.TabIndex = 19;
            this.Doc_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Doc_DGV);
            this.Controls.Add(this.Doctor_exp);
            this.Controls.Add(this.lebel);
            this.Controls.Add(this.Delete_Doctor);
            this.Controls.Add(this.Edit_Doctor);
            this.Controls.Add(this.Add_Docor);
            this.Controls.Add(this.Doctor_phone);
            this.Controls.Add(this.Label_Doctor_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOB_doctor);
            this.Controls.Add(this.DOB_label);
            this.Controls.Add(this.Doc_Pass);
            this.Controls.Add(this.Doctor_Label_Pass);
            this.Controls.Add(this.Doc_Gender);
            this.Controls.Add(this.Doc_Label_Name);
            this.Controls.Add(this.Doc_name);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Doc_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Doc_name;
        private System.Windows.Forms.Label Doc_Label_Name;
        private System.Windows.Forms.ComboBox Doc_Gender;
        private System.Windows.Forms.Label Doctor_Label_Pass;
        private System.Windows.Forms.TextBox Doc_Pass;
        private System.Windows.Forms.Label DOB_label;
        private System.Windows.Forms.DateTimePicker DOB_doctor;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Doctor_Phone;
        private System.Windows.Forms.TextBox Doctor_phone;
        private System.Windows.Forms.Button Add_Docor;
        private System.Windows.Forms.Button Edit_Doctor;
        private System.Windows.Forms.Button Delete_Doctor;
        private System.Windows.Forms.Label lebel;
        private System.Windows.Forms.TextBox Doctor_exp;
        private System.Windows.Forms.DataGridView Doc_DGV;
        private System.Windows.Forms.Button button1;
    }
}