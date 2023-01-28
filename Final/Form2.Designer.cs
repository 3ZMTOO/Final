namespace Final
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dfd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_hide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_show = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Add_Docor = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_Doctor = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_Doctor = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Doc_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Doc_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.Doc_DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Doctor_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.Doc_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DOB_doctor = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Doctor_exp = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.guna2Panel1.Controls.Add(this.dfd);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton2);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(229, 653);
            this.guna2Panel1.TabIndex = 8;
            // 
            // dfd
            // 
            this.dfd.CheckedState.Parent = this.dfd;
            this.dfd.CustomImages.Image = global::Final.Properties.Resources.icons8_occupied_bed_100;
            this.dfd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dfd.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.dfd.CustomImages.Parent = this.dfd;
            this.guna2Transition1.SetDecoration(this.dfd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dfd.FillColor = System.Drawing.Color.Empty;
            this.dfd.FillColor2 = System.Drawing.Color.Empty;
            this.dfd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfd.ForeColor = System.Drawing.Color.White;
            this.dfd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.dfd.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.dfd.HoverState.Parent = this.dfd;
            this.dfd.Location = new System.Drawing.Point(10, 167);
            this.dfd.Name = "dfd";
            this.dfd.ShadowDecoration.Parent = this.dfd;
            this.dfd.Size = new System.Drawing.Size(223, 40);
            this.dfd.TabIndex = 0;
            this.dfd.Text = "Patients";
            this.dfd.TextOffset = new System.Drawing.Point(5, 0);
            this.dfd.Click += new System.EventHandler(this.dfd_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(21, 335);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 7;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::Final.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(55, 71);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2Transition1.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2GradientButton2.Location = new System.Drawing.Point(10, 381);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(223, 41);
            this.guna2GradientButton2.TabIndex = 6;
            this.guna2GradientButton2.Text = "Logout";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2Transition1.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2GradientButton1.Location = new System.Drawing.Point(6, 257);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(227, 42);
            this.guna2GradientButton1.TabIndex = 5;
            this.guna2GradientButton1.Text = "Receptionists";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Animated = true;
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.CheckedState.Parent = this.btn_hide;
            this.btn_hide.CustomImages.Parent = this.btn_hide;
            this.guna2Transition1.SetDecoration(this.btn_hide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_hide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.btn_hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hide.ForeColor = System.Drawing.Color.Transparent;
            this.btn_hide.HoverState.Parent = this.btn_hide;
            this.btn_hide.Image = global::Final.Properties.Resources.icons8_chevron_left_24__1_;
            this.btn_hide.ImageOffset = new System.Drawing.Point(0, 15);
            this.btn_hide.Location = new System.Drawing.Point(218, 315);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_hide.ShadowDecoration.Parent = this.btn_hide;
            this.btn_hide.Size = new System.Drawing.Size(37, 45);
            this.btn_hide.TabIndex = 28;
            this.btn_hide.Text = "guna2CircleButton2";
            this.btn_hide.UseTransparentBackground = true;
            this.btn_hide.Click += new System.EventHandler(this.guna2CircleButton2_Click_1);
            // 
            // btn_show
            // 
            this.btn_show.Animated = true;
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.CheckedState.Parent = this.btn_show;
            this.btn_show.CustomImages.Parent = this.btn_show;
            this.guna2Transition1.SetDecoration(this.btn_show, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_show.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_show.ForeColor = System.Drawing.Color.Transparent;
            this.btn_show.HoverState.Parent = this.btn_show;
            this.btn_show.Image = global::Final.Properties.Resources.icons8_chevron_left_96;
            this.btn_show.ImageOffset = new System.Drawing.Point(0, 15);
            this.btn_show.Location = new System.Drawing.Point(50, 315);
            this.btn_show.Name = "btn_show";
            this.btn_show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_show.ShadowDecoration.Parent = this.btn_show;
            this.btn_show.Size = new System.Drawing.Size(41, 45);
            this.btn_show.TabIndex = 27;
            this.btn_show.Text = "guna2CircleButton1";
            this.btn_show.Tile = false;
            this.btn_show.UseTransparentBackground = true;
            this.btn_show.Visible = false;
            this.btn_show.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox2.Image = global::Final.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox2.Location = new System.Drawing.Point(462, 21);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(200, 95);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            // 
            // Add_Docor
            // 
            this.Add_Docor.BorderRadius = 9;
            this.Add_Docor.CheckedState.Parent = this.Add_Docor;
            this.Add_Docor.CustomImages.Parent = this.Add_Docor;
            this.guna2Transition1.SetDecoration(this.Add_Docor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Add_Docor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.Add_Docor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Docor.ForeColor = System.Drawing.Color.White;
            this.Add_Docor.HoverState.Parent = this.Add_Docor;
            this.Add_Docor.Location = new System.Drawing.Point(335, 345);
            this.Add_Docor.Name = "Add_Docor";
            this.Add_Docor.ShadowDecoration.Parent = this.Add_Docor;
            this.Add_Docor.Size = new System.Drawing.Size(101, 44);
            this.Add_Docor.TabIndex = 29;
            this.Add_Docor.Text = "Add";
            this.Add_Docor.Click += new System.EventHandler(this.Add_Docor_Click_1);
            // 
            // Edit_Doctor
            // 
            this.Edit_Doctor.BorderRadius = 9;
            this.Edit_Doctor.CheckedState.Parent = this.Edit_Doctor;
            this.Edit_Doctor.CustomImages.Parent = this.Edit_Doctor;
            this.guna2Transition1.SetDecoration(this.Edit_Doctor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Edit_Doctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.Edit_Doctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Doctor.ForeColor = System.Drawing.Color.White;
            this.Edit_Doctor.HoverState.Parent = this.Edit_Doctor;
            this.Edit_Doctor.Location = new System.Drawing.Point(731, 345);
            this.Edit_Doctor.Name = "Edit_Doctor";
            this.Edit_Doctor.ShadowDecoration.Parent = this.Edit_Doctor;
            this.Edit_Doctor.Size = new System.Drawing.Size(102, 44);
            this.Edit_Doctor.TabIndex = 30;
            this.Edit_Doctor.Text = "Edit";
            this.Edit_Doctor.Click += new System.EventHandler(this.Edit_Doctor_Click_1);
            // 
            // Delete_Doctor
            // 
            this.Delete_Doctor.BorderRadius = 9;
            this.Delete_Doctor.CheckedState.Parent = this.Delete_Doctor;
            this.Delete_Doctor.CustomImages.Parent = this.Delete_Doctor;
            this.guna2Transition1.SetDecoration(this.Delete_Doctor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Delete_Doctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.Delete_Doctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Doctor.ForeColor = System.Drawing.Color.White;
            this.Delete_Doctor.HoverState.Parent = this.Delete_Doctor;
            this.Delete_Doctor.Location = new System.Drawing.Point(462, 345);
            this.Delete_Doctor.Name = "Delete_Doctor";
            this.Delete_Doctor.ShadowDecoration.Parent = this.Delete_Doctor;
            this.Delete_Doctor.Size = new System.Drawing.Size(97, 44);
            this.Delete_Doctor.TabIndex = 31;
            this.Delete_Doctor.Text = "Delete";
            this.Delete_Doctor.Click += new System.EventHandler(this.Delete_Doctor_Click_1);
            // 
            // button1
            // 
            this.button1.BorderRadius = 9;
            this.button1.CheckedState.Parent = this.button1;
            this.button1.CustomImages.Parent = this.button1;
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.Parent = this.button1;
            this.button1.Location = new System.Drawing.Point(595, 345);
            this.button1.Name = "button1";
            this.button1.ShadowDecoration.Parent = this.button1;
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "View";
            this.button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Doc_name
            // 
            this.Doc_name.BorderRadius = 5;
            this.Doc_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.Doc_name, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Doc_name.DefaultText = "";
            this.Doc_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Doc_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Doc_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doc_name.DisabledState.Parent = this.Doc_name;
            this.Doc_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doc_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doc_name.FocusedState.Parent = this.Doc_name;
            this.Doc_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doc_name.HoverState.Parent = this.Doc_name;
            this.Doc_name.Location = new System.Drawing.Point(280, 155);
            this.Doc_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Doc_name.Name = "Doc_name";
            this.Doc_name.PasswordChar = '\0';
            this.Doc_name.PlaceholderText = "Name";
            this.Doc_name.SelectedText = "";
            this.Doc_name.ShadowDecoration.Parent = this.Doc_name;
            this.Doc_name.Size = new System.Drawing.Size(242, 35);
            this.Doc_name.TabIndex = 34;
            // 
            // Doc_Pass
            // 
            this.Doc_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.Doc_Pass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Doc_Pass.DefaultText = "";
            this.Doc_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Doc_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Doc_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doc_Pass.DisabledState.Parent = this.Doc_Pass;
            this.Doc_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doc_Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doc_Pass.FocusedState.Parent = this.Doc_Pass;
            this.Doc_Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doc_Pass.HoverState.Parent = this.Doc_Pass;
            this.Doc_Pass.Location = new System.Drawing.Point(579, 155);
            this.Doc_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Doc_Pass.Name = "Doc_Pass";
            this.Doc_Pass.PasswordChar = '\0';
            this.Doc_Pass.PlaceholderText = "Password";
            this.Doc_Pass.SelectedText = "";
            this.Doc_Pass.ShadowDecoration.Parent = this.Doc_Pass;
            this.Doc_Pass.Size = new System.Drawing.Size(254, 35);
            this.Doc_Pass.TabIndex = 35;
            // 
            // Doc_DGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Doc_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Doc_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Doc_DGV.BackgroundColor = System.Drawing.Color.White;
            this.Doc_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Doc_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Doc_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Doc_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Doc_DGV.ColumnHeadersHeight = 15;
            this.guna2Transition1.SetDecoration(this.Doc_DGV, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Doc_DGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.Doc_DGV.EnableHeadersVisualStyles = false;
            this.Doc_DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.Doc_DGV.Location = new System.Drawing.Point(235, 414);
            this.Doc_DGV.Name = "Doc_DGV";
            this.Doc_DGV.RowHeadersVisible = false;
            this.Doc_DGV.RowHeadersWidth = 62;
            this.Doc_DGV.RowTemplate.Height = 28;
            this.Doc_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Doc_DGV.Size = new System.Drawing.Size(681, 236);
            this.Doc_DGV.TabIndex = 33;
            this.Doc_DGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Doc_DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Doc_DGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Doc_DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Doc_DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Doc_DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Doc_DGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Doc_DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.Doc_DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Doc_DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Doc_DGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc_DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Doc_DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Doc_DGV.ThemeStyle.HeaderStyle.Height = 15;
            this.Doc_DGV.ThemeStyle.ReadOnly = false;
            this.Doc_DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Doc_DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Doc_DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc_DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Doc_DGV.ThemeStyle.RowsStyle.Height = 28;
            this.Doc_DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Doc_DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Doc_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doc_DGV_CellContentClick);
            // 
            // Doctor_phone
            // 
            this.Doctor_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.Doctor_phone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Doctor_phone.DefaultText = "";
            this.Doctor_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Doctor_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Doctor_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doctor_phone.DisabledState.Parent = this.Doctor_phone;
            this.Doctor_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doctor_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doctor_phone.FocusedState.Parent = this.Doctor_phone;
            this.Doctor_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doctor_phone.HoverState.Parent = this.Doctor_phone;
            this.Doctor_phone.Location = new System.Drawing.Point(280, 213);
            this.Doctor_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Doctor_phone.Name = "Doctor_phone";
            this.Doctor_phone.PasswordChar = '\0';
            this.Doctor_phone.PlaceholderText = "Phone";
            this.Doctor_phone.SelectedText = "";
            this.Doctor_phone.ShadowDecoration.Parent = this.Doctor_phone;
            this.Doctor_phone.Size = new System.Drawing.Size(242, 37);
            this.Doctor_phone.TabIndex = 36;
            // 
            // Doc_Gender
            // 
            this.Doc_Gender.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Doc_Gender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Doc_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Doc_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Doc_Gender.FocusedColor = System.Drawing.Color.Empty;
            this.Doc_Gender.FocusedState.Parent = this.Doc_Gender;
            this.Doc_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Doc_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Doc_Gender.FormattingEnabled = true;
            this.Doc_Gender.HoverState.Parent = this.Doc_Gender;
            this.Doc_Gender.ItemHeight = 30;
            this.Doc_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Doc_Gender.ItemsAppearance.Parent = this.Doc_Gender;
            this.Doc_Gender.Location = new System.Drawing.Point(579, 271);
            this.Doc_Gender.Name = "Doc_Gender";
            this.Doc_Gender.ShadowDecoration.Parent = this.Doc_Gender;
            this.Doc_Gender.Size = new System.Drawing.Size(116, 36);
            this.Doc_Gender.TabIndex = 37;
            // 
            // DOB_doctor
            // 
            this.DOB_doctor.CheckedState.Parent = this.DOB_doctor;
            this.guna2Transition1.SetDecoration(this.DOB_doctor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DOB_doctor.FillColor = System.Drawing.Color.White;
            this.DOB_doctor.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOB_doctor.HoverState.Parent = this.DOB_doctor;
            this.DOB_doctor.Location = new System.Drawing.Point(279, 271);
            this.DOB_doctor.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOB_doctor.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOB_doctor.Name = "DOB_doctor";
            this.DOB_doctor.ShadowDecoration.Parent = this.DOB_doctor;
            this.DOB_doctor.Size = new System.Drawing.Size(243, 36);
            this.DOB_doctor.TabIndex = 38;
            this.DOB_doctor.Value = new System.DateTime(2023, 1, 8, 16, 4, 11, 558);
            // 
            // Doctor_exp
            // 
            this.Doctor_exp.BorderRadius = 5;
            this.Doctor_exp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.Doctor_exp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Doctor_exp.DefaultText = "";
            this.Doctor_exp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Doctor_exp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Doctor_exp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doctor_exp.DisabledState.Parent = this.Doctor_exp;
            this.Doctor_exp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Doctor_exp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doctor_exp.FocusedState.Parent = this.Doctor_exp;
            this.Doctor_exp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Doctor_exp.HoverState.Parent = this.Doctor_exp;
            this.Doctor_exp.Location = new System.Drawing.Point(579, 213);
            this.Doctor_exp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Doctor_exp.Name = "Doctor_exp";
            this.Doctor_exp.PasswordChar = '\0';
            this.Doctor_exp.PlaceholderText = "Experience";
            this.Doctor_exp.SelectedText = "";
            this.Doctor_exp.ShadowDecoration.Parent = this.Doctor_exp;
            this.Doctor_exp.Size = new System.Drawing.Size(254, 37);
            this.Doctor_exp.TabIndex = 39;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(916, 652);
            this.Controls.Add(this.Doctor_exp);
            this.Controls.Add(this.DOB_doctor);
            this.Controls.Add(this.Doc_Gender);
            this.Controls.Add(this.Doctor_phone);
            this.Controls.Add(this.Doc_Pass);
            this.Controls.Add(this.Doc_name);
            this.Controls.Add(this.Doc_DGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete_Doctor);
            this.Controls.Add(this.Edit_Doctor);
            this.Controls.Add(this.Add_Docor);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doc_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton dfd;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_show;
        private Guna.UI2.WinForms.Guna2CircleButton btn_hide;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button Add_Docor;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button Delete_Doctor;
        private Guna.UI2.WinForms.Guna2Button Edit_Doctor;
        private Guna.UI2.WinForms.Guna2TextBox Doctor_exp;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOB_doctor;
        private Guna.UI2.WinForms.Guna2ComboBox Doc_Gender;
        private Guna.UI2.WinForms.Guna2TextBox Doctor_phone;
        private Guna.UI2.WinForms.Guna2TextBox Doc_Pass;
        private Guna.UI2.WinForms.Guna2TextBox Doc_name;
        private Guna.UI2.WinForms.Guna2DataGridView Doc_DGV;
    }
}