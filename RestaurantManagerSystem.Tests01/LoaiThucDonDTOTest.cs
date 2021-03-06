// <copyright file="LoaiThucDonDTOTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;

namespace RestaurantManagerSystem.DTO.Tests
{
    [TestClass]
    [PexClass(typeof(LoaiThucDonDTO))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LoaiThucDonDTOTest
    {

        [PexMethod]
        public LoaiThucDonDTO Constructor()
        {
            LoaiThucDonDTO target = new LoaiThucDonDTO();
            return target;
            // TODO: add assertions to method LoaiThucDonDTOTest.Constructor()
        }

        [PexMethod]
        public LoaiThucDonDTO Constructor01(
            int maLoai,
            string nhom,
            string tenLoai
        )
        {
            LoaiThucDonDTO target = new LoaiThucDonDTO(maLoai, nhom, tenLoai);
            return target;
            // TODO: add assertions to method LoaiThucDonDTOTest.Constructor01(Int32, String, String)
        }

        [PexMethod]
        public LoaiThucDonDTO Constructor02(LoaiThucDonDTO loai)
        {
            LoaiThucDonDTO target = new LoaiThucDonDTO(loai);
            return target;
            // TODO: add assertions to method LoaiThucDonDTOTest.Constructor02(LoaiThucDonDTO)
        }

        [PexMethod]
        public int MaLoaiGet([PexAssumeUnderTest]LoaiThucDonDTO target)
        {
            int result = target.MaLoai;
            return result;
            // TODO: add assertions to method LoaiThucDonDTOTest.MaLoaiGet(LoaiThucDonDTO)
        }

        [PexMethod]
        public void MaLoaiSet([PexAssumeUnderTest]LoaiThucDonDTO target, int value)
        {
            target.MaLoai = value;
            // TODO: add assertions to method LoaiThucDonDTOTest.MaLoaiSet(LoaiThucDonDTO, Int32)
        }

        [PexMethod]
        public string NhomGet([PexAssumeUnderTest]LoaiThucDonDTO target)
        {
            string result = target.Nhom;
            return result;
            // TODO: add assertions to method LoaiThucDonDTOTest.NhomGet(LoaiThucDonDTO)
        }

        [PexMethod]
        public void NhomSet([PexAssumeUnderTest]LoaiThucDonDTO target, string value)
        {
            target.Nhom = value;
            // TODO: add assertions to method LoaiThucDonDTOTest.NhomSet(LoaiThucDonDTO, String)
        }

        [PexMethod]
        public string TenLoaiGet([PexAssumeUnderTest]LoaiThucDonDTO target)
        {
            string result = target.TenLoai;
            return result;
            // TODO: add assertions to method LoaiThucDonDTOTest.TenLoaiGet(LoaiThucDonDTO)
        }

        [PexMethod]
        public void TenLoaiSet([PexAssumeUnderTest]LoaiThucDonDTO target, string value)
        {
            target.TenLoai = value;
            // TODO: add assertions to method LoaiThucDonDTOTest.TenLoaiSet(LoaiThucDonDTO, String)
        }
    }
}
