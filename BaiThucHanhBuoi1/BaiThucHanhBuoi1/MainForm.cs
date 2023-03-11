using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = textBox1.Text;

            MessageBox.Show(string.Format("Xin chào bạn {0}. Rất vui được gặp bạn", tenDaNhap), "Thông điệp chào mừng");
        }

        private void BtnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = textBox1.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
