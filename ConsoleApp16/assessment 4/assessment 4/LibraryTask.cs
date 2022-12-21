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
    public partial class LibraryTask : Form
    {
        public LibraryTask()
        {
            InitializeComponent();
            GetSno();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void GetSno()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM  TB_LIBRARYBOOKINSERTDATA", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DisplayMember = "BookUid";
                comboBox1.ValueMember = "BookUid";
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM TB_LIBRARYBOOKINSERTDATA  WHERE BookUid=@BookUid", con);
                cmd.Parameters.AddWithValue("@BookUid", comboBox1.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["BookName"].ToString();
                    textBox2.Text = dr["AuthorName"].ToString();
                    dateTimePicker1.Text = dr["YearOfPrinting"].ToString();
                    

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into  TB_LIBRARYPASSTASK values (@BookUid,@BookName,@AuthorName,@YearOfPrinting,@LibraryCode,@LPassword)", con);

                cmd.Parameters.AddWithValue("@BookUid", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@BookName", textBox1.Text);
                cmd.Parameters.AddWithValue("@AuthorName", textBox2.Text);
                cmd.Parameters.AddWithValue("@YearOfPrinting",Convert.ToDateTime(dateTimePicker1.Text) );
                cmd.Parameters.AddWithValue("@LibraryCode", txtLcode.Text);
                cmd.Parameters.AddWithValue("@LPassword", txtLp.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtLcode.Text = "";
                    txtLp.Text = "";

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
        }  }
}
    

