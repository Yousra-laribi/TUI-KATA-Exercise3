using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3.Services;
using System.IO;
using System.Reflection;

namespace Exercise3.Tests
{
    [TestClass]
    public class XmlFileTests
    {
        [TestMethod]
        public void ReadingXmlFileTest_Success()
        {
            
            string expectedValue = "<test>ceci est un test de lecture</test>";
            Exercise3.DTO.ExerciceFile f = new DTO.ExerciceFile() {
                Path = @"Data\TestFile1.xml"
            };
            var service = new FileServices(f);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingXmlFileTest_EmptyFile()
        {
            string expectedValue = string.Empty;
            Exercise3.DTO.ExerciceFile f = new DTO.ExerciceFile() {
                Path = @"Data\TestFile2.xml"
            };
            var service = new FileServices(f);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

    }
}
