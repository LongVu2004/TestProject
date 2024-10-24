using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class TaiKhoanService
    {
        public List<TaiKhoan> GetAll()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.TaiKhoans.ToList();
        }

        public List<TaiKhoan> GetAccount(string id)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.TaiKhoans.Where(p => p.TenDN == id).ToList();
        }

        public TaiKhoan FindByID(int MaNV)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.TaiKhoans.FirstOrDefault(p => p.MaNV == MaNV);
        }
        
        public void InsertUpdate(TaiKhoan taiKhoan)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.TaiKhoans.AddOrUpdate(taiKhoan);
            context.SaveChanges();
        }

        public void Remove(TaiKhoan taiKhoan)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.TaiKhoans.Remove(taiKhoan);
            context.SaveChanges();
        }
    }
}
