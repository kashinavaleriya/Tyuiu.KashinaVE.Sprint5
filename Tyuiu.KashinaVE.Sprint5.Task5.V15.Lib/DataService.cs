using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double min = double.MaxValue;
            bool found = false;

            foreach (string line in lines)
            {
                string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numStr in numbers)
                {
                    string cleanNum = numStr.Replace('.', ',');

                    if (double.TryParse(cleanNum, out double number))
                    {
                       
                        if (number % 5 == 0 && number > 0)
                        {
                            if (number < min)
                            {
                                min = number;
                                found = true;
                            }
                        }
                    }
                }
            }

            if (found)
            {
                return Math.Round(min, 3);
            }

            return 0;
        }
    }
}