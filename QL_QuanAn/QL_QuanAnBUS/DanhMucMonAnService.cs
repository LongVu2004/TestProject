using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class DanhMucMonAnService
    {
        public List<DanhMucMonAn> GetAll()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.DanhMucMonAns.ToList();
        }

        public DanhMucMonAn FindByID(int id)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.DanhMucMonAns.FirstOrDefault(p => p.MaDanhMuc == id);
        }

        public void InsertUpdate(DanhMucMonAn danhMucMonAn)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.DanhMucMonAns.AddOrUpdate(danhMucMonAn);
            context.SaveChanges();
        }
    }
}
