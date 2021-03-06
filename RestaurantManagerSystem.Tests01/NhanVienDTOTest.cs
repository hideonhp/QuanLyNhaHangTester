// <copyright file="NhanVienDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(NhanVienDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class NhanVienDTOTest
    {

        [PexMethod]
        public NhanVienDTO Constructor()
        {
            NhanVienDTO target = new NhanVienDTO();
            return target;
            // TODO: add assertions to method NhanVienDTOTest.Constructor()
        }

        [PexMethod]
        public NhanVienDTO Constructor01(
            int maNV,
            string hoTen,
            DateTime ngaySinh,
            string tenDN,
            string matKhau,
            string quyen
        )
        {
            NhanVienDTO target = new NhanVienDTO(maNV, hoTen, ngaySinh, tenDN, matKhau, quyen);
            return target;
            // TODO: add assertions to method NhanVienDTOTest.Constructor01(Int32, String, DateTime, String, String, String)
        }

        [PexMethod]
        public NhanVienDTO Constructor02(NhanVienDTO nhanVien)
        {
            NhanVienDTO target = new NhanVienDTO(nhanVien);
            return target;
            // TODO: add assertions to method NhanVienDTOTest.Constructor02(NhanVienDTO)
        }

        [PexMethod]
        public string HoTenGet([PexAssumeUnderTest]NhanVienDTO target)
        {
            string result = target.HoTen;
            return result;
            // TODO: add assertions to method NhanVienDTOTest.HoTenGet(NhanVienDTO)
        }

        [PexMethod]
        public void HoTenSet([PexAssumeUnderTest]NhanVienDTO target, string value)
        {
            target.HoTen = value;
            // TODO: add assertions to method NhanVienDTOTest.HoTenSet(NhanVienDTO, String)
        }

        [PexMethod]
        public int MaNVGet([PexAssumeUnderTest]NhanVienDTO target)
        {
            int result = target.MaNV;
            return result;
            // TODO: add assertions to method NhanVienDTOTest.MaNVGet(NhanVienDTO)
        }

        [PexMethod]
        public void MaNVSet([PexAssumeUnderTest]NhanVienDTO target, int value)
        {
            target.MaNV = value;
            // TODO: add assertions to method NhanVienDTOTest.MaNVSet(NhanVienDTO, Int32)
        }

        [PexMethod]
        public string MatKhauGet([PexAssumeUnderTest]NhanVienDTO target)
        {
            string result = target.MatKhau;
            return result;
            // TODO: add assertions to method NhanVienDTOTest.MatKhauGet(NhanVienDTO)
        }

        [PexMethod]
        public void MatKhauSet([PexAssumeUnderTest]NhanVienDTO target, string value)
        {
            target.MatKhau = value;
            // TODO: add assertions to method NhanVienDTOTest.MatKhauSet(NhanVienDTO, String)
        }

        [PexMethod]
        public DateTime NgaySinhGet([PexAssumeUnderTest]NhanVienDTO target)
        {
            DateTime result = target.NgaySinh;
            return result;
            // TODO: add assertions to method NhanVienDTOTest.NgaySinhGet(NhanVienDTO)
        }

        [PexMethod]
        public void NgaySinhSet([PexAssumeUnderTest]NhanVienDTO target, DateTime value)
        {
            target.NgaySinh = value;
            // TODO: add assertions to method NhanVienDTOTest.NgaySinhSet(NhanVienDTO, DateTime)
        }

        [PexMethod]
        public string QuyenGet([PexAssumeUnderTest]NhanVienDTO target)
        {
            string result = target.Quyen;
            return result;
            // TODO: add assertions to method NhanVienDTOTest.QuyenGet(NhanVienDTO)
        }

        [PexMethod]
        public void QuyenSet([PexAssumeUnderTest]NhanVienDTO target, string value)
        {
            target.Quyen = value;
            // TODO: add assertions to method NhanVienDTOTest.QuyenSet(NhanVienDTO, String)
        }

        [PexMethod]
        public string TenDNGet([PexAssumeUnderTest]NhanVienDTO target)
        {
            string result = target.TenDN;
            return result;
            // TODO: add assertions to method NhanVienDTOTest.TenDNGet(NhanVienDTO)
        }

        [PexMethod]
        public void TenDNSet([PexAssumeUnderTest]NhanVienDTO target, string value)
        {
            target.TenDN = value;
            // TODO: add assertions to method NhanVienDTOTest.TenDNSet(NhanVienDTO, String)
        }
    }
}
