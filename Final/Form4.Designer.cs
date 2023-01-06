namespace Final
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rece = new System.Windows.Forms.Label();
            this.Doc = new System.Windows.Forms.Label();
            this.Patients = new System.Windows.Forms.Label();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countpat = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Patient = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rece);
            this.panel1.Controls.Add(this.Doc);
            this.panel1.Controls.Add(this.Patients);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 699);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Logout";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rece
            // 
            this.rece.AutoSize = true;
            this.rece.Location = new System.Drawing.Point(46, 347);
            this.rece.Name = "rece";
            this.rece.Size = new System.Drawing.Size(98, 20);
            this.rece.TabIndex = 2;
            this.rece.Text = "Receptionist";
            this.rece.Click += new System.EventHandler(this.rece_Click);
            // 
            // Doc
            // 
            this.Doc.AutoSize = true;
            this.Doc.Location = new System.Drawing.Point(56, 245);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(65, 20);
            this.Doc.TabIndex = 1;
            this.Doc.Text = "Doctors";
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Patients
            // 
            this.Patients.AutoSize = true;
            this.Patients.BackColor = System.Drawing.Color.Transparent;
            this.Patients.Location = new System.Drawing.Point(56, 149);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(67, 20);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Patients";
            this.Patients.Click += new System.EventHandler(this.Patients_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.countpat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Patient);
            this.panel2.Location = new System.Drawing.Point(314, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // countpat
            // 
            this.countpat.Location = new System.Drawing.Point(52, 53);
            this.countpat.Name = "countpat";
            this.countpat.Size = new System.Drawing.Size(100, 26);
            this.countpat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\n";
            // 
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Location = new System.Drawing.Point(66, 20);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(67, 20);
            this.Patient.TabIndex = 0;
            this.Patient.Text = "Patients";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(662, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(53, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 38);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 715);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rece;
        private System.Windows.Forms.Label Doc;
        private System.Windows.Forms.Label Patients;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox countpat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}