using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo
{
    internal class Connect
    {
        //Tạo kết nối với cơ sở dữ liệu
        public SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True"); //Hàm kết nối tới cơ sở dữ liệu

        public void Ketnoi() // Hàm kết nối tới cơ sở dữ liệu
        {
            try
            {
                if (cnn.State == 0) //Kiem tra xem ket noi co mo khong
                {

                    cnn.Open(); // neu khong mo thi mo
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi() // Hàm ngắt kết nối tới cơ sở dữ liệu
        {
            if (cnn.State != 0) //Kiểm tra kết nối có mở không, nếu kết nối mở thì đóng lại
            {
                cnn.Close();
            }
        }
        //Phương thức truy vấn để xem dữ liệu
        public DataTable XemDL(string sql) //lenh select, kiểu trả về 1 cái bảng XemDL, biến truyền vào là 1 câu lệnh Sql(thường là câu lệnh Select*)
        {
            Ketnoi();  //Kết nối tới cơ sở dữ liệu
            SqlDataAdapter adap = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            Ngatketnoi(); //Ngắt kết nối
        }
        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql) //Kiểu trả về là SQLCOMMNAn, sử dụng để thực thi dữ liệu như xóa, sửa, thêm, biến truyền vào là 1 câu lệnh sql
        {
            Ketnoi(); //Kết nối tới cơ sở dữ liệu
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            return cmd;
            Ngatketnoi(); // Ngắt kết nối
        }

    }
}
