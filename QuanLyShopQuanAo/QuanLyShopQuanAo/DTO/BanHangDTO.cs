using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    internal class BanHangDTO
    {
        private string tenSP;
        private float giaBan;
        private int soLuong;
        public float thanhTien()
        {
            return giaBan * soLuong;
        }

        public string TenSP { get => tenSP; set => tenSP = value; }
        public float GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public BanHangDTO()
        {
            this.tenSP = "";
            this.giaBan = 0;
            this.soLuong = 0;
        }
    }
}
