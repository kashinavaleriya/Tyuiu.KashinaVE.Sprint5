using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
          
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                
                if ((Math.Cos(x) + x) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((2.0 * x + 6.0) / (Math.Cos(x) + x)) - 3.0;
                }

                y = Math.Round(y, 2);

                File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
            }

           
            return path;
        }
    }
}