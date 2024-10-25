using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAnBUS
{
    public class ChiTietHoaDonService
    {
        public List<ChiTietHoaDon> GetAll()
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.ChiTietHoaDons.ToList();
        }

        public ChiTietHoaDon FindByID(int maCTHD)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.ChiTietHoaDons.FirstOrDefault(p => p.MaCTHD == maCTHD);
        }

        public List<ChiTietHoaDon> FindByMaMonAn(int maMonAn)
        {
            QLQuanAnDBContext context = new QLQuanAnDBContext();
            return context.ChiTietHoaDons.Where(p => p.MaMonAn == maMonAn).ToList();
        }

    }
}
