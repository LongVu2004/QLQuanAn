using QL_QuanAnBUS;
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
    public partial class Form_DangNhap : Form
    {
        TaiKhoanService taiKhoan = new TaiKhoanService();
        public Form_DangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        Form form_con_hienthi;
        private void mo_formcon(Form form_con)
        {
            if (form_con_hienthi != null)
            {
                form_con_hienthi.Close();
            }
            form_con_hienthi = form_con;
            form_con.TopLevel = false;
            form_con.FormBorderStyle = FormBorderStyle.None;

            form_con.BackColor = panel_form.BackColor;
            panel_form.Controls.Add(form_con);
            panel_form.Tag = form_con;
            form_con.Dock = DockStyle.Fill;
            form_con.BringToFront();
            form_con.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form_QLNhanVien f = new Form_QLNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát không!?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                this.Close();
            }    
            
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;  // Quay về kích thước bình thường
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;  // Phóng to cửa sổ
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(txtTenDN.Text == "Admin" && txtMatKhau.Text == "123")
            {
                mo_formcon(new Form_MainQuanLy(null));
                return;
            }
            var taikhoan = taiKhoan.GetAccount(txtTenDN.Text, txtMatKhau.Text);
            if(taikhoan == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Nhập lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
            
        }
    }
}
