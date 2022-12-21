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
    public partial class TASK11 : Form
    {
        public TASK11()
        {
            InitializeComponent();
            Getdept();
        }
        public void Getdept()
        {
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select  job from tb_dept", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtdept.DisplayMember = "job";
                txtdept.DataSource = dt;
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
        private void TASK12_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_tb_task11", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UID", txtuid.Text);
                cmd.Parameters.AddWithValue("@NAME", txtname.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtemail.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", txtpass.Text);
                cmd.Parameters.AddWithValue("@GENDER", this.groupBox1.SeletedaRadioButton().Text);
                cmd.Parameters.AddWithValue("@SALARY", txtsal.Text);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtdob.Text));
                cmd.Parameters.AddWithValue("@QUALIFICATION", Qualification);
                cmd.Parameters.AddWithValue("@DEPARTMENT", txtdept.SelectedText);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtname.Text = "";
                    txtname.Text = "";
                    txtemail.Text = "";
                    txtpass.Text = "";
                    txtsal.Text = "";




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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
