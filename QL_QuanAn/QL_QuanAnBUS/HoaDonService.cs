using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class HoaDonService
    {
        public List<HoaDon> GetAllHoaDon()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.HoaDons.ToList();
        }

        public HoaDon FindbyID(int id)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.HoaDons.FirstOrDefault(p => p.MaHD == id);
        }

        public void InsertUpdate(HoaDon hoaDon)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.HoaDons.AddOrUpdate(hoaDon);
            context.SaveChanges();
        }
    }
}
