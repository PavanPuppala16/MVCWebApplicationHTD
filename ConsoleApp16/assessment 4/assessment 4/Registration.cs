using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_4
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogin obj = new StudentLogin();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REGISRATIONFORM obj = new REGISRATIONFORM();
            obj.Show();
        }
    }
}
