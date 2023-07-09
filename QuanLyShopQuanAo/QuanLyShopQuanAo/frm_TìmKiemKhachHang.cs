using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo
{
    public partial class frm_TìmKiemKhachHang : Form
    {
        BindingSource ListKH = new BindingSource();
        SqlConnection conn;
        public frm_TìmKiemKhachHang()
        {
            conn = new SqlConnection(@"Data Source= DESKTOP-1DHUUH7\SQLEXPRESS ; Initial Catalog= QUANLYBANHANG;Integrated Security=True");
            InitializeComponent();
            

        }

        void LoadBangKhachHang()
        {
            //string loadKH = "select * ́from KHACHHANG ";
            //ListKH.DataSource = DataProvide.Instance.ExecuteQuery(loadKH);
            string sql = "select *from KHACHHANG";
            ListKH.DataSource = DataProvide.Instance.ExecuteQuery(sql);
        }

        private void pboTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên !!!");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter();
                KhachHangDAO kh = new KhachHangDAO();
                da = kh.timKhachHang(txtTenKhach.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count <= 0) { MessageBox.Show("Không có tên khách hàng cần tìm !!!"); }
                else
                {
                    
                    dtgvKhachHang.DataSource = dt;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = ListKH;
            txtTenKhach.ResetText();
            LoadBangKhachHang();
        }

        private void frm_TìmKiemKhachHang_Load(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = ListKH;
            LoadBangKhachHang();
            dtgvKhachHang.ReadOnly = true;
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
