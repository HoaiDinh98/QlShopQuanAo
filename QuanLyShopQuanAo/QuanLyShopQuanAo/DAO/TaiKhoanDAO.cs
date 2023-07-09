using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAO
{
    internal class TaiKhoanDAO:DataProvide
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance //Tạo trạng thái duy nhất
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.Instance = value; }

        }
        public TaiKhoanDAO() { }
        public DataTable DanhSachTK()
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANHSACHTK";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool insertTK(TaiKhoan tk)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {



                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERT_TK";
                cmd.Parameters.AddWithValue("tendn",tk.Tendn);
                cmd.Parameters.AddWithValue("matkhau", tk.Mk);
                cmd.Parameters.AddWithValue("quyen", tk.Quyen);

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
        public bool updateTK(TaiKhoan tk)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {



                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateTK";
                cmd.Parameters.AddWithValue("tenDN", tk.Tendn);
                cmd.Parameters.AddWithValue("MK", tk.Mk);
                cmd.Parameters.AddWithValue("Quyen", tk.Quyen);

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
        public bool deleteTK(string id)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteTk";
                cmd.Parameters.AddWithValue("TENDN", id);

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
    }
}
