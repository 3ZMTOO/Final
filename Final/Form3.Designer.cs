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
            this.rolecb = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rolecb
            // 
            this.rolecb.FormattingEnabled = true;
            this.rolecb.Items.AddRange(new object[] {
            "admin",
            "doctor",
            "secretary"});
            this.rolecb.Location = new System.Drawing.Point(135, 82);
            this.rolecb.Name = "rolecb";
            this.rolecb.Size = new System.Drawing.Size(263, 28);
            this.rolecb.TabIndex = 0;
            this.rolecb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(135, 194);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(263, 26);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(135, 297);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(263, 26);
            this.pass.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(207, 359);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(94, 47);
            this.login.TabIndex = 3;
            this.login.Text = "button1";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Location = new System.Drawing.Point(224, 428);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(51, 20);
            this.reset.TabIndex = 4;
            this.reset.Text = "label1";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 701);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.rolecb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rolecb;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label reset;
    }
}