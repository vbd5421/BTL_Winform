
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTL_LTTQ
{
    class dataaccess
    {
        //B1 Tạo chuỗi kết nối: Thiết lập chuỗi kết nối, khai báo và tạo connection
        string connecstring = "Data Source=DESKTOP-MEETM40\\SQLEXPRESS;Initial Catalog=qlrapphim;Integrated Security=True";

        
        //B2 Mở kết nối
        SqlConnection connectionSQL = null;
        //Phương thức mở kết nối
        void Openconnect()
        {
            connectionSQL = new SqlConnection(connecstring);
            if (connectionSQL.State != ConnectionState.Open)
                connectionSQL.Open();

        }
        //phương thức đóng kết nối
        void Closeconnect()
        {
            if (connectionSQL.State != ConnectionState.Closed)
                connectionSQL.Close();//đóng connectionsql
            connectionSQL.Dispose();//Hủy đối tượng connection
        }
        //Phương thức thực thi câu lệnh sql dạng select
        public DataTable DocBang(string sqlSelect)
        {
            DataTable dataResult = new DataTable();
            Openconnect();
            SqlDataAdapter datasql = new SqlDataAdapter(sqlSelect, connectionSQL);
            datasql.Fill(dataResult);
            Closeconnect();
            datasql.Dispose();
            return dataResult;
        }
        //Phương thức thực hiện insert, update dùng sqlcommand
        public void Capnhatdulieu(string sql)
        {
            Openconnect();
            SqlCommand commandsql = new SqlCommand();
            commandsql.Connection = connectionSQL;//Chỉ định đối tượng kết nối
            commandsql.CommandText = sql;//Truyền lệnh sql cho thuộc tính CommandText
            commandsql.ExecuteNonQuery();
            Closeconnect();
            commandsql.Dispose();//Hủy đối tượng commandsql
        }
    }
}
