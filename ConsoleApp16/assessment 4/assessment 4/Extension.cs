using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_4
{
    public static class Extension
    {
        public static RadioButton SeletedaRadioButton(this GroupBox g)
        {
            return g.Controls.OfType<RadioButton>().Where(rb=>rb.Checked).FirstOrDefault();
        }

    }
}
