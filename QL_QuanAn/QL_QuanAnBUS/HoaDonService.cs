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
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.HoaDons.ToList();
        }

        public List<HoaDon> FindByID(int maHD)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.HoaDons.Where(p => p.MaHD == maHD).ToList();
        }

        public List<HoaDon> FindByIDCustomer(int maKH)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.HoaDons.Where(p => p.MaKH == maKH).ToList();
        }

        public void InsertUpdate(HoaDon hoaDon)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.HoaDons.AddOrUpdate(hoaDon);
            context.SaveChanges();
        }

        
    }
}
