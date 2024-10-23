namespace FilmsManage.frmAdminUserControls.DataUserControl
{
    partial class DoanhthuUC
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
            lalSelectMovie = new Label();
            cbbSelectMovie = new ComboBox();
            label1 = new Label();
            dateFromDate = new DateTimePicker();
            lblDenNgay = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnThongKe = new Button();
            btnBaoCao = new Button();
            dtgvDoanhThu = new DataGridView();
            lblTongDoanhThu = new Label();
            txtDoanhThu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // lalSelectMovie
            // 
            lalSelectMovie.AutoSize = true;
            lalSelectMovie.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lalSelectMovie.Location = new Point(92, 50);
            lalSelectMovie.Name = "lalSelectMovie";
            lalSelectMovie.Size = new Size(125, 26);
            lalSelectMovie.TabIndex = 0;
            lalSelectMovie.Text = "Chọn phim";
            // 
            // cbbSelectMovie
            // 
            cbbSelectMovie.FormattingEnabled = true;
            cbbSelectMovie.Location = new Point(261, 43);
            cbbSelectMovie.Name = "cbbSelectMovie";
            cbbSelectMovie.Size = new Size(393, 33);
            cbbSelectMovie.TabIndex = 1;
            cbbSelectMovie.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 102);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày";
            // 
            // dateFromDate
            // 
            dateFromDate.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dateFromDate.Format = DateTimePickerFormat.Custom;
            dateFromDate.Location = new Point(190, 97);
            dateFromDate.Name = "dateFromDate";
            dateFromDate.Size = new Size(191, 31);
            dateFromDate.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(411, 102);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(88, 25);
            lblDenNgay.TabIndex = 4;
            lblDenNgay.Tag = "";
            lblDenNgay.Text = "Đến ngày";
            lblDenNgay.Click += lblDenNgay_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(505, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(690, 97);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(112, 34);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Location = new Point(841, 97);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(112, 34);
            btnBaoCao.TabIndex = 7;
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // dtgvDoanhThu
            // 
            dtgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDoanhThu.Location = new Point(92, 145);
            dtgvDoanhThu.Name = "dtgvDoanhThu";
            dtgvDoanhThu.RowHeadersWidth = 62;
            dtgvDoanhThu.Size = new Size(861, 348);
            dtgvDoanhThu.TabIndex = 8;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongDoanhThu.Location = new Point(561, 514);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(173, 26);
            lblTongDoanhThu.TabIndex = 9;
            lblTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.Location = new Point(740, 514);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.Size = new Size(213, 31);
            txtDoanhThu.TabIndex = 10;
            // 
            // DoanhthuUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtDoanhThu);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(dtgvDoanhThu);
            Controls.Add(btnBaoCao);
            Controls.Add(btnThongKe);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDenNgay);
            Controls.Add(dateFromDate);
            Controls.Add(label1);
            Controls.Add(cbbSelectMovie);
            Controls.Add(lalSelectMovie);
            Name = "DoanhthuUC";
            Size = new Size(1006, 571);
            ((System.ComponentModel.ISupportInitialize)dtgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lalSelectMovie;
        private ComboBox cbbSelectMovie;
        private Label label1;
        private DateTimePicker dateFromDate;
        private Label lblDenNgay;
        private DateTimePicker dateTimePicker1;
        private Button btnThongKe;
        private Button btnBaoCao;
        private DataGridView dtgvDoanhThu;
        private Label lblTongDoanhThu;
        private TextBox txtDoanhThu;
    }
}
