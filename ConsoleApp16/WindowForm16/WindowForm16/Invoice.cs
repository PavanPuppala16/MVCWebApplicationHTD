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
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textinv.Text))
            {
                MessageBox.Show("name is cannot empty");
            }
            else if (string.IsNullOrEmpty(textname.Text))
            {
                MessageBox.Show("payment mode is cannot empty");
            }
            else if (string.IsNullOrEmpty(textdept.Text))
            {
                MessageBox.Show("dept name is cannot empty");
            }
           
            else
            {
                string value = "";
                bool isChecked = ronline.Checked;
                if (isChecked)
                    value = ronline.Text;
                else
                    value = roffiline.Text;
                SqlConnection obj = new SqlConnection("Data source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
                try
                {


                   
                  
                        
                    SqlCommand cmd = new SqlCommand("INSERT INTO TBL_INVOICE VALUES(@INVNO,@CLIENTNAME,@PAYMENTMODE,@EDATE,@INVTYPE,@DEPTNAME)", obj);

                    cmd.Parameters.AddWithValue("@INVNO", textinv.Text); 
                    cmd.Parameters.AddWithValue("@CLIENTNAME", textname.Text);
                    cmd.Parameters.AddWithValue("@PAYMENTMODE", value);
                    cmd.Parameters.AddWithValue("@INVTYPE", texttype.Text);
                    cmd.Parameters.AddWithValue("@EDATE", Convert.ToDateTime(dateTimePickere.Text));
                    cmd.Parameters.AddWithValue("@DEPTNAME", textdept.Text);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Inserted Successfully");
                        textinv.Text = "";

                        texttype.Text = "";
                        textname.Text = "";
                        value         = "";
                        textdept.Text = "";
                    }
                    MessageBox.Show("connected successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.Close();
                }
            }
        }

    }
}
        
