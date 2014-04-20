using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinasun.CommonClass
{
    class Validation
    {
        public bool isNotNullOrEmpty(Object o, ErrorProvider errorProvider, String errorString)
        {
            bool status = true;
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                if (String.IsNullOrEmpty(tb.Text))
                {
                    errorProvider.SetError(tb, "Vui Lòng Nhập " + errorString);
                    //tb.Focus();
                    status = false;
                }
                else
                {
                    errorProvider.SetError(tb, "");
                }
            }
            return status;
        }
    }
}
