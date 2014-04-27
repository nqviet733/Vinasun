using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using DevComponents.Editors.DateTimeAdv;

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
            if (o is DateTimeInput)
            {
                DateTimeInput dtp = o as DateTimeInput;
                DateTime dateTimeDefault = new DateTime(0);
                if (getAge(dtp.Value) < 16 || !System.DateTime.Equals(dtp.Value, dateTimeDefault))
                {
                    errorProvider.SetError(dtp, "Vui Lòng Nhập Năm Sinh Nhân Viên Trên 16 Tuổi" + errorString);
                    status = false;
                }
                else
                {
                    errorProvider.SetError(dtp, "");
                }
            }
            return status;
        }

        public int getAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth.AddYears(age) > DateTime.Now)
            {
                age--;
            }

            return age;
        }

        //Validation for gender
        public bool isGenderNotEmpty(Object o1, Object o2, ErrorProvider errorProvider, String errorString)
        {
            bool status = true;
            if (o1 is RadioButton && o2 is RadioButton)
            {
                RadioButton cb1 = o1 as RadioButton;
                RadioButton cb2 = o2 as RadioButton;
                if (!cb1.Checked && !cb2.Checked)
                {
                    errorProvider.SetError(cb1, "Vui Lòng Chọn " + errorString);
                    status = false;
                }
                else
                {
                    errorProvider.SetError(cb2, "");
                }
            }
            return status;
        }

        //Validation for email
        public bool isEmailValidator(Object o, ErrorProvider errorProvider, String errorString)
        {
            Regex ValidEmailRegex = CreateValidEmailRegex();
            bool status = true;
            if (o is TextBox)
            {
                TextBox tb = o as TextBox;
                status = ValidEmailRegex.IsMatch(tb.Text);
                if (false.Equals(status) && !String.IsNullOrEmpty(tb.Text))
                {
                    errorProvider.SetError(tb, "Vui Lòng Nhập Đúng Địa Chỉ Email" + errorString);
                    status = false;
                }
                else
                {
                    errorProvider.SetError(tb, "");
                }
            }
            return status;
        }

        private Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

    }
}
