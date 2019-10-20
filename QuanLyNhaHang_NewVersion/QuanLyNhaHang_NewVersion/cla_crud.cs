using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data;
using System.Data.SqlClient;
// 2 cái thư viện này dùng để kết nối và quản lí dữ liệu

namespace QuanLyNhaHang_NewVersion
{
    // Create, Read, Update, Delete class này được tạo ra để với mục đích là cầu nối giúp tạo kết nối đến SQL Server
    public static class cla_crud
    {
        public static string sqlcon = @"server =DESKTOP-0U3UGEI; uid= sa; pwd= 12345678; database = TesterQLNH";
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            return con;
        }
        //Tool > Connect To Database. Sau đó điền tên server vô Sau đó có thể nhấn Test Connection để thử kết nối.
        //Nếu thành công nhấn vào nút Advanced… và copy cái dòng cuối cùng
        public static void openconnect()
        {
            if (Getconnection().State == ConnectionState.Closed)
            {
                Getconnection().Open();
            }
        }
        // Hàm này dùng để mở cổng kết nối
        public static void closeconnect()
        {
            if (Getconnection().State == ConnectionState.Open)
            {
                Getconnection().Close();
            }
        }
        //Và đương nhiên có mở thì có đóng :D
        public static Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, Getconnection());
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        //Hàm được tạo là làm Boolean, sẽ trả về giá trị True hoặc False. Mình sẽ cho phép truyền vào một chuỗi lệnh cmd để sử dụng trong hàm
        //openconnect() là lời gọi làm mở kết nối mình đã viết ở trên
        //check là một biết boolean mình tạo ra để trả về sau này. Mặc định mình sẽ cho nó nhận giá trị False
        //try .... catch là một khối xử lý ngoại lệ, các đoạn code thực thi trong phần try nếu bị lỗi sẽ đưa xuống phần catch để xử lý tiếp
        //SqlCommand sc = new SqlCommand(cmd, con); là đoạn khai báo một lệnh SQL. Ở đây cần đưa vào 2 thông số đó là câu lệnh cmd và con là biến SqlConnection
        //sc.ExecuteNonQuery(); sẽ tiến hành thực thi đoạn lệnh trên
        //check = true: mình sẽ gán giá trị true cho biến check đã tạo ở trên vì lúc này lệnh đã thực thi thành công
        //check = false: mình sẽ gán giá trị false cho biến check khi lệnh thực thi ở trên không thể thực hiện được
        //closeconnect() là lời gọi hàm để đóng kết nối mình đã viết ở trên
        //return check; là giá trị trả về của hàm này. Mình sẽ trả về giá trị mà biến check đang mang


        public static DataTable readdata(string cmd)
        {
            openconnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, Getconnection());
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closeconnect();
            return da;
        }
        //Tương tự với hàm thực thi. Tuy nhiên ở đây ta sẽ không thực thi mà sử dụng sqldatadapter để chuyển đổi dữ liệu từ lệnh cmd trả về
        //Sau đó thì dùng Fill để đổ dữ liệu từ adapter vào datatable và cuối cùng là trả về một bảng chứa dữ liệu đã truy vấn

        public static DataSet FillDataSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Getconnection());
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return ds;
        }
        public static DataSet FillDataSet(string sql, string table)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Getconnection());
                da.Fill(ds, table);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return ds;
        }
        public static DataSet FillDataSet(string strQuery, CommandType cmdtype)
        {
            DataSet ds = new DataSet();
            try
            {

                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;
                cmd.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }
        public static DataSet FillDataSet(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlParameter sqlpara;
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];

                    cmd.Parameters.Add(sqlpara);
                }

                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(ds);
                sqlda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }

        public static DataSet DataSetReader(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            DataSet dsReader = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlParameter sqlpara;
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];

                    cmd.Parameters.Add(sqlpara);
                }
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                dsReader.Tables[0].Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dsReader;
        }

        public static SqlDataReader DataReader(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlDataReader dataReader;

            SqlConnection con = new SqlConnection();
            con = Getconnection();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strQuery;
            cmd.CommandType = cmdtype;

            cmd.Connection = con;
            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                cmd.Parameters.Add(sqlpara);
            }
            dataReader = cmd.ExecuteReader();

            return dataReader;
        }

        public static DataSet DataSetReader1(string strQuery, CommandType cmdtype)
        {
            DataSet dsReader = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                dsReader.Tables[0].Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dsReader;
        }
        public static DataSet DataSetReader(string strQuery, CommandType cmdtype)
        {
            DataSet dsReader = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;

                cmd.Connection = con;

                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                dsReader.Tables[0].Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dsReader;
        }
        public static DataTable FillDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Getconnection());
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return dt;
        }
        public static int Excute_Sql(string sql)
        {
            int i = 0;
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return i;
        }
        public static int Excute_Sql(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            int efftectRecord = 0;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return efftectRecord;
        }

        public static int thucThiLenh(string sql)
        {
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra\r\n" + ex.Message);
                }
            }
            return count;
        }
        public static object docGiaTri(string sql)
        {
            object result = null;
            SqlConnection conn = Getconnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra\r\n" + ex.Message);
            }
            return result;
        }
        public static string ExcuteScalar(string stringSQL)
        {
            string giaTri = "";
            try
            {
                SqlConnection sqlconn = Getconnection();
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(stringSQL, sqlconn);
                giaTri = cmd.ExecuteScalar().ToString();
            }
            catch { }
            return giaTri;
        }
        public static string ExcuteScalar(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            string efftectRecord = "";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return efftectRecord;
        }
    public static string getID(string username, string pass)
        {
            string id = "";
            try
            {
                Getconnection().Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_user WHERE user_name ='" + username + "' and pass='" + pass + "'", Getconnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                Getconnection().Close();
            }
            return id;
        }
        //hàm lấy id người dùng
        

        public static string id_per(string id_user)
        {
            string id = "";
            try
            {
                Getconnection().Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_per_relationship WHERE id_user_rel ='" + id_user + "'", Getconnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["suspended"].ToString() == "False")
                        {
                            id = dr["id_per_rel"].ToString();
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                Getconnection().Close();
            }
            return id;
        }
        //Hàm này để phân quyền người dùng

        public static List<string> list_per(string id_per)
        {
            List<string> termsList = new List<string>();
            try
            {
                Getconnection().Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_permision_detail WHERE id_per ='" + id_per + "'", Getconnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        termsList.Add(dr["code_action"].ToString());
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                Getconnection().Close();
            }
            return termsList;
        }
        //Lấy chi tiết quyền hạn
    }
}
