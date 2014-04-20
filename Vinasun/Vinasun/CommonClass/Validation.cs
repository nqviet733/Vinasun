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

        //Prevent null or empty in textbox
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

        //Emp age must be >= 16 year old
        public bool isValidDOB(Object o, ErrorProvider errorProvider, String errorString)
        {
            bool status = true;
            if (o is DateTimePicker)
            {
                DateTimePicker dtp = o as DateTimePicker;
                if (GetAge(dtp.Value) < 16 && dtp.Value != null)
                {
                    errorProvider.SetError(dtp, "Vui Lòng Nhập Năm Sinh Nhân Viên Trên 16 Tuổi" + errorString);
                    //tb.Focus();
                    status = false;
                }
                else
                {
                    errorProvider.SetError(dtp, "");
                }
            }
            return status;
        }

        public int GetAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth.AddYears(age) > DateTime.Now)
            {
                age--;
            }

            return age;
        }
    }
}
