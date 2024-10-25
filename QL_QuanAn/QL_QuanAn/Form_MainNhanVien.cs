using QL_QuanAnBUS;
using QL_QuanAnDAL;
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
    public partial class Form_MainNhanVien : Form
    {
        NhanVien User = new NhanVien();
        public Form_MainNhanVien()
        {
            InitializeComponent();
            btn_thoat.Visible = false;
            btn_hoadon.Visible = true;
            //User = nsd;
        }

        Form form_HienThi;

        private void moform_con(Form form_con)
        {
            if (form_HienThi != null)
            {
                form_HienThi.Close();
            }
            form_HienThi = form_con;
            form_con.TopLevel = false;
            form_con.FormBorderStyle = FormBorderStyle.None;
            form_con.Dock = DockStyle.Fill;
            form_con.BackColor = panel_form.BackColor;
            panel_form.Controls.Add(form_con);
            panel_form.Tag = form_con;
            form_con.BringToFront();
            form_con.Show();
            btn_thoat.Visible = true;
            btn_hoadon.Visible = false;
            lbe_tieude.Text = form_con.Text;
        }



        private void btn_thoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Form_MainNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát!?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form_MainNhanVien_Load(object sender, EventArgs e)
        {
            if(User != null)
            {
                labe_name.Text = User.TenNV;
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            daytime.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
        }
    }
}
