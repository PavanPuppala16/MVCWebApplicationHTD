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
    public partial class Task1cs : Form
    {
        public Task1cs()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string Qualification = "";
            if (this.checkBox1.Checked)
            {
                Qualification = Qualification + this.checkBox1.Text + "";
            }
            if (this.checkBox2.Checked)
            {
                Qualification = Qualification + this.checkBox2.Text + "";
            }
            if (this.checkBox3.Checked)
            {
                Qualification = Qualification + this.checkBox3.Text + "";
            }

            SqlConnection con = new SqlConnection("Data source=DESKTOP-2B7I1IJ;Initial Catalog=DB_QUERIES;User id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_TASK1_DATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UID", txtuid.Text);
                cmd.Parameters.AddWithValue("@NAME", txtname.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtemail.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", txtpass.Text);
                cmd.Parameters.AddWithValue("GENDER", this.groupBox1.Text);
                cmd.Parameters.AddWithValue("SALARY", txtsal.Text);
                cmd.Parameters.AddWithValue("DOB", Convert.ToDateTime(txtdob.Text));
                cmd.Parameters.AddWithValue("QUALIFICATION", Qualification);
                cmd.Parameters.AddWithValue("DEPT", this.comboBox1.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtuid.Text = "";
                    txtname.Text = "";
                    txtemail.Text = "";
                    txtpass.Text = "";
                    txtsal.Text = "";
                    Qualification = "";
                    this.comboBox1.Text = "";


                }
                else
                {
                    MessageBox.Show("Something went wrong");
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

        private void Task1cs_Load(object sender, EventArgs e)
        {

        }
    }
}
   
