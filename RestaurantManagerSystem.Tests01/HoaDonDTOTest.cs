// <copyright file="HoaDonDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(HoaDonDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HoaDonDTOTest
    {

        [PexMethod]
        public HoaDonDTO Constructor()
        {
            HoaDonDTO target = new HoaDonDTO();
            return target;
            // TODO: add assertions to method HoaDonDTOTest.Constructor()
        }

        [PexMethod]
        public HoaDonDTO Constructor01(
            int soHD,
            DateTime ngayLap,
            int msBan,
            int soKhach,
            int msNVLap,
            int msNVTT,
            double tongTien
        )
        {
            HoaDonDTO target = new HoaDonDTO(soHD, ngayLap, msBan, soKhach, msNVLap, msNVTT, tongTien);
            return target;
            // TODO: add assertions to method HoaDonDTOTest.Constructor01(Int32, DateTime, Int32, Int32, Int32, Int32, Double)
        }

        [PexMethod]
        public HoaDonDTO Constructor02(HoaDonDTO HoaDon)
        {
            HoaDonDTO target = new HoaDonDTO(HoaDon);
            return target;
            // TODO: add assertions to method HoaDonDTOTest.Constructor02(HoaDonDTO)
        }

        [PexMethod]
        public int MsBanGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            int result = target.MsBan;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.MsBanGet(HoaDonDTO)
        }

        [PexMethod]
        public void MsBanSet([PexAssumeUnderTest]HoaDonDTO target, int value)
        {
            target.MsBan = value;
            // TODO: add assertions to method HoaDonDTOTest.MsBanSet(HoaDonDTO, Int32)
        }

        [PexMethod]
        public int MsNVLapGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            int result = target.MsNVLap;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.MsNVLapGet(HoaDonDTO)
        }

        [PexMethod]
        public void MsNVLapSet([PexAssumeUnderTest]HoaDonDTO target, int value)
        {
            target.MsNVLap = value;
            // TODO: add assertions to method HoaDonDTOTest.MsNVLapSet(HoaDonDTO, Int32)
        }

        [PexMethod]
        public int MsNVTTGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            int result = target.MsNVTT;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.MsNVTTGet(HoaDonDTO)
        }

        [PexMethod]
        public void MsNVTTSet([PexAssumeUnderTest]HoaDonDTO target, int value)
        {
            target.MsNVTT = value;
            // TODO: add assertions to method HoaDonDTOTest.MsNVTTSet(HoaDonDTO, Int32)
        }

        [PexMethod]
        public int SoHDGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            int result = target.SoHD;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.SoHDGet(HoaDonDTO)
        }

        [PexMethod]
        public void SoHDSet([PexAssumeUnderTest]HoaDonDTO target, int value)
        {
            target.SoHD = value;
            // TODO: add assertions to method HoaDonDTOTest.SoHDSet(HoaDonDTO, Int32)
        }

        [PexMethod]
        public int SoKhachGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            int result = target.SoKhach;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.SoKhachGet(HoaDonDTO)
        }

        [PexMethod]
        public void SoKhachSet([PexAssumeUnderTest]HoaDonDTO target, int value)
        {
            target.SoKhach = value;
            // TODO: add assertions to method HoaDonDTOTest.SoKhachSet(HoaDonDTO, Int32)
        }

        [PexMethod]
        public DateTime TimeLapHDGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            DateTime result = target.TimeLapHD;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.TimeLapHDGet(HoaDonDTO)
        }

        [PexMethod]
        public void TimeLapHDSet([PexAssumeUnderTest]HoaDonDTO target, DateTime value)
        {
            target.TimeLapHD = value;
            // TODO: add assertions to method HoaDonDTOTest.TimeLapHDSet(HoaDonDTO, DateTime)
        }

        [PexMethod]
        public double TongTienGet([PexAssumeUnderTest]HoaDonDTO target)
        {
            double result = target.TongTien;
            return result;
            // TODO: add assertions to method HoaDonDTOTest.TongTienGet(HoaDonDTO)
        }

        [PexMethod]
        public void TongTienSet([PexAssumeUnderTest]HoaDonDTO target, double value)
        {
            target.TongTien = value;
            // TODO: add assertions to method HoaDonDTOTest.TongTienSet(HoaDonDTO, Double)
        }
    }
}
