namespace Final
{
    partial class Form3
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
            this.reset = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.login = new Guna.UI2.WinForms.Guna2Button();
            this.rolecb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(246, 694);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(58, 25);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.guna2ControlBox2);
            this.panel2.Controls.Add(this.guna2ControlBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.guna2ToggleSwitch2);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.rolecb);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Controls.Add(this.reset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 787);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // login
            // 
            this.login.Animated = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BorderRadius = 10;
            this.login.CheckedState.Parent = this.login;
            this.login.CustomImages.Parent = this.login;
            this.login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.HoverState.Parent = this.login;
            this.login.Location = new System.Drawing.Point(104, 571);
            this.login.Name = "login";
            this.login.ShadowDecoration.Parent = this.login;
            this.login.Size = new System.Drawing.Size(170, 81);
            this.login.TabIndex = 9;
            this.login.Text = "Login";
            this.login.UseTransparentBackground = true;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // rolecb
            // 
            this.rolecb.Animated = true;
            this.rolecb.BackColor = System.Drawing.Color.Transparent;
            this.rolecb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.rolecb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rolecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolecb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.rolecb.FocusedColor = System.Drawing.Color.Empty;
            this.rolecb.FocusedState.Parent = this.rolecb;
            this.rolecb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rolecb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.rolecb.FormattingEnabled = true;
            this.rolecb.HoverState.Parent = this.rolecb;
            this.rolecb.ItemHeight = 30;
            this.rolecb.Items.AddRange(new object[] {
            "Admin\t",
            "Doctor",
            "Receptionist"});
            this.rolecb.ItemsAppearance.Parent = this.rolecb;
            this.rolecb.Location = new System.Drawing.Point(140, 412);
            this.rolecb.Name = "rolecb";
            this.rolecb.ShadowDecoration.Parent = this.rolecb;
            this.rolecb.Size = new System.Drawing.Size(277, 36);
            this.rolecb.TabIndex = 8;
            this.rolecb.SelectedIndexChanged += new System.EventHandler(this.rolecb_SelectedIndexChanged);
            // 
            // pass
            // 
            this.pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.pass.BorderRadius = 6;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.Parent = this.pass;
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.FocusedState.Parent = this.pass;
            this.pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.HoverState.Parent = this.pass;
            this.pass.Location = new System.Drawing.Point(140, 315);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.PlaceholderText = "Password";
            this.pass.SelectedText = "";
            this.pass.ShadowDecoration.Parent = this.pass;
            this.pass.Size = new System.Drawing.Size(277, 67);
            this.pass.TabIndex = 7;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // username
            // 
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.username.BorderRadius = 6;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(140, 225);
            this.username.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "User Name";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(277, 69);
            this.username.TabIndex = 6;
            this.username.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Final.Properties.Resources.Logo_Project_AM;
            this.guna2PictureBox2.Location = new System.Drawing.Point(175, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(207, 190);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(304, 571);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(177, 81);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Sign Up";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.Animated = true;
            this.guna2ToggleSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(1)))), ((int)(((byte)(88)))));
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(140, 488);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.ShadowDecoration.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(49, 32);
            this.guna2ToggleSwitch2.TabIndex = 11;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.guna2ToggleSwitch2.UncheckedState.BorderThickness = 2;
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(62)))));
            this.guna2ToggleSwitch2.UncheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.UseTransparentBackground = true;
            this.guna2ToggleSwitch2.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Remember Me ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(490, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 29);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(436, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(38, 29);
            this.guna2ControlBox2.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 787);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label reset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2ComboBox rolecb;
        private Guna.UI2.WinForms.Guna2TextBox pass;
        private Guna.UI2.WinForms.Guna2Button login;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}