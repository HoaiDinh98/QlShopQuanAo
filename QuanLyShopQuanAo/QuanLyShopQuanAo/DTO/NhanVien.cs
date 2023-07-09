using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyShopQuanAo.DTO
{
    public class NhanVien
    {
        private int manv;

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string tennv;

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public NhanVien(int manv, string tennv, string gioitinh, string sdt, string chucvu, string diachi, DateTime ngaysinh)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.chucvu = chucvu;
            this.diachi = diachi;          
        }
        public NhanVien(DataRow row)
        {
            this.manv = (int)row["MANV"];
            this.tennv = row["TENNV"].ToString();
            this.gioitinh = row["GIOITINH"].ToString();
            this.sdt = row["SDTNV"].ToString();
            this.chucvu = row["CHUCVU"].ToString();
            this.diachi = row["DIACHI"].ToString();
        }
    }
}
