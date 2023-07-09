using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_body.Controls.Add(childForm);
            Panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show()
;        }

        private void Button_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
            Button_BanHang.BackColor = Color.FromArgb(102, 102, 255);
            Button_DonHang.BackColor =Color.Indigo;
            
            Button_HangHoa.BackColor = Color.Indigo;
            Button_kh.BackColor = Color.Indigo;
            Button_Nhansu.BackColor =Color.Indigo;
            Button_BaoCao.BackColor = Color.Indigo;
        }

        private void Button_DonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLTK());
            Button_BanHang.BackColor = Color.Indigo;
            Button_DonHang.BackColor = Color.FromArgb(102, 102, 255);
            
            Button_HangHoa.BackColor = Color.Indigo;
            Button_kh.BackColor = Color.Indigo;
            Button_Nhansu.BackColor = Color.Indigo;
            Button_BaoCao.BackColor = Color.Indigo;
        }

        

        private void Button_HangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLySP());
            Button_BanHang.BackColor = Color.Indigo;
            Button_DonHang.BackColor = Color.Indigo;
           
            Button_HangHoa.BackColor = Color.FromArgb(102, 102, 255);
            Button_kh.BackColor = Color.Indigo;
            Button_Nhansu.BackColor = Color.Indigo;
            Button_BaoCao.BackColor = Color.Indigo;
        }

       

        private void Button_Nhansu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_NhanVien());
            Button_BanHang.BackColor = Color.Indigo;
            Button_DonHang.BackColor = Color.Indigo;
            
            Button_HangHoa.BackColor = Color.Indigo;
            Button_kh.BackColor = Color.Indigo;
            Button_Nhansu.BackColor = Color.FromArgb(102, 102, 255);
            Button_BaoCao.BackColor = Color.Indigo;
        }

        private void Button_BaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
            Button_BanHang.BackColor = Color.Indigo;
            Button_DonHang.BackColor = Color.Indigo;
           
            Button_HangHoa.BackColor = Color.Indigo;
            Button_kh.BackColor = Color.Indigo;
            Button_Nhansu.BackColor = Color.Indigo;
            Button_BaoCao.BackColor = Color.FromArgb(102, 102, 255);
        }

        private void Panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void Button_kh_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhachHang());
            Button_BanHang.BackColor = Color.Indigo;
            Button_DonHang.BackColor = Color.Indigo;

            Button_HangHoa.BackColor = Color.Indigo;
            Button_kh.BackColor = Color.FromArgb(102, 102, 255);
            Button_Nhansu.BackColor = Color.Indigo;
            Button_BaoCao.BackColor = Color.Indigo;
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn  muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
                frmDN dn = new frmDN();
                dn.ShowDialog();
            }
        }
    }
}
