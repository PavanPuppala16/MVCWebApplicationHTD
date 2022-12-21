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
    public partial class Task12 : Form
    {
        public Task12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("client name cannot be empty");
            }
            else if (string.IsNullOrEmpty(txtpay.Text))
            {
                MessageBox.Show("payament mode cannot be empty");
            }

            else if (string.IsNullOrEmpty(txtinv.Text))
            {
                MessageBox.Show("dept name cannot be empty");
            }

            else
            {
                SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;initial catalog=PAVANKUMAR;user id=sa;password=123456");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tb_invoice values(@client_name,@payment_mode,@date,@inv_type,@dept_name)", con);


                    cmd.Parameters.AddWithValue("@client_name", txtname.Text);
                    cmd.Parameters.AddWithValue("@payment_mode", txtpay.Text);
                    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dob.Text));
                    cmd.Parameters.AddWithValue("@inv_type", txtinv.Text);
                    cmd.Parameters.AddWithValue("@dept_name", txtdept.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("inserted successfully");
                        txtname.Text = "";
                        txtpay.Text = "";
                        txtinv.Text = "";
                        txtdept.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("something went wrong");
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

        private void Task12_Load(object sender, EventArgs e)
        {

        }
    }
    
}
