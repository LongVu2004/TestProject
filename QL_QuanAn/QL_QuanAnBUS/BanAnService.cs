using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class BanAnService
    {
        public List<BanAn> GetAllTable()
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.BanAns.ToList();
        }

        public BanAn FindByID(int id)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            return context.BanAns.FirstOrDefault(p => p.MaBan == id);
        }

        public void InsertUpdate(BanAn banAn)
        {
            QLQuanAnContextDB context = new QLQuanAnContextDB();
            context.BanAns.AddOrUpdate(banAn);
            context.SaveChanges();
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public List<BanAn> LoadTableList()
        {
            using (var item = new QLQuanAnContextDB())
            {
                List<BanAn> tableList = item.BanAns.ToList();
                return tableList;
            }
        }
    }
}
