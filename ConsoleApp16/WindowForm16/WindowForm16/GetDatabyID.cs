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
    public partial class GetDatabyID : Form
    {
        public GetDatabyID()
        {
            InitializeComponent();
            GetSno();
        }
        public void GetSno()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=1616;user id=sa;password=123456");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM TBL_GETDATA", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DisplayMember = "sno";
                comboBox1.ValueMember = "sno";
                comboBox1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=1616;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_GETDATA   WHERE sno = @sno", con);
                cmd.Parameters.AddWithValue("@sno", comboBox1.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["name"].ToString();
                    textBox2.Text = dr["email"].ToString();

                    dateTimePicker1.Text = dr["dob"].ToString();
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

        private void GetDatabyID_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}