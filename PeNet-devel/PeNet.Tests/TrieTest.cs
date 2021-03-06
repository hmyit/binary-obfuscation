using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="TrieTest.cs">Copyright ©  2016</copyright>

namespace PeNet.PatternMatching.Tests
{
    [TestClass]
    [PexClass(typeof(Trie))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TrieTest
    {
        [PexMethod]
        public void Add(
            [PexAssumeUnderTest] Trie target,
            string pattern,
            Encoding encoding,
            string name
            )
        {
            target.Add(pattern, encoding, name);
            // TODO: add assertions to method TrieTest.Add(Trie, String, Encoding, String)
        }
    }
}