﻿using FilmsAPI.Models;
using FilmsManage.Services;
using FilmsManage.Models;
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
	public partial class DinhDangPhimUC : UserControl
	{
		private readonly DangPhimSV _dangPhimSV;
		public DinhDangPhimUC()
		{
			InitializeComponent();
			_dangPhimSV = new DangPhimSV("https://localhost:7085");
			LoadData();
			dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "TitleId",
				HeaderText = "Mã định dạng",
				DataPropertyName = "MaDangPhim" // Tên trường chính xác trong dữ liệu
			});

			dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "TitleName",
				HeaderText = "Tên dạng phim",
				DataPropertyName = "TenDangPhim" // Tên trường chính xác trong dữ liệu
			});

			dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "MaMH",
				HeaderText = "Mã màn hình",
				DataPropertyName = "MaManHinh" // Tên trường chính xác trong dữ liệu
			});

			dtgvFormat.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "TenMH",
				HeaderText = "Tên màn hình",
				DataPropertyName = "TenManHinh" // Tên trường chính xác trong dữ liệu
			});
			// Thêm sự kiện CellClick
			dtgvFormat.CellClick += DtgvFormat_CellClick;
			cbMaMH.SelectedIndexChanged += cbMaMH_SelectedIndexChanged;
			txtFormatID.Enabled = false;
			txtTenMh.Enabled = false;
		}

		public async Task LoadData()
		{
			try
			{
				// Gọi API để lấy danh sách DangPhim
				List<DangPhim> dangPhimList = await _dangPhimSV.GetAsync<List<DangPhim>>("DangPhim");

				var dangPhimListDisplay = dangPhimList.Select(d => new
				{
					d.MaDangPhim,
					d.TenDangPhim,
					d.MaManHinh,
					TenManHinh = d.MaManHinhNavigation?.TenManHinh,
				}).ToList();

				// Binding DataGridView
				dtgvFormat.DataSource = dangPhimListDisplay;
				dtgvFormat.Refresh();

				// Gọi API để lấy danh sách Màn Hình (điều chỉnh theo API của bạn)
				List<ManHinh> manHinhList = await _dangPhimSV.GetAsync<List<ManHinh>>("/api/ManHinh");

				// Bind dữ liệu vào ComboBox
				cbMaMH.DataSource = manHinhList;
				cbMaMH.DisplayMember = "MaManHinh"; // Hiển thị tên màn hình
				cbMaMH.ValueMember = "MaManHinh";   // Dùng mã màn hình làm giá trị
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
			}
		}

		private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Lấy giá trị MaManHinh được chọn
			var selectedMaManHinh = cbMaMH.SelectedValue?.ToString();

			// Hiển thị TenManHinh tương ứng
			var selectedManHinh = (ManHinh)cbMaMH.SelectedItem; // Lấy đối tượng ManHinh từ ComboBox
			if (selectedManHinh != null)
			{
				txtTenMh.Text = selectedManHinh.TenManHinh; // Hiển thị tên màn hình trong TextBox
			}
		}


		private void DtgvFormat_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
			{
				DataGridViewRow selectedRow = dtgvFormat.Rows[e.RowIndex];


                // Gán giá trị từ hàng được chọn vào các ô nhập liệu
                txtFormatID.Text = selectedRow.Cells["TitleId"].Value?.ToString(); // Mã định dạng
                txtTenDangPhim.Text = selectedRow.Cells["TitleName"].Value?.ToString(); // Mã định dạng
                cbMaMH.Text = selectedRow.Cells["MaMH"].Value?.ToString();
                txtTenMh.Text = selectedRow.Cells["TenMH"].Value?.ToString(); // Mã định dạng
            }
        }
        private void dtgvFormat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowFormat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnInsertFormat_Click(object sender, EventArgs e)
        {
            string genreName = txtTenDangPhim.Text;
            int.TryParse(cbMaMH.Text, out int maManHinh);


			if (string.IsNullOrWhiteSpace(genreName))
			{
				MessageBox.Show("Vui lòng nhập tên dạng phim.");
				return;
			}

			if (!System.Text.RegularExpressions.Regex.IsMatch(genreName, @"^[a-zA-Z0-9\s]+$"))
			{
				MessageBox.Show("Vui lòng nhập tên dạng phim hợp lệ (không có ký tự đặc biệt).");
				return;
			}

			var dangPhim = new DangPhim
			{
				TenDangPhim = genreName,
				MaManHinh = maManHinh
			};

			try
			{
				string endpoint = "/DangPhim";
				var response = await _dangPhimSV.PostAsync<Models.ApiRespone>(endpoint, dangPhim);

                if (response != null)
                {
                    if (!string.IsNullOrWhiteSpace(response.Message))
                    {
                        MessageBox.Show(response.Message);
                        await LoadData(); // Tải lại dữ liệu sau khi thêm thành công
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi không chứa thông báo.");
                    }
                }
                else
                {
                    MessageBox.Show("Phản hồi null từ API.");
                }
            }
            catch (Exception ex)
            {
                // Log lỗi chi tiết
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}\n{ex.StackTrace}");
            }

        }

        private async void btnUpdateFormat_Click(object sender, EventArgs e)
        {
            string tenDP = txtTenDangPhim.Text.Trim();
            int.TryParse(cbMaMH.Text, out int maManHinh);
            int.TryParse(txtFormatID.Text, out int maDangPhim);
			if (string.IsNullOrWhiteSpace(tenDP))
			{
				MessageBox.Show("Vui lòng nhập tên dạng phim.");
				return;
			}

			if (!System.Text.RegularExpressions.Regex.IsMatch(tenDP, @"^[a-zA-Z0-9\s]+$"))
			{
				MessageBox.Show("Vui lòng nhập tên dạng phim hợp lệ (không có ký tự đặc biệt).");
				return;
			}

			var dangPhim = new DangPhim
			{
				MaDangPhim = maDangPhim,
				TenDangPhim = tenDP,
				MaManHinh = maManHinh
			};

			try
			{
				string endpoint = "/DangPhim"; // Đảm bảo rằng endpoint là đúng
				var response = await _dangPhimSV.PutAsync<Models.ApiRespone>(endpoint, dangPhim);

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
            var exporter = new ExcelExporter();
            exporter.ExportDataGridViewToExcel(dtgvFormat);
        }
    }

}
