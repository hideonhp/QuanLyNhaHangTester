// <copyright file="ThucDonDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(ThucDonDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ThucDonDTOTest
    {

        [PexMethod]
        public ThucDonDTO Constructor()
        {
            ThucDonDTO target = new ThucDonDTO();
            return target;
            // TODO: add assertions to method ThucDonDTOTest.Constructor()
        }

        [PexMethod]
        public ThucDonDTO Constructor01(
            int maNV,
            int maLoai,
            string tenTD,
            string donViTinh
        )
        {
            ThucDonDTO target = new ThucDonDTO(maNV, maLoai, tenTD, donViTinh);
            return target;
            // TODO: add assertions to method ThucDonDTOTest.Constructor01(Int32, Int32, String, String)
        }

        [PexMethod]
        public ThucDonDTO Constructor02(ThucDonDTO thucDon)
        {
            ThucDonDTO target = new ThucDonDTO(thucDon);
            return target;
            // TODO: add assertions to method ThucDonDTOTest.Constructor02(ThucDonDTO)
        }

        [PexMethod]
        public string DonViTinhGet([PexAssumeUnderTest]ThucDonDTO target)
        {
            string result = target.DonViTinh;
            return result;
            // TODO: add assertions to method ThucDonDTOTest.DonViTinhGet(ThucDonDTO)
        }

        [PexMethod]
        public void DonViTinhSet([PexAssumeUnderTest]ThucDonDTO target, string value)
        {
            target.DonViTinh = value;
            // TODO: add assertions to method ThucDonDTOTest.DonViTinhSet(ThucDonDTO, String)
        }

        [PexMethod]
        public int MaLoaiGet([PexAssumeUnderTest]ThucDonDTO target)
        {
            int result = target.MaLoai;
            return result;
            // TODO: add assertions to method ThucDonDTOTest.MaLoaiGet(ThucDonDTO)
        }

        [PexMethod]
        public void MaLoaiSet([PexAssumeUnderTest]ThucDonDTO target, int value)
        {
            target.MaLoai = value;
            // TODO: add assertions to method ThucDonDTOTest.MaLoaiSet(ThucDonDTO, Int32)
        }

        [PexMethod]
        public int MaTDGet([PexAssumeUnderTest]ThucDonDTO target)
        {
            int result = target.MaTD;
            return result;
            // TODO: add assertions to method ThucDonDTOTest.MaTDGet(ThucDonDTO)
        }

        [PexMethod]
        public void MaTDSet([PexAssumeUnderTest]ThucDonDTO target, int value)
        {
            target.MaTD = value;
            // TODO: add assertions to method ThucDonDTOTest.MaTDSet(ThucDonDTO, Int32)
        }

        [PexMethod]
        public string TenTDGet([PexAssumeUnderTest]ThucDonDTO target)
        {
            string result = target.TenTD;
            return result;
            // TODO: add assertions to method ThucDonDTOTest.TenTDGet(ThucDonDTO)
        }

        [PexMethod]
        public void TenTDSet([PexAssumeUnderTest]ThucDonDTO target, string value)
        {
            target.TenTD = value;
            // TODO: add assertions to method ThucDonDTOTest.TenTDSet(ThucDonDTO, String)
        }
    }
}
