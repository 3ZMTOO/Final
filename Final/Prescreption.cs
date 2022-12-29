using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Configuration;
using System.Data.SqlClient;

namespace Final
{
    public partial class Prescreption : Form
    {
        public Prescreption()
        {
            InitializeComponent();
            DisplayPres();
        }

        private void Doc_Name_Click(object sender, EventArgs e)
        {

        }

        private void DisplayPres()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Prescreption";
                SqlDataAdapter sda = new SqlDataAdapter(Query, sqlcon);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DGV_Pre.DataSource = ds.Tables[0];
                clear();
            }
        }
        int key = 0;
        private void clear()
        {
            PName.Text = "";
            DName.Text = "";
            Mname.Text = "";
            Cost.Text = "";
            key = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (DName.Text == "" || PName.Text == "" ||Cost.Text==""||Mname.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();

                        SqlCommand cmd = new SqlCommand("SELECT d.Doc_Id, p.patid, d.Doc_Name, p.Pat_Name " +
                            "FROM Patient p " +
                            "JOIN Doctor d ON p.Doc_Id = d.Doc_Id;)", sqlcon);

                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Prescreption added");
                        DisplayPres();
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
    }
}
