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
    public partial class LibraryBookUpdate : Form
    {
        
        public LibraryBookUpdate()
        {
            InitializeComponent();
            GetData();

        }
        public void GetData()

        {
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_TB_LABRARY1", con);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtauthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker_y.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtuid.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update  TB_LABRARY1 set BookName=@BookName,AuthorName=@AuthorName,YearOfPrinting=@YearOfPrinting where BookUid=@BookUid",con);
                cmd.Parameters.AddWithValue("@BookUid",txtuid.Text);
                cmd.Parameters.AddWithValue("@BookName", txtname.Text);
                cmd.Parameters.AddWithValue("@AuthorName", txtauthor.Text);
                cmd.Parameters.AddWithValue("@YearOfPrinting", Convert.ToDateTime(dateTimePicker_y.Text));
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Updated Successfully!");
                    txtuid.Text = "";
                    txtname.Text = "";
                    txtauthor.Text = "";
                    dateTimePicker_y.Text = "";
                    GetData();
                }
                else
                {
                    MessageBox.Show("SOmething Went Wrong!");
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
                SqlCommand cmd = new SqlCommand("delete  from TB_LABRARY1 where BookUid=@BookUid", con);
                
                cmd.Parameters.AddWithValue("BookUid" ,txtuid.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Deleted Successfully!");
                    txtname.Text = "";
                    txtauthor.Text = "";
                    dateTimePicker_y.Text = "";
                    GetData();


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

        private void button3_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Show();
        }
    }
    }
