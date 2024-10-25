using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class KhachHangService
    {
        public List<KhachHang> GetAllCustomer()
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.KhachHangs.ToList();
        }

        public KhachHang FindByID(int maKH)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.KhachHangs.FirstOrDefault(p => p.MaKH == maKH);
        }

        public void InsertUpdate(KhachHang khachHang)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.KhachHangs.AddOrUpdate(khachHang);
            context.SaveChanges();
        }

        public void RemoveCustomer(KhachHang khachHang)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.KhachHangs.Remove(khachHang);
            context.SaveChanges();
        }
    }
}
