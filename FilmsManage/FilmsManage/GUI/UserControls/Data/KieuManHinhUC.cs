﻿using ClosedXML.Excel;
using FilmsAPI.Models;
using FilmsManage.Models;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class KieuManHinhUC : UserControl
    {
        private readonly DangPhimSV _kieuManHinh;

        public KieuManHinhUC()
        {
            InitializeComponent();
            _kieuManHinh = new DangPhimSV("https://localhost:7085");
            LoadData();
            dtgvScreenType.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TitleId",
                HeaderText = "Mã màn hình",
                DataPropertyName = "MaManHinh" // Tên trường chính xác trong dữ liệu
            });

            dtgvScreenType.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GenreName",
                HeaderText = "Tên màn hình",
                DataPropertyName = "TenManHinh" // Tên trường chính xác trong dữ liệu
            });
            txtScreenTypeID.Enabled = false;

            // Thêm sự kiện CellClick
            dtgvScreenType.CellClick += DtgvFormat_CellClick;
        }

        public async Task LoadData()
        {
            try
            {
                // Gọi API để lấy danh sách DangPhim
                List<ManHinh> manHinhList = await _kieuManHinh.GetAsync<List<ManHinh>>("api/ManHinh");

                var manHinhDisplayList = manHinhList.Select(d => new
                {
                    d.MaManHinh,
                    d.TenManHinh
                }).ToList();

                dtgvScreenType.DataSource = manHinhDisplayList;
                dtgvScreenType.Refresh();
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
                DataGridViewRow selectedRow = dtgvScreenType.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào các ô nhập liệu
                txtScreenTypeID.Text = selectedRow.Cells["TitleId"].Value?.ToString();
                txtScreenTypeName.Text = selectedRow.Cells["GenreName"].Value?.ToString();
            }
        }

        private async void btnInsertScreenType_Click_1(object sender, EventArgs e)
        {
           
        }

        private async void btnUpdateScreenType_Click_1(object sender, EventArgs e)
        {
            
        }

        private async void btnDeleteScreenType_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
           
        }

        private async void btnInsertScreenType_Click(object sender, EventArgs e)
        {
            string newScreenTypeName = txtScreenTypeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(newScreenTypeName))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(newScreenTypeName, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình hợp lệ (không có ký tự đặc biệt).");
                return;
            }

            try
            {
                // Gọi API để kiểm tra danh sách tên màn hình
                List<ManHinh> manHinhList = await _kieuManHinh.GetAsync<List<ManHinh>>("api/ManHinh");

                bool isDuplicateName = manHinhList.Any(mh => mh.TenManHinh.Equals(newScreenTypeName, StringComparison.OrdinalIgnoreCase));

                if (isDuplicateName)
                {
                    MessageBox.Show("Tên màn hình đã tồn tại. Vui lòng nhập một tên khác.");
                    return;
                }

                // Nếu tên không trùng, thực hiện thêm mới
                var manHinh = new ManHinh
                {
                    TenManHinh = newScreenTypeName
                };

                string endpoint = "/api/ManHinh";
                var response = await _kieuManHinh.PostAsync<Models.ApiRespone>(endpoint, manHinh);

                if (response != null) // Giả sử ApiRespone có thuộc tính xác định thành công
                {
                    MessageBox.Show("Thêm màn hình thành công!");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể thêm màn hình. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnUpdateScreenType_Click(object sender, EventArgs e)
        {
            string newScreenTypeName = txtScreenTypeName.Text.Trim();
            int.TryParse(txtScreenTypeID.Text, out int maManHinh);

            if (string.IsNullOrWhiteSpace(newScreenTypeName))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(newScreenTypeName, @"^[\w\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập tên màn hình hợp lệ.");
                return;
            }

            try
            {
                // Gọi API kiểm tra xem tên màn hình mới có tồn tại không
                List<ManHinh> manHinhList = await _kieuManHinh.GetAsync<List<ManHinh>>("api/ManHinh");

                bool isDuplicateName = manHinhList.Any(mh => mh.TenManHinh.Equals(newScreenTypeName, StringComparison.OrdinalIgnoreCase)
                                                             && mh.MaManHinh != maManHinh);

                if (isDuplicateName)
                {
                    MessageBox.Show("Tên màn hình đã tồn tại. Vui lòng nhập một tên khác.");
                    return;
                }

                // Nếu không trùng, tiếp tục thực hiện cập nhật
                var manHinh = new { TenManHinh = newScreenTypeName }; // Chỉ gửi tên màn hình
                string endpoint = $"/api/ManHinh/{maManHinh}";
                var response = await _kieuManHinh.PutAsync<string>(endpoint, manHinh);

                if (!string.IsNullOrEmpty(response))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    await LoadData(); // Tải lại dữ liệu sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Không có phản hồi từ API.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Lỗi yêu cầu: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnDeleteScreenType_Click(object sender, EventArgs e)
        {
            string genreId = txtScreenTypeID.Text;

            if (string.IsNullOrWhiteSpace(genreId))
            {
                MessageBox.Show("Vui lòng nhập mã màn hình để xóa.");
                return;
            }

            try
            {
                string endpoint = $"/api/ManHinh/{genreId}"; // Chỉnh sửa endpoint nếu cần
                var response = await _kieuManHinh.DeleteAsync(endpoint); // Gọi API Delete

                if (response) // Kiểm tra nếu việc xóa thành công
                {
                    MessageBox.Show("Màn hình đã được xóa thành công.");
                    await LoadData(); // Tải lại dữ liệu sau khi xóa thành công
                }
                else
                {
                    MessageBox.Show("Xóa màn hình thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo SaveFileDialog để người dùng chọn vị trí lưu file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                    saveFileDialog.FileName = "ManHinh"; // Tên mặc định cho file Excel

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Tạo workbook và worksheet
                        var workbook = new XLWorkbook();
                        var worksheet = workbook.Worksheets.Add("Màn Hình");

                        // Thêm header vào worksheet (dòng đầu tiên là tên cột)
                        for (int colIndex = 0; colIndex < dtgvScreenType.Columns.Count; colIndex++)
                        {
                            worksheet.Cell(1, colIndex + 1).Value = dtgvScreenType.Columns[colIndex].HeaderText;
                        }

                        // Thêm dữ liệu vào worksheet, bắt đầu từ dòng thứ 2
                        for (int rowIndex = 0; rowIndex < dtgvScreenType.Rows.Count; rowIndex++)
                        {
                            for (int colIndex = 0; colIndex < dtgvScreenType.Columns.Count; colIndex++)
                            {
                                worksheet.Cell(rowIndex + 2, colIndex + 1).Value = dtgvScreenType.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                            }
                        }

                        // Lưu workbook vào file được chọn
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Dữ liệu đã được xuất thành công ra file Excel.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xuất file: {ex.Message}");
            }
        }
    }
}
