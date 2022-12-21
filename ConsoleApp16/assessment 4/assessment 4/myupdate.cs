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
    public partial class myupdate : Form
    {
        int sno;
        SqlConnection con;
        public myupdate()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=1616;user id=sa;password=123456");
            con.Open();
            GetData();

        }
        public void GetData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_my", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textemail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textdept.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker_dob.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            sno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_tb_my", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", textname.Text);
                cmd.Parameters.AddWithValue("@emailid", textemail.Text);
                cmd.Parameters.AddWithValue("@dept", textdept.Text);
                cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker_dob.Text));
                cmd.Parameters.AddWithValue("@sno", sno);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Updated Successfully!");
                    textname.Text = "";
                    textemail.Text = "";
                    textdept.Text = "";
                    GetData();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sno", sno);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Deleted Successfully!");
                    textname.Text = "";
                    textemail.Text = "";
                    textdept.Text = "";
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
    }
