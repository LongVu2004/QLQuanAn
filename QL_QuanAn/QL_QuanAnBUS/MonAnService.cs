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
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.MonAns.ToList();
        }

        public MonAn FindByID(int id)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.MonAns.FirstOrDefault(p => p.MaMonAn == id);
        }

        public void InsertUpdate(MonAn monAn)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.MonAns.AddOrUpdate(monAn);
            context.SaveChanges();
        }
        public void Remove(MonAn monAn)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.MonAns.Remove(monAn);
            context.SaveChanges();
        }
    }
}
