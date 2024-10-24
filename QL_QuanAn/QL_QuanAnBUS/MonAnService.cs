using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class MonAnService
    {
        public List<MonAn> GetAllFood()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.MonAns.ToList();
        }

        public MonAn FindByID(int id)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.MonAns.FirstOrDefault(p => p.MaMonAn == id);
        }

        public void InsertUpdate(MonAn monAn)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.MonAns.AddOrUpdate( monAn );
            context.SaveChanges();
        }

    }
}
