using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagerSystem.DTO;
// <copyright file="BanDTOTest.Constructor.g.cs">Copyright ©  2010</copyright>
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
    public partial class BanDTOTest
    {

[TestMethod]
[PexGeneratedBy(typeof(BanDTOTest))]
public void Constructor802()
{
    BanDTO banDTO;
    banDTO = this.Constructor();
    Assert.IsNotNull((object)banDTO);
    Assert.AreEqual<int>(0, banDTO.MaBan);
    Assert.AreEqual<int>(0, banDTO.SoGhe);
}
    }
}
