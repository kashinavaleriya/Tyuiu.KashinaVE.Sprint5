using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            strX = strX.Replace('.', ',');

            double x = Convert.ToDouble(strX);

            double y = Math.Pow(x, 3) * Math.Sin(x) - 4 * x;

            y = Math.Round(y, 3);

            return y;
        }
    }
}