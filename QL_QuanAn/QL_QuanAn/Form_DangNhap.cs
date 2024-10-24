using QL_QuanAnBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanAn
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form_QLNhanVien f = new Form_QLNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
