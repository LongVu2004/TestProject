using QL_QuanAnBUS;
using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanAn
{
    public partial class Form_QLMenu : Form
    {
        private readonly MonAnService monAnService = new MonAnService();
        private readonly DanhMucMonAnService danhMucMonAnService = new DanhMucMonAnService();
        public Form_QLMenu()
        {
            InitializeComponent();
        }

        private void ghi_cbm_danhmuc(List<DanhMucMonAn> listDanhMuc)
        {
            cbmDanhMucMonAn.DataSource = listDanhMuc;
            cbmDanhMucMonAn.DisplayMember = "TenDanhMuc";
            cbmDanhMucMonAn.ValueMember = "MaDanhMuc";
            cbmDanhMucMonAn.SelectedIndex = -1;
        }

        public void DoDuLieuMonAn(List<MonAn> listMonAn)
        {
            if (listMonAn == null)
                return;
            dgv_dsDoAn.Rows.Clear();
            foreach(MonAn monAn in listMonAn)
            {
                int index = dgv_dsDoAn.Rows.Add();
                dgv_dsDoAn.Rows[index].Cells[0].Value = monAn.MaMonAn;
                dgv_dsDoAn.Rows[index].Cells[1].Value = monAn.TenMonAn;
                dgv_dsDoAn.Rows[index].Cells[2].Value = monAn.MaDanhMuc;
                dgv_dsDoAn.Rows[index].Cells[3].Value = monAn.Gia;
            }
        }

        private bool KTRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaMonAn.Text) || string.IsNullOrWhiteSpace(txtTenMonAn.Text) 
                || string.IsNullOrWhiteSpace(txtGia.Text)) 
                return false;
            return true;
        }

        private void ResetControl()
        {
            txtMaMonAn.Clear();
            txtTenMonAn.Clear();
            cbmDanhMucMonAn.SelectedIndex = -1;
            txtGia.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KTRangBuoc())
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin menu!", "Thông báo", MessageBoxButtons.OK);
            MonAn monAn = new MonAn()
            {
                MaMonAn = int.Parse(txtMaMonAn.Text),
                TenMonAn = txtTenMonAn.Text,
                DanhMucMonAn = danhMucMonAnService.GetAll().SingleOrDefault(dm => dm.MaDanhMuc.ToString() == cbmDanhMucMonAn.SelectedValue),
                Gia = decimal.Parse(txtGia.Text),
            };
            monAnService.InsertUpdate(monAn);
            DoDuLieuMonAn(monAnService.GetAllFood());
            MessageBox.Show("Thêm dữ liệu Menu thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetControl();
        }

        private void Form_QLMenu_Load(object sender, EventArgs e)
        {
            ghi_cbm_danhmuc(danhMucMonAnService.GetAll());
            DoDuLieuMonAn(monAnService.GetAllFood());
        }


    }
}
