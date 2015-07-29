using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

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
            Assert.AreEqual(2731, codes.Count);
        }

        [TestMethod]
        [DeploymentItem("data/onlytableheader.csv")]
        public void ParserIgnoresTableHeader()
        {
            var parser = new ClinicalCodesParser();
            var codes = parser.Parse("onlytableheader.csv");
            Assert.AreEqual(0, codes.Count);
        }
    }
}
