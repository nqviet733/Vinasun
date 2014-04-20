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

         EntityDiagramContainer entitiesContainer = new EntityDiagramContainer();

        public Main()
        {
            InitializeComponent();

            Employee employee = new Employee();
            employee.showDGV(dgv_entities, entitiesContainer);
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
            Entity entity = new Entity();
            entity.entityNo = txt_employeeId.Text;
            entity.firstname = txt_firstName.Text;
            entity.lastname = txt_lastName.Text;
            entity.birthday = dp_DOB.Value;
            entity.email = txt_email.Text;
            entity.businessPhone = txt_phoneNumber.Text;
            EntityDTO entityDTO = new EntityDTOImpl();
            int signal = entityDTO.addEntity(entitiesContainer, entity);
            if (signal == 1)
            {
                MessageBox.Show("Thêm Nhân Viên Mới Thành Công");
            }
            else
            {
                MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Nhân Viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dp_DOB_Click(object sender, EventArgs e)
        {

        }


        private void txt_employeeIdValidattion(object sender, CancelEventArgs e)
        {
            Validation validation = new Validation();
            validation.isNotNullOrEmpty(sender, errorProvider_EmployeeId, "Mã Nhân Niên");
        }

        private void employeeId_keyPress(object sender, KeyPressEventArgs e)
        {
            Vinasun.CommonClass.EventHandler eventHandler = new Vinasun.CommonClass.EventHandler();
            eventHandler.characterOnly(sender, e);
        }

    }
}
