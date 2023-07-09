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

namespace QuanLyShopQuanAo
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }
        string tk = "", mk = "", email = "", quyen = "";

        private void txt_tenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pass.Checked)
            {
                txt_pass.PasswordChar = (char)0;

            }
            else 
            { 
                txt_pass.PasswordChar = '*';
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuenMatKhau qmk = new frm_QuenMatKhau();
            qmk.Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangKy dk = new frm_DangKy();
            dk.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection constr =new SqlConnection (@"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True");
            try
            {
                
                string sql="select *from DANGNHAP where TENDN='"+txt_tenDN.Text+"' and MK='"+txt_pass.Text+"'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, constr);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    quyen = dt.Rows[0][3].ToString();
                    if (quyen == "admin")
                    {
                        this.Hide();

                        Form_Main mhc=new Form_Main();
                        mhc.Show();

                    }
                    else
                    {
                        this.Hide();

                        frmUser mhcuser =new frmUser();
                        mhcuser.Show();
                    }


                }
                else
                    MessageBox.Show("Sai thông tin");
             
            }
            catch
            {
                MessageBox.Show("Kết Nối lỗi");
            }

        }

        private void frmDN_Load(object sender, EventArgs e)
        {

        }
    }
}
