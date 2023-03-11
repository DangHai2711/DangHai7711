﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class FrmBai3 : Form
    {
        public FrmBai3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnXemKq_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = 0;

            if (rdTongAB.Checked)
                TinhToan.CongHaiSo(a, b, ref kq);
            else
                kq = TinhToan.TongDaySo(n);

            lblKetQua.Text = kq.ToString();
        }
    }
}
