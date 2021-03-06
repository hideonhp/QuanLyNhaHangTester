// <copyright file="BanDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(BanDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BanDTOTest
    {

        [PexMethod]
        public BanDTO Constructor()
        {
            BanDTO target = new BanDTO();
            return target;
            // TODO: add assertions to method BanDTOTest.Constructor()
        }

        [PexMethod]
        public BanDTO Constructor01(int maBan, int soGhe)
        {
            BanDTO target = new BanDTO(maBan, soGhe);
            return target;
            // TODO: add assertions to method BanDTOTest.Constructor01(Int32, Int32)
        }

        [PexMethod]
        public BanDTO Constructor02(BanDTO HoaDon)
        {
            BanDTO target = new BanDTO(HoaDon);
            return target;
            // TODO: add assertions to method BanDTOTest.Constructor02(BanDTO)
        }

        [PexMethod]
        public int MaBanGet([PexAssumeUnderTest]BanDTO target)
        {
            int result = target.MaBan;
            return result;
            // TODO: add assertions to method BanDTOTest.MaBanGet(BanDTO)
        }

        [PexMethod]
        public void MaBanSet([PexAssumeUnderTest]BanDTO target, int value)
        {
            target.MaBan = value;
            // TODO: add assertions to method BanDTOTest.MaBanSet(BanDTO, Int32)
        }

        [PexMethod]
        public int SoGheGet([PexAssumeUnderTest]BanDTO target)
        {
            int result = target.SoGhe;
            return result;
            // TODO: add assertions to method BanDTOTest.SoGheGet(BanDTO)
        }

        [PexMethod]
        public void SoGheSet([PexAssumeUnderTest]BanDTO target, int value)
        {
            target.SoGhe = value;
            // TODO: add assertions to method BanDTOTest.SoGheSet(BanDTO, Int32)
        }
    }
}
