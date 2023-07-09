using QuanLyShopQuanAo.DAO;
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
using System.Data;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo
{
    public partial class frmThongKe : Form
    {
        DataTable thongke = new DataTable("ThongKe");
        public frmThongKe()
        {
            InitializeComponent();
        }
        void load(DateTime ngaydau, DateTime ngaycuoi)
        {

            dtgv_thongke.DataSource = SanPhamDAO.Instance.getlistBill1(ngaydau, ngaycuoi);
            this.dtgv_thongke.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgv_thongke.DefaultCellStyle.BackColor = Color.White;
            


        }
        void load1(DateTime ngaydau, DateTime ngaycuoi,int manv)
        {

            dtgv_thongke.DataSource = SanPhamDAO.Instance.getlistBill2(ngaydau, ngaycuoi,manv);
            this.dtgv_thongke.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgv_thongke.DefaultCellStyle.BackColor = Color.White;



        }
        void load2(DateTime ngaydau, DateTime ngaycuoi, int masp)
        {

            dtgv_thongke.DataSource = SanPhamDAO.Instance.getlistBill3(ngaydau, ngaycuoi, masp);
            this.dtgv_thongke.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgv_thongke.DefaultCellStyle.BackColor = Color.White;



        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            
        }


        private void ckb_sp_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sp.Checked)
            {
                {
                    DataTable dt_sp = DataProvide.Instance.ExecuteQuery("exec LOADSP");
                    cbo_sp.DataSource = dt_sp;
                    cbo_sp.DisplayMember = "TENSP";
                    cbo_sp.ValueMember = "MASP";
                }
            }
            else
            {
                cbo_sp.SelectedIndex = -1;
            }
            

        }

        private void ckb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_all.Checked)
            {
                {
                    cbo_nv.SelectedIndex = -1;
                    ckb_nv.Enabled=false;
                    ckb_sp.Enabled = false;
                    cbo_sp.SelectedIndex = -1;
                }
            }
            else
            {
                ckb_nv.Enabled = true;
                ckb_sp.Enabled = true;
            }

        }

        private void ckb_nv_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ckb_nv.Checked)
            {
                {
                    DataTable dt_nv = DataProvide.Instance.ExecuteQuery("exec loadNV");
                    cbo_nv.DataSource = dt_nv;
                    cbo_nv.DisplayMember = "TENNV";
                    cbo_nv.ValueMember = "MANV";
                }
            }
            else
            {
                cbo_nv.SelectedIndex = -1;
            }

        }

       
        private void btn_thongke(object sender, EventArgs e)
        {
            if (ckb_all.Checked)
               load(dp_ngaydau.Value, dp_ngaycuoi.Value);
            if (ckb_nv.Checked)
               load1(dp_ngaydau.Value, dp_ngaycuoi.Value, (int)cbo_nv.SelectedValue);
            if(ckb_sp.Checked)
                load2(dp_ngaydau.Value, dp_ngaycuoi.Value, (int)cbo_sp.SelectedValue);
            thongke = (DataTable)dtgv_thongke.DataSource;

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MyReport tk = new MyReport();
            tk.SetDataSource(thongke);
            frmInThongKe f = new frmInThongKe();
            f.crystalReportViewer1.ReportSource = tk;
            f.crystalReportViewer1.Refresh();
            f.crystalReportViewer1.DisplayToolbar = false;
            f.crystalReportViewer1.DisplayStatusBar = false;
            f.ShowDialog();
        }

        private void cbo_sp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
