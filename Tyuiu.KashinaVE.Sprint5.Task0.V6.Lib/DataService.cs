using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            
            string tempPath = Path.GetTempPath();

            
            string path = Path.Combine(tempPath, "OutPutFileTask0.txt");

            
            double xSquared = Math.Pow(x, 2);
            double denominator = Math.Sqrt(xSquared + x);
            double result = x / denominator;

          
            result = Math.Round(result, 3);

         
            File.WriteAllText(path, result.ToString());

            
            return path;
        }
    }
}

