using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class ThanhToanService
    {
        public List<ThanhToan> GetAll()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.ThanhToans.ToList();
        }

        public ThanhToan FindByID(int maTT)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.ThanhToans.FirstOrDefault(p => p.MaTT == maTT);
        }
    }
}
