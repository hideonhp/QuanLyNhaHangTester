// <copyright file="CT_HoaDonDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(CT_HoaDonDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CT_HoaDonDTOTest
    {

        [PexMethod]
        public CT_HoaDonDTO Constructor()
        {
            CT_HoaDonDTO target = new CT_HoaDonDTO();
            return target;
            // TODO: add assertions to method CT_HoaDonDTOTest.Constructor()
        }

        [PexMethod]
        public CT_HoaDonDTO Constructor01(
            int soHD,
            int maTD,
            int soLuong,
            double donGia
        )
        {
            CT_HoaDonDTO target = new CT_HoaDonDTO(soHD, maTD, soLuong, donGia);
            return target;
            // TODO: add assertions to method CT_HoaDonDTOTest.Constructor01(Int32, Int32, Int32, Double)
        }

        [PexMethod]
        public CT_HoaDonDTO Constructor02(CT_HoaDonDTO cthd)
        {
            CT_HoaDonDTO target = new CT_HoaDonDTO(cthd);
            return target;
            // TODO: add assertions to method CT_HoaDonDTOTest.Constructor02(CT_HoaDonDTO)
        }

        [PexMethod]
        public double DonGiaGet([PexAssumeUnderTest]CT_HoaDonDTO target)
        {
            double result = target.DonGia;
            return result;
            // TODO: add assertions to method CT_HoaDonDTOTest.DonGiaGet(CT_HoaDonDTO)
        }

        [PexMethod]
        public void DonGiaSet([PexAssumeUnderTest]CT_HoaDonDTO target, double value)
        {
            target.DonGia = value;
            // TODO: add assertions to method CT_HoaDonDTOTest.DonGiaSet(CT_HoaDonDTO, Double)
        }

        [PexMethod]
        public int MaTDGet([PexAssumeUnderTest]CT_HoaDonDTO target)
        {
            int result = target.MaTD;
            return result;
            // TODO: add assertions to method CT_HoaDonDTOTest.MaTDGet(CT_HoaDonDTO)
        }

        [PexMethod]
        public void MaTDSet([PexAssumeUnderTest]CT_HoaDonDTO target, int value)
        {
            target.MaTD = value;
            // TODO: add assertions to method CT_HoaDonDTOTest.MaTDSet(CT_HoaDonDTO, Int32)
        }

        [PexMethod]
        public int SoHDGet([PexAssumeUnderTest]CT_HoaDonDTO target)
        {
            int result = target.SoHD;
            return result;
            // TODO: add assertions to method CT_HoaDonDTOTest.SoHDGet(CT_HoaDonDTO)
        }

        [PexMethod]
        public void SoHDSet([PexAssumeUnderTest]CT_HoaDonDTO target, int value)
        {
            target.SoHD = value;
            // TODO: add assertions to method CT_HoaDonDTOTest.SoHDSet(CT_HoaDonDTO, Int32)
        }

        [PexMethod]
        public int SoLuongGet([PexAssumeUnderTest]CT_HoaDonDTO target)
        {
            int result = target.SoLuong;
            return result;
            // TODO: add assertions to method CT_HoaDonDTOTest.SoLuongGet(CT_HoaDonDTO)
        }

        [PexMethod]
        public void SoLuongSet([PexAssumeUnderTest]CT_HoaDonDTO target, int value)
        {
            target.SoLuong = value;
            // TODO: add assertions to method CT_HoaDonDTOTest.SoLuongSet(CT_HoaDonDTO, Int32)
        }
    }
}
