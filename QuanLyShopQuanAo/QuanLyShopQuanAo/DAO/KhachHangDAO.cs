using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyShopQuanAo.DTO;
using System.Data.SqlClient;
namespace QuanLyShopQuanAo.DAO
{
    public class KhachHangDAO
    {
         SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True");
        public static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }

        }
        public KhachHangDAO() {}
        public List<KhachHang> LoadKH()
        {
            List<KhachHang> LoadKH = new List<KhachHang>();
            DataTable dt = DataProvide.Instance.ExecuteQuery("select * ́from KHACHHANG ");
            foreach (DataRow item in dt.Rows)
            {
               KhachHang tb = new KhachHang(item);
                LoadKH.Add(tb);
            }
            return LoadKH;
        }
        public bool them_KhachHang(string tenkh, string sdt, string diachi)
        {
            string themKH = string.Format("EXEC them_kh N'{0}', N'{1}', N'{2}' ", tenkh, sdt,diachi);
            int result = DataProvide.Instance.ExecuteNonQuery(themKH);
            return result > 0;
        }
        public bool sua_KhachHang(int makh,string tenkh, string sdt, string diachi)
        {

            string suaKH = string.Format("EXEC Suakh {0}, N'{1}',N'{2}', N'{3}' ",makh, tenkh, sdt, diachi);
            int result = DataProvide.Instance.ExecuteNonQuery(suaKH);
            return result > 0;
        }
        public bool xoa_KhachHang(int makh)
        {
            string xoaKH = string.Format("EXEC XOA_KH {0}", makh);
            int result = DataProvide.Instance.ExecuteNonQuery(xoaKH);
            return result > 0;
        }
        public SqlDataAdapter timKhachHang(string tenKhachHang)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectKhachHang = "EXEC TIMKIEM_TENKH_Like N'" + tenKhachHang + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectKhachHang, conn);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return da;
            }
            catch { return null; }
        }
    }
}
