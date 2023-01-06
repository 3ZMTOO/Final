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
using System.Net;

namespace Final
{
    public partial class Prescreption : Form
    {
        public Prescreption()
        {
            InitializeComponent();
            DisplayPres();
            Get_Doc_ID();
            Get_Pat_ID();
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
            Mlabel.Text = "";
            Cost.Text = "";
            key = 0;
            Doc_ID.SelectedIndex= -1;
            Pat_ID.SelectedIndex= -1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                if (PName.Text == "" || DName.Text == "" || Mname.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        sqlcon.Open();

                        SqlCommand cmd = new SqlCommand("insert into Prescreption (Doc_Id,Doc_Name,Pat_id,Pat_Name,Medicines,Cost,diagnosis)values(@DID,@DN,@PID,@PN,@MD,@DG,@CO)", sqlcon);
                        cmd.Parameters.AddWithValue("@DID", Doc_ID.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@DN", DName.Text);
                        cmd.Parameters.AddWithValue("@PID", Pat_ID.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@PN", PName.Text);
                        cmd.Parameters.AddWithValue("@MD", Medicine.Text);
                        cmd.Parameters.AddWithValue("@DG", Diagnosis.Text);
                        cmd.Parameters.AddWithValue("@CO", Cost.Text);
                       


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient added");
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

        private void Get_Doc_ID()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select Doc_Id from Doctor ",sqlcon);
                SqlDataReader rdr;
                rdr= cmd.ExecuteReader();
                DataTable dt= new DataTable();
                dt.Columns.Add("Doc_Id", typeof(int));
                dt.Load(rdr);
                Doc_ID.ValueMember = "Doc_Id";
                Doc_ID.DataSource= dt;


                sqlcon.Close() ;
            }
        }

        private void Get_Pat_ID()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select patid from Patient ", sqlcon);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("patid", typeof(int));
                dt.Load(rdr);
                Pat_ID.ValueMember = "patid";
                Pat_ID.DataSource = dt;
                sqlcon.Close();
            }
        }


        private void get_Doctor_Name()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string query = "select * from Doctor where Doc_Id = " + Doc_ID.SelectedValue.ToString() + "";
                SqlCommand cmd =new SqlCommand(query, sqlcon);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);   
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    DName.Text = dr["Doc_Name"].ToString();
                }
                sqlcon.Close();
            }
        }


        private void get_Pat_Name()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();

            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                string query = "select * from Patient where patid = " + Pat_ID.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    PName.Text = dr["patName"].ToString();
                }
                sqlcon.Close();
            }
        }

        private void Prescreption_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void DGV_Pre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doc_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            get_Doctor_Name();
        }

        private void Pat_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            get_Pat_Name();
        }
    }
}
