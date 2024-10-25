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
    public partial class Form_MainQuanLy : Form
    {
        NhanVien User = new NhanVien();
        public Form_MainQuanLy(NhanVien user)
        {
            InitializeComponent();
            User = user;
        }

        Form form_con_hienthi;

        //Hàm mở các form con
        private void mo_formcon(Form form_con)
        {
            //Nếu có form đang mở thì tắt để mở form mới
            if (form_con_hienthi != null)
            {
                form_con_hienthi.Close();
            }
            //Thực hiện mở form mới 
            form_con_hienthi = form_con;
            form_con.TopLevel = false;
            form_con.FormBorderStyle = FormBorderStyle.None; 
            form_con.Dock = DockStyle.Fill; 
            form_con.BackColor = panel_form.BackColor;
            panel_form.Controls.Add(form_con);
            panel_form.Tag = form_con;
            form_con.BringToFront();
            form_con.Show(); 
            lbe_tieude.Text = form_con.Text; 

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát không!?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void reset_button(Button btn)
        {
            //Reset button về trạng thái ban đầu
            btn.BackColor = panel1.BackColor;
            btn.ForeColor = Color.White;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            mo_formcon(new Form_QLNhanVien());
            btn_nhanvien.BackColor = panel_form.BackColor;
            btn_nhanvien.ForeColor = Color.Blue;
            reset_button(btn_khachhang);
            reset_button(btn_hoadon);
            reset_button(btn_doanhthu);
            reset_button(btn_monan);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            mo_formcon(new Form_KhachHang());
            btn_nhanvien.BackColor = panel_form.BackColor;
            btn_nhanvien.ForeColor = Color.Blue;
            reset_button(btn_nhanvien);
            reset_button(btn_hoadon);
            reset_button(btn_doanhthu);
            reset_button(btn_monan);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            mo_formcon(new Form_HoaDon());
            btn_nhanvien.BackColor = panel_form.BackColor;
            btn_nhanvien.ForeColor = Color.Blue;
            reset_button(btn_khachhang);
            reset_button(btn_nhanvien);
            reset_button(btn_doanhthu);
            reset_button(btn_monan);
        }

        private void btn_monan_Click(object sender, EventArgs e)
        {
            mo_formcon(new Form_QLMenu());
            btn_nhanvien.BackColor = panel_form.BackColor;
            btn_nhanvien.ForeColor = Color.Blue;
            reset_button(btn_khachhang);
            reset_button(btn_hoadon);
            reset_button(btn_doanhthu);
            reset_button(btn_nhanvien);
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            mo_formcon(new Form_DoanhThu());
            btn_nhanvien.BackColor = panel_form.BackColor;
            btn_nhanvien.ForeColor = Color.Blue;
            reset_button(btn_khachhang);
            reset_button(btn_hoadon);
            reset_button(btn_nhanvien);
            reset_button(btn_monan);
        }

        
    }
}
