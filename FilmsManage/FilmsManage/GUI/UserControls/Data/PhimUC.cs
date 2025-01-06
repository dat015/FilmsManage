using FilmsAPI.Models;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.Models;
using FilmsManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FilmsManage.GUI.UserControls.Data
{
    public partial class PhimUC : UserControl
    {

        private readonly DangPhimSV _dangPhimSV;
        private DataUC dataUC;
        public PhimUC(DataUC data)
        {
            _dangPhimSV = new DangPhimSV("https://localhost:7085");
            dataUC = data;

            InitializeComponent();
            LoadData();
            LoadDangPhim();
            txtMovieID.Enabled = false;
        }
        public void LoadTitle()
        {
            lwShow.Columns.Clear();

            lwShow.Columns.Add("Mã phim", 100);    // Cột cho "Mã phim"
            lwShow.Columns.Add("Tên Phim", 300);    // Cột cho "Tên Phim"
            lwShow.Columns.Add("Mô tả", 300);       // Cột cho "Mô tả"
            lwShow.Columns.Add("Nội dung", 300);       // Cột cho "Mô tả"
            lwShow.Columns.Add("Thời lượng", 100);  // Cột cho "Thời lượng"
            lwShow.Columns.Add("Ngày khởi chiếu", 150);  // Cột cho "Ngày khởi chiếu"
            lwShow.Columns.Add("Ngày kết thúc", 150);     // Cột cho "Ngày kết thúc"
            lwShow.Columns.Add("Đạo diễn", 250);    // Cột cho "Đạo diễn"

            lwShow.View = View.Details;
        }


        public async void LoadData()
        {
            // Xóa các mục cũ trong ListView
            lwShow.Items.Clear();
            LoadTitle();
            try
            {
                // Lấy dữ liệu từ API
                List<Phim> dangPhimList = await _dangPhimSV.GetAsync<List<Phim>>("/api/Phim");

                // Duyệt qua danh sách phim và thêm vào ListView
                foreach (var phim in dangPhimList)
                {
                    // Tạo mục mới cho mỗi phim
                    ListViewItem item = new ListViewItem(phim.MaPhim.ToString());  // Thêm MaPhim vào cột đầu tiên

                    // Thêm các thông tin còn lại vào các cột tương ứng
                    item.SubItems.Add(phim.TenPhim);
                    item.SubItems.Add(phim.Mota);
                    item.SubItems.Add(phim.NoiDung);
                    item.SubItems.Add(phim.ThoiLuong.ToString());
                    item.SubItems.Add(phim.NgayKc.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(phim.NgayKt.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(phim.TenDaoDien);

                    // Thêm item vào ListView
                    lwShow.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }



        private void dtgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PhimUC_Load(object sender, EventArgs e)
        {

        }

        private void btnUpLoadPictureFilm_Click(object sender, EventArgs e)
        {

        }

        public void ClearCheckBoxes()
        {
            for (int i = pnlLoaiPhim.Controls.Count - 1; i >= 0; i--)
            {
                var control = pnlLoaiPhim.Controls[i];
                if (control is CheckBox)
                {
                    pnlLoaiPhim.Controls.Remove(control);
                }
            }
        }



        private void clbMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public async Task loadLoaiPhim(List<TheLoaiCuaPhim>? loaiCuaPhim)
        {
            // Lấy danh sách các loại phim từ API
            var loaiPhim = await _dangPhimSV.GetAsync<List<LoaiPhim>>("/api/LoaiPhim");

            // Biến đếm để đặt vị trí Top cho các checkbox
            int i = 1;

            foreach (var item in loaiPhim)
            {
                // Tạo checkbox cho từng loại phim
                CheckBox checkbox = new CheckBox
                {
                    Text = item.TenTheLoai, // Hiển thị tên loại phim
                    Top = (i - 1) * 30,    // Khoảng cách giữa các checkbox
                    Left = 10,
                    AutoSize = true,
                    Checked = loaiCuaPhim != null && loaiCuaPhim.Any(l => l.MaTheLoai == item.MaTheLoai), // Đánh dấu nếu trùng
                    Enabled = false
                };

                // Thêm checkbox vào Panel
                pnlLoaiPhim.Controls.Add(checkbox);

                // Tăng biến đếm
                i++;
            }
        }

        private async void lwShow_MouseClick(object sender, MouseEventArgs e)
        {
            ClearCheckBoxes();

            if (lwShow.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn đầu tiên
                ListViewItem selectedItem = lwShow.SelectedItems[0];

                // Chuyển đổi giá trị cột đầu tiên thành int (MaPhim)
                if (int.TryParse(selectedItem.Text, out int MaPhim))
                {
                    Debug.WriteLine("Mã phim: " + MaPhim);

                    try
                    {
                        // Gọi API lấy danh sách thể loại của phim
                        var phim = await _dangPhimSV.GetAsync<Phim>("/api/Phim/" + MaPhim);


                        txtMovieID.Text = phim.MaPhim.ToString();
                        txtMovieName.Text = phim.TenPhim;
                        txtMovieDesc.Text = phim.Mota;
                        txtGhiChu.Text = phim.GhiChu;
                        txtNoiDung.Text = phim.NoiDung;
                        txtMovieLength.Text = phim.ThoiLuong.ToString();
                        dtmMovieStart.Value = DateTime.Parse(phim.NgayKc.ToString());
                        dtmMovieEnd.Value = DateTime.Parse(phim.NgayKt.ToString());
                        txtDoTuoi.Text = phim.DoTuoi.ToString();
                        txtMovieDirector.Text = phim.TenDaoDien;
                        ccbDangPhim.SelectedValue = phim.MaDangPhim;
                        picFilm.Image = LoadImageFromFileSystem(phim.AnhBia);


                        var loaiPhimList = await _dangPhimSV.GetAsync<List<TheLoaiCuaPhim>>("/api/LoaiCuaPhim/" + MaPhim);
                        foreach (var item in loaiPhimList)
                        {
                            Debug.WriteLine(item.MaTheLoai);
                        }
                        await loadLoaiPhim(loaiPhimList);

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Ngoại lệ: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị mã phim không hợp lệ.");
                }
            }

        }

        public async Task LoadDangPhim()
        {
            try
            {
                var listDangPhim = await _dangPhimSV.GetAsync<List<DangPhim>>("/DangPhim");

                if (listDangPhim == null || listDangPhim.Count == 0)
                {
                    MessageBox.Show("Không có dạng phim nào!");
                    return;
                }

                ccbDangPhim.DataSource = listDangPhim;
                ccbDangPhim.ValueMember = "MaDangPhim";
                ccbDangPhim.DisplayMember = "TenDangPhim";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dạng phim: {ex.Message}");
            }
        }
        private Image LoadImageFromFileSystem(string filePath)
        {
            // Kiểm tra nếu đường dẫn hợp lệ và file tồn tại
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                return null;
            }

            try
            {
                // Tải ảnh từ file hệ thống
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                return null;
            }
        }
        private void btnAddMovie_Click_1(object sender, EventArgs e)
        {

            var themSua = dataUC.pnData.Controls.OfType<ChucNang_Phim.Them_Sua>().FirstOrDefault();
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
            themSua = new ChucNang_Phim.Them_Sua("Them", new Phim(), dataUC);
            themSua.Dock = DockStyle.Fill;
            dataUC.pnData.Controls.Add(themSua);
        }




        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lwShow.SelectedItems.Count > 0)
            {
                var themSua = dataUC.pnData.Controls.OfType<ChucNang_Phim.Them_Sua>().FirstOrDefault();

                if (themSua != null)
                {
                    dataUC.pnData.Controls.Remove(themSua);
                    themSua.Dispose();
                }

                ListViewItem selectedItem = lwShow.SelectedItems[0];

                // Chuyển đổi giá trị cột đầu tiên thành `int` (MaPhim)
                if (int.TryParse(selectedItem.Text, out int MaPhim))
                {
                    var phim = await _dangPhimSV.GetAsync<Phim>($"/api/Phim/{MaPhim}");

                    if (phim == null)
                    {
                        MessageBox.Show("Không tìm thấy phim cần cập nhật");
                        return;
                    }

                    foreach (Control control in dataUC.pnData.Controls)
                    {
                        control.Visible = false;
                    }

                    themSua = new ChucNang_Phim.Them_Sua("Sua", phim, dataUC);
                    themSua.Dock = DockStyle.Fill;
                    dataUC.pnData.Controls.Add(themSua);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phim cần cập nhật");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phim để cập nhật");
            }

        }

        private async void btnDeleteMovie_Click_1(object sender, EventArgs e)
        {
            if (lwShow.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lwShow.SelectedItems[0];

                // Chuyển đổi mã phim từ Text của item
                if (int.TryParse(selectedItem.Text, out int MaPhim))
                {
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện xóa nếu người dùng chọn Yes
                        var response = await _dangPhimSV.DeleteAsync($"/api/Phim/{MaPhim}");

                        if (!response)
                        {
                            MessageBox.Show("Không thể xóa phim này! Vui lòng liên hệ với bộ phận IT");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Xoá thành công!");
                            // Xoá thông tin phim khỏi các trường
                            txtMovieID.Text = "";
                            txtMovieName.Text = "";
                            txtMovieDesc.Text = "";
                            txtGhiChu.Text = "";
                            txtNoiDung.Text = "";
                            txtMovieLength.Text = "";
                            txtDoTuoi.Text = "";
                            txtMovieDirector.Text = "";
                            ccbDangPhim.SelectedValue = "";
                            picFilm.Image = LoadImageFromFileSystem("");
                            LoadData();
                        }
                    }

                }


            }
            else
            {
                MessageBox.Show("Hãy chọn một phim để xóa");
                return;
            }
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            var exporter = new ExcelExporter();

            // Gọi hàm ExportListViewToExcel và truyền vào ListView
            exporter.ExportListViewToExcel(lwShow);
        }

       
    }
}
