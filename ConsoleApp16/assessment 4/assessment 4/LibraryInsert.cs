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
    public partial class LibraryInsert : Form
    {
        public LibraryInsert()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryBookUpdate obj = new LibraryBookUpdate();
            obj.Show();
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial Catalog=PAVANKUMAR;User id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into  TB_LIBRARYBOOKINSERTDATA values(@BookUid,@BookName,@AuthorName,@YearOfPrinting,@BranchCategory,@Room,@CollegeId)", con);
                cmd.Parameters.AddWithValue("@BookUid", txtbuid.Text);
                cmd.Parameters.AddWithValue("@BookName", txtname.Text);
                cmd.Parameters.AddWithValue("@AuthorName", txtau.Text);
                cmd.Parameters.AddWithValue("@YearOfPrinting", Convert.ToDateTime(dateTimePicker_y.Text));
                cmd.Parameters.AddWithValue("@BranchCategory", txtbc.Text);
                cmd.Parameters.AddWithValue("@Room", textBox4.Text);
                cmd.Parameters.AddWithValue("@CollegeId", CollegeId.Text);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtbuid.Text = "";
                    txtname.Text = "";
                    txtname.Text = "";
                    txtau.Text = "";
                    txtbc.Text = "";
                    textBox4.Text = "";
                    CollegeId.Text = "";




                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            }

        private void LibraryInsert_Load(object sender, EventArgs e)
        {

        }
    }
    }

