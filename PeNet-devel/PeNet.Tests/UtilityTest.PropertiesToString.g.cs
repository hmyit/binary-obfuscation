using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="UtilityTest.PropertiesToString.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PeNet.Tests
{
    public partial class UtilityTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
public void PropertiesToString220()
{
    string s;
    object s0 = new object();
    s = this.PropertiesToString(s0, (string)null);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(NullReferenceException))]
        [ExpectedException(typeof(NullReferenceException))]
        public void PropertiesToStringThrowsNullReferenceException217()
{
    string s;
    s = this.PropertiesToString((object)null, (string)null);
}
    }
}
