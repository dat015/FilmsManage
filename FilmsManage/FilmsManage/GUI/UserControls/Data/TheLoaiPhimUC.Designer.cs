﻿namespace FilmsManage.GUI.UserControls.Data
{
    partial class TheLoaiPhimUC
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
            components = new System.ComponentModel.Container();
            panel40 = new Panel();
            btnUpdateGenre = new Button();
            btnDeleteGenre = new Button();
            btnInsertGenre = new Button();
            panel1 = new Panel();
            dtgvGenre = new DataGridView();
            panel2 = new Panel();
            dtgvPhim = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            chiTiếtPhimToolStripMenuItem = new ToolStripMenuItem();
            panel38 = new Panel();
            txtGenreName = new TextBox();
            lblGenreName = new Label();
            panel39 = new Panel();
            txtGenreID = new TextBox();
            lblGenreID = new Label();
            btnExport = new Button();
            panel40.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvGenre).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel38.SuspendLayout();
            panel39.SuspendLayout();
            SuspendLayout();
            // 
            // panel40
            // 
            panel40.BackColor = Color.LightSteelBlue;
            panel40.Controls.Add(btnExport);
            panel40.Controls.Add(btnUpdateGenre);
            panel40.Controls.Add(btnDeleteGenre);
            panel40.Controls.Add(btnInsertGenre);
            panel40.Dock = DockStyle.Top;
            panel40.Location = new Point(0, 0);
            panel40.Margin = new Padding(5, 6, 5, 6);
            panel40.Name = "panel40";
            panel40.Size = new Size(1935, 360);
            panel40.TabIndex = 10;
            panel40.Paint += panel40_Paint;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.Location = new Point(431, 216);
            btnUpdateGenre.Margin = new Padding(6, 8, 6, 8);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(125, 89);
            btnUpdateGenre.TabIndex = 2;
            btnUpdateGenre.Text = "Sửa";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Location = new Point(226, 216);
            btnDeleteGenre.Margin = new Padding(6, 8, 6, 8);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(125, 89);
            btnDeleteGenre.TabIndex = 1;
            btnDeleteGenre.Text = "Xóa";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // btnInsertGenre
            // 
            btnInsertGenre.Location = new Point(28, 216);
            btnInsertGenre.Margin = new Padding(6, 8, 6, 8);
            btnInsertGenre.Name = "btnInsertGenre";
            btnInsertGenre.Size = new Size(125, 89);
            btnInsertGenre.TabIndex = 0;
            btnInsertGenre.Text = "Thêm";
            btnInsertGenre.UseVisualStyleBackColor = true;
            btnInsertGenre.Click += btnInsertGenre_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvGenre);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 360);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 638);
            panel1.TabIndex = 11;
            // 
            // dtgvGenre
            // 
            dtgvGenre.AllowUserToAddRows = false;
            dtgvGenre.AllowUserToDeleteRows = false;
            dtgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvGenre.Dock = DockStyle.Fill;
            dtgvGenre.Location = new Point(0, 0);
            dtgvGenre.Margin = new Padding(5, 6, 5, 6);
            dtgvGenre.Name = "dtgvGenre";
            dtgvGenre.ReadOnly = true;
            dtgvGenre.RowHeadersWidth = 62;
            dtgvGenre.Size = new Size(1100, 638);
            dtgvGenre.TabIndex = 1;
            dtgvGenre.CellClick += dtgvGenre_CellClick;
            dtgvGenre.CellContentClick += dtgvGenre_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(dtgvPhim);
            panel2.Controls.Add(panel38);
            panel2.Controls.Add(panel39);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1100, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 638);
            panel2.TabIndex = 0;
            // 
            // dtgvPhim
            // 
            dtgvPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPhim.ContextMenuStrip = contextMenuStrip1;
            dtgvPhim.Location = new Point(84, 358);
            dtgvPhim.Margin = new Padding(4, 4, 4, 4);
            dtgvPhim.Name = "dtgvPhim";
            dtgvPhim.RowHeadersWidth = 62;
            dtgvPhim.Size = new Size(710, 525);
            dtgvPhim.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { chiTiếtPhimToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 36);
            // 
            // chiTiếtPhimToolStripMenuItem
            // 
            chiTiếtPhimToolStripMenuItem.Name = "chiTiếtPhimToolStripMenuItem";
            chiTiếtPhimToolStripMenuItem.Size = new Size(185, 32);
            chiTiếtPhimToolStripMenuItem.Text = "Chi tiết phim";
            chiTiếtPhimToolStripMenuItem.Click += chiTiếtPhimToolStripMenuItem_Click;
            // 
            // panel38
            // 
            panel38.Controls.Add(txtGenreName);
            panel38.Controls.Add(lblGenreName);
            panel38.Location = new Point(5, 108);
            panel38.Margin = new Padding(5, 6, 5, 6);
            panel38.Name = "panel38";
            panel38.Size = new Size(658, 84);
            panel38.TabIndex = 4;
            // 
            // txtGenreName
            // 
            txtGenreName.Location = new Point(209, 16);
            txtGenreName.Margin = new Padding(5, 6, 5, 6);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(410, 31);
            txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            lblGenreName.AutoSize = true;
            lblGenreName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblGenreName.Location = new Point(5, 18);
            lblGenreName.Margin = new Padding(5, 0, 5, 0);
            lblGenreName.Name = "lblGenreName";
            lblGenreName.Size = new Size(162, 29);
            lblGenreName.TabIndex = 0;
            lblGenreName.Text = "Tên thể loại :";
            // 
            // panel39
            // 
            panel39.Controls.Add(txtGenreID);
            panel39.Controls.Add(lblGenreID);
            panel39.Location = new Point(5, 12);
            panel39.Margin = new Padding(5, 6, 5, 6);
            panel39.Name = "panel39";
            panel39.Size = new Size(658, 84);
            panel39.TabIndex = 3;
            // 
            // txtGenreID
            // 
            txtGenreID.Location = new Point(209, 31);
            txtGenreID.Margin = new Padding(5, 6, 5, 6);
            txtGenreID.Name = "txtGenreID";
            txtGenreID.Size = new Size(410, 31);
            txtGenreID.TabIndex = 1;
            txtGenreID.TextChanged += txtGenreID_TextChanged;
            // 
            // lblGenreID
            // 
            lblGenreID.AutoSize = true;
            lblGenreID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblGenreID.Location = new Point(5, 31);
            lblGenreID.Margin = new Padding(5, 0, 5, 0);
            lblGenreID.Name = "lblGenreID";
            lblGenreID.Size = new Size(153, 29);
            lblGenreID.TabIndex = 0;
            lblGenreID.Text = "Mã thể loại :";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(644, 216);
            btnExport.Margin = new Padding(6, 8, 6, 8);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(125, 89);
            btnExport.TabIndex = 3;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // TheLoaiPhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel40);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TheLoaiPhimUC";
            Size = new Size(1935, 998);
            panel40.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvGenre).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            panel39.ResumeLayout(false);
            panel39.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnInsertGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.DataGridView dtgvGenre;
        private DataGridView dtgvPhim;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem chiTiếtPhimToolStripMenuItem;
        private Button btnExport;
    }
}
