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
    public partial class REGISRATIONFORM : Form
    {
        public REGISRATIONFORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
         {
            AvailableBook obj = new AvailableBook();
            obj.Show();
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into  TB_REGISTRATIONFORM values(@StudentId,@StudentName,@StudentPassword)", con);
                cmd.Parameters.AddWithValue("@StudentId", txtid.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtname.Text);
                cmd.Parameters.AddWithValue("@StudentPassword", txtpass.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtid.Text = "";
                    txtname.Text = "";
                    txtpass.Text = "";


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
