using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KashinaVE.Sprint5.Task7.V24.Lib;

namespace Tyuiu.KashinaVE.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string inputTemp = Path.GetTempFileName();
            File.WriteAllText(inputTemp, "Привет мир 123");

            string pathSaveFile = ds.LoadDataAndSave(inputTemp);

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            string expectedText = "слово слово 123";
            string actualText = File.ReadAllText(pathSaveFile);
            Assert.AreEqual(expectedText, actualText);

            File.Delete(inputTemp);
            File.Delete(pathSaveFile);
        }
    }
}
