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
                    if (char.IsControl(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Letter.Equals(k) && char.IsLetter(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.WhiteSpace.Equals(k) && char.IsWhiteSpace(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Digit.Equals(k) && char.IsDigit(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Punctuation.Equals(k) && char.IsPunctuation(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Comma.Equals(k) && ','.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.QuestionMark.Equals(k) && '?'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.BackSlash.Equals(k) && '\\'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Slash.Equals(k) && '/'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Asterisk.Equals(k) && '*'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.AtSign.Equals(k) && '@'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Apostrophe.Equals(k) && '\''.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Colon.Equals(k) && ':'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Hyphen.Equals(k) && '-'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Underscore.Equals(k) && '_'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.VerticalBar.Equals(k) && '|'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                    if (KeyType.Ampersand.Equals(k) && ';'.Equals(e.KeyChar))
                    {
                        status = false;
                    }
                }
                e.Handled = status;
            }
        }

    }
}
