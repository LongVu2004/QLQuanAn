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
    public partial class Form_KhachHang : Form
    {
        private readonly KhachHangService khachHangService = new KhachHangService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        private void DoDuLieuKhachHang(List<KhachHang> listKhachHang)
        {
            if (listKhachHang == null) return;
            dgv_dsKhachHang.Rows.Clear();
            foreach (KhachHang khachHang in listKhachHang)
            {
                int index = dgv_dsKhachHang.Rows.Add();
                dgv_dsKhachHang.Rows[index].Cells[0].Value = khachHang.MaKH;
                dgv_dsKhachHang.Rows[index].Cells[1].Value = khachHang.TenKH;
                dgv_dsKhachHang.Rows[index].Cells[2].Value = khachHang.SoDT;
            }
        }

        private void ResetControl()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
        }

        private bool KTRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
                return false;
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin Khách Hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            KhachHang khachHang = new KhachHang()
            {
                MaKH = int.Parse(txtMaKH.Text),
                TenKH = txtTenKH.Text,
                SoDT = txtSDT.Text,
            };

            khachHangService.InsertUpdate(khachHang);
            DoDuLieuKhachHang(khachHangService.GetAllCustomer());
            MessageBox.Show("Thêm mới dữ liệu khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetControl();
        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            DoDuLieuKhachHang(khachHangService.GetAllCustomer());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var khachHang = khachHangService.FindByID(int.Parse(txtMaKH.Text));
            if (khachHang == null)
            {
                MessageBox.Show("Khách hàng không tồn tại trong danh sách", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            // chỉnh sửa thông tin 
            khachHang.TenKH = txtTenKH.Text;
            khachHang.SoDT = txtSDT.Text;

            // sửa và lưu thông tin
            khachHangService.InsertUpdate(khachHang);
            DoDuLieuKhachHang(khachHangService.GetAllCustomer());
            MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng nhập mã khách hàng để sửa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var khachhang = khachHangService.FindByID(int.Parse(txtMaKH.Text));
            if (khachhang == null)
            {
                MessageBox.Show("Khách hàng không tồn tại trong menu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (hoaDonService.FindByIDCustomer(int.Parse(txtMaKH.Text)).Count > 0)
            {
                MessageBox.Show("Khách hàng đang tôn tại trong hoá đơn! không thể xoá", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult rl = MessageBox.Show("Chắc chắn xoá khách hàng", "Thông báo", MessageBoxButtons.OKCancel);
            if (rl == DialogResult.OK)
            {
                khachHangService.RemoveCustomer(khachhang);

                DoDuLieuKhachHang(khachHangService.GetAllCustomer());
                MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
