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
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.ChucVus.ToList();
        }

        public ChucVu FindbyID(int maCV)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.ChucVus.FirstOrDefault(p => p.MaCV == maCV);
        }

        public void InsertUpdate(ChucVu chucVu)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.ChucVus.AddOrUpdate(chucVu);
            context.SaveChanges();
        }

    }
}
