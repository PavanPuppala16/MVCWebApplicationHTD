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
    public partial class StudentDetailsInserting : Form
    {
        public StudentDetailsInserting()
        {
            InitializeComponent();
        }

        private void StudentDetailsInserting_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAssesing obj = new BookAssesing();
            obj.Show();
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into TB_STUDENTDATA values(@StudentId,@StudentName,@Year,@Branch,@StudentPassword,@CollegeId)", con);
          
                cmd.Parameters.AddWithValue("@StudentId", txtid.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtname.Text);
                cmd.Parameters.AddWithValue("@Year", txtyear.Text);
                cmd.Parameters.AddWithValue("@Branch", txtbranch.Text);
                cmd.Parameters.AddWithValue("@StudentPassword", txtpass.Text);
                cmd.Parameters.AddWithValue("@CollegeId", txtcid.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtid.Text = "";
                    txtname.Text = "";
                    txtyear.Text = "";
                    txtbranch.Text = "";
                    txtcid.Text = "";

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

    
    }
}
