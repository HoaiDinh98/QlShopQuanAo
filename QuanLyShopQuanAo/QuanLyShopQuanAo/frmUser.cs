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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body1.Controls.Add(childForm);
            panel_body1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show()
;
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
            btn_banhang.BackColor = Color.FromArgb(102, 102, 255);
            btn_banhang.BackColor = Color.Indigo;

            btn_hanghoa.BackColor = Color.Indigo;
           btn_kh.BackColor = Color.Indigo;
           
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhachHang());
            btn_banhang.BackColor = Color.Indigo;
            btn_hanghoa.BackColor = Color.Indigo;
          
            btn_kh.BackColor = Color.FromArgb(102, 102, 255);
          
        
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLySP());
            btn_hanghoa.BackColor = Color.FromArgb(102, 102, 255);
            btn_banhang.BackColor = Color.Indigo;
            btn_hanghoa.BackColor = Color.Indigo;
            btn_kh.BackColor = Color.Indigo;

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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
