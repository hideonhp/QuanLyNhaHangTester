using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DAO
{
    public class CT_HoaDonDAO
    {
        //Rút trích dữ liêu: select 
        public static DataTable LayDSCTHDTuMaHD(int maHD)
        {
            string sql = "select TenThucDon as 'Tên TĐ', DonGia as 'Đơn Giá', SoLuong as 'Số Lượng' from ChiTietHD ct, ThucDon td where ct.MaThucDon = td.MaThucDon and ct.SoHD = " + maHD;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);            
            return dt;
        }
        public static DataTable LayDSCTHD(int SoHD)
        {
            string sql = string.Format("select * from ChiTietHD where SoHD = {0}", SoHD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        public static bool ThemChiTietHoaDon(CT_HoaDonDTO cthd)
        {
            bool kq;
            string sql = string.Format("insert into ChiTietHD values ({0}, {1}, {2}, {3})", cthd.SoHD, cthd.MaTD, cthd.SoLuong, cthd.DonGia);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool XoaCTHDTheoSoHD(int soHD)
        {
            bool kq;
            string sql = string.Format("delete ChiTietHD where SoHD = {0}", soHD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool XoaCTHDTheoSoHDVaMaTD(int soHD, int maTD)
        {
            bool kq;
            string sql = string.Format("delete ChiTietHD where SoHD = {0} and MaThucDon = {1}", soHD, maTD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public static int MaTuTang()
        {
            string sql = "select * from ChiTietHD";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            int maTuTang = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i][0].ToString()) != maTuTang)
                {
                    return maTuTang;
                }
                maTuTang++;
            }
            return maTuTang;
        }
    }
}
