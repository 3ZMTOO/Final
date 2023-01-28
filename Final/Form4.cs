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
    public partial class Form4 : Form
    {
        public Form4()
        {
            
            InitializeComponent();
            if(Form3.role=="Receptionist")
            {
                rece.Enabled= false;
                Doc.Enabled= false;

            }
            count_doctors();
            count_patient();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patients_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void rece_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void count_patient()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from Patient", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                countpat.Text= dt.Rows[0][0].ToString();
                sqlcon.Close();
                
            }
        }
        
        private void count_doctors()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from Patient", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                countdoc.Text = dt.Rows[0][0].ToString();
                sqlcon.Close();

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();

        }

        private void dfd_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void countpat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
