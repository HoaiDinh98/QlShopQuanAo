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
namespace QuanLyShopQuanAo
{
    public partial class frm_QuenMatKhau : Form
    {
        Modify modify = new Modify();
        public frm_QuenMatKhau()
        {
            InitializeComponent();
            lbl_kq.Text = "";
        }

        private void btnLaylaimatkhau_Click(object sender, EventArgs e)
        {
            string email = txtEmaildangky.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email !");
            }
            else
            {
                string sql = "Select * from DANGNHAP where EMAIL ='" + email + "'";
                if (modify.TaiKhoans(sql).Count != 0)
                {
                    lbl_kq.ForeColor = Color.Blue;
                    lbl_kq.Text = "Mật Khẩu: " + modify.TaiKhoans(sql)[0].Mk;
                }
                else
                {
                    lbl_kq.ForeColor = Color.Red;
                    lbl_kq.Text = "Email chưa được đăng kí !";
                }
            }
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            frmDN dn = new frmDN();
            dn.Show();
            this.Hide();

        }

        private void frm_QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
