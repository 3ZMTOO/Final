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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Doc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Patients = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PName = new Guna.UI2.WinForms.Guna2TextBox();
            this.PNational = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.Paddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.PPressure = new Guna.UI2.WinForms.Guna2TextBox();
            this.PBmi = new Guna.UI2.WinForms.Guna2TextBox();
            this.PAllergie = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pmedication = new Guna.UI2.WinForms.Guna2TextBox();
            this.PGender = new System.Windows.Forms.ComboBox();
            this.PHistory = new Guna.UI2.WinForms.Guna2TextBox();
            this.Psearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddR = new Guna.UI2.WinForms.Guna2Button();
            this.EditR = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_Doctor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PDob = new System.Windows.Forms.DateTimePicker();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DGV_Patient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.guna2Panel1.Controls.Add(this.Doc);
            this.guna2Panel1.Controls.Add(this.Patients);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton2);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(267, 857);
            this.guna2Panel1.TabIndex = 30;
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
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
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
            this.Patients.Click += new System.EventHandler(this.Patients_Click);
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
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Final.Properties.Resources.icons8_nurse_100;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageOffset = new System.Drawing.Point(-4, 0);
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.Location = new System.Drawing.Point(6, 286);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(265, 65);
            this.guna2GradientButton1.TabIndex = 5;
            this.guna2GradientButton1.Text = "Receptionists";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // PName
            // 
            this.PName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PName.DefaultText = "";
            this.PName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PName.DisabledState.Parent = this.PName;
            this.PName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PName.FocusedState.Parent = this.PName;
            this.PName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PName.HoverState.Parent = this.PName;
            this.PName.Location = new System.Drawing.Point(296, 203);
            this.PName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PName.Name = "PName";
            this.PName.PasswordChar = '\0';
            this.PName.PlaceholderText = "Name";
            this.PName.SelectedText = "";
            this.PName.ShadowDecoration.Parent = this.PName;
            this.PName.Size = new System.Drawing.Size(281, 41);
            this.PName.TabIndex = 31;
            // 
            // PNational
            // 
            this.PNational.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNational.DefaultText = "";
            this.PNational.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNational.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNational.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNational.DisabledState.Parent = this.PNational;
            this.PNational.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNational.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNational.FocusedState.Parent = this.PNational;
            this.PNational.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNational.HoverState.Parent = this.PNational;
            this.PNational.Location = new System.Drawing.Point(295, 261);
            this.PNational.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNational.Name = "PNational";
            this.PNational.PasswordChar = '\0';
            this.PNational.PlaceholderText = "National ID";
            this.PNational.SelectedText = "";
            this.PNational.ShadowDecoration.Parent = this.PNational;
            this.PNational.Size = new System.Drawing.Size(281, 43);
            this.PNational.TabIndex = 32;
            // 
            // Pphone
            // 
            this.Pphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pphone.DefaultText = "";
            this.Pphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pphone.DisabledState.Parent = this.Pphone;
            this.Pphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pphone.FocusedState.Parent = this.Pphone;
            this.Pphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pphone.HoverState.Parent = this.Pphone;
            this.Pphone.Location = new System.Drawing.Point(296, 314);
            this.Pphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pphone.Name = "Pphone";
            this.Pphone.PasswordChar = '\0';
            this.Pphone.PlaceholderText = "Phone";
            this.Pphone.SelectedText = "";
            this.Pphone.ShadowDecoration.Parent = this.Pphone;
            this.Pphone.Size = new System.Drawing.Size(281, 46);
            this.Pphone.TabIndex = 33;
            // 
            // Paddress
            // 
            this.Paddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Paddress.DefaultText = "";
            this.Paddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Paddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Paddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Paddress.DisabledState.Parent = this.Paddress;
            this.Paddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Paddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Paddress.FocusedState.Parent = this.Paddress;
            this.Paddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Paddress.HoverState.Parent = this.Paddress;
            this.Paddress.Location = new System.Drawing.Point(295, 370);
            this.Paddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Paddress.Name = "Paddress";
            this.Paddress.PasswordChar = '\0';
            this.Paddress.PlaceholderText = "Address";
            this.Paddress.SelectedText = "";
            this.Paddress.ShadowDecoration.Parent = this.Paddress;
            this.Paddress.Size = new System.Drawing.Size(282, 44);
            this.Paddress.TabIndex = 35;
            // 
            // PPressure
            // 
            this.PPressure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPressure.DefaultText = "";
            this.PPressure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PPressure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PPressure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPressure.DisabledState.Parent = this.PPressure;
            this.PPressure.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPressure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPressure.FocusedState.Parent = this.PPressure;
            this.PPressure.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPressure.HoverState.Parent = this.PPressure;
            this.PPressure.Location = new System.Drawing.Point(603, 203);
            this.PPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PPressure.Name = "PPressure";
            this.PPressure.PasswordChar = '\0';
            this.PPressure.PlaceholderText = "Pressure";
            this.PPressure.SelectedText = "";
            this.PPressure.ShadowDecoration.Parent = this.PPressure;
            this.PPressure.Size = new System.Drawing.Size(300, 43);
            this.PPressure.TabIndex = 36;
            // 
            // PBmi
            // 
            this.PBmi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PBmi.DefaultText = "";
            this.PBmi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PBmi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PBmi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PBmi.DisabledState.Parent = this.PBmi;
            this.PBmi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PBmi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBmi.FocusedState.Parent = this.PBmi;
            this.PBmi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBmi.HoverState.Parent = this.PBmi;
            this.PBmi.Location = new System.Drawing.Point(603, 261);
            this.PBmi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBmi.Name = "PBmi";
            this.PBmi.PasswordChar = '\0';
            this.PBmi.PlaceholderText = "BMI";
            this.PBmi.SelectedText = "";
            this.PBmi.ShadowDecoration.Parent = this.PBmi;
            this.PBmi.Size = new System.Drawing.Size(300, 43);
            this.PBmi.TabIndex = 37;
            // 
            // PAllergie
            // 
            this.PAllergie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAllergie.DefaultText = "";
            this.PAllergie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PAllergie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PAllergie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAllergie.DisabledState.Parent = this.PAllergie;
            this.PAllergie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAllergie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAllergie.FocusedState.Parent = this.PAllergie;
            this.PAllergie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAllergie.HoverState.Parent = this.PAllergie;
            this.PAllergie.Location = new System.Drawing.Point(603, 316);
            this.PAllergie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PAllergie.Name = "PAllergie";
            this.PAllergie.PasswordChar = '\0';
            this.PAllergie.PlaceholderText = "Allergies";
            this.PAllergie.SelectedText = "";
            this.PAllergie.ShadowDecoration.Parent = this.PAllergie;
            this.PAllergie.Size = new System.Drawing.Size(300, 44);
            this.PAllergie.TabIndex = 38;
            // 
            // Pmedication
            // 
            this.Pmedication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pmedication.DefaultText = "";
            this.Pmedication.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pmedication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pmedication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pmedication.DisabledState.Parent = this.Pmedication;
            this.Pmedication.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pmedication.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pmedication.FocusedState.Parent = this.Pmedication;
            this.Pmedication.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pmedication.HoverState.Parent = this.Pmedication;
            this.Pmedication.Location = new System.Drawing.Point(937, 203);
            this.Pmedication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pmedication.Name = "Pmedication";
            this.Pmedication.PasswordChar = '\0';
            this.Pmedication.PlaceholderText = "Currrent Medication";
            this.Pmedication.SelectedText = "";
            this.Pmedication.ShadowDecoration.Parent = this.Pmedication;
            this.Pmedication.Size = new System.Drawing.Size(285, 120);
            this.Pmedication.TabIndex = 39;
            this.Pmedication.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // PGender
            // 
            this.PGender.FormattingEnabled = true;
            this.PGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGender.Location = new System.Drawing.Point(603, 381);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(138, 28);
            this.PGender.TabIndex = 40;
            // 
            // PHistory
            // 
            this.PHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PHistory.DefaultText = "";
            this.PHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PHistory.DisabledState.Parent = this.PHistory;
            this.PHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PHistory.FocusedState.Parent = this.PHistory;
            this.PHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PHistory.HoverState.Parent = this.PHistory;
            this.PHistory.Location = new System.Drawing.Point(937, 344);
            this.PHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PHistory.Name = "PHistory";
            this.PHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PHistory.PasswordChar = '\0';
            this.PHistory.PlaceholderText = "Medical History";
            this.PHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PHistory.SelectedText = "";
            this.PHistory.ShadowDecoration.Parent = this.PHistory;
            this.PHistory.Size = new System.Drawing.Size(285, 126);
            this.PHistory.TabIndex = 41;
            this.PHistory.TextChanged += new System.EventHandler(this.PHistory_TextChanged);
            // 
            // Psearch
            // 
            this.Psearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Psearch.DefaultText = "";
            this.Psearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Psearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Psearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Psearch.DisabledState.Parent = this.Psearch;
            this.Psearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Psearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Psearch.FocusedState.Parent = this.Psearch;
            this.Psearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Psearch.HoverState.Parent = this.Psearch;
            this.Psearch.Location = new System.Drawing.Point(791, 506);
            this.Psearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Psearch.Name = "Psearch";
            this.Psearch.PasswordChar = '\0';
            this.Psearch.PlaceholderText = "Search";
            this.Psearch.SelectedText = "";
            this.Psearch.ShadowDecoration.Parent = this.Psearch;
            this.Psearch.Size = new System.Drawing.Size(173, 43);
            this.Psearch.TabIndex = 42;
            this.Psearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // AddR
            // 
            this.AddR.BorderRadius = 10;
            this.AddR.CheckedState.Parent = this.AddR;
            this.AddR.CustomImages.Parent = this.AddR;
            this.AddR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.AddR.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddR.ForeColor = System.Drawing.Color.White;
            this.AddR.HoverState.Parent = this.AddR;
            this.AddR.Location = new System.Drawing.Point(298, 499);
            this.AddR.Name = "AddR";
            this.AddR.ShadowDecoration.Parent = this.AddR;
            this.AddR.Size = new System.Drawing.Size(108, 50);
            this.AddR.TabIndex = 43;
            this.AddR.Text = "Add";
            this.AddR.Click += new System.EventHandler(this.AddR_Click);
            // 
            // EditR
            // 
            this.EditR.BorderRadius = 10;
            this.EditR.CheckedState.Parent = this.EditR;
            this.EditR.CustomImages.Parent = this.EditR;
            this.EditR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.EditR.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditR.ForeColor = System.Drawing.Color.White;
            this.EditR.HoverState.Parent = this.EditR;
            this.EditR.Location = new System.Drawing.Point(448, 499);
            this.EditR.Name = "EditR";
            this.EditR.ShadowDecoration.Parent = this.EditR;
            this.EditR.Size = new System.Drawing.Size(114, 53);
            this.EditR.TabIndex = 44;
            this.EditR.Text = "Edit";
            this.EditR.Click += new System.EventHandler(this.EditR_Click);
            // 
            // Delete_Doctor
            // 
            this.Delete_Doctor.BorderRadius = 9;
            this.Delete_Doctor.CheckedState.Parent = this.Delete_Doctor;
            this.Delete_Doctor.CustomImages.Parent = this.Delete_Doctor;
            this.Delete_Doctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.Delete_Doctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Doctor.ForeColor = System.Drawing.Color.White;
            this.Delete_Doctor.HoverState.Parent = this.Delete_Doctor;
            this.Delete_Doctor.Location = new System.Drawing.Point(614, 501);
            this.Delete_Doctor.Name = "Delete_Doctor";
            this.Delete_Doctor.ShadowDecoration.Parent = this.Delete_Doctor;
            this.Delete_Doctor.Size = new System.Drawing.Size(121, 51);
            this.Delete_Doctor.TabIndex = 45;
            this.Delete_Doctor.Text = "Delete";
            this.Delete_Doctor.Click += new System.EventHandler(this.Delete_Doctor_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // PDob
            // 
            this.PDob.Location = new System.Drawing.Point(298, 435);
            this.PDob.Name = "PDob";
            this.PDob.Size = new System.Drawing.Size(279, 26);
            this.PDob.TabIndex = 47;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Final.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox2.Location = new System.Drawing.Point(715, -1);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(132, 117);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 9;
            this.guna2PictureBox2.TabStop = false;
            // 
            // DGV_Patient
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGV_Patient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Patient.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Patient.ColumnHeadersHeight = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Patient.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Patient.EnableHeadersVisualStyles = false;
            this.DGV_Patient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.DGV_Patient.Location = new System.Drawing.Point(273, 579);
            this.DGV_Patient.Name = "DGV_Patient";
            this.DGV_Patient.RowHeadersVisible = false;
            this.DGV_Patient.RowHeadersWidth = 62;
            this.DGV_Patient.RowTemplate.Height = 28;
            this.DGV_Patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Patient.Size = new System.Drawing.Size(973, 277);
            this.DGV_Patient.TabIndex = 48;
            this.DGV_Patient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGV_Patient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Patient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_Patient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_Patient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_Patient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_Patient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Patient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.DGV_Patient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV_Patient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Patient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Patient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Patient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_Patient.ThemeStyle.HeaderStyle.Height = 15;
            this.DGV_Patient.ThemeStyle.ReadOnly = false;
            this.DGV_Patient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Patient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Patient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Patient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Patient.ThemeStyle.RowsStyle.Height = 28;
            this.DGV_Patient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Patient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doc_DGV_CellContentClick);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 853);
            this.Controls.Add(this.DGV_Patient);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.PDob);
            this.Controls.Add(this.Delete_Doctor);
            this.Controls.Add(this.EditR);
            this.Controls.Add(this.AddR);
            this.Controls.Add(this.Psearch);
            this.Controls.Add(this.PHistory);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.Pmedication);
            this.Controls.Add(this.PAllergie);
            this.Controls.Add(this.PBmi);
            this.Controls.Add(this.PPressure);
            this.Controls.Add(this.Paddress);
            this.Controls.Add(this.Pphone);
            this.Controls.Add(this.PNational);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton Doc;
        private Guna.UI2.WinForms.Guna2GradientButton Patients;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox PName;
        private Guna.UI2.WinForms.Guna2TextBox PNational;
        private Guna.UI2.WinForms.Guna2TextBox Pphone;
        private Guna.UI2.WinForms.Guna2TextBox Paddress;
        private Guna.UI2.WinForms.Guna2TextBox PPressure;
        private Guna.UI2.WinForms.Guna2TextBox PBmi;
        private Guna.UI2.WinForms.Guna2TextBox PAllergie;
        private Guna.UI2.WinForms.Guna2TextBox Pmedication;
        private System.Windows.Forms.ComboBox PGender;
        private Guna.UI2.WinForms.Guna2TextBox PHistory;
        private Guna.UI2.WinForms.Guna2TextBox Psearch;
        private Guna.UI2.WinForms.Guna2Button AddR;
        private Guna.UI2.WinForms.Guna2Button EditR;
        private Guna.UI2.WinForms.Guna2Button Delete_Doctor;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DateTimePicker PDob;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_Patient;
    }
}