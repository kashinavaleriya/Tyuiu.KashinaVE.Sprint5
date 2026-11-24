
using System;
using System.IO;
using Tyuiu.KashinaVE.Sprint5.Task5.V15.Lib;

namespace Tyuiu.KashinaVE.Sprint5.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
           
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "InPutDataFileTask5V15.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}