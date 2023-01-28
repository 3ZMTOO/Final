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
using System.Windows.Input;
using System.IO;
using Microsoft.Graph;

namespace Final
{
    public partial class Patient : Form
    {


        private void DisplayPatient()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Patient ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, sqlcon);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DGV_Patient.DataSource = ds.Tables[0];

            }
        }
        public Patient()
        {
            InitializeComponent();
            DisplayPatient();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
        private void clear()
        {
            PName.Text = "";
            Pphone.Text = "";
            PNational.Text = "";
            PAllergie.Text = "";
            PGender.SelectedIndex = 0;
            PBmi.Text = string.Empty;
            Pmedication.Text = string.Empty;
            PHistory.Text = string.Empty;
            Paddress.Text = string.Empty;
            PPressure.Text= string.Empty;
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
  
        }

        private void Psearch_TextChanged(object sender, EventArgs e)
        {
             string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            string searchTerm = Psearch.Text;

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Patient WHERE patName LIKE @searchTerm OR  patPhone LIKE @searchTerm OR patNational_Id LIKE @searchTerm ";
                SqlCommand cmd = new SqlCommand(Query, sqlcon);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DGV_Patient.DataSource = ds.Tables[0];
            }
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form4 obj =new Form4();
            obj.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void Rece_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void Patients_Click(object sender, EventArgs e)
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

        private void Doc_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            string searchTerm = Psearch.Text;

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Patient WHERE patName LIKE @searchTerm OR  patPhone LIKE @searchTerm OR patNational_Id LIKE @searchTerm ";
                SqlCommand cmd = new SqlCommand(Query, sqlcon);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DGV_Patient.DataSource = ds.Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void PHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddR_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (PName.Text == "" || Pphone.Text == "" || Pmedication.Text == "" || PAllergie.Text == "" || PGender.SelectedIndex == -1 || PNational.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();

                        SqlCommand cmd = new SqlCommand("insert into Patient (patName,patGen,patDOB,patPhone,patNational_Id,PatAll,Patient_pressure,BMI,current_medication,Medical_history,PAddress)values(@PN,@PG,@PDO,@PP,@PNA,@PAL,@PPR,@PB,@PC,@PM,@PAD)", sqlcon);
                        cmd.Parameters.AddWithValue("@PN", PName.Text);
                        cmd.Parameters.AddWithValue("@PG", PGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PDO", PDob.Value.Date);
                        cmd.Parameters.AddWithValue("@PP", Pphone.Text);
                        cmd.Parameters.AddWithValue("@PNA", PNational.Text);
                        cmd.Parameters.AddWithValue("@PAL", PAllergie.Text);
                        cmd.Parameters.AddWithValue("@PPR", PPressure.Text);
                        cmd.Parameters.AddWithValue("@PB", PBmi.Text);
                        cmd.Parameters.AddWithValue("@PC", Pmedication.Text);
                        cmd.Parameters.AddWithValue("@PM", PHistory.Text);
                        cmd.Parameters.AddWithValue("@PAD", Paddress.Text);






                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient added");
                        DisplayPatient();
                        clear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlcon.Close();
                        clear();
                    }
                }


            }
        }

        private void EditR_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (PName.Text == "" || Pphone.Text == "" || Pmedication.Text == "" || PAllergie.Text == "" || PGender.SelectedIndex == -1 || PNational.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("update Patient set patName=@PN,patGen=@PG,patDOB=@PDO,patPhone=@PP,patNational_Id=@PNA,PatAll=@PAL,Patient_pressure=@PPR,BMI=@PB,current_medication=@PC,Medical_history=@PM,PAddress=@PAD where patid=@Pkey", sqlcon);
                        cmd.Parameters.AddWithValue("@PN", PName.Text);
                        cmd.Parameters.AddWithValue("@PG", PGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PDO", PDob.Value.Date);
                        cmd.Parameters.AddWithValue("@PP", Pphone.Text);
                        cmd.Parameters.AddWithValue("@PNA", PNational.Text);
                        cmd.Parameters.AddWithValue("@PAL", PAllergie.Text);
                        cmd.Parameters.AddWithValue("@PPR", PPressure.Text);
                        cmd.Parameters.AddWithValue("@PB", PBmi.Text);
                        cmd.Parameters.AddWithValue("@PC", Pmedication.Text);
                        cmd.Parameters.AddWithValue("@PM", PHistory.Text);
                        cmd.Parameters.AddWithValue("@PAD", Paddress.Text);

                        cmd.Parameters.AddWithValue("@Pkey", key);



                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Edited");
                        DisplayPatient();
                        clear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlcon.Close();
                        clear();

                    }
                }
            }
        }

        private void Delete_Doctor_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (key == 0)
                {
                    MessageBox.Show("Select The Patient");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Patient where patid=@Pkey ", sqlcon);
                        cmd.Parameters.AddWithValue("@Pkey", key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Deleted");


                        DisplayPatient();
                        clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlcon.Close();
                        clear();
                    }
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void Doc_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked cell index is valid and the ReceDGV control has at least one row
            if (DGV_Patient.Rows.Count == 0 || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            // Get the DataGridViewRow object for the clicked cell
            DataGridViewRow row = DGV_Patient.Rows[e.RowIndex];

            // Set the Text property of the textboxes to the values of the cells in the clicked row
            string name = row.Cells[1].Value.ToString();
            string gender = row.Cells[2].Value.ToString();
            string DOB = row.Cells[3].Value.ToString();
            string phone = row.Cells[4].Value.ToString();
            string National = row.Cells[5].Value.ToString();
            string patall = row.Cells[6].Value.ToString();
            string patpress = row.Cells[7].Value.ToString();
            string BMI = row.Cells[8].Value.ToString();
            string current = row.Cells[9].Value.ToString();
            string Medical = row.Cells[10].Value.ToString();
            string Address = row.Cells[11].Value.ToString();









            PName.Text = name;
            PDob.Text = DOB;
            Pphone.Text = phone;
            PGender.SelectedItem = gender;
            PNational.Text = National;
            PAllergie.Text = patall;
            PPressure.Text = patpress;
            PBmi.Text = BMI;
            Pmedication.Text = current;
            PHistory.Text = Medical;
            Paddress.Text = Address;





            // Set the key variable to the value of the first cell in the clicked row
            key = Convert.ToInt32(row.Cells[0].Value);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            ofd.Title = "Select Patient Photo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                byte[] photo = new byte[fs.Length];
                fs.Read(photo, 0, photo.Length);
                fs.Close();
            }
        }
    }
}
