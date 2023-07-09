using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    public class HD
    {
        private int mahd;
        private int makh;
        private int manv;
        private DateTime ngayxuathd;
        public int Mahd { get => mahd; set => mahd = value; }
        public int Makh { get => makh; set => makh = value; }
        public int Manv { get => manv; set => manv = value; }
        public DateTime Ngayxuathd { get => ngayxuathd; set => ngayxuathd = value; }

        public HD(int mahd, int makh, int manv, DateTime ngayxuathd)
        {
            Mahd = mahd;
            Makh = makh;
            Manv = manv;
            Ngayxuathd = ngayxuathd;

        } 
        public HD() { }

       
    }
}
