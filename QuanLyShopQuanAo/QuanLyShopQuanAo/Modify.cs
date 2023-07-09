using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace QuanLyShopQuanAo
{
    public class Modify
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True");
        public Modify() { }

         public List<TaiKhoan1> TaiKhoans(string sql)
        {
            List<TaiKhoan1> tk = new List<TaiKhoan1>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn );
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tk.Add(new TaiKhoan1(rd.GetString(0), rd.GetString(1)));
            }
            conn.Close(); ;

            return tk;
        }
    }
}
