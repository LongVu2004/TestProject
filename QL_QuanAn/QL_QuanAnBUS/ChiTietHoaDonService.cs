using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class ChiTietHoaDonService
    {
        public List<ChiTietHoaDon> GetAll()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.ChiTietHoaDons.ToList();
        }

        public ChiTietHoaDon FindByID(int maCTHD)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.ChiTietHoaDons.FirstOrDefault(p => p.MaCTHD == maCTHD);
        }

    }
}
