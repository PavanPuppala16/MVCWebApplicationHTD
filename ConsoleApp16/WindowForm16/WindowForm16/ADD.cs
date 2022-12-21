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
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void ADD_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=PAVAN;password=123456");
            SqlCommand cmd = new SqlCommand(" insert into mytable values(@x,@y)");

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
                

        }
    }
}
