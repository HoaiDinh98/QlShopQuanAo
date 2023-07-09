using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyShopQuanAo.DAO
{
    public class DataProvide
    {

        DataSet ds;
        public DataSet DS { get => ds; set => ds = value; }

        private static DataProvide instance;
        public static DataProvide Instance //Tạo trạng thái duy nhất
        {
            get { if (instance == null) instance = new DataProvide(); return DataProvide.instance; }
            private set { DataProvide.Instance = value; }
        }
        protected string constr = @"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True";

        public DataProvide() { }


        public DataTable ExecuteQuery(string query, object[] parameter = null) //Truyền Parameter
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' '); //Split theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) //dấu @ chứa parameter, để add n parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public int ExecuteNonQuery(string sql)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            data = cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public object ExecuteScala(string sql)
        {
            object data = 0;
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            data = cmd.ExecuteScalar();
            connection.Close();
            return data;
        }
        public int execute_Scalar(string sql)
        {
            SqlCommand cmd;
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
             cmd = new SqlCommand(sql, connection);
            int kq = (int)cmd.ExecuteScalar();
            connection.Close();
            return kq;
        }
        public void dbconnect()
        {
            constr = @"Data Source=DESKTOP-1DHUUH7\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True";
            SqlConnection connection = new SqlConnection(constr);
        }
    
}
}
