using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class DoanhThuService
    {
        public List<DoanhThu> GetAll()
        {
            QLQuanAnDBContext context  = new QLQuanAnDBContext();
            return context.DoanhThus.ToList();
        }

        public List<DoanhThu> GetDoanhThu(DateTime dateStart, DateTime dateEnd)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.DoanhThus.Where(doanhThu => doanhThu.Ngay >= dateStart && doanhThu.Ngay <= dateEnd).ToList();
        }

        public DoanhThu FindByID(int maDT)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.DoanhThus.FirstOrDefault(ma => ma.MaDT == maDT);
        }

        public void InsertUpdate(DoanhThu doanhThu)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.DoanhThus.AddOrUpdate(doanhThu);
            context.SaveChanges();
        }
    }
}
