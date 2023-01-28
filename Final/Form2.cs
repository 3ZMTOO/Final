using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Input;
using Guna.UI2.WinForms;

namespace Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked cell index is valid and the ReceDGV control has at least one row
           

        }


        private void Edit_Doctor_Click(object sender, EventArgs e)
        {
  
        }
        


        private void DisplayDoc()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, sqlcon);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Doc_DGV.DataSource = ds.Tables[0];
             
            }
        }


        private void Add_Docor_Click(object sender, EventArgs e)
        {
            
        }

        private void clear()
        {
            Doc_name.Text = "";
            Doc_Pass.Text = "";
            Doctor_phone.Text = "";
            Doctor_exp.Text ="";
            Doc_Pass.Text = "";
            Doc_Gender.SelectedIndex= 0;
        }

        int key = 0;



        private void label3_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
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

        private void label1_Click_2(object sender, EventArgs e)
        {
            Patient obj = new Patient();
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

       

     
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = true;
            guna2Panel1.Width = 233;
            guna2Separator1.Visible = true;

            guna2Transition1.ShowSync(guna2Panel1);
            guna2PictureBox1.Visible = true;

        }

        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
            btn_show.Visible = true;
            btn_hide.Visible = false;
            guna2Panel1.Visible = false;
            guna2Separator1.Visible = false;
            guna2PictureBox1.Visible = true;
            guna2Panel1.Width = 69;
            guna2Transition1.ShowSync(guna2Panel1);
            

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_exp_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DisplayDoc();

        }

        private void Delete_Doctor_Click_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (key == 0)
                {
                    MessageBox.Show("Select The Doctor");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("Delete from Doctor where Doc_Id=@Rkey ", sqlcon);
                        cmd.Parameters.AddWithValue("@Rkey", key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Deleted");


                        DisplayDoc();
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

        private void Edit_Doctor_Click_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (Doc_name.Text == "" || Doc_Pass.Text == "" || Doctor_phone.Text == "" || Doc_Gender.SelectedIndex == -1 || DOB_doctor.Value.Date == null)
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("update Doctor set Doc_Name =@DN,Doc_DOB=@DDO,Doctor_Gen=@DG,Doc_Exp=@DE,Doc_Phone=@DP,Doc_pass=@DPA where Doc_Id=@Dkey", sqlcon);
                        cmd.Parameters.AddWithValue("@DN", Doc_name.Text);
                        cmd.Parameters.AddWithValue("@DDO", DOB_doctor.Value.Date);
                        cmd.Parameters.AddWithValue("@DG", Doc_Gender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DE", Doctor_exp.Text);
                        cmd.Parameters.AddWithValue("@DP", Doctor_phone.Text);
                        cmd.Parameters.AddWithValue("@DPA", Doc_Pass.Text);
                        cmd.Parameters.AddWithValue("@Dkey", key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Edited");
                        DisplayDoc();
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

        private void Add_Docor_Click_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (Doc_name.Text == "" || Doc_Pass.Text == "" || Doctor_phone.Text == "" || Doc_Gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("insert into Doctor (Doc_Name,Doc_DOB,Doctor_Gen,Doc_Exp,Doc_Phone,Doc_pass)values(@DN,@DDO,@DG,@DE,@DP,@DPA)", sqlcon);
                        cmd.Parameters.AddWithValue("@DN", Doc_name.Text);
                        cmd.Parameters.AddWithValue("@DDO", DOB_doctor.Value.Date);
                        cmd.Parameters.AddWithValue("@DG", Doc_Gender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DE", Doctor_exp.Text);
                        cmd.Parameters.AddWithValue("@DP", Doctor_phone.Text);
                        cmd.Parameters.AddWithValue("@DPA", Doc_Pass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor added");
                        DisplayDoc();
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Doc_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Doc_DGV.Rows.Count == 0 || e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            // Get the DataGridViewRow object for the clicked cell
            DataGridViewRow row = Doc_DGV.Rows[e.RowIndex];

            // Set the Text property of the textboxes to the values of the cells in the clicked row
            string name = row.Cells[1].Value.ToString();
            string DOB = row.Cells[2].Value.ToString();
            string gender = row.Cells[3].Value.ToString();
            string exp = row.Cells[4].Value.ToString();
            string phone = row.Cells[5].Value.ToString();
            string pass = row.Cells[6].Value.ToString();





            Doc_name.Text = name;
            DOB_doctor.Text = DOB;
            Doctor_phone.Text = phone;
            Doc_Gender.SelectedItem = gender;
            Doctor_exp.Text = exp;
            Doc_Pass.Text = pass;



            // Set the key variable to the value of the first cell in the clicked row
            key = Convert.ToInt32(row.Cells[0].Value);
        }
    }
 }
    