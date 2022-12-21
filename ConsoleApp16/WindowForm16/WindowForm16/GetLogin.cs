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
    public partial class GetLogin : Form
    {
        public GetLogin()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {​​​​​​
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=1616;user id=sa;password=123456");
            try
            {​​​​​​
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_GETDATA   WHERE EMAIL= @EMAIL  and DOB=@DOB", con);
                cmd.Parameters.AddWithValue("@EMAIL", textBox1.Text);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dateTimePicker1.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {​​​​​​
                    MessageBox.Show("Login Successfully");
                    textBox1.Text = "";
                }
                else
                {​​​
                    MessageBox.Show("Email or Password is no correct");
                }​​​​​​
            }​​​​​​
            catch (Exception ex)
            {​​​​​​
                MessageBox.Show(ex.Message);
            }​​​​​​
        }​​​​​​

    }
}
