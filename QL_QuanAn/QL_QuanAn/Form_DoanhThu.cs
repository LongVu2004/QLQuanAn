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
    public partial class Form_DoanhThu : Form
    {
        private readonly DoanhThuService doanhThuService =  new DoanhThuService();
        public Form_DoanhThu()
        {
            InitializeComponent();
        }

        private decimal tongtien = 0;

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            if(dateStart.Value > dateEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không hợp lệ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateStart.Value > dateEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DoDuLieuDoanhThu(List<DoanhThu> listDoanhThu)
        {
            if (listDoanhThu == null)
                return;
            dgvDSDoanhThu.Rows.Clear();
            foreach (DoanhThu doanhthu in listDoanhThu)
            {
                int index = dgvDSDoanhThu.Rows.Add();
                dgvDSDoanhThu.Rows[index].Cells[0].Value = doanhthu.Ngay;
                dgvDSDoanhThu.Rows[index].Cells[1].Value = doanhthu.SLNuocBanRa;
                dgvDSDoanhThu.Rows[index].Cells[2].Value = doanhthu.SLMonAnBanRa;
                dgvDSDoanhThu.Rows[index].Cells[3].Value = doanhthu.LoiNhuan;
                tongtien += doanhthu.LoiNhuan;
            }
            txtTongTien.Text = tongtien.ToString("N0");
            tongtien = 0;
        }

        private void Form_DoanhThu_Load(object sender, EventArgs e)
        {
            dateStart.Value = DateTime.Parse(DateTime.Now.ToString("MM/01/yyyy"));// lấy các đơn hàng bắt đầu từ ngày 1 của tháng
            DoDuLieuDoanhThu(doanhThuService.GetDoanhThu(dateStart.Value, DateTime.Now));
        }

        private void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_All.Checked)
            {
                DoDuLieuDoanhThu(doanhThuService.GetAll());
            }
            else
            {
                DoDuLieuDoanhThu(doanhThuService.GetDoanhThu(dateStart.Value, dateEnd.Value));
            }
        }
    }
}
