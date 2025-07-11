﻿using FilmsAPI.Models;
using FilmsManage.GUI.UserControls;
using FilmsManage.GUI.UserControls.Data;
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

namespace FilmsManage.GUI.DataUserControl
{
    public partial class DataUC : UserControl
    {
        public DataUC()
        {
            InitializeComponent();
        }

        private void DataUC_Load(object sender, EventArgs e)
        {

        }

        private void pnData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnScreenTypeUC_Click(object sender, EventArgs e)
        {
            this.Text = "Loại màn hình";

            if (!(pnData.Controls.OfType<KieuManHinhUC>().Any()))
            {
                pnData.Controls.Clear();
                KieuManHinhUC manHinh = new KieuManHinhUC();
                manHinh.Dock = DockStyle.Fill;
                pnData.Controls.Add(manHinh);
            }
        }

        private void btnCinemaUC_Click(object sender, EventArgs e)
        {
            this.Text = "Phòng chiếu";

            if (!(pnData.Controls.OfType<LichChieuUC>().Any()))
            {
                pnData.Controls.Clear();
                CinemaUC phongChieu = new CinemaUC(this);
                phongChieu.Dock = DockStyle.Fill;
                pnData.Controls.Add(phongChieu);
            }
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            this.Text = "Thể loại";

            if (!(pnData.Controls.OfType<TheLoaiPhimUC>().Any()))
            {
                pnData.Controls.Clear();
                TheLoaiPhimUC theLoai = new TheLoaiPhimUC(this);
                theLoai.Dock = DockStyle.Fill;
                pnData.Controls.Add(theLoai);
            }
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
            this.Text = "Phim";

            if (!(pnData.Controls.OfType<PhimUC>().Any()))
            {
                pnData.Controls.Clear();
                InitializePhimUC();
            }
        }
        public void InitializePhimUC()
        {
            PhimUC phimUC = new PhimUC(this); // Truyền DataUC vào constructor của PhimUC
            phimUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(phimUC); // Thêm PhimUC vào panel
        }

        private void btnFormatMovieUC_Click(object sender, EventArgs e)
        {
            this.Text = "Định dạng";

            if (!(pnData.Controls.OfType<DinhDangPhimUC>().Any()))
            {
                pnData.Controls.Clear();
                DinhDangPhimUC dangPhim = new DinhDangPhimUC();
                dangPhim.Dock = DockStyle.Fill;
                pnData.Controls.Add(dangPhim);
            }
        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
            this.Text = "Lịch chiếu";

            if (!(pnData.Controls.OfType<LichChieuUC>().Any()))
            {
                pnData.Controls.Clear();
                LichChieuUC lichChieu = new LichChieuUC();
                lichChieu.Dock = DockStyle.Fill;
                pnData.Controls.Add(lichChieu);
            }
        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {
            this.Text = "Vé";

            if (!(pnData.Controls.OfType<VeUC>().Any()))
            {
                pnData.Controls.Clear();
                VeUC ve = new VeUC();
                ve.Dock = DockStyle.Fill;
                pnData.Controls.Add(ve);
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Text = "Đồ ăn";

            if (!(pnData.Controls.OfType<FoodUC>().Any()))
            {
                pnData.Controls.Clear();
                FoodUC ve = new FoodUC();
                ve.Dock = DockStyle.Fill;
                pnData.Controls.Add(ve);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Text = "Đồ ăn";

            if (!(pnData.Controls.OfType<FoodUC>().Any()))
            {
                pnData.Controls.Clear();
                FoodUC ve = new FoodUC();
                ve.Dock = DockStyle.Fill;
                pnData.Controls.Add(ve);
            }
        }
    }
}
