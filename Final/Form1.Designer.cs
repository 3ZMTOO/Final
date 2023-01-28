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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Doc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Patients = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.rece = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressR = new Guna.UI2.WinForms.Guna2TextBox();
            this.EditR = new Guna.UI2.WinForms.Guna2Button();
            this.AddR = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteR = new Guna.UI2.WinForms.Guna2Button();
            this.view = new Guna.UI2.WinForms.Guna2Button();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ReceDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final.Properties.Resources.exit_icon_4597;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1052, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(254, 753);
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
            this.Doc.Click += new System.EventHandler(this.Doc_Click_1);
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
            this.Patients.Click += new System.EventHandler(this.Patients_Click_1);
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
            this.rece.Click += new System.EventHandler(this.rece_Click_1);
            // 
            // RName
            // 
            this.RName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RName.DefaultText = "";
            this.RName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RName.DisabledState.Parent = this.RName;
            this.RName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RName.FocusedState.Parent = this.RName;
            this.RName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RName.HoverState.Parent = this.RName;
            this.RName.Location = new System.Drawing.Point(299, 143);
            this.RName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RName.Name = "RName";
            this.RName.PasswordChar = '\0';
            this.RName.PlaceholderText = "Name";
            this.RName.SelectedText = "";
            this.RName.ShadowDecoration.Parent = this.RName;
            this.RName.Size = new System.Drawing.Size(255, 44);
            this.RName.TabIndex = 31;
            // 
            // Rpassword
            // 
            this.Rpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rpassword.DefaultText = "";
            this.Rpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rpassword.DisabledState.Parent = this.Rpassword;
            this.Rpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rpassword.FocusedState.Parent = this.Rpassword;
            this.Rpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rpassword.HoverState.Parent = this.Rpassword;
            this.Rpassword.Location = new System.Drawing.Point(590, 143);
            this.Rpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.PasswordChar = '\0';
            this.Rpassword.PlaceholderText = "Password";
            this.Rpassword.SelectedText = "";
            this.Rpassword.ShadowDecoration.Parent = this.Rpassword;
            this.Rpassword.Size = new System.Drawing.Size(255, 45);
            this.Rpassword.TabIndex = 32;
            // 
            // Rphone
            // 
            this.Rphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rphone.DefaultText = "";
            this.Rphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rphone.DisabledState.Parent = this.Rphone;
            this.Rphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rphone.FocusedState.Parent = this.Rphone;
            this.Rphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rphone.HoverState.Parent = this.Rphone;
            this.Rphone.Location = new System.Drawing.Point(299, 197);
            this.Rphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rphone.Name = "Rphone";
            this.Rphone.PasswordChar = '\0';
            this.Rphone.PlaceholderText = "Phone";
            this.Rphone.SelectedText = "";
            this.Rphone.ShadowDecoration.Parent = this.Rphone;
            this.Rphone.Size = new System.Drawing.Size(255, 45);
            this.Rphone.TabIndex = 33;
            // 
            // AddressR
            // 
            this.AddressR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressR.DefaultText = "";
            this.AddressR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressR.DisabledState.Parent = this.AddressR;
            this.AddressR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressR.FocusedState.Parent = this.AddressR;
            this.AddressR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressR.HoverState.Parent = this.AddressR;
            this.AddressR.Location = new System.Drawing.Point(590, 198);
            this.AddressR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressR.Name = "AddressR";
            this.AddressR.PasswordChar = '\0';
            this.AddressR.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.AddressR.PlaceholderText = "Type The Address";
            this.AddressR.SelectedText = "";
            this.AddressR.ShadowDecoration.Parent = this.AddressR;
            this.AddressR.Size = new System.Drawing.Size(335, 44);
            this.AddressR.TabIndex = 34;
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
            this.EditR.Location = new System.Drawing.Point(438, 370);
            this.EditR.Name = "EditR";
            this.EditR.ShadowDecoration.Parent = this.EditR;
            this.EditR.Size = new System.Drawing.Size(132, 57);
            this.EditR.TabIndex = 35;
            this.EditR.Text = "Edit";
            this.EditR.Click += new System.EventHandler(this.EditR_Click);
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
            this.AddR.Location = new System.Drawing.Point(287, 370);
            this.AddR.Name = "AddR";
            this.AddR.ShadowDecoration.Parent = this.AddR;
            this.AddR.Size = new System.Drawing.Size(120, 57);
            this.AddR.TabIndex = 36;
            this.AddR.Text = "Add";
            this.AddR.Click += new System.EventHandler(this.AddR_Click);
            // 
            // DeleteR
            // 
            this.DeleteR.BorderRadius = 10;
            this.DeleteR.CheckedState.Parent = this.DeleteR;
            this.DeleteR.CustomImages.Parent = this.DeleteR;
            this.DeleteR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.DeleteR.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteR.ForeColor = System.Drawing.Color.White;
            this.DeleteR.HoverState.Parent = this.DeleteR;
            this.DeleteR.Location = new System.Drawing.Point(600, 370);
            this.DeleteR.Name = "DeleteR";
            this.DeleteR.ShadowDecoration.Parent = this.DeleteR;
            this.DeleteR.Size = new System.Drawing.Size(131, 57);
            this.DeleteR.TabIndex = 37;
            this.DeleteR.Text = "Delete";
            this.DeleteR.Click += new System.EventHandler(this.DeleteR_Click);
            // 
            // view
            // 
            this.view.BorderRadius = 10;
            this.view.CheckedState.Parent = this.view;
            this.view.CustomImages.Parent = this.view;
            this.view.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.view.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.HoverState.Parent = this.view;
            this.view.Location = new System.Drawing.Point(762, 370);
            this.view.Name = "view";
            this.view.ShadowDecoration.Parent = this.view;
            this.view.Size = new System.Drawing.Size(139, 57);
            this.view.TabIndex = 38;
            this.view.Text = "View";
            this.view.Click += new System.EventHandler(this.view_Click_1);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.Parent = this.SearchTextBox;
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.FocusedState.Parent = this.SearchTextBox;
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.HoverState.Parent = this.SearchTextBox;
            this.SearchTextBox.Location = new System.Drawing.Point(937, 370);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Search";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(172, 57);
            this.SearchTextBox.TabIndex = 39;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // ReceDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ReceDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceDGV.BackgroundColor = System.Drawing.Color.White;
            this.ReceDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReceDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReceDGV.EnableHeadersVisualStyles = false;
            this.ReceDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReceDGV.Location = new System.Drawing.Point(252, 475);
            this.ReceDGV.Name = "ReceDGV";
            this.ReceDGV.RowHeadersVisible = false;
            this.ReceDGV.RowHeadersWidth = 62;
            this.ReceDGV.RowTemplate.Height = 28;
            this.ReceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceDGV.Size = new System.Drawing.Size(885, 275);
            this.ReceDGV.TabIndex = 40;
            this.ReceDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ReceDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReceDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReceDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReceDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReceDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReceDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReceDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReceDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReceDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReceDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReceDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReceDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReceDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ReceDGV.ThemeStyle.ReadOnly = false;
            this.ReceDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReceDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReceDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReceDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReceDGV.ThemeStyle.RowsStyle.Height = 28;
            this.ReceDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReceDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceDGV_CellContentClick_1);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Final.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox2.Location = new System.Drawing.Point(619, 22);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(91, 97);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 9;
            this.guna2PictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(937, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 166);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.ReceDGV);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.view);
            this.Controls.Add(this.DeleteR);
            this.Controls.Add(this.AddR);
            this.Controls.Add(this.EditR);
            this.Controls.Add(this.AddressR);
            this.Controls.Add(this.Rphone);
            this.Controls.Add(this.Rpassword);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton Doc;
        private Guna.UI2.WinForms.Guna2GradientButton Patients;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton rece;
        private Guna.UI2.WinForms.Guna2Button EditR;
        private Guna.UI2.WinForms.Guna2TextBox AddressR;
        private Guna.UI2.WinForms.Guna2TextBox Rphone;
        private Guna.UI2.WinForms.Guna2TextBox Rpassword;
        private Guna.UI2.WinForms.Guna2TextBox RName;
        private Guna.UI2.WinForms.Guna2Button view;
        private Guna.UI2.WinForms.Guna2Button DeleteR;
        private Guna.UI2.WinForms.Guna2Button AddR;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView ReceDGV;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

