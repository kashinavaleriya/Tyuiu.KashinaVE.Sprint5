using System.IO;
using Tyuiu.KashinaVE.Sprint5.Task2.V6.Lib;

namespace Tyuiu.KashinaVE.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            int[,] mtrx = new int[3, 3] {
                { -2,  1,  8 },
                { -4, -7,  8 },
                {  6,  5,  5 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
