using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class ChucVuService
    {
        public List<ChucVu> GetAll()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.ChucVus.ToList();
        }

        public ChucVu FindbyID(int maCV)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.ChucVus.FirstOrDefault(p => p.MaCV == maCV);
        }

        public void InsertUpdate(ChucVu chucVu)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.ChucVus.AddOrUpdate(chucVu);
            context.SaveChanges();
        }

    }
}
