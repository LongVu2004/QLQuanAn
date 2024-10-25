using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class NhanVienService
    {
        public List<NhanVien> GetAll()
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.NhanViens.ToList();
        }

        public NhanVien FindByID(int maNV)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.NhanViens.FirstOrDefault(p => p.MaNV == maNV);
        }

        public void InsertUpdate(NhanVien nhanVien)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            context.NhanViens.AddOrUpdate(nhanVien);
            context.SaveChanges();
        }

        public void RemoveEmplyee(NhanVien nhanVien)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();

            // Tìm đối tượng NhanVien từ cơ sở dữ liệu
            var existingNhanVien = context.NhanViens.FirstOrDefault(nv => nv.MaNV == nhanVien.MaNV);

            if (existingNhanVien != null)
            {
                context.NhanViens.Remove(existingNhanVien);
                context.SaveChanges();
            }
            else
            {
                // Thông báo hoặc xử lý trường hợp không tìm thấy NhanVien
                throw new InvalidOperationException("Nhân viên không tồn tại trong cơ sở dữ liệu.");
            }
        }

    }
}
