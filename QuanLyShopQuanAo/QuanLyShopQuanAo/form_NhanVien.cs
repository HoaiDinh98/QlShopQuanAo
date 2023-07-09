using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;
namespace QuanLyShopQuanAo
{
    public partial class form_NhanVien : Form
    {


        private void form_NhanVien_Load(object sender, EventArgs e)
        {
            //txt_MaNV.Enabled = false;
            //txt_TenNV.Enabled = false;
            //txt_DiaChi.Enabled = false;
            //txt_SĐT.Enabled = false;
            //cbo_ChucVu.Enabled = false;
            //cbo_GioiTinh.Enabled = false;
            dtgv_NhanVien.DataSource = lstNV;
            Load_DSNhanVien();
            bingding_NhanVien();
        }
        SqlConnection conn;
        BindingSource lstNV = new BindingSource();
        public form_NhanVien()
        {
            conn = new SqlConnection(@"Data Source= DESKTOP-1DHUUH7\SQLEXPRESS ; Initial Catalog= QUANLYBANHANG;Integrated Security=True");
            InitializeComponent();
        }

        private void frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void bingding_NhanVien()
        {
            txt_MaNV.DataBindings.Add(new Binding("Text", dtgv_NhanVien.DataSource, "MANV", true));
            txt_TenNV.DataBindings.Add(new Binding("Text", dtgv_NhanVien.DataSource, "TENNV", true));
            cbo_GioiTinh.DataBindings.Add(new Binding("Text", dtgv_NhanVien.DataSource, "GIOITINH", true));
            txt_SĐT.DataBindings.Add(new Binding("Text", dtgv_NhanVien.DataSource, "SDTNV", true));
            cbo_ChucVu.DataBindings.Add(new Binding("Text", dtgv_NhanVien.DataSource, "CHUCVU", true));
            txt_DiaChi.DataBindings.Add(new Binding("Text", dtgv_NhanVien.DataSource, "DIACHI", true));


        }

        public void Load_DSNhanVien()
        {
            string sql = "select *from NHANVIEN";
            lstNV.DataSource = DataProvide.Instance.ExecuteQuery(sql);
        }

        private void btn_ThêmNV_Click(object sender, EventArgs e)
        {
            //txt_MaNV.Enabled = true;
            //txt_TenNV.Enabled = true;
            //txt_DiaChi.Enabled = true;
            //txt_SĐT.Enabled = true;
            //cbo_ChucVu.Enabled = true;
            //cbo_GioiTinh.Enabled = true;
            //txt_MaNV.Focus();
            //txt_MaNV.Clear();
            //txt_TenNV.Clear();
            //txt_DiaChi.Clear();
            //txt_SĐT.Clear();

            int manv = int.Parse(txt_MaNV.Text);
            string tennv = txt_TenNV.Text;
            string gioitinh = cbo_GioiTinh.Text;
            string sdt = txt_SĐT.Text;
            string chucvu = cbo_ChucVu.Text;
            string diachi = txt_DiaChi.Text;

            if (NhanVienDAO.Instance.them_NhanVien(tennv, gioitinh, sdt, chucvu, diachi))
            {
                MessageBox.Show("Thêm nhân viên thành công !!!");
                Load_DSNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại !!!");
                return;
            }
        }

        private void btn_XoáNV_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txt_MaNV.Text);
            if (NhanVienDAO.Instance.xoa_NhanVien(manv))
            {
                MessageBox.Show("Xóa nhân viên thành công !!!");
                Load_DSNhanVien();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại !!!");
                return;
            }
        }

        private void btn_SửaNV_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txt_MaNV.Text);
            string tennv = txt_TenNV.Text;
            string gioitinh = cbo_GioiTinh.Text;
            string sdt = txt_SĐT.Text;
            string chucvu = cbo_ChucVu.Text;
            string diachi = txt_DiaChi.Text;
            if (NhanVienDAO.Instance.sua_NhanVien(manv, tennv, gioitinh, sdt, chucvu, diachi))
            {
                MessageBox.Show("Sửa nhân viên thành công !!!");
                Load_DSNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại !!!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_TìmKiemNhanVien nv = new frm_TìmKiemNhanVien();
            nv.Show();
            this.Hide();
        }

        private void cbo_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
