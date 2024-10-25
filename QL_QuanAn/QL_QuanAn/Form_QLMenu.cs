using QL_QuanAnBUS;
using QL_QuanAnDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanAn
{
    public partial class Form_QLMenu : Form
    {
        private readonly MonAnService monAnService = new MonAnService();
        private readonly DanhMucMonAnService danhMucMonAnService = new DanhMucMonAnService();
        private readonly ChiTietHoaDonService chiTietHoaDonService = new ChiTietHoaDonService();
        public Form_QLMenu()
        {
            InitializeComponent();
        }

        private void ghi_cbm_danhmuc(List<DanhMucMonAn> listDanhMuc)
        {
            cbmDanhMuc.DataSource = listDanhMuc;
            cbmDanhMuc.DisplayMember = "TenDanhMuc";
            cbmDanhMuc.ValueMember = "MaDanhMuc";
            cbmDanhMuc.SelectedValue = -1;
        }

        public void DoDuLieuMonAn(List<MonAn> listMonAn)
        {
            if (listMonAn == null)
            {
                return;
            }    
            dgv_dsDoAn.Rows.Clear();
            foreach(MonAn monAn in listMonAn)
            {
                int index = dgv_dsDoAn.Rows.Add();
                dgv_dsDoAn.Rows[index].Cells[0].Value = monAn.MaMonAn;
                dgv_dsDoAn.Rows[index].Cells[1].Value = monAn.TenMonAn;
                dgv_dsDoAn.Rows[index].Cells[2].Value = monAn.MaDanhMuc;
                dgv_dsDoAn.Rows[index].Cells[3].Value = monAn.GiaBan;
                dgv_dsDoAn.Rows[index].Cells[4].Value = monAn.Gia;
            }
        }

        private bool KTRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaMonAn.Text) || string.IsNullOrWhiteSpace(txtTenMonAn.Text) 
                || string.IsNullOrWhiteSpace(txtGiaMua.Text) || string.IsNullOrWhiteSpace(txtGiaBan.Text)) 
                return false;
            return true;
        }

        private void ResetControl()
        {
            txtMaMonAn.Clear();
            txtTenMonAn.Clear();
            cbmDanhMuc.SelectedIndex = -1;
            txtGiaMua.Clear();
            txtGiaBan.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin menu!", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
            if(!decimal.TryParse(txtGiaMua.Text, out decimal giaban) || giaban < 0)
            {
                if(!decimal.TryParse(txtGiaBan.Text, out decimal giamua) || giamua < 0)
                {
                    if(giamua > giaban)
                    {
                        MessageBox.Show("Giá mua và bán không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }    
                }    
            }
            if (monAnService.FindByID(int.Parse(txtMaMonAn.Text)) != null)
            {
                MessageBox.Show("Món đã tồn tại trong danh sách", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MonAn monAn = new MonAn()
            {
                MaMonAn = int.Parse(txtMaMonAn.Text),
                TenMonAn = txtTenMonAn.Text,
                MaDanhMuc = int.Parse(cbmDanhMuc.SelectedValue.ToString()),
                Gia = decimal.Parse(txtGiaBan.Text),
                GiaBan = decimal.Parse(txtGiaMua.Text),
            };
            monAnService.InsertUpdate(monAn);
            DoDuLieuMonAn(monAnService.GetAllFood());
            MessageBox.Show("Thêm dữ liệu Menu thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetControl();
        }

        private void Form_QLMenu_Load(object sender, EventArgs e)
        {
            ghi_cbm_danhmuc(danhMucMonAnService.GetAll());
            DoDuLieuMonAn(monAnService.GetAllFood());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                MessageBox.Show("Vui lòng chọn món ăn muốn để xóa!", "Thông báo", MessageBoxButtons.OK);
            }

            var monAn = monAnService.FindByID(int.Parse(txtMaMonAn.Text));
            if(monAn == null)
            {
                MessageBox.Show("Món ăn không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (chiTietHoaDonService.FindByMaMonAn(monAn.MaMonAn).Count > 0)
            {
                MessageBox.Show("Món đang tồn tại trong hoá đơn! không thể xoá", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DialogResult dlr = MessageBox.Show("Chắc chắn xóa món ăn!", "Thông báo", MessageBoxButtons.OKCancel);
            if(dlr == DialogResult.OK)
            {
                monAnService.Remove(monAn);
                DoDuLieuMonAn(monAnService.GetAllFood());
                MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK);
            }    
            ResetControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaMonAn.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập món cần sửa!", "Thông báo", MessageBoxButtons.OK);
            }    

            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng chọn món để sửa!","Thông báo",MessageBoxButtons.OK);
                return;
            }

            var monAn = monAnService.FindByID(int.Parse(txtMaMonAn.Text));
            
            if(decimal.TryParse(txtGiaMua.Text, out decimal giaban) || giaban < 0)
            {
                if (decimal.TryParse(txtGiaBan.Text, out decimal giamua) || giamua < 0)
                {
                    if (giamua > giaban)
                    {
                        MessageBox.Show("Giá mua và giá bán không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                    }
                }    
            }
            if (!KTRangBuoc())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(monAn == null)
            {
                MessageBox.Show("Món ăn không tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
            monAn.MaDanhMuc = int.Parse(cbmDanhMuc.SelectedValue.ToString());
            monAn.TenMonAn = txtTenMonAn.Text;
            monAn.GiaBan = decimal.Parse(txtGiaBan.Text);
            monAn.Gia = decimal.Parse(txtGiaMua.Text);

            monAnService.InsertUpdate(monAn);
            DoDuLieuMonAn(monAnService.GetAllFood());
            MessageBox.Show("Sửa dữ liệu món ăn thành công!", "Thông báo", MessageBoxButtons.OK);
            ResetControl();
        }

        private void dgv_dsDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_dsDoAn.Rows[e.RowIndex];
                txtMaMonAn.Text = row.Cells[0].Value.ToString();
                txtTenMonAn.Text = row.Cells[1].Value.ToString();
                cbmDanhMuc.Text = row.Cells[2].Value.ToString();
                txtGiaBan.Text = row.Cells[3].Value.ToString();
                txtGiaMua.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
