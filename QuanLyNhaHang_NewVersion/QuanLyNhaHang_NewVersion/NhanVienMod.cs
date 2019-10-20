using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang_NewVersion
{
    class NhanVienMod
    {
        protected string IdNhanVien { get; set; }
        protected string HoVaTenNV { get; set; }
        protected string NgaySinhNV { get; set; }
        protected string GioiTinhNV { get; set; }
        protected string DienThoaiNV { get; set; }
        protected string EmailVN { get; set; }
        protected string DiaChiNV { get; set; }

        public NhanVienMod(string _IdNhanVien)
        {
            IdNhanVien = _IdNhanVien;
        }
        public NhanVienMod() { }
        public NhanVienMod(string _idNhanVien, String _hoVaTen, string _ngaySinh, string _gioiTinh, string _dienThoai, string _email, string _diaChi)
        {
            IdNhanVien = _idNhanVien;
            HoVaTenNV = _hoVaTen;
            NgaySinhNV = _ngaySinh;
            GioiTinhNV = _gioiTinh;
            DienThoaiNV = _dienThoai;
            EmailVN = _email;
            DiaChiNV = _diaChi;
        }
        public int InsertNhanVien()
        {
            int i = 0;
            string[] paras = new string[7] { "@IdNhanVien", "@HoVaTen", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[7] { IdNhanVien, HoVaTenNV, NgaySinhNV, GioiTinhNV, DienThoaiNV, EmailVN, DiaChiNV };
            i = 
            return i;
        }

    }
}
