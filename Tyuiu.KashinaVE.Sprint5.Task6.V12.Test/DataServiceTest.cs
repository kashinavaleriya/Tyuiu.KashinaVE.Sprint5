using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KashinaVE.Sprint5.Task6.V12.Lib;

namespace Tyuiu.KashinaVE.Sprint5.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "InPutDataFileTask6V12.txt");

            int res = ds.LoadFromDataFile(path);
            int wait = 3; 

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "InPutDataFileTask6V12.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
