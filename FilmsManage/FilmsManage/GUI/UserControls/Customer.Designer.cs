﻿namespace FilmsManage.GUI.UserControls
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearchCus = new Button();
            txtSearchCus = new TextBox();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddCustomer = new Button();
            grpCustomer = new GroupBox();
            CusDate = new DateTimePicker();
            nudPoint = new NumericUpDown();
            lblCusID = new Label();
            txtCusID = new TextBox();
            txtCusAddress = new TextBox();
            lblCusINumber = new Label();
            txtCusName = new TextBox();
            lblCusBirth = new Label();
            txtCusPhone = new TextBox();
            lblCusPhone = new Label();
            lblCusPoint = new Label();
            txtCusBirth = new TextBox();
            lblCusAddress = new Label();
            txtCusINumber = new TextBox();
            lblCusName = new Label();
            btnShowCustomer = new Button();
            dtgvCustomer = new DataGridView();
            maKH = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            DiemTichLuy = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnSearchCus
            // 
            btnSearchCus.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchCus.Location = new Point(281, 275);
            btnSearchCus.Margin = new Padding(4);
            btnSearchCus.Name = "btnSearchCus";
            btnSearchCus.Size = new Size(34, 40);
            btnSearchCus.TabIndex = 29;
            btnSearchCus.UseVisualStyleBackColor = true;
            // 
            // txtSearchCus
            // 
            txtSearchCus.Location = new Point(59, 280);
            txtSearchCus.Margin = new Padding(4);
            txtSearchCus.Name = "txtSearchCus";
            txtSearchCus.Size = new Size(202, 31);
            txtSearchCus.TabIndex = 28;
            txtSearchCus.TextChanged += txtSearchCus_TextChanged;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(54, 677);
            btnDeleteCustomer.Margin = new Padding(4);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(261, 70);
            btnDeleteCustomer.TabIndex = 25;
            btnDeleteCustomer.Text = "Xóa";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnUpdateCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(54, 575);
            btnUpdateCustomer.Margin = new Padding(4);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(261, 69);
            btnUpdateCustomer.TabIndex = 26;
            btnUpdateCustomer.Text = "Sửa";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnAddCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(54, 463);
            btnAddCustomer.Margin = new Padding(4);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(261, 71);
            btnAddCustomer.TabIndex = 27;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // grpCustomer
            // 
            grpCustomer.BackColor = Color.Transparent;
            grpCustomer.Controls.Add(btnClear);
            grpCustomer.Controls.Add(CusDate);
            grpCustomer.Controls.Add(nudPoint);
            grpCustomer.Controls.Add(lblCusID);
            grpCustomer.Controls.Add(txtCusID);
            grpCustomer.Controls.Add(txtCusAddress);
            grpCustomer.Controls.Add(lblCusINumber);
            grpCustomer.Controls.Add(txtCusName);
            grpCustomer.Controls.Add(lblCusBirth);
            grpCustomer.Controls.Add(txtCusPhone);
            grpCustomer.Controls.Add(lblCusPhone);
            grpCustomer.Controls.Add(lblCusPoint);
            grpCustomer.Controls.Add(txtCusBirth);
            grpCustomer.Controls.Add(lblCusAddress);
            grpCustomer.Controls.Add(txtCusINumber);
            grpCustomer.Controls.Add(lblCusName);
            grpCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpCustomer.Location = new Point(59, 13);
            grpCustomer.Margin = new Padding(4);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Padding = new Padding(4);
            grpCustomer.Size = new Size(1389, 228);
            grpCustomer.TabIndex = 24;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Thông tin khách hàng";
            // 
            // CusDate
            // 
            CusDate.Location = new Point(285, 166);
            CusDate.Name = "CusDate";
            CusDate.Size = new Size(300, 35);
            CusDate.TabIndex = 6;
            // 
            // nudPoint
            // 
            nudPoint.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPoint.Location = new Point(1218, 56);
            nudPoint.Margin = new Padding(4);
            nudPoint.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPoint.Name = "nudPoint";
            nudPoint.Size = new Size(94, 35);
            nudPoint.TabIndex = 5;
            nudPoint.TextAlign = HorizontalAlignment.Center;
            nudPoint.ValueChanged += nudPoint_ValueChanged;
            // 
            // lblCusID
            // 
            lblCusID.AutoSize = true;
            lblCusID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusID.Location = new Point(157, 62);
            lblCusID.Margin = new Padding(4, 0, 4, 0);
            lblCusID.Name = "lblCusID";
            lblCusID.Size = new Size(99, 26);
            lblCusID.TabIndex = 4;
            lblCusID.Text = "Mã KH:";
            // 
            // txtCusID
            // 
            txtCusID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusID.Location = new Point(292, 58);
            txtCusID.Margin = new Padding(4);
            txtCusID.Name = "txtCusID";
            txtCusID.ReadOnly = true;
            txtCusID.Size = new Size(238, 35);
            txtCusID.TabIndex = 2;
            // 
            // txtCusAddress
            // 
            txtCusAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusAddress.Location = new Point(755, 56);
            txtCusAddress.Margin = new Padding(4);
            txtCusAddress.Name = "txtCusAddress";
            txtCusAddress.Size = new Size(238, 35);
            txtCusAddress.TabIndex = 2;
            // 
            // lblCusINumber
            // 
            lblCusINumber.AutoSize = true;
            lblCusINumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusINumber.Location = new Point(639, 170);
            lblCusINumber.Margin = new Padding(4, 0, 4, 0);
            lblCusINumber.Name = "lblCusINumber";
            lblCusINumber.Size = new Size(88, 26);
            lblCusINumber.TabIndex = 4;
            lblCusINumber.Text = "CCCD:";
            // 
            // txtCusName
            // 
            txtCusName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusName.Location = new Point(292, 111);
            txtCusName.Margin = new Padding(4);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(238, 35);
            txtCusName.TabIndex = 2;
            // 
            // lblCusBirth
            // 
            lblCusBirth.AutoSize = true;
            lblCusBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusBirth.Location = new Point(157, 169);
            lblCusBirth.Margin = new Padding(4, 0, 4, 0);
            lblCusBirth.Name = "lblCusBirth";
            lblCusBirth.Size = new Size(121, 26);
            lblCusBirth.TabIndex = 4;
            lblCusBirth.Text = "Ngày sinh:";
            // 
            // txtCusPhone
            // 
            txtCusPhone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusPhone.Location = new Point(755, 111);
            txtCusPhone.Margin = new Padding(4);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(238, 35);
            txtCusPhone.TabIndex = 2;
            // 
            // lblCusPhone
            // 
            lblCusPhone.AutoSize = true;
            lblCusPhone.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusPhone.Location = new Point(639, 119);
            lblCusPhone.Margin = new Padding(4, 0, 4, 0);
            lblCusPhone.Name = "lblCusPhone";
            lblCusPhone.Size = new Size(81, 26);
            lblCusPhone.TabIndex = 4;
            lblCusPhone.Text = "Số ĐT:";
            // 
            // lblCusPoint
            // 
            lblCusPoint.AutoSize = true;
            lblCusPoint.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusPoint.Location = new Point(1053, 65);
            lblCusPoint.Margin = new Padding(4, 0, 4, 0);
            lblCusPoint.Name = "lblCusPoint";
            lblCusPoint.Size = new Size(157, 26);
            lblCusPoint.TabIndex = 4;
            lblCusPoint.Text = "Điểm tích lũy:";
            // 
            // txtCusBirth
            // 
            txtCusBirth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusBirth.Location = new Point(1320, 62);
            txtCusBirth.Margin = new Padding(4);
            txtCusBirth.Name = "txtCusBirth";
            txtCusBirth.Size = new Size(60, 35);
            txtCusBirth.TabIndex = 2;
            txtCusBirth.Visible = false;
            // 
            // lblCusAddress
            // 
            lblCusAddress.AutoSize = true;
            lblCusAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusAddress.Location = new Point(639, 62);
            lblCusAddress.Margin = new Padding(4, 0, 4, 0);
            lblCusAddress.Name = "lblCusAddress";
            lblCusAddress.Size = new Size(93, 26);
            lblCusAddress.TabIndex = 4;
            lblCusAddress.Text = "Địa chỉ:";
            // 
            // txtCusINumber
            // 
            txtCusINumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusINumber.Location = new Point(755, 169);
            txtCusINumber.Margin = new Padding(4);
            txtCusINumber.Name = "txtCusINumber";
            txtCusINumber.Size = new Size(238, 35);
            txtCusINumber.TabIndex = 2;
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusName.Location = new Point(157, 119);
            lblCusName.Margin = new Padding(4, 0, 4, 0);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(89, 26);
            lblCusName.TabIndex = 4;
            lblCusName.Text = "Họ tên:";
            // 
            // btnShowCustomer
            // 
            btnShowCustomer.AccessibleRole = AccessibleRole.ScrollBar;
            btnShowCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnShowCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowCustomer.ForeColor = Color.White;
            btnShowCustomer.ImageAlign = ContentAlignment.TopCenter;
            btnShowCustomer.Location = new Point(54, 358);
            btnShowCustomer.Margin = new Padding(4);
            btnShowCustomer.Name = "btnShowCustomer";
            btnShowCustomer.Size = new Size(261, 71);
            btnShowCustomer.TabIndex = 23;
            btnShowCustomer.Text = "Xem";
            btnShowCustomer.UseVisualStyleBackColor = false;
            btnShowCustomer.Click += btnShowCustomer_Click;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.AllowUserToAddRows = false;
            dtgvCustomer.AllowUserToDeleteRows = false;
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Columns.AddRange(new DataGridViewColumn[] { maKH, HoTen, NgaySinh, DiaChi, Sdt, CCCD, DiemTichLuy });
            dtgvCustomer.Location = new Point(361, 282);
            dtgvCustomer.Margin = new Padding(4);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.ReadOnly = true;
            dtgvCustomer.RowHeadersWidth = 51;
            dtgvCustomer.RowTemplate.Height = 24;
            dtgvCustomer.Size = new Size(1126, 454);
            dtgvCustomer.TabIndex = 22;
            dtgvCustomer.CellClick += dtgvCustomer_CellClick;
            // 
            // maKH
            // 
            maKH.DataPropertyName = "MaKH";
            maKH.HeaderText = "Mã KH";
            maKH.MinimumWidth = 8;
            maKH.Name = "maKH";
            maKH.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "TenKH";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 8;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 8;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Sdt
            // 
            Sdt.DataPropertyName = "SDT";
            Sdt.HeaderText = "Số điện thoại";
            Sdt.MinimumWidth = 8;
            Sdt.Name = "Sdt";
            Sdt.ReadOnly = true;
            // 
            // CCCD
            // 
            CCCD.DataPropertyName = "CCCD";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 8;
            CCCD.Name = "CCCD";
            CCCD.ReadOnly = true;
            // 
            // DiemTichLuy
            // 
            DiemTichLuy.DataPropertyName = "DiemTichLuy";
            DiemTichLuy.HeaderText = "Điểm tích lũy";
            DiemTichLuy.MinimumWidth = 8;
            DiemTichLuy.Name = "DiemTichLuy";
            DiemTichLuy.ReadOnly = true;
            DiemTichLuy.Visible = false;
            // 
            // btnClear
            // 
            btnClear.AccessibleRole = AccessibleRole.ScrollBar;
            btnClear.BackColor = Color.FromArgb(133, 19, 33);
            btnClear.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.ImageAlign = ContentAlignment.TopCenter;
            btnClear.Location = new Point(1041, 166);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 48);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearchCus);
            Controls.Add(txtSearchCus);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(grpCustomer);
            Controls.Add(btnShowCustomer);
            Controls.Add(dtgvCustomer);
            Name = "Customer";
            Size = new Size(1518, 763);
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchCus;
        private TextBox txtSearchCus;
        private Button btnDeleteCustomer;
        private Button btnUpdateCustomer;
        private Button btnAddCustomer;
        private GroupBox grpCustomer;
        private NumericUpDown nudPoint;
        private Label lblCusID;
        private TextBox txtCusID;
        private TextBox txtCusAddress;
        private Label lblCusINumber;
        private TextBox txtCusName;
        private Label lblCusBirth;
        private TextBox txtCusPhone;
        private Label lblCusPhone;
        private Label lblCusPoint;
        private TextBox txtCusBirth;
        private Label lblCusAddress;
        private TextBox txtCusINumber;
        private Label lblCusName;
        private Button btnShowCustomer;
        private DataGridView dtgvCustomer;
        private DataGridViewTextBoxColumn maKH;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn DiemTichLuy;
        private DateTimePicker CusDate;
        private Button btnClear;
    }
}
