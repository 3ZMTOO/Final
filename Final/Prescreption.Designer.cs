namespace Final
{
    partial class Prescreption
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
            this.DName = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Medicine = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Mlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGV_Pre = new System.Windows.Forms.DataGridView();
            this.Diagnosis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Doc_ID = new System.Windows.Forms.ComboBox();
            this.Pat_ID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pre)).BeginInit();
            this.SuspendLayout();
            // 
            // DName
            // 
            this.DName.Location = new System.Drawing.Point(336, 50);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(154, 26);
            this.DName.TabIndex = 0;
            this.DName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(336, 118);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(154, 26);
            this.PName.TabIndex = 1;
            // 
            // Mname
            // 
            this.Mname.Location = new System.Drawing.Point(334, 203);
            this.Mname.Multiline = true;
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(156, 100);
            this.Mname.TabIndex = 2;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(334, 336);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(154, 26);
            this.Cost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doctor Name";
            this.label1.Click += new System.EventHandler(this.Doc_Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient Name";
            // 
            // Medicine
            // 
            this.Medicine.AutoSize = true;
            this.Medicine.Location = new System.Drawing.Point(30, 230);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(0, 20);
            this.Medicine.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(34, 397);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 34);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Mlabel
            // 
            this.Mlabel.AutoSize = true;
            this.Mlabel.Location = new System.Drawing.Point(217, 244);
            this.Mlabel.Name = "Mlabel";
            this.Mlabel.Size = new System.Drawing.Size(72, 20);
            this.Mlabel.TabIndex = 11;
            this.Mlabel.Text = "Medicine";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(863, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 321);
            this.textBox1.TabIndex = 12;
            // 
            // DGV_Pre
            // 
            this.DGV_Pre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pre.Location = new System.Drawing.Point(3, 471);
            this.DGV_Pre.Name = "DGV_Pre";
            this.DGV_Pre.RowHeadersWidth = 62;
            this.DGV_Pre.RowTemplate.Height = 28;
            this.DGV_Pre.Size = new System.Drawing.Size(1200, 220);
            this.DGV_Pre.TabIndex = 13;
            this.DGV_Pre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Pre_CellContentClick);
            // 
            // Diagnosis
            // 
            this.Diagnosis.Location = new System.Drawing.Point(634, 56);
            this.Diagnosis.Multiline = true;
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(168, 182);
            this.Diagnosis.TabIndex = 14;
            this.Diagnosis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "diagnosis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Doc_ID
            // 
            this.Doc_ID.FormattingEnabled = true;
            this.Doc_ID.Location = new System.Drawing.Point(34, 53);
            this.Doc_ID.Name = "Doc_ID";
            this.Doc_ID.Size = new System.Drawing.Size(121, 28);
            this.Doc_ID.TabIndex = 16;
            this.Doc_ID.Text = "Doctor_ID";
            this.Doc_ID.SelectionChangeCommitted += new System.EventHandler(this.Doc_ID_SelectionChangeCommitted);
            // 
            // Pat_ID
            // 
            this.Pat_ID.FormattingEnabled = true;
            this.Pat_ID.Location = new System.Drawing.Point(34, 113);
            this.Pat_ID.Name = "Pat_ID";
            this.Pat_ID.Size = new System.Drawing.Size(121, 28);
            this.Pat_ID.TabIndex = 17;
            this.Pat_ID.Text = "Patient_ID";
            this.Pat_ID.SelectionChangeCommitted += new System.EventHandler(this.Pat_ID_SelectionChangeCommitted);
            // 
            // Prescreption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 895);
            this.Controls.Add(this.Pat_ID);
            this.Controls.Add(this.Doc_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.DGV_Pre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mlabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.DName);
            this.Name = "Prescreption";
            this.Text = "Prescreption";
            this.Load += new System.EventHandler(this.Prescreption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Mlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGV_Pre;
        private System.Windows.Forms.TextBox Diagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Doc_ID;
        private System.Windows.Forms.ComboBox Pat_ID;
    }
}