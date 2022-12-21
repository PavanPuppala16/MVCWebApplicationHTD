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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Name cannot be Empty");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Email  cannot be Empty");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Sal cannot be Empty");
            }
            else
            {
                {
                    SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO TBL_REGISTER_WINDOWS VALUES(@NAME,@EMAILID,@SALARY,@DOB)", con);
                        cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                        cmd.Parameters.AddWithValue("@emailid", textBox2.Text);
                        cmd.Parameters.AddWithValue("@salary", textBox3.Text);
                        cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker1.Text));
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
                            MessageBox.Show("SOmething went Wrong!");
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
