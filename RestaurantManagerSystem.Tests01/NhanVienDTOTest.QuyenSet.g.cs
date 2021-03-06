using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;
// <copyright file="NhanVienDTOTest.QuyenSet.g.cs">Copyright ©  2010</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace RestaurantManagerSystem.DTO.Tests
{
    public partial class NhanVienDTOTest
    {

[TestMethod]
[PexGeneratedBy(typeof(NhanVienDTOTest))]
public void QuyenSet176()
{
    NhanVienDTO s0 = new NhanVienDTO(0, (string)null, default(DateTime), 
                                     (string)null, (string)null, (string)null);
    this.QuyenSet(s0, (string)null);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.MaNV);
    Assert.AreEqual<string>((string)null, s0.HoTen);
    Assert.AreEqual<int>(1, s0.NgaySinh.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Monday, s0.NgaySinh.DayOfWeek);
    Assert.AreEqual<int>(1, s0.NgaySinh.DayOfYear);
    Assert.AreEqual<int>(0, s0.NgaySinh.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, s0.NgaySinh.Kind);
    Assert.AreEqual<int>(0, s0.NgaySinh.Millisecond);
    Assert.AreEqual<int>(0, s0.NgaySinh.Minute);
    Assert.AreEqual<int>(1, s0.NgaySinh.Month);
    Assert.AreEqual<int>(0, s0.NgaySinh.Second);
    Assert.AreEqual<int>(1, s0.NgaySinh.Year);
    Assert.AreEqual<string>((string)null, s0.TenDN);
    Assert.AreEqual<string>((string)null, s0.MatKhau);
    Assert.AreEqual<string>((string)null, s0.Quyen);
}
    }
}
