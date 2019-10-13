using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Models
{
    class CreateAcc
    {
        /// <summary>
        /// phần này là khai báo biến
        /// </summary>
        protected string user { get; set; }
        protected string pass { get; set; }
        /// Thêm 1 biến tình trạng cho dễ nhìn :D
        protected bool status { get; set; }
        //Khởi tạo biến
        public CreateAcc(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }
        //Check đăng nhập
        public string CreateAccS()
        {
            string str = "";
            //lấy 2 biến tư thằng sql
            string[] par = new string[2] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            //cái này copy trên youtube :v
            str = Models.Connection.ExcuteScalar("spCreateAcc", System.Data.CommandType.StoredProcedure, par, value);
            return str;
        }
    }
}
