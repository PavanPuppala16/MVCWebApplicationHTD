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
    public partial class AFTERASSIGNINGDATAcs : Form
    {
        public AFTERASSIGNINGDATAcs()
        {
            InitializeComponent();
            GetSnoD();
        }
        public void GetSnoD()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {


                SqlDataAdapter da = new SqlDataAdapter("SP_TB_LIBRARYBOOKINSERTDATA", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BookReturn obj = new BookReturn();
            obj.Show();

        }
    }
}
