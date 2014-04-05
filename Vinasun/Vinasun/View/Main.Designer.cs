namespace Vinasun.View
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.collectionDataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxiType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionDataGridView
            // 
            this.collectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.taxiType,
            this.moneySum,
            this.driver,
            this.kmSum,
            this.created,
            this.tripSum,
            this.Group});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.collectionDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.collectionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.collectionDataGridView.Location = new System.Drawing.Point(68, 127);
            this.collectionDataGridView.Name = "collectionDataGridView";
            this.collectionDataGridView.Size = new System.Drawing.Size(586, 150);
            this.collectionDataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            // 
            // taxiType
            // 
            this.taxiType.DataPropertyName = "taxiType";
            this.taxiType.HeaderText = "Loại Taxi";
            this.taxiType.Name = "taxiType";
            // 
            // moneySum
            // 
            this.moneySum.DataPropertyName = "moneySum";
            this.moneySum.HeaderText = "Tổng Tiền";
            this.moneySum.Name = "moneySum";
            // 
            // driver
            // 
            this.driver.DataPropertyName = "driver";
            this.driver.HeaderText = "Tài Xế";
            this.driver.Name = "driver";
            // 
            // kmSum
            // 
            this.kmSum.DataPropertyName = "kmSum";
            this.kmSum.HeaderText = "Tổng KM";
            this.kmSum.Name = "kmSum";
            // 
            // created
            // 
            this.created.DataPropertyName = "created";
            this.created.HeaderText = "Ngày Nhập";
            this.created.Name = "created";
            // 
            // tripSum
            // 
            this.tripSum.DataPropertyName = "tripSum";
            this.tripSum.HeaderText = "Tổng Cước";
            this.tripSum.Name = "tripSum";
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Tên Đội";
            this.Group.Name = "Group";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(899, 481);
            this.Controls.Add(this.collectionDataGridView);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX collectionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxiType;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn created;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;


    }
}