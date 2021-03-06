// <copyright file="PhanCongDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(PhanCongDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PhanCongDTOTest
    {

        [PexMethod]
        public int CaGet([PexAssumeUnderTest]PhanCongDTO target)
        {
            int result = target.Ca;
            return result;
            // TODO: add assertions to method PhanCongDTOTest.CaGet(PhanCongDTO)
        }

        [PexMethod]
        public void CaSet([PexAssumeUnderTest]PhanCongDTO target, int value)
        {
            target.Ca = value;
            // TODO: add assertions to method PhanCongDTOTest.CaSet(PhanCongDTO, Int32)
        }

        [PexMethod]
        public PhanCongDTO Constructor()
        {
            PhanCongDTO target = new PhanCongDTO();
            return target;
            // TODO: add assertions to method PhanCongDTOTest.Constructor()
        }

        [PexMethod]
        public PhanCongDTO Constructor01(
            int msNV,
            int msBan,
            int ca
        )
        {
            PhanCongDTO target = new PhanCongDTO(msNV, msBan, ca);
            return target;
            // TODO: add assertions to method PhanCongDTOTest.Constructor01(Int32, Int32, Int32)
        }

        [PexMethod]
        public PhanCongDTO Constructor02(PhanCongDTO pc)
        {
            PhanCongDTO target = new PhanCongDTO(pc);
            return target;
            // TODO: add assertions to method PhanCongDTOTest.Constructor02(PhanCongDTO)
        }

        [PexMethod]
        public int MsBanGet([PexAssumeUnderTest]PhanCongDTO target)
        {
            int result = target.MsBan;
            return result;
            // TODO: add assertions to method PhanCongDTOTest.MsBanGet(PhanCongDTO)
        }

        [PexMethod]
        public void MsBanSet([PexAssumeUnderTest]PhanCongDTO target, int value)
        {
            target.MsBan = value;
            // TODO: add assertions to method PhanCongDTOTest.MsBanSet(PhanCongDTO, Int32)
        }
    }
}
