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
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyShopQuanAo
{
    
    public partial class frmQuanLySP : Form
    {
        private string fileAddress;
        private string fileName;
        private string fileSavePath;
        private string checkFileName;
        SanPham sp = new SanPham();
       

        public frmQuanLySP()
        {
            InitializeComponent();
        }


        void Load_loaiSP()
        {
            DataTable dt_loai = DataProvide.Instance.ExecuteQuery("EXEC LOADLOAISP");
            cbo_loaiSP.DataSource = dt_loai;
            cbo_loaiSP.DisplayMember = "TENLOAI";
            cbo_loaiSP.ValueMember = "MALOAI";
        }

        private void frmQuanLySP_Load(object sender, EventArgs e)
        {
            Load_loaiSP();
            showSP();
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
        }
        void Load_dtgv()
        {
           
            dtgv_DSSP.Columns[0].HeaderText = "Mã hàng";
            dtgv_DSSP.Columns[1].HeaderText = "Tên hàng";
            dtgv_DSSP.Columns[2].HeaderText = "Số lượng";
            dtgv_DSSP.Columns[3].HeaderText = "Đơn giá nhập";
            dtgv_DSSP.Columns[4].HeaderText = "Đơn giá bán";
            dtgv_DSSP.Columns[5].HeaderText = "Hình ảnh";
            dtgv_DSSP.Columns[6].HeaderText = "Ghi chú";
            dtgv_DSSP.Columns[7].HeaderText = "Mã Loại";
            foreach (DataGridViewColumn item in dtgv_DSSP.Columns)
                item.DividerWidth = 2;
        }
        void showSP()
        {
            dtgv_DSSP.DataSource = sp.DanhSachHang();
            Load_dtgv();
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool checkIsNummber(string text)
        {
            return int.TryParse(text, out int s);
        }
        private Image cloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();

            };

            return result;
        }
        private void moHinh()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(.gif)|*.gif|All files(*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pcb_SanPham.Image = cloneImage(fileAddress);
                pcb_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\Images\" + fileName;
                txt_hinhanh.Text = fileName;
            }
        }

        private void pcb_SanPham_Click(object sender, EventArgs e)
        {
            moHinh();
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            moHinh();
        }

        private void dtgv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dtgv_DSSP.Rows.Count > 0)
            {
                btn_luu.Enabled = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                txt_masp.Enabled = false;
                txt_tensp.Enabled = false;
                txt_sl.Enabled = false;
                txt_dongianhap.Enabled = false;
                txt_dongiaban.Enabled = false;
                txt_hinhanh.Enabled = false;
                txt_ghichu.Enabled = false;

                txt_masp.Text = dtgv_DSSP.CurrentRow.Cells[0].Value.ToString();
                txt_tensp.Text = dtgv_DSSP.CurrentRow.Cells[1].Value.ToString();
                txt_sl.Text = dtgv_DSSP.CurrentRow.Cells[2].Value.ToString();
                txt_dongianhap.Text = dtgv_DSSP.CurrentRow.Cells[3].Value.ToString();
                txt_dongiaban.Text = dtgv_DSSP.CurrentRow.Cells[4].Value.ToString();
                checkFileName = dtgv_DSSP.CurrentRow.Cells[5].Value.ToString();
                txt_hinhanh.Text = checkFileName;
                Bitmap bm = new Bitmap(Application.StartupPath + @"\img\" + checkFileName);
                pcb_SanPham.Image = bm;
                txt_ghichu.Text = dtgv_DSSP.CurrentRow.Cells[6].Value.ToString();
                cbo_loaiSP.SelectedValue = dtgv_DSSP.CurrentRow.Cells[7].Value.ToString();
            }



        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_masp.Text = null;
            txt_tensp.Text = null;
            txt_sl.Text = null;
            txt_dongianhap.Text = null;
            txt_dongiaban.Text = null;
            txt_hinhanh.Text = null;
            pcb_SanPham.Image = null;
            txt_ghichu.Text = null;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            txt_masp.Enabled = true;
            txt_tensp.Enabled = true;
            txt_sl.Enabled = true;
            txt_dongianhap.Enabled = true;
            txt_dongiaban.Enabled = true;
            txt_hinhanh.Enabled = true;
            txt_ghichu.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            txt_masp.Enabled = false;
            txt_tensp.Enabled = true;
            txt_sl.Enabled = true;
            txt_dongianhap.Enabled = true;
            txt_dongiaban.Enabled = true;
            txt_hinhanh.Enabled = true;
            txt_ghichu.Enabled = true;
        }

        //private File GetFile()
        //{
        //    return File;
        //}

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!checkIsNummber(txt_sl.Text) || !checkIsNummber(txt_dongiaban.Text) || !checkIsNummber(txt_dongianhap.Text))
                msgBox("Vui lòng nhập chữ số!", true);
            else if (txt_tensp.Text == "" || txt_ghichu.Text == "")
                msgBox("Thiếu trường thông tin!", true);
            else if (txt_hinhanh.Text == "")
                msgBox("Vui lòng chọn hình!", true);
            else
            {
                if (txt_masp.Enabled == true)
                {

                 
                    sp.Tensp = txt_tensp.Text;
                    sp.Soluong = int.Parse(txt_sl.Text);
                    sp.Dongiaban = float.Parse(txt_dongiaban.Text);
                    sp.Dongianhap = float.Parse(txt_dongianhap.Text);
                    sp.Ghichu = txt_ghichu.Text;
                    sp.Hinhanh = txt_hinhanh.Text;
                    sp.Maloai = int.Parse(cbo_loaiSP.SelectedValue.ToString());
                    if (SanPhamDAO.Instance.insertHang(sp))
                    {
                        showSP();
                        msgBox("Thêm sản phẩm thành công!");
                    }
                    else
                    {
                        msgBox("Thêm sản phẩm không được", true);
                    }

                }
                else
                {

                    sp.Tensp = txt_tensp.Text;
                    sp.Soluong = int.Parse(txt_sl.Text);
                    sp.Dongiaban = float.Parse(txt_dongiaban.Text);
                    sp.Dongianhap = float.Parse(txt_dongianhap.Text);
                    sp.Ghichu = txt_ghichu.Text;
                    sp.Hinhanh = txt_hinhanh.Text;
                    sp.Masp  = int.Parse(txt_masp.Text);
                    sp.Maloai = int.Parse(cbo_loaiSP.SelectedValue.ToString());
                    if (SanPhamDAO.Instance.updateSP(sp))
                    {
                        showSP();
                        msgBox("Sửa sản phẩm thành công!");
                    }
                    else
                    {
                        msgBox("Sửa sản phẩm không được", true);
                    }
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
          
        {
          
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt_sp = new DataTable();
                dt_sp = DataProvide.Instance.ExecuteQuery("select *from CTHD WHERE MASP ='" + txt_masp.Text + "'");
                if (dt_sp.Rows.Count > 0)
                {
                    msgBox("Dữ Liệu Không Thể Xóa");
                }
                else
                {
                    if (SanPhamDAO.Instance.deleteHang(int.Parse(txt_masp.Text)))
                    {
                        showSP();
                        msgBox("Xóa thành công");
                    }
                    else
                        msgBox("Xóa không thành công!");
                }
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txt_timkiem.Text.Trim();
            if (name == "")
            {
                frmQuanLySP_Load(sender, e);
            }
            else
            {
                DataTable table = SanPhamDAO.Instance.searchSanPham(txt_timkiem.Text);
                dtgv_DSSP.DataSource = table;
            }
        }

        private void cbo_loaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

