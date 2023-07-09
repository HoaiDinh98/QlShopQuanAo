using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyShopQuanAo
{
    public partial class frmQLTK : Form
    {
        TaiKhoan tk = new TaiKhoan();

        public frmQLTK()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        public void load_dstk()
        {
            dtgv_TK.Columns[0].HeaderText = "Tên Đăng Nhập";
            dtgv_TK.Columns[1].HeaderText = "MẬT KHẨU";
            dtgv_TK.Columns[2].HeaderText = "QUYỀN";
            foreach (DataGridViewColumn item in dtgv_TK.Columns)
                item.DividerWidth = 2;

        }
        void showTK()
        {
            dtgv_TK.DataSource = TaiKhoanDAO.Instance.DanhSachTK();
            load_dstk();
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            showTK();
            btn_luu.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;

        }

        

        private void dtgv_TK_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_TK.Rows.Count > 0)
            {
                txt_tenDN.Enabled = false;
                txt_mk.Enabled = false;
                txt_quyen.Enabled = false;
                btn_luu.Enabled = true;
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

                txt_tenDN.Text = dtgv_TK.CurrentRow.Cells[0].Value.ToString();
                txt_mk.Text = dtgv_TK.CurrentRow.Cells[1].Value.ToString();
                txt_quyen.Text = dtgv_TK.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_tenDN.Enabled = true;
            txt_mk.Enabled = true;
            txt_quyen.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tenDN.Text == "" || txt_mk.Text == "" || txt_quyen.Text == "")
                msgBox("Thiếu trường thông tin!", true);
            if (txt_tenDN.Enabled == true)
            { 
            
                tk.Tendn = txt_tenDN.Text;
                tk.Mk = txt_mk.Text;
                tk.Quyen = txt_quyen.Text;
                if (TaiKhoanDAO.Instance.insertTK(tk))
                {

                    showTK();
                    msgBox("Thêm tài khoản thành công!");
                }

                else
                {
                    msgBox("Thêm tài khoản không được", true);
                }

            }
            else
            {
                tk.Tendn = txt_tenDN.Text;
                tk.Mk = txt_mk.Text;
                tk.Quyen = txt_quyen.Text;
                if (TaiKhoanDAO.Instance.updateTK(tk))
                {

                    showTK();
                    msgBox("Sửa tài khoản thành công!");
                }

                else
                {
                    msgBox("Sửa tài khoản không được", true);
                }

            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_tenDN.Enabled = false;
            txt_mk.Enabled = true;
            txt_quyen.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                {
                    if (TaiKhoanDAO.Instance.deleteTK((txt_tenDN.Text)))
                    {
                        showTK();
                        msgBox("Xóa thành công");
                    }
                    else
                        msgBox("Xóa không thành công!");
                }
            }
        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quyen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
