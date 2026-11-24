using System.IO;
using Tyuiu.KashinaVE.Sprint5.Task3.V23.Lib;

namespace Tyuiu.KashinaVE.Sprint5.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;


            string path = ds.SaveToFileBinaryData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}


