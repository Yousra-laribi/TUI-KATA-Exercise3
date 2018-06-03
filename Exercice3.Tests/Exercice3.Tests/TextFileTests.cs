using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3.Services;
using System.IO;
using System.Reflection;

namespace Exercise3.Tests
{
    [TestClass]
    public class TextFileTests
    {
        [TestMethod]
        public void ReadingFileTest_Success()
        {
            
            string expectedValue = "Ceci est un test de lecture d'un fichier .txt";
            Exercise3.DTO.ExerciceFile f = new DTO.ExerciceFile() {
                Path = @"Data\TestFile1.txt"
            };
            var service = new FileServices(f);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingFileTest_EmptyFile()
        {
            string expectedValue = string.Empty;
            Exercise3.DTO.ExerciceFile f = new DTO.ExerciceFile() {
                Path = @"Data\TestFile2.txt"
            };
            var service = new FileServices(f);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

        [TestMethod]
        public void ReadingFileTest_TypeERROR()
        {
            string expectedValue = "ERROR EXTENSION";
            Exercise3.DTO.ExerciceFile f = new DTO.ExerciceFile() {
                Path = @"Data\TestFile3.csv"
            };
            var service = new FileServices(f);
            string calculatedValue = service.ReadFile();
            Assert.AreEqual(calculatedValue, expectedValue);
        }

    }
}
