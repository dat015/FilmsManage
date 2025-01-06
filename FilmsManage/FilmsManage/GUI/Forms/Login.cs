using FilmsManage.DTO;
using FilmsManage.GUI.Forms;
using FilmsManage.GUI.Forms.BanVe_Form;
using FilmsManage.Helper;
using FilmsManage.Models;
using FilmsManage.Services;
using System.Data;
using System.Drawing.Drawing2D;


namespace FilmsManage
{
    public partial class Login : Form
    {
        private readonly DangPhimSV _sv;
        public Login()
        {
            InitializeComponent();
            _sv = new DangPhimSV("https://localhost:7085");
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public bool checklogin(string username, string password)
        //{
        //    //try
        //    //{
        //    //    using (var db = new FilmsManageDbContext())
        //    //    {
        //    //        return db.NhanViens.Any(tk => tk.TenDangNhap == username && tk.MatKhau == password);
        //    //    }
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    return false;
        //    //}
        //}

        public string USER_NAME = "";

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            LoginDTO loginDTO = new LoginDTO
            {
                Sdt = userName,
                Password = passWord
            };

            try
            {
                var loginResponse = await _sv.PostAsync<LoginResponse>("/api/Auth/login", loginDTO);
                if (!string.IsNullOrEmpty(loginResponse.Token))
                {
                    TokenStorage.SaveLoginResponse(loginResponse); // Lưu thông tin đăng nhập
                    MessageBox.Show("Đăng nhập thành công!");

                    if (loginResponse.User?.MaQuyenNavigation.TenQuyen == "Admin") // Kiểm tra quyền Admin
                    {
                        var adminForm = new MainForm(); // Form quản lý
                        adminForm.Show();
                    }
                    else // Nhân viên
                    {
                        var nhanVienForm = new Main_Form(); // Form nhân viên
                        nhanVienForm.Show();
                    }

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra thông tin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                // Hiển thị mật khẩu khi Checked = true
                txtPassword.PasswordChar = '\0'; // Không có ký tự thay thế
            }
            else
            {
                // Ẩn mật khẩu khi Checked = false
                txtPassword.PasswordChar = '*'; // Mật khẩu bị ẩn với dấu *
            }
        }
    }
}
