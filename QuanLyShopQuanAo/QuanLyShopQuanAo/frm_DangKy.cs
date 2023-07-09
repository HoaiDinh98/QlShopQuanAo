using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace QuanLyShopQuanAo
{
    public partial class frm_DangKy : Form
    {
        SqlConnection conn;
        Modify modify = new Modify();
        public frm_DangKy()
        {
            conn = new SqlConnection(@"Data Source= DESKTOP-1DHUUH7\SQLEXPRESS ; Initial Catalog= QUANLYBANHANG;Integrated Security=True");
            InitializeComponent();
        }
        public bool check_Account(string account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{3,24}$");
        }

        public bool check_Email(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            frmDN dn = new frmDN();       
            dn.Show();
            this.Hide();

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tentk = txtTendangnhap.Text;
            string matkhau = txtMatkhau.Text;
            string xnmatkhau = txtXacnhanmatkhau.Text;
            string email = txtEmail.Text;

            if (!check_Account(tentk))
            {
                MessageBox.Show("Tên tài khoản gồm 3-25 kí tự bao gồm chữ và số !!!");
                return;
            }
            if (!check_Account(matkhau))
            {
                MessageBox.Show("Mật khẩu gồm 6-20 kí tự bao gồm chữ và số !!!");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return;
            }
            if (!check_Email(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email !!!");
                return;
            }
            if (modify.TaiKhoans("select * from DANGNHAP where EMAIL = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email đã được đăng kí !");

                return;
            }
            try
            {
                if (rdoAdmin.Checked)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("Insert into DANGNHAP values('" + tentk + "','" + matkhau + "','" + email + "','" + rdoAdmin.Text + "')", conn);
                    da.Fill(dt);
                    MessageBox.Show("Đăng kí thành công !");
                }
                else
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("Insert into DANGNHAP values('" + tentk + "','" + matkhau + "','" + email + "','" + rdoAdmin.Text + "')", conn);
                    da.Fill(dt);
                    MessageBox.Show("Đăng kí thành công !");
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí. Vui lòng đăng kí tên tài khoản khác!");
            }
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
