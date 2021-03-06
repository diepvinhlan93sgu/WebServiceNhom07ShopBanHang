﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thànhViênNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTin ftn = new FormThongTin();
            ftn.Show();
        }
        
        private void toolStripMenuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FormQLNguoiDung fuser = new FormQLNguoiDung();
            fuser.Show();
        }

        private void xemTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXemTonKho fxtk = new FormXemTonKho();
            fxtk.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham fsp = new FormSanPham();
            fsp.Show();
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhMuc fdm = new FormDanhMuc();
            fdm.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLNhapHang nh = new FormQLNhapHang();
            nh.Show();
        }

        private void xemĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDonHang qldh = new FormQLDonHang();
            qldh.Show();
        }
    }
}
