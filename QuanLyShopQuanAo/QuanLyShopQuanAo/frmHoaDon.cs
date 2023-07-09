using Guna.UI2.WinForms.Suite;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyShopQuanAo
{

    public partial class frmHoaDon : Form
    {
        string s = @"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True";
       

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void cbo_nv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void load_nv() 
         {
            DataTable dt_nv = DataProvide.Instance.ExecuteQuery("exec loadNV");
            cbo_nv.DataSource = dt_nv;
            cbo_nv.DisplayMember = "TENNV";
            cbo_nv.ValueMember = "MANV";

        }
        void load_kh()
        {
            DataTable dt_kh = DataProvide.Instance.ExecuteQuery("select *from khachhang");
            cbo_kh.DataSource = dt_kh;
            cbo_kh.DisplayMember = "TENKH";
            cbo_kh.ValueMember = "MAKH";

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            load_nv();
            load_kh();
            showDS();
            
        }
        public void load_dshd()
        {
            dtgv_DSHD.Columns[0].HeaderText = "Mã HD";
            dtgv_DSHD.Columns[1].HeaderText = "Mã KH";
            dtgv_DSHD.Columns[2].HeaderText = "Mã NV";
            dtgv_DSHD.Columns[3].HeaderText = "Ngày Xuất Hóa Đơn";
            foreach (DataGridViewColumn item in dtgv_DSHD.Columns)
                item.DividerWidth = 2;

        }
        void showDS()
        {
            {
                DataTable ds= DataProvide.Instance.ExecuteQuery("select *from HoaDon");
                dtgv_DSHD.DataSource = ds;
                load_dshd();
                bingding_HoaDon(ds);

            }
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Button_Them_Click(object sender, EventArgs e)
        {

            HD hd = new HD();

            hd.Makh = (int)cbo_kh.SelectedValue;
            hd.Manv = (int)cbo_nv.SelectedValue;
           
                if (HoaDonDAO.Instance.inserthd(hd))
                {

                    showDS();
                    msgBox("Thêm hóa đơn thành công!");
                }

                else
                {
                    msgBox("Thêm hóa đơn không được", true);
                }
        }

        private void Button_CTHD_Click(object sender, EventArgs e)
        {
            FormBanHang bh=new FormBanHang();
            bh.ShowDialog();
        }

        private void Button_HienThiTatCa_Click(object sender, EventArgs e)
        {
            showDS();
        }

        private void Button_TimKiem_Click(object sender, EventArgs e)
        {
            if (TextBox_TimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm !!!");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter();
                HoaDonDAO hd = new HoaDonDAO();
                da = hd.timHoaDon(TextBox_TimKiem.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0) { MessageBox.Show("Không có hóa đơn cần tìm !!!"); }
                else
                {

                    dtgv_DSHD.DataSource = dt;
                }
            }
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {

            int mahd = int.Parse(dtgv_DSHD.SelectedCells[0].Value.ToString());
            if (HoaDonDAO.Instance.xoa_HoaDon(mahd))
            {
                MessageBox.Show("Xóa hóa đơn thành công !!!");
                showDS();
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại !!!");
                return;
            }

        }
        public void bingding_HoaDon(DataTable ql)
        {

            cbo_nv.DataBindings.Clear();
            cbo_kh.DataBindings.Clear();
            cbo_nv.DataBindings.Add("SelectedVaLue", ql, "MANV");
            cbo_kh.DataBindings.Add("SelectedVaLue", ql, "MAKH");


        }
        private void Button_Sua_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(dtgv_DSHD.SelectedCells[0].Value.ToString());
            int manv = (int)cbo_nv.SelectedValue;
            int makh = (int)cbo_kh.SelectedValue;
            if (HoaDonDAO.Instance.sua_HoaDon(mahd,manv,makh))
            {
                MessageBox.Show("Sửa hóa đơn thành công !!!");
                showDS();
            }
            else
            {
                MessageBox.Show("Sửa hóa đơn thất bại !!!");
                return;
            }
        }
    }
    }
