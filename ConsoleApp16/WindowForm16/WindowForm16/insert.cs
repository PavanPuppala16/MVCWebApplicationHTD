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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial catalog=1616;user id=sa;password=123456");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TBl_insert VALUES(@SNO,@NAME)", con);
                cmd.Parameters.AddWithValue("@sno", textsno.Text);
                cmd.Parameters.AddWithValue("@name", textname.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("inserted succefullu");
                    textsno.Text = "";
                    textname.Text = "";
                }
                else
                {
                    MessageBox.Show("something went wrong");
                }
                con.Close();

            }
            catch(Exception ex )
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
