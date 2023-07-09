using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace QuanLyShopQuanAo.DAO
{
    internal class HoaDonDAO:DataProvide

    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QlThueXe;Integrated Security=True");
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance //Tạo trạng thái duy nhất
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.Instance = value; }

        }
        public HoaDonDAO() { }
        public bool inserthd(HD hd)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {



                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertHD";
                cmd.Parameters.AddWithValue("makh",hd.Makh);
                cmd.Parameters.AddWithValue("manv", hd.Manv);
                
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool insertcthd(CTHD cthd)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {



                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertCTHD";
                cmd.Parameters.AddWithValue("mahd",cthd.MaHD);
                cmd.Parameters.AddWithValue("masp", cthd.MaSP);
                cmd.Parameters.AddWithValue("sl", cthd.Soluong);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public SqlDataAdapter timHoaDon(string MaHD)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectHoaDon = "SELECT * FROM dbo.TimKiem_MaHD_FUNC("+ MaHD + ")";
                SqlDataAdapter da = new SqlDataAdapter(selectHoaDon, conn);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return da;
            }
            catch { return null; }
        }
        public bool xoa_HoaDon(int maHD)
        {
            string xoaHD = string.Format("EXEC XOA_HD {0}", maHD);
            int result = DataProvide.Instance.ExecuteNonQuery(xoaHD);
            return result > 0;
        }
        public bool sua_HoaDon(int mahd,int manv, int makh)
        {

            string suaHD = string.Format("EXEC SuaHD  {0},{1},{2}", mahd, manv, makh);
            int result = DataProvide.Instance.ExecuteNonQuery(suaHD);
            return result > 0;
        }
        public bool xoa_ChiTietHoaDon(int maHD,int masp)
        {
            string xoaCTHD = string.Format("EXEC XOA_CTHD {0},{1}", maHD,masp);
            int result = DataProvide.Instance.ExecuteNonQuery(xoaCTHD);
            return result > 0;
        }
        public bool sua_ChiTietHoaDon(int mahd, int MASP, int SOLUONG)
        {

            string suaCTHD = string.Format("EXEC SuaCTHD  {0},{1},{2}", mahd, MASP, SOLUONG);
            int result = DataProvide.Instance.ExecuteNonQuery(suaCTHD);
            return result > 0;
        }
    }
}
