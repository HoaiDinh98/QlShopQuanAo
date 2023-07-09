using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo
{
    public partial class frm_KhachHang : Form
    {
        SqlConnection conn;
        BindingSource lstKH = new BindingSource();
        public frm_KhachHang()
        {
            conn = new SqlConnection(@"Data Source= DESKTOP-1DHUUH7\SQLEXPRESS ; Initial Catalog= QUANLYBANHANG;Integrated Security=True");
            InitializeComponent();
        }

        private void frm_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            txt_MaKH.Enabled = false;
            
            dtgv_KhachHang.DataSource = lstKH;
            Load_DSKhachHang();
            bingding_KhachHang();
        }
        public void bingding_KhachHang()
        {
            txt_MaKH.DataBindings.Add(new Binding("Text", dtgv_KhachHang.DataSource, "MAKH", true));
            txt_TenKH.DataBindings.Add(new Binding("Text", dtgv_KhachHang.DataSource, "TENKH", true));
            txt_SDTKH.DataBindings.Add(new Binding("Text", dtgv_KhachHang.DataSource, "SDTKH", true));
            txt_DiaChiKH.DataBindings.Add(new Binding("Text", dtgv_KhachHang.DataSource, "DIACHIKH", true));
            

        }

        public void Load_DSKhachHang()
        {
            string sql = "select *from KHACHHANG";
            lstKH.DataSource = DataProvide.Instance.ExecuteQuery(sql);
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {  
           
            string tenkh = txt_TenKH.Text;
            string sdt = txt_SDTKH.Text;
            string diachi = txt_DiaChiKH.Text;
            if (KhachHangDAO.Instance.them_KhachHang(tenkh, sdt,diachi))
            {
                MessageBox.Show("Thêm khách hàng thành công !!!");
                Load_DSKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại !!!");
            }
        }

        private void btn_Xoá_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txt_MaKH.Text);
            if (KhachHangDAO.Instance.xoa_KhachHang(makh))
            {
                MessageBox.Show("Xóa khách hàng thành công !!!");
                Load_DSKhachHang();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại !!!");
                return;
            }
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txt_MaKH.Text); 
            string tenkh = txt_TenKH.Text;
            string sdt = txt_SDTKH.Text;
            string diachi = txt_DiaChiKH.Text;
            if (KhachHangDAO.Instance.sua_KhachHang(makh, tenkh, sdt,diachi))
            {
                MessageBox.Show("Sửa khách hàng thành công !!!");
                Load_DSKhachHang();
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại !!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm_TìmKiemKhachHang tk = new frm_TìmKiemKhachHang();
            tk.Show();
            this.Hide();
        }
    }
}
