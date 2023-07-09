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
    public class NhanVienDAO
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True");
        private static NhanVienDAO instance;

       public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
           
        }
       public NhanVienDAO() { }
       public List<NhanVien> LoadNV()
       {
           List<NhanVien> LoadNV = new List<NhanVien>();
           DataTable dt = DataProvide.Instance.ExecuteQuery("select * ́from NHANVIEN");
           foreach (DataRow item in dt.Rows)
           {
               NhanVien tb = new NhanVien(item);
               LoadNV.Add(tb);
           }
           return LoadNV;
       }
        public bool them_NhanVien(string tennv, string gioitinh, string sdt, string chucvu, string diachi)
        {
            string themNV = string.Format("exec them_nv  N'{0}', N'{1}', N'{2}', N'{3}',N'{4}'", tennv, gioitinh, sdt, chucvu, diachi);
            int result = DataProvide.Instance.ExecuteNonQuery(themNV);
            return result > 0;
        }
        public bool sua_NhanVien(int manv ,string tennv, string gioitinh, string sdt, string chucvu, string diachi)
        {

            string suaNV = string.Format("EXEC SuaNV {0},N'{1}', N'{2}', N'{3}',N'{4}',N'{5}'", manv, tennv, gioitinh, sdt, chucvu, diachi);
            int result = DataProvide.Instance.ExecuteNonQuery(suaNV);
            return result > 0;
        }
        public bool xoa_NhanVien(int manv)
        {
            string xoaNV = string.Format(" EXEC XOA_NV {0}", manv);
            int result = DataProvide.Instance.ExecuteNonQuery(xoaNV);
            return result > 0;
        }
        public SqlDataAdapter timNhanVien(string tenNhanVien)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectNhanVien = "EXEC TIMKIEM_TENNV_Like N'" + tenNhanVien + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectNhanVien, conn);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return da;
            }
            catch { return null; }
        }
    }
}
