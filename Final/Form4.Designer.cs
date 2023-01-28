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
            this.components = new System.ComponentModel.Container();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countpat = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Patient = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.countdoc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Doc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Patients = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.rece = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.countpat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Patient);
            this.panel2.Location = new System.Drawing.Point(341, 569);
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
            this.countpat.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.countpat_MaskInputRejected);
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
            this.Patient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Patient.Location = new System.Drawing.Point(66, 20);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(67, 20);
            this.Patient.TabIndex = 0;
            this.Patient.Text = "Patients";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.countdoc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(868, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // countdoc
            // 
            this.countdoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countdoc.Location = new System.Drawing.Point(53, 53);
            this.countdoc.Name = "countdoc";
            this.countdoc.Size = new System.Drawing.Size(97, 38);
            this.countdoc.TabIndex = 1;
            this.countdoc.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.guna2Panel1.Controls.Add(this.Doc);
            this.guna2Panel1.Controls.Add(this.Patients);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton2);
            this.guna2Panel1.Controls.Add(this.rece);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(275, 783);
            this.guna2Panel1.TabIndex = 29;
            // 
            // Doc
            // 
            this.Doc.CheckedState.Parent = this.Doc;
            this.Doc.CustomImages.Image = global::Final.Properties.Resources.icons8_occupied_bed_100;
            this.Doc.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Doc.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.Doc.CustomImages.Parent = this.Doc;
            this.Doc.FillColor = System.Drawing.Color.Empty;
            this.Doc.FillColor2 = System.Drawing.Color.Empty;
            this.Doc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.White;
            this.Doc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.Doc.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.Doc.HoverState.Parent = this.Doc;
            this.Doc.Location = new System.Drawing.Point(12, 382);
            this.Doc.Name = "Doc";
            this.Doc.ShadowDecoration.Parent = this.Doc;
            this.Doc.Size = new System.Drawing.Size(246, 67);
            this.Doc.TabIndex = 8;
            this.Doc.Text = "Doctors";
            this.Doc.TextOffset = new System.Drawing.Point(5, 0);
            this.Doc.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // Patients
            // 
            this.Patients.CheckedState.Parent = this.Patients;
            this.Patients.CustomImages.Image = global::Final.Properties.Resources.icons8_occupied_bed_100;
            this.Patients.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Patients.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.Patients.CustomImages.Parent = this.Patients;
            this.Patients.FillColor = System.Drawing.Color.Empty;
            this.Patients.FillColor2 = System.Drawing.Color.Empty;
            this.Patients.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients.ForeColor = System.Drawing.Color.White;
            this.Patients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.Patients.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.Patients.HoverState.Parent = this.Patients;
            this.Patients.Location = new System.Drawing.Point(6, 184);
            this.Patients.Name = "Patients";
            this.Patients.ShadowDecoration.Parent = this.Patients;
            this.Patients.Size = new System.Drawing.Size(262, 84);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Patients";
            this.Patients.TextOffset = new System.Drawing.Point(5, 0);
            this.Patients.Click += new System.EventHandler(this.dfd_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(29, 491);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Final.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(91, 97);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = global::Final.Properties.Resources.icons8_logout_rounded_100;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton2.Location = new System.Drawing.Point(12, 549);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(246, 91);
            this.guna2GradientButton2.TabIndex = 6;
            this.guna2GradientButton2.Text = "Logout";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // rece
            // 
            this.rece.CheckedState.Parent = this.rece;
            this.rece.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.rece.CustomImages.Parent = this.rece;
            this.rece.FillColor = System.Drawing.Color.Empty;
            this.rece.FillColor2 = System.Drawing.Color.Empty;
            this.rece.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rece.ForeColor = System.Drawing.Color.White;
            this.rece.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.rece.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.rece.HoverState.Parent = this.rece;
            this.rece.Image = global::Final.Properties.Resources.icons8_nurse_100;
            this.rece.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rece.ImageOffset = new System.Drawing.Point(-4, 0);
            this.rece.ImageSize = new System.Drawing.Size(40, 40);
            this.rece.Location = new System.Drawing.Point(6, 286);
            this.rece.Name = "rece";
            this.rece.ShadowDecoration.Parent = this.rece;
            this.rece.Size = new System.Drawing.Size(265, 65);
            this.rece.TabIndex = 5;
            this.rece.Text = "Receptionists";
            this.rece.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rece.TextOffset = new System.Drawing.Point(5, 0);
            this.rece.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(411, 429);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "label3";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 782);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Patient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox countpat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel countdoc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton Patients;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton rece;
        private Guna.UI2.WinForms.Guna2GradientButton Doc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}