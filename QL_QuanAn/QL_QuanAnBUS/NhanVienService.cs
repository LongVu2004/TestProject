using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class NhanVienService
    {
        public List<NhanVien> GetAll()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.NhanViens.ToList();
        }

        public NhanVien FindByID(int maNV)
        {
                QLQuanAnContextDB context = new QLQuanAnContextDB();
                return context.NhanViens.FirstOrDefault(p => p.MaNV == maNV);
        }

        public void InsertUpdate(NhanVien nhanVien)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.NhanViens.AddOrUpdate(nhanVien);
            context.SaveChanges();
        }



    }
}
