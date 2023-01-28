using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            rolecb.SelectedIndex= 0;
            username.Text= string.Empty;
            pass.Text= string.Empty;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
    
            
        }
        public static string role;
     

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (rolecb.SelectedIndex == -1)
                {
                    MessageBox.Show("select your position");
                }
                else if (rolecb.SelectedIndex == 0)
                {
                    if (username.Text == "" && pass.Text == "")
                    {
                        MessageBox.Show("enter both admin and password");
                    }

                    else if (username.Text == "admin" && pass.Text == "password")
                    {
                        role = "Admin";
                        Patient obj = new Patient();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("wrond admin and pass");
                    }
                }
                else if (rolecb.SelectedIndex == 1)
                {
                    if (username.Text == "" && pass.Text == "")
                    {
                        MessageBox.Show("enter both doctor name and password");
                    }

                    else
                    {
                        sqlcon.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Doctor where Doc_Name = '" + username.Text + "' and Doc_pass = '" + pass.Text + "'", sqlcon);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            role = "Doctor";
                            Prescreption obj = new Prescreption();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("doctor not found");
                        }
                        sqlcon.Close();
                    }
                }
                else
                {
                    if (username.Text == "" && pass.Text == "")
                    {
                        MessageBox.Show("enter both receptionist name and password");
                    }

                    else
                    {
                        sqlcon.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Rece where Rece_Name = '" + username.Text + "' and Rece_Password = '" + pass.Text + "'", sqlcon);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            role = "Receptionist";
                            Form4 obj = new Form4();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Rece not found");
                        }
                        sqlcon.Close();
                    }
                }
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rolecb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
