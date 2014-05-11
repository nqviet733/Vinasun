namespace Vinasun.View
{
    partial class AddListEntities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAddListEntities = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.gender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderAddEntities = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddListEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddEntities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddListEntities
            // 
            this.dataGridViewAddListEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddListEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstName,
            this.lastName,
            this.dateOfBirth,
            this.gender,
            this.phoneNumber,
            this.email,
            this.group,
            this.Position,
            this.address});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddListEntities.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewAddListEntities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewAddListEntities.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAddListEntities.Name = "dataGridViewAddListEntities";
            this.dataGridViewAddListEntities.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewAddListEntities.Size = new System.Drawing.Size(1153, 327);
            this.dataGridViewAddListEntities.TabIndex = 0;
            this.dataGridViewAddListEntities.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellValidatedEvent);
            this.dataGridViewAddListEntities.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.cellValidatingEvent);
            this.dataGridViewAddListEntities.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.columnAddedEvent);
            this.dataGridViewAddListEntities.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddListEntities_RowLeave);
            this.dataGridViewAddListEntities.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAddListEntities_RowsAdded);
            this.dataGridViewAddListEntities.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewAddListEntities_RowValidating);
            // 
            // id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Mã Nhân Viên";
            this.id.Name = "id";
            // 
            // firstName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.firstName.DefaultCellStyle = dataGridViewCellStyle2;
            this.firstName.HeaderText = "Tên";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lastName.DefaultCellStyle = dataGridViewCellStyle3;
            this.lastName.HeaderText = "Họ";
            this.lastName.Name = "lastName";
            // 
            // dateOfBirth
            // 
            // 
            // 
            // 
            this.dateOfBirth.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateOfBirth.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.dateOfBirth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateOfBirth.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateOfBirth.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateOfBirth.HeaderText = "Ngày Sinh";
            this.dateOfBirth.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            // 
            // 
            // 
            this.dateOfBirth.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateOfBirth.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateOfBirth.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dateOfBirth.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateOfBirth.MonthCalendar.DisplayMonth = new System.DateTime(2014, 4, 1, 0, 0, 0, 0);
            this.dateOfBirth.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateOfBirth.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateOfBirth.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateOfBirth.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới Tính(Nam)";
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gender.Width = 110;
            // 
            // phoneNumber
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phoneNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.phoneNumber.HeaderText = "Di Động";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // email
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.email.DefaultCellStyle = dataGridViewCellStyle6;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // group
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.group.DefaultCellStyle = dataGridViewCellStyle7;
            this.group.HeaderText = "Tổ";
            this.group.Name = "group";
            this.group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Position
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Position.DefaultCellStyle = dataGridViewCellStyle8;
            this.Position.HeaderText = "Chức Vụ";
            this.Position.Name = "Position";
            this.Position.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // address
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.address.DefaultCellStyle = dataGridViewCellStyle9;
            this.address.HeaderText = "Địa Chỉ";
            this.address.Name = "address";
            this.address.Width = 200;
            // 
            // errorProviderAddEntities
            // 
            this.errorProviderAddEntities.ContainerControl = this;
            // 
            // AddListEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 412);
            this.Controls.Add(this.dataGridViewAddListEntities);
            this.Name = "AddListEntities";
            this.Text = "AddListEntities";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddListEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddEntities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewAddListEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewComboBoxColumn group;
        private System.Windows.Forms.DataGridViewComboBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.ErrorProvider errorProviderAddEntities;
    }
}