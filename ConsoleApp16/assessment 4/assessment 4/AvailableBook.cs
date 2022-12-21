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
    public partial class AvailableBook : Form
    {
        public AvailableBook()
        {
            InitializeComponent();
            GetData();
            GetSno();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtauthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker_y.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            BookUid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtauthor_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetSno()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM  TB_LABRARY1 ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BookUid.DisplayMember = "BookUid";
                BookUid.ValueMember = "BookUid";
                BookUid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void BookUid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TB_LABRARY1  WHERE BookUid=@BookUid", con);
                cmd.Parameters.AddWithValue("@BookUid", BookUid.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtname.Text = dr["BookName"].ToString();
                    txtauthor.Text = dr["AuthorName"].ToString();
                    dateTimePicker_y.Text = dr["YearOfPrinting"].ToString();


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

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryInsert obj = new LibraryInsert();
            obj.Show();
        }
    }
    
}
