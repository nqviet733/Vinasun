using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.Model;
using Vinasun.EntityClass;
using Vinasun.CommonClass;


namespace Vinasun.View
{
    public partial class Main : Form
    {

         EntityDiagramContainer entitiesContainer;
         Validation validation;
         Vinasun.CommonClass.EventHandler eventHandler;
         ToolTip txt_empIdToolTip;
         ToolTip txt_empFirstNameToolTip;
         ToolTip txt_empLastNameToolTip;
         ToolTip txt_empPhoneNumberToolTip;
         ToolTip txt_empEmailToolTip;
         private bool statusEmpId;

         public bool StatusEmpId
         {
             get { return statusEmpId; }
             set { statusEmpId = value; }
         }
         private bool statusEmpFirtName;

         public bool StatusEmpFirtName
         {
             get { return statusEmpFirtName; }
             set { statusEmpFirtName = value; }
         }
         private bool statusEmpLastName;

         public bool StatusEmpLastName
         {
             get { return statusEmpLastName; }
             set { statusEmpLastName = value; }
         }
         private bool statusEmpDOB;

         public bool StatusEmpDOB
         {
             get { return statusEmpDOB; }
             set { statusEmpDOB = value; }
         }

         private bool statusGender;

         public bool StatusEmpGender
         {
             get { return statusGender; }
             set { statusGender = value; }
         }

         private bool statusEmpEmail;

         public bool StatusEmpEmail
         {
             get { return statusEmpEmail; }
             set { statusEmpEmail = value; }
         }

         private bool statusEmpPhone;

         public bool StatusEmpPhone
         {
             get { return statusEmpPhone; }
             set { statusEmpPhone = value; }
         }

        public Main()
        {
            InitializeComponent();

            entitiesContainer = new EntityDiagramContainer();
            validation = new Validation();
            eventHandler = new Vinasun.CommonClass.EventHandler();

            Employee employee = new Employee();
            employee.showDGV(dgv_entities, entitiesContainer);

            this.StatusEmpId = false;
            this.StatusEmpFirtName = false;
            this.StatusEmpLastName = false;
            this.StatusEmpDOB = true;
            this.StatusEmpEmail = true;
            this.StatusEmpPhone = true;
            this.statusGender = false;
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && textBoxX1.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_Validating(object sender, CancelEventArgs e)
        {
            validate();
        }
        private bool validate()
        {
            bool status = true;
            if (this.textBoxX1.Text.Length > 5)
            {
                errorProvider1.SetError(this.textBoxX1, "Please Provide....");
                this.buttonX1.Focus();
                status = false;
            }
            else
            {
                errorProvider1.SetError(this.textBoxX1, "Please Provide....");
            }
            return status;
        }

        private void textBoxX17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void superTabControlPanel13_Click(object sender, EventArgs e)
        {

        }

        private void bt_addEmployee_Click(object sender, EventArgs e)
        {
            if (!StatusEmpId)
            {
                //MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên", "WARNING", 
                //                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_employeeId.Focus();
            }
            if (!StatusEmpFirtName)
            {
                txt_firstName.Focus();
            }
            if (!StatusEmpLastName)
            {
                txt_lastName.Focus();
            }
            StatusEmpDOB = validation.isValidDOB(dp_empDOB, errorProvider, "");
            if (!StatusEmpDOB)
            {
                dp_empDOB.Focus();
            }
            StatusEmpGender = validation.isGenderNotEmpty(rb_empNam, rb_empNu, errorProvider, "Giới Tính");
            if (!StatusEmpGender)
            {
                //rb_empNu.Focus();
            }
            if (StatusEmpId && StatusEmpFirtName && StatusEmpLastName && StatusEmpGender && StatusEmpDOB && StatusEmpEmail && StatusEmpPhone)
            {
                Entity entity = new Entity();
                entity.entityNo = txt_employeeId.Text;
                entity.firstname = txt_firstName.Text;
                entity.lastname = txt_lastName.Text;
                entity.birthday = dp_empDOB.Value;
                entity.email = txt_email.Text;
                entity.businessPhone = txt_phoneNumber.Text;
                EntityDTO entityDTO = new EntityDTOImpl();
                int signal = entityDTO.addEntity(entitiesContainer, entity);
                //if (signal == 1)
                //{
                //    MessageBox.Show("Thêm Nhân Viên Mới Thành Công");
                //}
                //else
                //{
                //    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Nhân Viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void txt_empIdValidattion(object sender, CancelEventArgs e)
        {
            StatusEmpId = validation.isNotNullOrEmpty(sender, errorProvider, "Mã Nhân Niên");
        }

        private void txt_empIdKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOnly(sender, e);
        }

        private void txt_empIdFocus(object sender, EventArgs e)
        {
            txt_empIdToolTip = new ToolTip();
            txt_empIdToolTip.Show("Mã Sõ Nhân Viên Bao Gồm Kí Tự Và Số", txt_employeeId);
        }

        private void txt_empIdLeave(object sender, EventArgs e)
        {
            txt_empIdToolTip.Dispose();
        }

        //Event Handler for Employee FirstName
        private void txt_empFirstNameFocus(object sender, EventArgs e)
        {
            txt_empFirstNameToolTip = new ToolTip();
            txt_empFirstNameToolTip.Show("Tên Nhân Viên Chỉ Bao Gồm Kí Tự", txt_firstName);
        }

        private void txt_empFirstNameKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOnly(sender, e);
        }

        private void txt_empFirstNameValidatior(object sender, CancelEventArgs e)
        {
            StatusEmpFirtName = validation.isNotNullOrEmpty(sender, errorProvider, "Tên Nhân Niên");
        }

        private void txt_empFirstNameLeave(object sender, EventArgs e)
        {
            txt_empFirstNameToolTip.Dispose();
        }

        //Event Handler for Employee LastName
        private void txt_empLastNameFocus(object sender, EventArgs e)
        {
            txt_empLastNameToolTip = new ToolTip();
            txt_empLastNameToolTip.Show("Họ Nhân Viên Chỉ Bao Gồm Kí Tự", txt_lastName);
        }

        private void txt_empLastNameKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOnly(sender, e);
        }

        private void txt_empLastNameValidatior(object sender, CancelEventArgs e)
        {
            StatusEmpLastName = validation.isNotNullOrEmpty(sender, errorProvider, "Họ Nhân Niên");
        }

        private void txt_empLastNameLeave(object sender, EventArgs e)
        {
            txt_empLastNameToolTip.Dispose();
        }

        //EventHandler for dateof birth
        private void dtp_dateOfBirthValidator(object sender, CancelEventArgs e)
        {
            
        }

        private void dtp_dateOfBirthLeave(object sender, EventArgs e)
        {
            //validation.isValidDOB(sender, errorProvider, "");
        }

        //EventHandler for phone nụmber
        private void txt_phoneNumberFocus(object sender, EventArgs e)
        {
            txt_empPhoneNumberToolTip = new ToolTip();
            txt_empPhoneNumberToolTip.Show("Số Điện Thoại Nhân Viên Bao Gồm Sõ Và Khoảng Trắng", txt_phoneNumber);
        }

        private void txt_phoneNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.numberOnly(sender, e);
        }

        private void txt_phoneNumberLeave(object sender, EventArgs e)
        {
            txt_empPhoneNumberToolTip.Dispose();
        }

        //EventHandler for email
        private void txt_emailFocus(object sender, EventArgs e)
        {
            txt_empEmailToolTip = new ToolTip();
            txt_empEmailToolTip.Show("Địa Chỉ Email Của Nhân Viên", txt_email);
        }

        private void txt_emailLeave(object sender, EventArgs e)
        {
            txt_empEmailToolTip.Dispose();
        }

        private void txt_emailValidator(object sender, CancelEventArgs e)
        {
            StatusEmpEmail = validation.isEmailValidator(sender, errorProvider, "");
        }

    }
}
