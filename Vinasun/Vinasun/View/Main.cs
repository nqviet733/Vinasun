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
using Vinasun.Enum;

/*Ctrl+Shift+C : Class View
 Ctrl K, T: Call Hierarchy */
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

         ToolTip txt_taxiDriverMainTooltip;
         ToolTip txt_taxiNoTooltip;
         ToolTip txt_taxiGroupTooltip;
         ToolTip txt_taxiTypeTooltip;
         ToolTip txt_taxiDateJoinTooltip;
         ToolTip txt_taxiModelTooltip;

         ToolTip txt_taxiTypeSymbolTooltip;
         ToolTip txt_taxiTypeDescriptionTooltip;

         ToolTip txt_branchNameTooltip;

         ToolTip txt_groupNameTooltip;
         ToolTip txt_groupBranchTooltip;
         ToolTip txt_groupAddressTooltip;

         ToolTip txt_priceRangeStartTooltip;
         ToolTip txt_priceRangeEndTooltip;

         ToolTip txt_driverPercentageRateTooltip;

         ToolTip txt_userRolePermissionNameTooltip;
         ToolTip txt_userRolePermissionDescriptionTooltip;

         EmployeeModel employeeModel;
         TaxiModel taxiModel;
         TaxiTypeModel taxiTypeModel;
         BranchModel branchModel;
         GroupModel groupModel;
         PriceRangeModel priceRangeModel;
         DriverPercentageModel driverPercentageModel;
         UserRoleModel userRoleModel;


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

         private bool statusGroupName;

         public bool StatusGroupName
         {
             get { return statusGroupName; }
             set { statusGroupName = value; }
         }
         private bool statusGroupBranch;

         public bool StatusGroupBranch
         {
             get { return statusGroupBranch; }
             set { statusGroupBranch = value; }
         }

         private bool statusGroupAddress;

         public bool StatusGroupAddress
         {
             get { return statusGroupAddress; }
             set { statusGroupAddress = value; }
         }

         private bool statusPriceRangeStart;

         public bool StatusPriceRangeStart
         {
             get { return statusPriceRangeStart; }
             set { statusPriceRangeStart = value; }
         }
         private bool statusPriceRangeEnd;

         public bool StatusPriceRangeEnd
         {
             get { return statusPriceRangeEnd; }
             set { statusPriceRangeEnd = value; }
         }

         private bool statusDriverPercentageRate;

         public bool StatusDriverPercentageRate
         {
             get { return statusDriverPercentageRate; }
             set { statusDriverPercentageRate = value; }
         }

         private bool statusUserRolePermissionName;

         public bool StatusUserRolePermissionName
         {
             get { return statusUserRolePermissionName; }
             set { statusUserRolePermissionName = value; }
         }
         private bool statusUserRolePermissionDescription;

         public bool StatusUserRolePermissionDescription
         {
             get { return statusUserRolePermissionDescription; }
             set { statusUserRolePermissionDescription = value; }
         }

        public Main()
        {
            InitializeComponent();

            entitiesContainer = new EntityDiagramContainer();
            validation = new Validation();
            eventHandler = new Vinasun.CommonClass.EventHandler();
            employeeModel = new EmployeeModel();
            taxiModel = new TaxiModel();
            taxiTypeModel = new TaxiTypeModel();
            branchModel = new BranchModel();
            userRoleModel = new UserRoleModel();
            driverPercentageModel = new DriverPercentageModel();
            priceRangeModel = new PriceRangeModel();
            groupModel = new GroupModel();

            groupModel.showDGV(dgv_group, entitiesContainer);
            priceRangeModel.showDGV(dgv_priceRange, entitiesContainer);
            employeeModel.showDGV(dgv_entities, entitiesContainer);
            taxiModel.showDGV(dgv_taxis, entitiesContainer);
            taxiTypeModel.showDGV(dgv_taxiType, entitiesContainer);
            branchModel.showDGV(dgv_branches, entitiesContainer);
            driverPercentageModel.showDGV(dgv_driverPercentage, entitiesContainer);
            userRoleModel.showDGV(dgv_userRole, entitiesContainer);

            Dictionary<int, string> branchTypes = branchModel.getBranchTypes(entitiesContainer);
            if (branchTypes.Count != 0)
            {
                cb_groupBranchName.DataSource = new BindingSource(branchTypes, null);
                cb_groupBranchName.DisplayMember = "Value";
                cb_groupBranchName.ValueMember = "Key";
            }

            Dictionary<int, string> taxiTypes = taxiTypeModel.getTaxiTypes(entitiesContainer);
            if (taxiTypes.Count != 0)
            {
                cb_taxiType.DataSource = new BindingSource(taxiTypes, null);
                cb_taxiType.DisplayMember = "Value";
                cb_taxiType.ValueMember = "Key";

                cb_driverPercentageTaxiType.DataSource = new BindingSource(taxiTypes, null);
                cb_driverPercentageTaxiType.DisplayMember = "Value";
                cb_driverPercentageTaxiType.ValueMember = "Key";
            }

            Dictionary<int, string> priceRanges = priceRangeModel.getPriceRanges(entitiesContainer);
            if (priceRanges.Count != 0)
            {
                cb_driverPercentagePriceRange.DataSource = new BindingSource(priceRangeModel.getPriceRanges(entitiesContainer), null);
                cb_driverPercentagePriceRange.DisplayMember = "Value";
                cb_driverPercentagePriceRange.ValueMember = "Key";
            }

            Dictionary<int, string> groupNames = groupModel.getGroupNames(entitiesContainer);
            if (groupNames.Count != 0)
            {
                cb_taxiGroup.DataSource = new BindingSource(groupNames, null);
                cb_taxiGroup.DisplayMember = "Value";
                cb_taxiGroup.ValueMember = "Key";
            }

            Dictionary<int, string> userRoles = userRoleModel.getUserRoles(entitiesContainer);
            if (userRoles.Count != 0)
            {
                lstb_userRole.DataSource = new BindingSource(userRoles, null);
                lstb_userRole.DisplayMember = "Value";
                lstb_userRole.ValueMember = "Key";
                lstb_userRole.SelectedIndex = 1;
            }

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

            this.statusGroupName = false;
            this.StatusGroupBranch = true;
            this.StatusGroupAddress = false;

            this.StatusPriceRangeStart = false;
            this.StatusPriceRangeStart = false;

            this.StatusDriverPercentageRate = false;

            this.StatusUserRolePermissionName = false;
            this.StatusUserRolePermissionDescription = false;
        }

        private void bt_addEmployee_Click(object sender, EventArgs e)
        {
            if (!StatusEmpId)
            {
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
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.Digit);
            //eventHandler.characterOrDigitOnly(sender, e);
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
            eventHandler.keyPressHandler(sender, e, KeyType.Letter); ;
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
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.WhiteSpace); ;
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
            eventHandler.keyPressHandler(sender, e, KeyType.WhiteSpace, KeyType.Digit); ;
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
                GroupDTO groupDTO = new GroupDTOImpl();
                taxi.Group = groupDTO.retrieveGroup(entitiesContainer, int.Parse(cb_taxiGroup.SelectedValue.ToString()));
                TaxiTypeDTO taxiTypeDTO = new TaxiTypeDTOImpl();
                taxi.TaxiType = taxiTypeDTO.retrieveTaxiType(entitiesContainer, int.Parse(cb_taxiType.SelectedValue.ToString()));
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
            txt_taxiDriverMainTooltip = new ToolTip();
            txt_taxiDriverMainTooltip.Show("Mã Tài Chính", txt_taxiDriverMain);
        }

        private void txt_taxiDriverMainLeave(object sender, EventArgs e)
        {
            txt_taxiDriverMainTooltip.Dispose();
        }

        private void txt_taxiDriverMainKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Digit); ;
        }

        private void txt_taxiDriverMainValidator(object sender, CancelEventArgs e)
        {
            StatusTaxiDriverMain = validation.isNotNullOrEmpty(sender, errorProvider, "Mã Tài Chính");
        }

        //Event handler for taxi no
        private void txt_taxiNoKeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.Digit, KeyType.Hyphen); ;
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
            txt_taxiTypeSymbolTooltip = new ToolTip();
            txt_taxiTypeSymbolTooltip.Show("Kí Hiệu Xe", txt_taxiTypeSymbol);
        }

        private void txt_taxiTypeSymbol_Leave(object sender, EventArgs e)
        {
            txt_taxiTypeSymbolTooltip.Dispose();
        }

        private void txt_taxiTypeSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.Digit); ;
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
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.Digit, KeyType.WhiteSpace);
        }

        private void txt_taxiTypeDescription_Leave(object sender, EventArgs e)
        {
            txt_taxiTypeDescriptionTooltip.Dispose();
        }

        private void txt_taxiTypeDescription_Enter(object sender, EventArgs e)
        {
            txt_taxiTypeDescriptionTooltip = new ToolTip();
            txt_taxiTypeDescriptionTooltip.Show("Mô Tả Loại Xe", txt_taxiTypeSymbol);
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
            txt_branchNameTooltip.Dispose();
        }

        private void txt_branchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.Digit, KeyType.WhiteSpace);
        }

        private void txt_branchName_Enter(object sender, EventArgs e)
        {
            txt_branchNameTooltip = new ToolTip();
            txt_branchNameTooltip.Show("Tên Chi Nhánh", txt_branchName);
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

        private void txt_groupName_Enter(object sender, EventArgs e)
        {
            txt_groupNameTooltip = new ToolTip();
            txt_groupNameTooltip.Show("Tên Nhóm", txt_groupName);
        }

        private void txt_groupName_Validating(object sender, CancelEventArgs e)
        {
            StatusGroupName = validation.isNotNullOrEmpty(sender, errorProvider, "Tên Đội");
        }

        private void txt_groupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.Digit, KeyType.WhiteSpace);
        }

        private void txt_groupName_Leave(object sender, EventArgs e)
        {
            txt_groupNameTooltip.Dispose();
        }

        private void bt_AddGroup_Click(object sender, EventArgs e)
        {
            if (StatusGroupName && StatusGroupAddress && statusGroupBranch)
            {
                Group group = new Group();
                group.name = txt_groupName.Text;
                group.address = txt_groupAddress.Text;
                BranchDTO branchDTO = new BranchDTOImpl();
                group.Branch = branchDTO.retrieveBranch(entitiesContainer, int.Parse(cb_groupBranchName.SelectedValue.ToString()));
                GroupDTO groupDTO = new GroupDTOImpl();
                int signal = groupDTO.addGroup(entitiesContainer, group);
                if (signal > 0)
                {
                    MessageBox.Show("Thêm Group Mới Thành Công");
                    groupModel.showDGV(dgv_group, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Tổ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_groupAddress_Validating(object sender, CancelEventArgs e)
        {
            StatusGroupAddress = validation.isNotNullOrEmpty(sender, errorProvider, "Địa Chỉ Tổ");
        }

        private void txt_groupAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(txt_groupAddress, e, KeyType.Letter, KeyType.Digit);
        }

        private void txt_groupAddress_Enter(object sender, EventArgs e)
        {
            txt_groupAddressTooltip = new ToolTip();
            txt_groupAddressTooltip.Show("Địa Chỉ Tổ", txt_groupAddress);
        }

        private void txt_groupAddress_Leave(object sender, EventArgs e)
        {
            txt_groupAddressTooltip.Dispose();
        }

        private void txt_priceRangeStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Digit);
        }

        private void txt_priceRangeStart_Enter(object sender, EventArgs e)
        {
            txt_priceRangeStartTooltip = new ToolTip();
            txt_priceRangeStartTooltip.Show("Giá Bắt Đầu", txt_priceRangeStart);
        }

        private void txt_priceRangeStart_Validating(object sender, CancelEventArgs e)
        {
            StatusPriceRangeStart = validation.isNotNullOrEmpty(sender, errorProvider, "Giá Bắt Đầu");
        }

        private void txt_priceRangeStart_Leave(object sender, EventArgs e)
        {
            txt_priceRangeStartTooltip.Dispose();
        }

        private void txt_priceRangeEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Digit);
        }

        private void txt_priceRangeEnd_Validating(object sender, CancelEventArgs e)
        {
            StatusPriceRangeEnd = validation.isNotNullOrEmpty(sender, errorProvider, "Giá Kết Thúc");
        }

        private void txt_priceRangeEnd_Leave(object sender, EventArgs e)
        {
            txt_priceRangeEndTooltip.Dispose();
        }

        private void txt_priceRangeEnd_Enter(object sender, EventArgs e)
        {
            txt_priceRangeEndTooltip = new ToolTip();
            txt_priceRangeEndTooltip.Show("Giá Kết Thúc", txt_priceRangeEnd);
        }

        private void bt_addPriceRange_Click(object sender, EventArgs e)
        {
            if (StatusPriceRangeEnd && StatusPriceRangeStart)
            {
                PriceRange priceRange = new PriceRange();
                priceRange.start = int.Parse(txt_priceRangeStart.Text);
                priceRange.end = int.Parse(txt_priceRangeEnd.Text);
                PriceRangeDTO priceRangeDTO = new PriceRangeDTOImpl();
                int signal = priceRangeDTO.addPriceRange(entitiesContainer, priceRange);
                if (signal > 0)
                {
                    MessageBox.Show("Thêm Giá Mới Thành Công");
                    priceRangeModel.showDGV(dgv_priceRange, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Tổ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_addDriverPercentage_Click(object sender, EventArgs e)
        {
            if (StatusDriverPercentageRate)
            {
                DriverPercentange driverPercentage = new DriverPercentange();

                driverPercentage.percent = int.Parse(txt_driverPercentageRate.Text);
                PriceRangeDTO priceRangeDTO = new PriceRangeDTOImpl();
                driverPercentage.PriceRange = priceRangeDTO.retrievePriceRange(entitiesContainer, int.Parse(cb_driverPercentagePriceRange.SelectedValue.ToString()));
                TaxiTypeDTO taxiTypeDTO = new TaxiTypeDTOImpl();
                driverPercentage.TaxiType = taxiTypeDTO.retrieveTaxiType(entitiesContainer, int.Parse(cb_driverPercentageTaxiType.SelectedValue.ToString()));
                
                DriverPercentangeDTO driverPercentageDTO = new DriverPercentangeDTOImpl();
                int signal = driverPercentageDTO.addDriverPercentange(entitiesContainer, driverPercentage);
                if (signal > 0)
                {
                    MessageBox.Show("Thêm Giá Tỉ Lệ Giá Cho Taxi Thành Công");
                    driverPercentageModel.showDGV(dgv_driverPercentage, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Tổ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_driverPercentageRate_Validating(object sender, CancelEventArgs e)
        {
            StatusDriverPercentageRate = validation.isNotNullOrEmpty(sender, errorProvider, "Giá Bắt Đầu");
        }

        private void txt_driverPercentageRate_Enter(object sender, EventArgs e)
        {
            txt_driverPercentageRateTooltip = new ToolTip();
            txt_driverPercentageRateTooltip.Show("Tỉ Lệ % chia cho tài xế", txt_driverPercentageRate);
        }

        private void txt_driverPercentageRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Digit);
        }

        private void txt_driverPercentageRate_Leave(object sender, EventArgs e)
        {
            txt_driverPercentageRateTooltip.Dispose();
        }

        private void txt_userRoleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Letter);
        }

        private void txt_userRoleName_Validating(object sender, CancelEventArgs e)
        {
            StatusUserRolePermissionName = validation.isNotNullOrEmpty(sender, errorProvider, "Tên Quyền");
        }

        private void txt_userRoleName_Leave(object sender, EventArgs e)
        {
            txt_userRolePermissionNameTooltip.Dispose();
        }

        private void txt_userRoleName_Enter(object sender, EventArgs e)
        {
            txt_userRolePermissionNameTooltip = new ToolTip();
            txt_userRolePermissionNameTooltip.Show("Tên Quyền", txt_userRolePermissionName);
        }

        private void txt_userRoleDescription_Enter(object sender, EventArgs e)
        {
            txt_userRolePermissionDescriptionTooltip = new ToolTip();
            txt_userRolePermissionDescriptionTooltip.Show("Mô Tả Tên Quyền", txt_userRolePermissionDescription);
        }

        private void txt_userRoleDescription_Validating(object sender, CancelEventArgs e)
        {
            StatusUserRolePermissionDescription = validation.isNotNullOrEmpty(sender, errorProvider, "Mô Tả Tên Quyền");
        }

        private void txt_userRoleDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventHandler.keyPressHandler(sender, e, KeyType.Letter, KeyType.WhiteSpace);
        }

        private void txt_userRoleDescription_Leave(object sender, EventArgs e)
        {
            txt_userRolePermissionDescriptionTooltip.Dispose();
        }

        private void bt_addUserRole_Click(object sender, EventArgs e)
        {
            if (StatusUserRolePermissionName && StatusUserRolePermissionDescription)
            {
                UserRole userRole = new UserRole();

                userRole.permission = txt_userRolePermissionName.Text;
                userRole.description = txt_userRolePermissionDescription.Text;
                UserRoleDTO userRoleDTO = new UserRoleDTOImpl();
                int signal = userRoleDTO.addUserRole(entitiesContainer, userRole);
                if (signal > 0)
                {
                    MessageBox.Show("Thêm Quyền Mới Thành Công");
                    userRoleModel.showDGV(dgv_userRole, entitiesContainer);
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Quyền Mới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstb_userRole_MouseHover(object sender, EventArgs e)
        {
            lstb_userRole.Width = 200;
            lstb_userRole.Height = 100;
        }

        private void lstb_userRole_MouseLeave(object sender, EventArgs e)
        {
            lstb_userRole.Width = 113;
            lstb_userRole.Height = 20;
        }

    }
}
