using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo
{
   public class TaiKhoan1
    {
        private string tenTk;

        public string TenTk
        {
            get { return tenTk; }
            set { tenTk = value; }
        }



        private string mk;

        public string Mk
        {
            get { return mk; }
            set { mk = value; }
        }

        public TaiKhoan1(string tenTk, string mk)
        {
            this.tenTk = tenTk;
            this.Mk = mk;
        }
       
    }
}
