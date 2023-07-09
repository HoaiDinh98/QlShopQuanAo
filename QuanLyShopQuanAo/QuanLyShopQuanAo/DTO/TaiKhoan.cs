using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    internal class TaiKhoan
    {
        string tendn;
        string mk;
        string quyen;

        public string Tendn { get => tendn; set => tendn = value; }
        public string Mk { get => mk; set => mk = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public TaiKhoan(string ten,string mk,string quyen) 
        {
            this.tendn = ten;
            this.mk = mk;
            this.quyen = quyen;
        }
        public TaiKhoan() { }
    }
}
