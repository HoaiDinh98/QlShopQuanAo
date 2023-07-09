using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyShopQuanAo.DAO;

namespace QuanLyShopQuanAo.DTO
{
    public class SanPham
    {
         private int masp;
        private string tensp;
        private int soluong;
        private float dongianhap;
        private float dongiaban;
        private string hinhanh;
        private string ghichu;
        private int maloai;

        public int Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongianhap { get => dongianhap; set => dongianhap = value; }
        public float Dongiaban { get => dongiaban; set => dongiaban = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int Maloai { get => maloai; set => maloai = value; }
        public SanPham(int masp,string tensp,int sl,float gianhap,float giaban,string hinhanh,string ghichu,int maloai)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.soluong = sl;
            this.dongianhap = gianhap;
            this.dongiaban = giaban;
            this.hinhanh = hinhanh;
            this.ghichu = ghichu;
            this.maloai = Maloai;

        }
        public SanPham() { }
        SanPhamDAO sp = new SanPhamDAO();
        public DataTable DanhSachHang()
        {
            return sp.DanhSachSP();
        }
     

    }
}
