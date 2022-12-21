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
    public partial class Task13 : Form
    {
        public Task13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=northwnd;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_SHIPPED_NULL", con);
                DataTable dt = new DataTable();  // used to hold the data at ClicntMac
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=northwnd;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_SHIPPEDDATE_NOTNULL", con);
                DataTable dt = new DataTable();  // used to hold the data at ClicntMac
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=northwnd;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_YEARLY_DATE", con);
                DataTable dt = new DataTable();  // used to hold the data at ClicntMac
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void Task13_Load(object sender, EventArgs e)
        {

        }
    }
}
