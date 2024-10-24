using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class KhachHangService
    {
        public List<KhachHang> GetAllCustomer()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.KhachHangs.ToList();
        }

        public KhachHang FindByID(int maKH)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.KhachHangs.FirstOrDefault(p => p.MaKH == maKH);
        }

        public void InsertUpdate(KhachHang khachHang)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.KhachHangs.AddOrUpdate(khachHang);
            context.SaveChanges();
        }
    }
}
