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
using Vinasun.DTO;


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

         ToolTip txt_taxiDriverMainTootip;
         ToolTip txt_taxiNoTooltip;
         ToolTip txt_taxiGroupTootip;
         ToolTip txt_taxiTypeTootip;
         ToolTip txt_taxiDateJoinTootip;
         ToolTip txt_taxiModelTootip;

         ToolTip txt_taxiTypeSymbolTootip;
         ToolTip txt_taxiTypeDescriptionTootip;

         ToolTip txt_branchNameTootip;

         EmployeeModel employeeModel;
         TaxiModel taxiModel;
         TaxiTypeModel taxiTypeModel;
         BranchModel branchModel;

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

         private bool statusTaxiDriverMain;

         public bool StatusTaxiDriverMain
         {
             get { return statusTaxiDriverMain; }
             set { statusTaxiDriverMain = value; }
         }
         private bool statusTaxiNo;

         public bool StatusTaxiNo
         {
             get { return statusTaxiNo; }
             set { statusTaxiNo = value; }
         }
         private bool statusTaxiGroup;

         public bool StatusTaxiGroup
         {
             get { return statusTaxiGroup; }
             set { statusTaxiGroup = value; }
         }
         private bool statusTaxiType;

         public bool StatusTaxiType
         {
             get { return statusTaxiType; }
             set { statusTaxiType = value; }
         }
         private bool statusTaxiDateJoin;

         public bool StatusTaxiDateJoin
         {
             get { return statusTaxiDateJoin; }
             set { statusTaxiDateJoin = value; }
         }
         private bool statusTaxiModel;

         public bool StatusTaxiModel
         {
             get { return statusTaxiModel; }
             set { statusTaxiModel = value; }
         }

         private bool statusTaxiTypeSymbol;

         public bool StatusTaxiTypeSymbol
         {
             get { return statusTaxiTypeSymbol; }
             set { statusTaxiTypeSymbol = value; }
         }
         private bool statusTaxiTypeDescription;

         public bool StatusTaxiTypeDescription
         {
             get { return statusTaxiTypeDescription; }
             set { statusTaxiTypeDescription = value; }
         }

         private bool statusBranchName;

         public bool StatusBranchName
         {
             get { return statusBranchName; }
             set { statusBranchName = value; }
         }

        public Main()
        {
            InitializeComponent();

            entitiesContainer = new EntityDiagramContainer();
            validation = new Validation();
            eventHandler = new Vinasun.CommonClass.EventHandler();

            employeeModel = new EmployeeModel();
            employeeModel.showDGV(dgv_entities, entitiesContainer);

            taxiModel = new TaxiModel();
            taxiModel.showDGV(dgv_taxis, entitiesContainer);

            taxiTypeModel = new TaxiTypeModel();
            taxiTypeModel.showDGV(dgv_taxiType, entitiesContainer);

            branchModel = new BranchModel();
            branchModel.showDGV(dgv_branches, entitiesContainer);

            this.StatusEmpId = false;
            this.StatusEmpFirtName = false;
            this.StatusEmpLastName = false;
            this.StatusEmpDOB = true;
            this.StatusEmpEmail = true;
            this.StatusEmpPhone = true;
            this.statusGender = false;

            this.StatusTaxiDriverMain = false;
            this.StatusTaxiNo = false;
            this.StatusTaxiGroup = true;
            this.StatusTaxiType = true;
            this.StatusTaxiDateJoin = true;
            this.StatusTaxiModel = true;

            this.StatusTaxiTypeSymbol = false;
            this.StatusTaxiTypeDescription = false;
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
            //AddListEntities entitiesForm = new AddListEntities();
            //entitiesForm.Show();
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
                entity.gender = rb_empNam.Checked ? true : false;
                if (!System.DateTime.Equals(dp_empDOB.Value, new DateTime(0)))
                {
                    entity.birthday =  dp_empDOB.Value;
                }

                entity.email = txt_email.Text;
                entity.businessPhone = txt_phoneNumber.Text;
                EntityDTO entityDTO = new EntityDTOImpl();
                int signal = entityDTO.addEntity(entitiesContainer, entity);
                if (signal == 1)
                {
                    MessageBox.Show("Thêm Nhân Viên Mới Thành Công");
                    employeeModel.showDGV(dgv_entities, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Nhân Viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_empIdValidator(object sender, CancelEventArgs e)
        {
            StatusEmpId = validation.isNotNullOrEmpty(sender, errorProvider, "Mã Nhân Niên");
        }

        private void txt_empIdKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOrDigitOnly(sender, e);
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
            eventHandler.characterOrSpaceOnly(sender, e);
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
            eventHandler.digitOrSpaceOnly(sender, e);
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

        //button add new Taxi
        private void btAddTaxi_Click(object sender, EventArgs e)
        {
            if (StatusTaxiNo && StatusTaxiType && StatusTaxiModel && StatusTaxiDriverMain && StatusTaxiDateJoin && StatusTaxiGroup)
            {
                Taxi taxi = new Taxi();
                taxi.driverNoMain = txt_taxiDriverMain.Text;
                taxi.taxiNo = txt_taxiNo.Text;
                TaxiDTO taxiDTO = new TaxiDTOImpl();
                int signal = taxiDTO.addTaxi(entitiesContainer, taxi);
                if (signal == 1)
                {
                    MessageBox.Show("Thêm Taxi Mới Thành Công");
                    taxiModel.showDGV(dgv_taxis, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Taxi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Event handler for taxi main driver
        private void txt_taxiDriverMainFocus(object sender, EventArgs e)
        {
            txt_taxiDriverMainTootip = new ToolTip();
            txt_taxiDriverMainTootip.Show("Mã Tài Chính", txt_taxiDriverMain);
        }

        private void txt_taxiDriverMainLeave(object sender, EventArgs e)
        {
            txt_taxiDriverMainTootip.Dispose();
        }

        private void txt_taxiDriverMainKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOrDigitOnly(sender, e);
        }

        private void txt_taxiDriverMainValidator(object sender, CancelEventArgs e)
        {
            StatusTaxiDriverMain = validation.isNotNullOrEmpty(sender, errorProvider, "Mã Tài Chính");
        }

        //Event handler for taxi no
        private void txt_taxiNoKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.taxiNoOnly(sender, e);
        }

        private void txt_taxiNoValidator(object sender, CancelEventArgs e)
        {
            StatusTaxiNo = validation.isNotNullOrEmpty(sender, errorProvider, "Biển Số Xe");
        }

        private void txt_taxiNoLeave(object sender, EventArgs e)
        {
            txt_taxiNoTooltip.Dispose();
        }

        private void txt_taxiNoFocus(object sender, EventArgs e)
        {
            txt_taxiNoTooltip = new ToolTip();
            txt_taxiNoTooltip.Show("Biển Số Xe", txt_taxiNo);
        }
        //expand datagridview width  when mouse over
        private void dgv_entitiesMouseHover(object sender, EventArgs e)
        {
            isHidenEmpFieldForExpand(false);
            dgv_entities.Width = 900;
        }
        //reset size when mouse out
        private void dgv_entitiesMouseLeave(object sender, EventArgs e)
        {
            isHidenEmpFieldForExpand(true);
            dgv_entities.Width = 227;
        }
        private void isHidenEmpFieldForExpand(bool visible)
        {
            txt_employeeId.Visible = visible;
            lb_empId.Visible = visible;
            txt_address.Visible = visible;
            lb_address.Visible = visible;
            txt_email.Visible = visible;
            lb_email.Visible = visible;
            txt_firstName.Visible = visible;
            lb_firstname.Visible = visible;
            txt_lastName.Visible = visible;
            lb_lastname.Visible = visible;
            txt_phoneNumber.Visible = visible;
            lb_phoneNumber.Visible = visible;
            cb_checkerGroup.Visible = visible;
            lb_checkerGroup.Visible = visible;
            rb_empNam.Visible = visible;
            rb_empNu.Visible = visible;
            bt_addEmployee.Visible = visible;
            bt_delEmployee.Visible = visible;
            dp_empDOB.Visible = visible;
            cb_position.Visible = visible;
            lb_position.Visible = visible;
        }
        private void isHidenTaxiFieldForExpand(bool visible)
        {
            txt_taxiDriverMain.Visible = visible;
            lb_taxiDriverMain.Visible = visible;
            txt_taxiModel.Visible = visible;
            lb_taxiModel.Visible = visible;
            txt_taxiNo.Visible = visible;
            lb_taxiNo.Visible = visible;
            txt_taxiModel.Visible = visible;
            lb_taxiModel.Visible = visible;
            cb_taxiGroup.Visible = visible;
            lb_taxiGroup.Visible = visible;
            cb_taxiType.Visible = visible;
            lb_taxiType.Visible = visible;
            bt_AddTaxi.Visible = visible;
            bt_DelTaxi.Visible = visible;
            dp_taxiDateJoin.Visible = visible;
            lb_taxiDateJoin.Visible = visible;
        }

        private void dgv_taxiMouseOver(object sender, EventArgs e)
        {
            isHidenTaxiFieldForExpand(false);
            dgv_taxis.Width = 900;
        }

        private void dgv_taxiMouseLeave(object sender, EventArgs e)
        {
            isHidenTaxiFieldForExpand(true);
            dgv_taxis.Width = 227;
        }

        private void txt_taxiTypeSymbol_Enter(object sender, EventArgs e)
        {
            txt_taxiTypeSymbolTootip = new ToolTip();
            txt_taxiTypeSymbolTootip.Show("Kí Hiệu Xe", txt_taxiTypeSymbol);
        }

        private void txt_taxiTypeSymbol_Leave(object sender, EventArgs e)
        {
            txt_taxiTypeSymbolTootip.Dispose();
        }

        private void txt_taxiTypeSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOrDigitOnly(sender, e);
        }

        private void txt_taxiTypeSymbol_Validating(object sender, CancelEventArgs e)
        {
            StatusTaxiTypeSymbol = validation.isNotNullOrEmpty(sender, errorProvider, "Kí Hiệu Xe");
        }

        private void txt_taxiTypeDescription_Validating(object sender, CancelEventArgs e)
        {
            StatusTaxiTypeDescription = validation.isNotNullOrEmpty(sender, errorProvider, "Mô Tả Loại Xe");
        }

        private void txt_taxiTypeDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOrSpaceOnly(sender, e);
        }

        private void txt_taxiTypeDescription_Leave(object sender, EventArgs e)
        {
            txt_taxiTypeDescriptionTootip.Dispose();
        }

        private void txt_taxiTypeDescription_Enter(object sender, EventArgs e)
        {
            txt_taxiTypeDescriptionTootip = new ToolTip();
            txt_taxiTypeDescriptionTootip.Show("Mô Tả Loại Xe", txt_taxiTypeSymbol);
        }

        private void bt_addTaxiType_Click(object sender, EventArgs e)
        {
            if (StatusTaxiTypeDescription && StatusTaxiTypeSymbol)
            {
                TaxiType taxiType = new TaxiType();
                taxiType.symbol = txt_taxiTypeSymbol.Text;
                taxiType.description = txt_taxiTypeDescription.Text;
                TaxiTypeDTO taxiTypeDTO = new TaxiTypeDTOImpl();
                int signal = taxiTypeDTO.addTaxiType(entitiesContainer, taxiType);
                if (signal == 1)
                {
                    MessageBox.Show("Thêm Taxi Mới Thành Công");
                    taxiTypeModel.showDGV(dgv_taxiType, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Loại Taxi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_branchName_Validating(object sender, CancelEventArgs e)
        {
            StatusBranchName = validation.isNotNullOrEmpty(sender, errorProvider, "Mô Tả Loại Xe");
        }

        private void txt_branchName_Leave(object sender, EventArgs e)
        {
            txt_branchNameTootip.Dispose();
        }

        private void txt_branchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.characterOrSpaceOnly(sender, e);
        }

        private void txt_branchName_Enter(object sender, EventArgs e)
        {
            txt_branchNameTootip = new ToolTip();
            txt_branchNameTootip.Show("Tên Chi Nhánh", txt_branchName);
        }

        private void bt_AddBranch_Click(object sender, EventArgs e)
        {
            if (StatusBranchName)
            {
                Branch branch = new Branch();
                branch.name = txt_branchName.Text;
                branch.created = DateTime.Now;
                BranchDTO branchDTO = new BranchDTOImpl();
                int signal = branchDTO.addBranch(entitiesContainer, branch);
                if (signal == 1)
                {
                    MessageBox.Show("Thêm Taxi Mới Thành Công");
                    branchModel.showDGV(dgv_branches, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Loại Taxi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
