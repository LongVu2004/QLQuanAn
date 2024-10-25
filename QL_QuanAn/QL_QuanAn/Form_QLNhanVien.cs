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
    public partial class Form_QLNhanVien : Form
    {
        private readonly NhanVienService nhanVienService = new NhanVienService();
        private readonly ChucVuService chucVuService = new ChucVuService();
        private readonly TaiKhoanService taiKhoanService = new TaiKhoanService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        public Form_QLNhanVien()
        {
            InitializeComponent();
        }

        private void DoDuLieuChucVu(List<ChucVu> listChucVu)
        {
            cbmChucVu.DataSource = listChucVu;
            cbmChucVu.DisplayMember = "TenCV";
            cbmChucVu.ValueMember = "MaCV";
            cbmChucVu.SelectedIndex = -1;
        }

        private void DoDuLieuNhanVien(List<NhanVien> listNhanVien)
        {
            if (listNhanVien == null) return;
            dgv_dsNhanVien.Rows.Clear();
            foreach(NhanVien nhanVien in listNhanVien)
            {
                int index = dgv_dsNhanVien.Rows.Add();
                dgv_dsNhanVien.Rows[index].Cells[0].Value = nhanVien.MaNV;
                dgv_dsNhanVien.Rows[index].Cells[1].Value = nhanVien.TenNV;
                dgv_dsNhanVien.Rows[index].Cells[2].Value = nhanVien.ChucVu.TenCV;
                dgv_dsNhanVien.Rows[index].Cells[3].Value = nhanVien.SoDT;
                dgv_dsNhanVien.Rows[index].Cells[4].Value = nhanVien.MucLuong;
            }    
        }

        private void ResetControl()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            cbmChucVu.SelectedIndex = -1;
            txtSDT.Clear();
            txtLuong.Clear();
        }

        private void Form_QLNhanVien_Load(object sender, EventArgs e)
        {
            DoDuLieuNhanVien(nhanVienService.GetAll());
            DoDuLieuChucVu(chucVuService.GetAll());
        }

        private bool KTRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text)
                || string.IsNullOrWhiteSpace(txtLuong.Text) || string.IsNullOrWhiteSpace(txtSDT.Text)) return false;
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            } 
            var nhanVien = nhanVienService.FindByID(int.Parse(txtMaNV.Text));
            if(nhanVien == null)
            {
                MessageBox.Show("Nhân viên không tồn tại trong danh sách", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!decimal.TryParse(txtLuong.Text, out decimal mucluong) || mucluong <= 0)
            {
                MessageBox.Show($"Dữ liệu mức lương không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // chỉnh sửa thông tin 
            nhanVien.TenNV = txtTenNV.Text;
            nhanVien.SoDT = txtSDT.Text;
            nhanVien.MaCV = int.Parse(cbmChucVu.SelectedValue.ToString());
            nhanVien.MucLuong = decimal.Parse(txtLuong.Text);
            
            // sửa và lưu thông tin
            nhanVienService.InsertUpdate(nhanVien);
            DoDuLieuNhanVien(nhanVienService.GetAll());
            MessageBox.Show("Sửa Nhân Viên thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void dgv_dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_dsNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                cbmChucVu.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtLuong.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (nhanVienService.FindByID(int.Parse(txtMaNV.Text)) != null)
            {
                MessageBox.Show("Mã NV đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!decimal.TryParse(txtLuong.Text, out decimal luong) || luong < 0)
            {
                MessageBox.Show("Mức lương không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (cbmChucVu.SelectedValue != null && int.TryParse(cbmChucVu.SelectedValue.ToString(), out int maChucVu))
            {
                var chucvu = chucVuService.GetAll().SingleOrDefault(cv => cv.MaCV == maChucVu);
                if (chucvu != null)
                {
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = int.Parse(txtMaNV.Text),
                        TenNV = txtTenNV.Text,
                        MaCV = chucvu.MaCV, // Đảm bảo ChucVu là giá trị đúng
                        SoDT = txtSDT.Text,
                        MucLuong = decimal.Parse(txtLuong.Text),
                    };

                    nhanVienService.InsertUpdate(nhanVien);
                    DoDuLieuNhanVien(nhanVienService.GetAll());
                    MessageBox.Show("Thêm Nhân Viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    ResetControl();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chức vụ!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ hợp lệ.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK);
            }
            var nhanvien = nhanVienService.FindByID(int.Parse(txtMaNV.Text));
            if(nhanvien == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
            // nếu nhân viên còn trong hóa đơn thì không thể xóa
            if(hoaDonService.GetAllHoaDon().Where(p => p.MaNV == nhanvien.MaNV).ToList().Count > 0)
            {
                MessageBox.Show("Nhân viên đang tồn tại trong hoá đơn! không thể xoá", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult rl = MessageBox.Show("Chắc chắn xoá nhân viên", "Thông báo", MessageBoxButtons.OKCancel);
            if (rl == DialogResult.OK)
            {
                //Nếu nhân viên có tài khoản thì xoá tài khoản
                var tk = taiKhoanService.FindByID(nhanvien.MaNV);
                if (tk != null)
                {
                    taiKhoanService.Remove(tk);
                    MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                nhanVienService.RemoveEmplyee(nhanvien);
                DoDuLieuNhanVien(nhanVienService.GetAll());
                MessageBox.Show("Xoá nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
