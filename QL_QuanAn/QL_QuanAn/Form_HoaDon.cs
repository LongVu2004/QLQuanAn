using QL_QuanAnBUS;
using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanAn
{
    public partial class Form_HoaDon : Form
    {
        private readonly HoaDonService hoaDonService = new HoaDonService();
        
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        private void DoDuLieuHoaDon(List<HoaDon> listHoaDon)
        {
            if (listHoaDon == null)
                return;
            dgvDSHoaDon.Rows.Clear();
            foreach(HoaDon hoadon in listHoaDon) 
            {
                int index = dgvDSHoaDon.Rows.Add();
                dgvDSHoaDon.Rows[index].Cells[0].Value = hoadon.MaHD;
                if(hoadon.MaKH != null)
                {
                    dgvDSHoaDon.Rows[index].Cells[1].Value = hoadon.MaKH;
                    dgvDSHoaDon.Rows[index].Cells[2].Value = hoadon.KhachHang.TenKH;
                }    
                dgvDSHoaDon.Rows[index].Cells[3].Value = hoadon.NgayLap;
                dgvDSHoaDon.Rows[index].Cells[4].Value = hoadon.TongTien;
            }
        }

        private void txtTimKiemDonHang_TextChanged(object sender, EventArgs e)
        {
            switch (cbmTimKiem.SelectedIndex)
            {
                case 0:
                    {
                        var dsCanTim = hoaDonService.FindByID(int.Parse(txtTimKiemDonHang.Text));
                        DoDuLieuHoaDon(dsCanTim);
                        break;
                    }
                case 1:
                    {
                        var dsCanTim = hoaDonService.FindByIDCustomer(int.Parse(txtTimKiemDonHang.Text));
                        DoDuLieuHoaDon(dsCanTim);
                        break;
                    }
            }
        }
    }
}
