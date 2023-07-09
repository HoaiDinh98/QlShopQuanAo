using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    public class CTHD
    {
        int maHD;
        int maSP;
        int soluong;
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int Soluong { get => soluong; set => soluong = value; }
       
        public CTHD(int maHD, int maSP, int soluong)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soluong = soluong;
          
        }
        public CTHD() { }
    }
}
