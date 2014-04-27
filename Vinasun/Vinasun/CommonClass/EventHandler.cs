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
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        //Only allow character or sapce
        public void characterOrSpaceOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        //Only allow character or digit
        public void characterOrDigitOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        //Only allow digit only
        public void digitOnly(Object o, KeyPressEventArgs e)
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

        //Only allow number||phone number
        public void digitOrSpaceOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        //Only allow Comma
        public void digitOrCommaOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.' && tb.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

            }
        }
    }
}
