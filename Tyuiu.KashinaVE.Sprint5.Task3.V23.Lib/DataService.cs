using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task3.V23.Lib
{
    public class DataService : ISprint5Task3V23
    {
        public string SaveToFileBinaryData(int x)
        {

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");


            if (File.Exists(path))
            {
                File.Delete(path);
            }


            double xDouble = Convert.ToDouble(x);
            double numerator = 1 + Math.Pow(xDouble, 3);
            double denominator = Math.Pow(xDouble, 2);
            double z = numerator / denominator;

            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
            {
                writer.Write(z);
            }

            return path;
        }

        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double xDouble = Convert.ToDouble(x);
            double numerator = 1 + Math.Pow(xDouble, 3);
            double denominator = Math.Pow(xDouble, 2);
            double z = numerator / denominator;

            z = Math.Round(z, 3);

            File.WriteAllText(path, z.ToString());

            return path;
        }
    }
}