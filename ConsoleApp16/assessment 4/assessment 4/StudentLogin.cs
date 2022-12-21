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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AvailableBook obj = new AvailableBook();
            obj.Show();
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select BookUid, LibraryCode, LibraryCode, LPassword, StudentId, StudentPassword from TB_LIBRARYTASK inner join LibraryStudent on TB_LIBRARYTASK.BookUid = LibraryStudent.StudentId", con);
                cmd.Parameters.AddWithValue("StudentId",txtsuid.Text);
                cmd.Parameters.AddWithValue("StudentPassword",txtstpss.Text);
                cmd.Parameters.AddWithValue("LibraryCode",txtLCode.Text);
                cmd.Parameters.AddWithValue("LPassword",txtLp.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read()==true)
                {
                    MessageBox.Show("login successfull");
                }
                else
                {
                    MessageBox.Show("unidefied user");
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
