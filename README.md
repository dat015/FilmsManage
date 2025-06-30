# 🎬 PHẦN MỀM QUẢN LÝ RẠP CHIẾU PHIM - WinForms & SQL Server

## 1. Mô tả

Đây là ứng dụng phần mềm dành cho việc **quản lý hoạt động của rạp chiếu phim**. Hệ thống hỗ trợ các chức năng như quản lý lịch chiếu, đặt vé, đồ ăn, thông tin phim, phòng chiếu, và doanh thu. Giao diện được xây dựng bằng **WinForms (C#)** trên nền tảng **.NET Framework**, sử dụng **SQL Server** làm hệ quản trị cơ sở dữ liệu. Mục tiêu của hệ thống là giúp rạp phim hoạt động hiệu quả, quản lý rõ ràng và tăng trải nghiệm cho khách hàng.

---

## 2. Mục đích, yêu cầu và người dùng hướng tới

### 🎯 Mục đích:

- **Tự động hóa quản lý rạp phim**: Hỗ trợ xử lý các nghiệp vụ từ đặt vé, đồ ăn,quản lý suất chiếu, cho đến báo cáo doanh thu.
- **Tối ưu hóa hoạt động kinh doanh**: Giảm thiểu sai sót thủ công, tiết kiệm thời gian và chi phí vận hành.
- **Nâng cao trải nghiệm khách hàng**: Cung cấp giao diện đặt vé nhanh chóng và dễ sử dụng.

### ✅ Yêu cầu:

- Giao diện người dùng đơn giản, trực quan (WinForms).
- Đáp ứng đầy đủ các chức năng quản lý rạp chiếu phim.
- Tách biệt phân quyền giữa **nhân viên bán vé** và **quản trị viên**.
- Cơ sở dữ liệu ổn định, lưu trữ an toàn.

### 👥 Người dùng:

- **Khách hàng**: Đặt vé xem phim tại quầy.
- **Nhân viên bán vé**: Thực hiện đặt vé, in vé, đồ ăn,quản lý thông tin khách hàng.
- **Quản trị viên**: Quản lý thông tin phim, suất chiếu, phòng chiếu, báo cáo doanh thu.

---

## 3. Tổng quan sản phẩm

### 3.1 Chức năng chính

#### 👩‍💼 Quản trị viên:
- Quản lý thông tin phim (tên phim, thể loại, diễn viên, trailer).
- Quản lý suất chiếu (giờ chiếu, ngày chiếu, phòng chiếu).
- Quản lý phòng chiếu (số ghế, loại phòng).
- Quản lý giá vé theo loại ghế, suất chiếu, khuyến mãi.
- Xem thống kê doanh thu, số lượng vé bán theo ngày/tháng.

#### 💼 Nhân viên:
- Đặt vé, in vé cho khách hàng.
- Xem lịch chiếu và tình trạng ghế.
- Tra cứu thông tin phim và vé đã bán.

---

### 3.2 Công nghệ sử dụng

- **Giao diện**: WinForms (.NET Framework)
- **Ngôn ngữ**: C#
- **Cơ sở dữ liệu**: SQL Server
- **Công cụ hỗ trợ**: Visual Studio, SSMS (SQL Server Management Studio), GitHub Desktop

---

## 4. Hướng dẫn cài đặt

### 👥 Đối với người dùng:
1. Cài đặt ứng dụng từ file `.exe`.
2. Khởi chạy ứng dụng để bắt đầu đặt vé và xem lịch chiếu.
3. Yêu cầu kết nối đến mạng nội bộ có chứa database (nếu dùng chung hệ thống).

### 👨‍💻 Đối với nhà phát triển:
1. Clone source code từ GitHub:
   ```bash
   git clone https://github.com/dat015/FilmsManage
