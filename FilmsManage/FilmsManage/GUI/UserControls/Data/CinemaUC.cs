﻿using ClosedXML.Excel;
using FilmsAPI.Models;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class CinemaUC : UserControl
    {
        private DataUC dataUC;
        private readonly DangPhimSV _PhongChieu;
        public CinemaUC(DataUC data)
        {
            _PhongChieu = new DangPhimSV("https://localhost:7085");
            InitializeComponent();
            dataUC = data;
            LoadData();
            LoadComboBoxData();
            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhong",
                HeaderText = "Mã phòng",
                DataPropertyName = "MaPhongChieu" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhong",
                HeaderText = "Tên phòng chiếu",
                DataPropertyName = "TenPhongChieu" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tenManHinh",
                HeaderText = "Tên màn hình",
                DataPropertyName = "TenManHinh" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soChoNgoi",
                HeaderText = "Số chỗ ngồi",
                DataPropertyName = "SoGhe" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soHangGhe",
                HeaderText = "Số hàng ghế",
                DataPropertyName = "SoHangGhe" // Tên trường chính xác trong dữ liệu
            });

            dtgvCinema.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soGheMoiHang",
                HeaderText = "Số ghế mỗi hàng",
                DataPropertyName = "SoGheMotHang" // Tên trường chính xác trong dữ liệu
            });
            // Thêm sự kiện CellClick
            dtgvCinema.CellClick += DtgvFormat_CellClick;
            txtCinemaID.Enabled = false;
            txtNumberOfRows.Visible = false;
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<PhongChieu> phongChieuList = await _PhongChieu.GetAsync<List<PhongChieu>>("/api/PhongChieu");

                var phongChieuDisplayList = phongChieuList.Select(d => new
                {
                    d.MaPhongChieu,
                    d.TenPhongChieu,
                    d.SoGhe,
                    TenManHinh = d.MaManHinhNavigation?.TenManHinh,
                    d.SoHangGhe,
                    d.SoGheMotHang,
                }).ToList();

                dtgvCinema.DataSource = phongChieuDisplayList;
                dtgvCinema.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                DataGridViewRow selectedRow = dtgvCinema.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào các ô nhập liệu
                txtCinemaID.Text = selectedRow.Cells["MaPhong"].Value?.ToString();
                txtCinemaName.Text = selectedRow.Cells["TenPhong"].Value?.ToString();
                cboCinemaScreenType.Text = selectedRow.Cells["tenManHinh"].Value?.ToString();
                txtCinemaSeats.Text = selectedRow.Cells["soChoNgoi"].Value?.ToString();
                txtNumberOfRows.Text = selectedRow.Cells["soHangGhe"].Value?.ToString();
                txtSeatsPerRow.Text = selectedRow.Cells["soGheMoiHang"].Value?.ToString();
            }
        }

        public async Task LoadComboBoxData()
        {
            try
            {
                // Lấy danh sách phòng chiếu từ API
                var manHinh = await _PhongChieu.GetAsync<List<ManHinh>>("/api/ManHinh");



                cboCinemaScreenType.DataSource = manHinh;
                cboCinemaScreenType.DisplayMember = "TenManHinh";
                cboCinemaScreenType.ValueMember = "MaManHinh";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu ComboBox: {ex.Message}");
            }
        }

        private async void btnInsertCinema_Click(object sender, EventArgs e)
        {
            var themSua = dataUC.pnData.Controls.OfType<ChucNang_PhongChieu.ThemSua>().FirstOrDefault();
            if (themSua != null)
            {
                dataUC.pnData.Controls.Remove(themSua);
                themSua.Dispose();
            }

            Debug.WriteLine("ok");

            // Ẩn tất cả các control khác
            foreach (Control control in dataUC.pnData.Controls)
            {
                control.Visible = false;
            }

            // Khởi tạo control Them_Sua cho "Sửa"
            themSua = new ChucNang_PhongChieu.ThemSua("Them", new PhongChieu(), dataUC);
            themSua.Dock = DockStyle.Fill;
            dataUC.pnData.Controls.Add(themSua);
        }

        private async void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            string tenPC = txtCinemaName.Text.Trim();
            string tenMH = cboCinemaScreenType.Text.Trim();

            if (!int.TryParse(txtCinemaID.Text, out int maPC))
            {
                MessageBox.Show("Số ghế không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtCinemaSeats.Text, out int soGhe))
            {
                MessageBox.Show("Số ghế không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (!int.TryParse(txtSeatsPerRow.Text, out int soGheMoiHang))
            {
                MessageBox.Show("Số ghế mỗi hàng không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tenPC))
            {
                MessageBox.Show("Vui lòng nhập tên phòng chiếu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tenMH))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }

            var phongChieu = new PhongChieu
            {
                MaPhongChieu = maPC,
                TenPhongChieu = tenPC,
                MaManHinhNavigation = new ManHinh
                {
                    TenManHinh = tenMH
                },
                SoGhe = soGhe,
                SoGheMotHang = soGheMoiHang
            };

            try
            {
                string endpoint = "api/PhongChieu"; // Đảm bảo rằng endpoint là đúng
                var response = await _PhongChieu.PutAsync<Models.ApiRespone>(endpoint, phongChieu);

                MessageBox.Show(response.Message);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtgvCinema.DataSource is not null)
            {
                // Chuyển dữ liệu từ DataGridView sang DataTable
                var dataTable = new DataTable();

                foreach (DataGridViewColumn column in dtgvCinema.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in dtgvCinema.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var dataRow = dataTable.NewRow();
                        foreach (DataGridViewColumn column in dtgvCinema.Columns)
                        {
                            dataRow[column.HeaderText] = row.Cells[column.Name].Value ?? DBNull.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                // Chọn nơi lưu file Excel
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = "DanhSachPhongChieu.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Dùng ClosedXML để xuất ra file Excel với định dạng đẹp
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.AddWorksheet("Danh sách phòng chiếu");

                            // Chèn dữ liệu từ DataTable vào Excel
                            worksheet.Cell(1, 1).InsertTable(dataTable);

                            // Định dạng tiêu đề cột (tô đậm, căn giữa, nền màu)
                            var headerRow = worksheet.Range(worksheet.Cell(1, 1), worksheet.Cell(1, dataTable.Columns.Count));
                            headerRow.Style.Font.Bold = true;
                            headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            headerRow.Style.Fill.BackgroundColor = XLColor.LightGray;

                            // Căn chỉnh số liệu
                            for (int col = 1; col <= dataTable.Columns.Count; col++)
                            {
                                worksheet.Column(col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // Lưu file Excel
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
