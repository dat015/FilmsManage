﻿using FilmsManage.GUI.Forms.BanVe_Form.UserControl_BanVe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.Forms.BanVe_Form
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Đồ ăn";


            if (!(panel4.Controls.OfType<Food>().Any()))
            {
                panel4.Controls.Clear();
                Food customerUc = new Food(this, new List<FilmsAPI.Models.Ghe>(), new FilmsAPI.Models.XuatChieu());
                customerUc.Dock = DockStyle.Fill;
                panel4.Controls.Add(customerUc);
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Bán vé";


            if (!(panel4.Controls.OfType<LichChieu>().Any()))
            {
                panel4.Controls.Clear();
                UserControl_BanVe.LichChieu customerUc = new UserControl_BanVe.LichChieu(this);
                customerUc.Dock = DockStyle.Fill;
                panel4.Controls.Add(customerUc);
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Xóa vùng vẽ hiện tại
            e.Graphics.Clear(Color.MidnightBlue);

            // Vẽ nền gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle,
                Color.RoyalBlue, Color.MidnightBlue, 45F))
            {
                e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            }

            // Vẽ viền
            using (Pen pen = new Pen(Color.LightSteelBlue, 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1);
            }

            // Vẽ text
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle,
                Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Xóa vùng vẽ hiện tại
            e.Graphics.Clear(Color.MidnightBlue);

            // Vẽ nền gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(btn.ClientRectangle,
                Color.RoyalBlue, Color.MidnightBlue, 45F))
            {
                e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            }

            // Vẽ viền
            using (Pen pen = new Pen(Color.LightSteelBlue, 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1);
            }

            // Vẽ text
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle,
                Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
