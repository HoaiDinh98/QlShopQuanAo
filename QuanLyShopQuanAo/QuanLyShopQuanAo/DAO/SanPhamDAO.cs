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
    public class SanPhamDAO:DataProvide

    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance //Tạo trạng thái duy nhất
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }
            private set { SanPhamDAO.Instance = value; }

        }
        public SanPhamDAO() { }
        public DataTable DanhSachSP()
        {
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachHang";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                connection.Close();
            }
        }
       
        public bool insertHang(SanPham sp)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {


                
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataHang";
                cmd.Parameters.AddWithValue("TenHang", sp.Tensp);
                cmd.Parameters.AddWithValue("Soluong", sp.Soluong);
                cmd.Parameters.AddWithValue("DonGiaNhap", sp.Dongianhap);
                cmd.Parameters.AddWithValue("DonGiaBan", sp.Dongiaban);
                cmd.Parameters.AddWithValue("HinhAnh", sp.Hinhanh);
                cmd.Parameters.AddWithValue("GhiChu", sp.Ghichu);
                cmd.Parameters.AddWithValue("maloai", sp.Maloai);
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
       
        public bool updateSP(SanPham sp)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {



                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateHang";
                cmd.Parameters.AddWithValue("maHang", sp.Masp);
                cmd.Parameters.AddWithValue("TenHang", sp.Tensp);
                cmd.Parameters.AddWithValue("Soluong", sp.Soluong);
                cmd.Parameters.AddWithValue("DonGiaNhap", sp.Dongianhap);
                cmd.Parameters.AddWithValue("DonGiaBan", sp.Dongiaban);
                cmd.Parameters.AddWithValue("hinhAnh", sp.Hinhanh);
                cmd.Parameters.AddWithValue("ghiChu", sp.Ghichu);
                cmd.Parameters.AddWithValue("maLoai", sp.Maloai);

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
        public bool deleteHang(int id)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromHang";
                cmd.Parameters.AddWithValue("masp", id);

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
        public DataTable searchSanPham(string tenSP)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchHang";
                cmd.Parameters.AddWithValue("tenSP", tenSP);
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;

            }
          
            finally
            {
                connection.Close();
            }
        }
        public DataTable getlistBill1(DateTime ngaydau,DateTime ngaycuoi)
        {
            return DataProvide.Instance.ExecuteQuery("exec GETLISTBILLALL @nd , @nc", new object[] { ngaydau, ngaycuoi });
        }
        public bool them_ct(CTHD cthd)
        {
            SqlConnection connection = new SqlConnection(constr);

            try
            {



                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertBillInfo";
                cmd.Parameters.AddWithValue("idBill", cthd.MaHD);
                cmd.Parameters.AddWithValue("idsp", cthd.MaSP);
                cmd.Parameters.AddWithValue("count", cthd.Soluong);
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
        public DataTable getlistBill2(DateTime ngaydau, DateTime ngaycuoi,int manv)
        {
            return DataProvide.Instance.ExecuteQuery("exec GETLISTBILLNV @nd , @nc , @manv", new object[] { ngaydau, ngaycuoi,manv });
        }
        public DataTable getlistBill3(DateTime ngaydau, DateTime ngaycuoi, int masp)
        {
            return DataProvide.Instance.ExecuteQuery("exec GETLISTBILLSP @nd , @nc , @masp", new object[] { ngaydau, ngaycuoi, masp });
        }

    }
    }



