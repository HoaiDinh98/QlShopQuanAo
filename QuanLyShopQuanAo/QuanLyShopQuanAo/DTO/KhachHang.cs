using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyShopQuanAo.DTO
{
    public class KhachHang
    {
        private int makh;

        public int Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public KhachHang(int makh, string tenkh, string sdt, string diachi)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.sdt = sdt;
            this.diachi = diachi;
        }
        public KhachHang(DataRow row)
        {
            this.makh = (int)row["MAKH"];
            this.tenkh = row["TENKH"].ToString();
            this.sdt = row["SDTKH"].ToString();
            this.diachi = row["DIACHIKH"].ToString();


        }
    }
}
