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

namespace assessment_4
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            GetSno();
        }
        public void GetSno()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM TB_STUDENTDATA", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DisplayMember = "StudentId";
                comboBox1.ValueMember = "StudentId";
                comboBox1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  TB_STUDENTDATA  WHERE StudentId=@StudentId", con);
                cmd.Parameters.AddWithValue("@StudentId", comboBox1.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["StudentName"].ToString();
                    textBox2.Text = dr["Year"].ToString();
                    textBox3.Text = dr["Branch"].ToString();
                    textBox4.Text = dr["StudentPassword"].ToString();
                    textBox5.Text = dr["CollegeId"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAssesing obj = new BookAssesing();
            obj.ShowDialog();
        }
    }
    }
