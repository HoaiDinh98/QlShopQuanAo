using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class FormBanHang : Form
    {
        List<BanHangDTO> dsSP_DaChon=new List<BanHangDTO>();
        CTHD ct= new CTHD();
      
        Connect cnn = new Connect();
        public FormBanHang()
        {
            InitializeComponent();
        }
        
        

        private void DataGridView_SPs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
              
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void load_dscthd()
        {
            dtgv_cthd.Columns[0].HeaderText = "Mã HD";
            dtgv_cthd.Columns[1].HeaderText = "Mã SP";
            dtgv_cthd.Columns[2].HeaderText = "Số Lượng";
            dtgv_cthd.Columns[3].HeaderText = "Đơn Giá";
            foreach (DataGridViewColumn item in dtgv_cthd.Columns)
                item.DividerWidth = 2;

        }

        void showDS()
        {
            {
                DataTable ds = DataProvide.Instance.ExecuteQuery("select Mahd, masp,soluong,dongia from CTHD");
                dtgv_cthd.DataSource = ds;
                load_dscthd();
                bingding_ChiTietHoaDon(ds);

            }
        }
        void load_SP()
        {
            DataTable dt_sp= DataProvide.Instance.ExecuteQuery("exec LOADSP");
            ComboBox_SPs.DataSource = dt_sp;
            ComboBox_SPs.DisplayMember = "TENSP";
            ComboBox_SPs.ValueMember = "MASP";
        }
        void load_HD()
        {
            
            DataTable dt_hd = DataProvide.Instance.ExecuteQuery("exec LOADHD");
            ComboBox_MaHd.DataSource = dt_hd;
            ComboBox_MaHd.DisplayMember = "MAHD";
            ComboBox_MaHd.ValueMember = "MAHD";
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
            CTHD cthd = new CTHD();
            //cthd.MaHD = Convert.ToInt32( txt_mahd.Text);
            cthd.MaHD = (int)ComboBox_MaHd.SelectedValue;
            cthd.MaSP = (int)ComboBox_SPs.SelectedValue;
            cthd.Soluong =(int)NumericUpDown_SLSP.Value;

            if (HoaDonDAO.Instance.insertcthd(cthd))
            {

                showDS();
                msgBox("Thêm chi tiết Hóa đơn thành công!");
            }

            else
            {
                msgBox("Thêm chi tiết Hóa đơn không được", true);
            }

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            load_SP();
            load_HD();
            showDS();
        }

        private void ComboBox_SPs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown_SLSP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            int mahd = int.Parse(dtgv_cthd.SelectedCells[0].Value.ToString());
            int masp = int.Parse(dtgv_cthd.SelectedCells[1].Value.ToString());
            if (HoaDonDAO.Instance.xoa_ChiTietHoaDon(mahd,masp))
            {
                MessageBox.Show("Xóa chi tiết hóa đơn thành công !!!");
                showDS();
            }
            else
            {
                MessageBox.Show("Xóa chi tiết hóa đơn thất bại !!!");
                return;
            }
        }

        public void bingding_ChiTietHoaDon(DataTable ql)
        {
            
            ComboBox_MaHd.DataBindings.Clear();
            ComboBox_SPs.DataBindings.Clear();
            NumericUpDown_SLSP.DataBindings.Clear();
            ComboBox_MaHd.DataBindings.Add("SelectedVaLue", ql, "MAHD");
            ComboBox_SPs.DataBindings.Add("SelectedVaLue", ql, "MASP");
            NumericUpDown_SLSP.DataBindings.Add("Value", ql, "SOLUONG");


        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(dtgv_cthd.SelectedCells[0].Value.ToString());
            int masp = (int)ComboBox_SPs.SelectedValue;
            int soluong = (int)NumericUpDown_SLSP.Value;
            if (HoaDonDAO.Instance.sua_ChiTietHoaDon(mahd, masp, soluong))
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thành công !!!");
                showDS();
            }
            else
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thất bại !!!");
                return;
            }
        }
    }
}
