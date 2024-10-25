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
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.DanhMucMonAns.ToList();
        }

        public DanhMucMonAn FindByID(int id)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.DanhMucMonAns.FirstOrDefault(p => p.MaDanhMuc == id);
        }

        public void InsertUpdate(DanhMucMonAn danhMucMonAn)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.DanhMucMonAns.AddOrUpdate(danhMucMonAn);
            context.SaveChanges();
        }
    }
}
