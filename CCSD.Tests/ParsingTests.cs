using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CCSD.Tests
{
    [TestClass]
    public class ParsingTests
    {
        [TestMethod]
        [DeploymentItem("data/ccsd.csv")]
        public void CodesAreParsedCorrectly()
        {
            var parser = new ClinicalCodesParser();
            var codes = parser.Parse("ccsd.csv");
            Assert.AreEqual(2732, codes.Count);
        }
    }
}
