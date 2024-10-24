using QL_QuanAnBUS;
using QL_QuanAnDAL;
using QL_QuanAnDAL.Model;
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
    public partial class Form_ThuNgan : Form
    {
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        private readonly ThanhToanService thanhToanService = new ThanhToanService();
        private readonly BanAnService banAnService = new BanAnService();
        private readonly MonAnService monAnService = new MonAnService();
        public Form_ThuNgan()
        {
            InitializeComponent();
        }

        //void LoadTable()
        //{
        //    flpTable.Controls.Clear();
        //    List<BanAn> tableList = BanAnService

        //    var buttons = tableList.Select(item => new Button
        //    {
        //        Width = BanAnService.TableWidth,
        //        Height = BanAnService.TableHeight,
        //        Text = $"{item.MaBan}{Environment.NewLine}{item.TrangThai}",
        //        Tag = item,
        //        BackColor = item.TrangThai == "Trống" ? Color.Aqua : Color.LightPink
        //    });

        //    foreach (var btn in buttons)
        //    {
        //        btn.Click += btn_Click;
        //        flpTable.Controls.Add(btn);
        //    }
        //}

        private void btn_Click(object sender, EventArgs e)
        {
            //int tableID = ((sender as Button).Tag as BanAn).MaBan;
            //lsvBill.Tag = (sender as Button).Tag;
        }

    }
}
