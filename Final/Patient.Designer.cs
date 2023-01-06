namespace Final
{
    partial class Patient
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
            this.label1 = new System.Windows.Forms.Label();
            this.PGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PDob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Paddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PAllergie = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PPressure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PBmi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Pmedication = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Psearch = new System.Windows.Forms.TextBox();
            this.DGV_Patient = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PNational = new System.Windows.Forms.TextBox();
            this.PHistory = new System.Windows.Forms.TextBox();
            this.labellkfl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Label();
            this.Rece = new System.Windows.Forms.Label();
            this.Doctor = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // PGender
            // 
            this.PGender.FormattingEnabled = true;
            this.PGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGender.Location = new System.Drawing.Point(843, 326);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(89, 28);
            this.PGender.TabIndex = 1;
            this.PGender.Text = "Gender";
            this.PGender.SelectedIndexChanged += new System.EventHandler(this.PGender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1080, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOB";
            // 
            // PDob
            // 
            this.PDob.Location = new System.Drawing.Point(1175, 55);
            this.PDob.Name = "PDob";
            this.PDob.Size = new System.Drawing.Size(200, 26);
            this.PDob.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // Paddress
            // 
            this.Paddress.Location = new System.Drawing.Point(843, 148);
            this.Paddress.Multiline = true;
            this.Paddress.Name = "Paddress";
            this.Paddress.Size = new System.Drawing.Size(196, 118);
            this.Paddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // Pphone
            // 
            this.Pphone.Location = new System.Drawing.Point(843, 108);
            this.Pphone.Name = "Pphone";
            this.Pphone.Size = new System.Drawing.Size(196, 26);
            this.Pphone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1097, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Allergies";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PAllergie
            // 
            this.PAllergie.Location = new System.Drawing.Point(1197, 160);
            this.PAllergie.Multiline = true;
            this.PAllergie.Name = "PAllergie";
            this.PAllergie.Size = new System.Drawing.Size(162, 118);
            this.PAllergie.TabIndex = 10;
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(843, 14);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(196, 26);
            this.PName.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PPressure
            // 
            this.PPressure.Location = new System.Drawing.Point(843, 278);
            this.PPressure.Name = "PPressure";
            this.PPressure.Size = new System.Drawing.Size(196, 26);
            this.PPressure.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(719, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "pressure";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1097, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "BMI";
            // 
            // PBmi
            // 
            this.PBmi.Location = new System.Drawing.Point(1236, 120);
            this.PBmi.Name = "PBmi";
            this.PBmi.Size = new System.Drawing.Size(188, 26);
            this.PBmi.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1047, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Current-Medication";
            // 
            // Pmedication
            // 
            this.Pmedication.Location = new System.Drawing.Point(1197, 304);
            this.Pmedication.Multiline = true;
            this.Pmedication.Name = "Pmedication";
            this.Pmedication.Size = new System.Drawing.Size(162, 124);
            this.Pmedication.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Psearch
            // 
            this.Psearch.Location = new System.Drawing.Point(357, 414);
            this.Psearch.Name = "Psearch";
            this.Psearch.Size = new System.Drawing.Size(226, 26);
            this.Psearch.TabIndex = 23;
            this.Psearch.TextChanged += new System.EventHandler(this.Psearch_TextChanged);
            // 
            // DGV_Patient
            // 
            this.DGV_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Patient.Location = new System.Drawing.Point(299, 461);
            this.DGV_Patient.Name = "DGV_Patient";
            this.DGV_Patient.RowHeadersWidth = 62;
            this.DGV_Patient.RowTemplate.Height = 28;
            this.DGV_Patient.Size = new System.Drawing.Size(1074, 290);
            this.DGV_Patient.TabIndex = 24;
            this.DGV_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "National_ID";
            // 
            // PNational
            // 
            this.PNational.Location = new System.Drawing.Point(843, 61);
            this.PNational.Name = "PNational";
            this.PNational.Size = new System.Drawing.Size(196, 26);
            this.PNational.TabIndex = 26;
            this.PNational.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PHistory
            // 
            this.PHistory.Location = new System.Drawing.Point(843, 360);
            this.PHistory.Multiline = true;
            this.PHistory.Name = "PHistory";
            this.PHistory.Size = new System.Drawing.Size(176, 95);
            this.PHistory.TabIndex = 27;
            // 
            // labellkfl
            // 
            this.labellkfl.AutoSize = true;
            this.labellkfl.Location = new System.Drawing.Point(708, 384);
            this.labellkfl.Name = "labellkfl";
            this.labellkfl.Size = new System.Drawing.Size(116, 20);
            this.labellkfl.TabIndex = 28;
            this.labellkfl.Text = "Medical History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Rece);
            this.panel1.Controls.Add(this.Doctor);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 743);
            this.panel1.TabIndex = 29;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Location = new System.Drawing.Point(104, 547);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(59, 20);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Rece
            // 
            this.Rece.AutoSize = true;
            this.Rece.Location = new System.Drawing.Point(112, 382);
            this.Rece.Name = "Rece";
            this.Rece.Size = new System.Drawing.Size(47, 20);
            this.Rece.TabIndex = 2;
            this.Rece.Text = "Rece";
            this.Rece.Click += new System.EventHandler(this.Rece_Click);
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Location = new System.Drawing.Point(99, 271);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(65, 20);
            this.Doctor.TabIndex = 1;
            this.Doctor.Text = "Doctors";
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Location = new System.Drawing.Point(112, 164);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(52, 20);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labellkfl);
            this.Controls.Add(this.PHistory);
            this.Controls.Add(this.PNational);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_Patient);
            this.Controls.Add(this.Psearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Pmedication);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PBmi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PPressure);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PAllergie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Paddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.label1);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PDob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Paddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PAllergie;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PPressure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PBmi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Pmedication;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Psearch;
        private System.Windows.Forms.DataGridView DGV_Patient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PNational;
        private System.Windows.Forms.TextBox PHistory;
        private System.Windows.Forms.Label labellkfl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Rece;
    }
}