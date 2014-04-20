using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vinasun.CommonClass
{
    class EventHandler
    {

        //Only allow character
        public void characterOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

            }
        }


        //Only allow number
        public void numberOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }
    }
}
