using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayRec()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Rece";
                SqlDataAdapter sda = new SqlDataAdapter(Query, sqlcon);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ReceDGV.DataSource = ds.Tables[0];
                clear();
            }
        }

      
        private void AddressR_TextChanged(object sender, EventArgs e)
        {

        }
        int key = 0;


    
 
        private void clear()
        {
            RName.Text = "";
            Rpassword.Text = "";
            Rphone.Text = "";
            AddressR.Text = "";
            key= 0;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clear();
            Application.Exit();
        }

        private void view_Click(object sender, EventArgs e)
        {
            DisplayRec();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();

            // Refresh the DataGridView to display all rows in the Rece table
            DisplayRec();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void Patients_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void rece_Click(object sender, EventArgs e)
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

        private void Patients_Click_1(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void rece_Click_1(object sender, EventArgs e)
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

        private void Doc_Click_1(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            string searchTerm = SearchTextBox.Text;

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Rece WHERE Rece_Name LIKE @searchTerm OR Rece_phone LIKE @searchTerm OR Rece_address LIKE @searchTerm OR Rece_Password LIKE @searchTerm";
                SqlCommand cmd = new SqlCommand(Query, sqlcon);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ReceDGV.DataSource = ds.Tables[0];
            }
        }

        private void view_Click_1(object sender, EventArgs e)
        {
            DisplayRec();
        }

        private void ReceDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked cell index is valid and the ReceDGV control has at least one row
            if (ReceDGV.Rows.Count == 0 || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            // Get the DataGridViewRow object for the clicked cell
            DataGridViewRow row = ReceDGV.Rows[e.RowIndex];

            // Set the Text property of the textboxes to the values of the cells in the clicked row
            string name = row.Cells[1].Value.ToString();
            string phone = row.Cells[2].Value.ToString();
            string address = row.Cells[3].Value.ToString();
            string password = row.Cells[4].Value.ToString();

            RName.Text = name;
            Rphone.Text = phone;
            AddressR.Text = address;
            Rpassword.Text = password;



            // Set the key variable to the value of the first cell in the clicked row
            key = Convert.ToInt32(row.Cells[0].Value);


        }

        private void DeleteR_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (key == 0)
                {
                    MessageBox.Show("Select The Customer");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Rece where Rece_ID=@Rkey ", sqlcon);
                        cmd.Parameters.AddWithValue("@Rkey", key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Receptionist Deleted");


                        DisplayRec();
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
                if (RName.Text == "" || Rpassword.Text == "" || Rphone.Text == "" || AddressR.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("update Rece set Rece_Name= @RN,Rece_phone=@RP,Rece_address=@RA,Rece_Password=@RPA where Rece_ID=@Rkey", sqlcon);
                        cmd.Parameters.AddWithValue("@RN", RName.Text);
                        cmd.Parameters.AddWithValue("@RP", Rphone.Text);
                        cmd.Parameters.AddWithValue("@RA", AddressR.Text);
                        cmd.Parameters.AddWithValue("@RPA", Rpassword.Text);
                        cmd.Parameters.AddWithValue("@Rkey", key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Receptionist Edited");
                        DisplayRec();
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

        private void AddR_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (RName.Text == "" || Rpassword.Text == "" || Rphone.Text == "" || AddressR.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();

                        SqlCommand cmd = new SqlCommand("insert into Rece (Rece_Name,Rece_phone,Rece_address,Rece_Password)values(@RN,@RP,@RA,@RPA)", sqlcon);
                        cmd.Parameters.AddWithValue("@RN", RName.Text);
                        cmd.Parameters.AddWithValue("@RP", Rphone.Text);
                        cmd.Parameters.AddWithValue("@RA", AddressR.Text);
                        cmd.Parameters.AddWithValue("@RPA", Rpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Receptionist added");
                        DisplayRec();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
