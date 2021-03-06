using RestaurantManagerSystem.DTO;
// <copyright file="NhanVienBUSTest.cs">Copyright ©  2010</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.BUS;

namespace RestaurantManagerSystem.BUS.Tests
{
    [TestClass]
    [PexClass(typeof(NhanVienBUS))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class NhanVienBUSTest
    {

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public bool CapNhatNhanVien(NhanVienDTO nv)
        {
            bool result = NhanVienBUS.CapNhatNhanVien(nv);
            return result;
            // TODO: add assertions to method NhanVienBUSTest.CapNhatNhanVien(NhanVienDTO)
        }
    }
}
