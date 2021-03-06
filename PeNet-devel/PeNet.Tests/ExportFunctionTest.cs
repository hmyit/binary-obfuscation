// <copyright file="ExportFunctionTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Tests
{
    [TestClass]
    [PexClass(typeof(ExportFunction))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ExportFunctionTest
    {
        [PexMethod]
        public ExportFunction Constructor(
            string name,
            uint address,
            ushort ordinal
            )
        {
            var target = new ExportFunction(name, address, ordinal);
            return target;
            // TODO: add assertions to method ExportFunctionTest.Constructor(String, UInt32, UInt16)
        }

        [PexMethod]
        public string ToString01([PexAssumeUnderTest] ExportFunction target)
        {
            var result = target.ToString();
            return result;
            // TODO: add assertions to method ExportFunctionTest.ToString01(ExportFunction)
        }
    }
}