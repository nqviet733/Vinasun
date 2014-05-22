using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.Enum;


namespace Vinasun.CommonClass
{
    class EventHandler
    {

        //Keypress handler
        public void keyPressHandler(Object o, KeyPressEventArgs e, params KeyType[] kt)
        {
            if (o is TextBox || o is DataGridTextBoxColumn)
            {
                bool status = true;
                foreach (KeyType k in kt)
                {
                    if (KeyType.Digit.Equals(k) && !char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Letter.Equals(k) && !char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
                    {
                        status = false;
                    }
                }
                e.Handled = status;
            }
        }


        //Only allow character
        public void characterOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox || o is DataGridTextBoxColumn)
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

        //Only allow character or digit or space
        public void characterOrDigitOrSpaceOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        //Only allow number || character || space || or "-"
        public void taxiNoOnly(Object o, KeyPressEventArgs e)
        {
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '-')
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
