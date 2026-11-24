using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task2.V6.Lib
{
    public class DataService : ISprint5Task2V6
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");


            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0) matrix[i, j] = 1;
                    else if (matrix[i, j] < 0) matrix[i, j] = 0;
                }
            }


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str = str + matrix[i, j] + ";";
                    else
                        str = str + matrix[i, j];
                }


                if (i != rows - 1)
                    File.AppendAllText(path, str + Environment.NewLine);
                else
                    File.AppendAllText(path, str);
            }

            return path;
        }
    }
}

