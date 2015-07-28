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
        public void CanReadTestFile()
        {
            var ccsd = File.ReadAllLines("ccsd.csv");
        }
    }
}
