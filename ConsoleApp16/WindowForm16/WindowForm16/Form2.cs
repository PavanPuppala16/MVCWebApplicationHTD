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
namespace WindowForm16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            getdata();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void getdata()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from tb_dept", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DisplayMember = "job";
                comboBox1.DataSource = dt;

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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                string value = "";
                bool isChecked = radioButton1.Checked;
                if (isChecked)
                    value = radioButton1.Text;
                else
                    value = radioButton2.Text;
                
                SqlCommand cmd = new SqlCommand("sp_tb_task1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@emailid", textBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox3.Text);
                cmd.Parameters.AddWithValue("@gender", value);
                cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker1.Text));
                
                cmd.Parameters.AddWithValue("@department", comboBox1);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("something went Wrong!");
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
    }
    }
