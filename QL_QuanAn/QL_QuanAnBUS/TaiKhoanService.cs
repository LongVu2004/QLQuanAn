using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class TaiKhoanService
    {
        public List<TaiKhoan> GetAll()
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.TaiKhoans.ToList();
        }

        public List<TaiKhoan> GetAccount(string tenDN, string matkhau)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.TaiKhoans.Where(p => p.TenDN == tenDN && p.MatKhau == matkhau).ToList();
        }

        public TaiKhoan FindByID(int MaNV)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.TaiKhoans.FirstOrDefault(p => p.MaNV == MaNV);
        }
        
        public void InsertUpdate(TaiKhoan taiKhoan)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.TaiKhoans.AddOrUpdate(taiKhoan);
            context.SaveChanges();
        }

        public void Remove(TaiKhoan taiKhoan)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.TaiKhoans.Remove(taiKhoan);
            context.SaveChanges();
        }
    }
}
