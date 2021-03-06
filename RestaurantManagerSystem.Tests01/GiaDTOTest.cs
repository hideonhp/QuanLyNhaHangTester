// <copyright file="GiaDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(GiaDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GiaDTOTest
    {

        [PexMethod]
        public GiaDTO Constructor()
        {
            GiaDTO target = new GiaDTO();
            return target;
            // TODO: add assertions to method GiaDTOTest.Constructor()
        }

        [PexMethod]
        public GiaDTO Constructor01(
            DateTime ngayAD,
            int maTD,
            double gia
        )
        {
            GiaDTO target = new GiaDTO(ngayAD, maTD, gia);
            return target;
            // TODO: add assertions to method GiaDTOTest.Constructor01(DateTime, Int32, Double)
        }

        [PexMethod]
        public GiaDTO Constructor02(GiaDTO gia)
        {
            GiaDTO target = new GiaDTO(gia);
            return target;
            // TODO: add assertions to method GiaDTOTest.Constructor02(GiaDTO)
        }

        [PexMethod]
        public double GiaGet([PexAssumeUnderTest]GiaDTO target)
        {
            double result = target.Gia;
            return result;
            // TODO: add assertions to method GiaDTOTest.GiaGet(GiaDTO)
        }

        [PexMethod]
        public void GiaSet([PexAssumeUnderTest]GiaDTO target, double value)
        {
            target.Gia = value;
            // TODO: add assertions to method GiaDTOTest.GiaSet(GiaDTO, Double)
        }

        [PexMethod]
        public int MaTDGet([PexAssumeUnderTest]GiaDTO target)
        {
            int result = target.MaTD;
            return result;
            // TODO: add assertions to method GiaDTOTest.MaTDGet(GiaDTO)
        }

        [PexMethod]
        public void MaTDSet([PexAssumeUnderTest]GiaDTO target, int value)
        {
            target.MaTD = value;
            // TODO: add assertions to method GiaDTOTest.MaTDSet(GiaDTO, Int32)
        }

        [PexMethod]
        public DateTime NgayADGiaGet([PexAssumeUnderTest]GiaDTO target)
        {
            DateTime result = target.NgayADGia;
            return result;
            // TODO: add assertions to method GiaDTOTest.NgayADGiaGet(GiaDTO)
        }

        [PexMethod]
        public void NgayADGiaSet([PexAssumeUnderTest]GiaDTO target, DateTime value)
        {
            target.NgayADGia = value;
            // TODO: add assertions to method GiaDTOTest.NgayADGiaSet(GiaDTO, DateTime)
        }
    }
}
