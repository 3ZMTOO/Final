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
            ((System.ComponentModel.ISupportInitialize)(this.ReceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(45, 58);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(155, 26);
            this.RName.TabIndex = 0;
            // 
            // Rpassword
            // 
            this.Rpassword.Location = new System.Drawing.Point(232, 58);
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.Size = new System.Drawing.Size(195, 26);
            this.Rpassword.TabIndex = 1;
            // 
            // Rphone
            // 
            this.Rphone.Location = new System.Drawing.Point(45, 115);
            this.Rphone.Name = "Rphone";
            this.Rphone.Size = new System.Drawing.Size(155, 26);
            this.Rphone.TabIndex = 2;
            // 
            // AddressR
            // 
            this.AddressR.Location = new System.Drawing.Point(527, 68);
            this.AddressR.Name = "AddressR";
            this.AddressR.Size = new System.Drawing.Size(195, 169);
            this.AddressR.TabIndex = 3;
            this.AddressR.Text = "";
            this.AddressR.TextChanged += new System.EventHandler(this.AddressR_TextChanged);
            // 
            // AddR
            // 
            this.AddR.Location = new System.Drawing.Point(153, 188);
            this.AddR.Name = "AddR";
            this.AddR.Size = new System.Drawing.Size(107, 39);
            this.AddR.TabIndex = 4;
            this.AddR.Text = "add";
            this.AddR.UseVisualStyleBackColor = true;
            this.AddR.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteR
            // 
            this.DeleteR.Location = new System.Drawing.Point(275, 188);
            this.DeleteR.Name = "DeleteR";
            this.DeleteR.Size = new System.Drawing.Size(113, 39);
            this.DeleteR.TabIndex = 5;
            this.DeleteR.Text = "delete";
            this.DeleteR.UseVisualStyleBackColor = true;
            this.DeleteR.Click += new System.EventHandler(this.DeleteR_Click);
            // 
            // EditR
            // 
            this.EditR.Location = new System.Drawing.Point(27, 189);
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
            this.ReceDGV.Location = new System.Drawing.Point(64, 260);
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
            this.pictureBox1.Location = new System.Drawing.Point(1107, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(408, 188);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(94, 39);
            this.view.TabIndex = 9;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(753, 68);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(217, 26);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ClearSearchButton_Click
            // 
            this.ClearSearchButton_Click.Location = new System.Drawing.Point(991, 63);
            this.ClearSearchButton_Click.Name = "ClearSearchButton_Click";
            this.ClearSearchButton_Click.Size = new System.Drawing.Size(75, 36);
            this.ClearSearchButton_Click.TabIndex = 12;
            this.ClearSearchButton_Click.Text = "button2";
            this.ClearSearchButton_Click.UseVisualStyleBackColor = true;
            this.ClearSearchButton_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 562);
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
    }
}

