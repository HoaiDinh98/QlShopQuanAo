using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frm_TìmKiemNhanVien : Form
    {
        BindingSource ListNV = new BindingSource();
        SqlConnection conn;
        public frm_TìmKiemNhanVien()
        {
            conn = new SqlConnection(@"Data Source= DESKTOP-1DHUUH7\SQLEXPRESS ; Initial Catalog= QUANLYBANHANG;Integrated Security=True");
            InitializeComponent();
        }

        void LoadBangNhanVien()
        {
            //string loadKH = "select * ́from KHACHHANG ";
            //ListKH.DataSource = DataProvide.Instance.ExecuteQuery(loadKH);
            string sql = "select * from NHANVIEN";
            ListNV.DataSource = DataProvide.Instance.ExecuteQuery(sql);
        }
        private void frm_TìmKiemNhanVien_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = ListNV;
            LoadBangNhanVien();
            dtgvNhanVien.ReadOnly = true;
        }

        private void pboTimKiem_Click(object sender, EventArgs e)
        {
            
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên !!!");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter();
                NhanVienDAO nds = new NhanVienDAO();
                NhanVienDAO nv = new NhanVienDAO();
                da = nv.timNhanVien(txtTenNV.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0) { MessageBox.Show("Không có tên khách hàng cần tìm !!!"); }
                else
                {

                    dtgvNhanVien.DataSource = dt;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = ListNV;
            txtTenNV.ResetText();
            LoadBangNhanVien();
        }


       
    }
}
