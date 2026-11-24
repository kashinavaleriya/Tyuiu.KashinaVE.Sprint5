using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KashinaVE.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {

            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V24.txt");


            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string text = File.ReadAllText(path);

            string resultText = Regex.Replace(text, @"[а-яА-ЯёЁ]+", "слово");


            File.WriteAllText(pathSaveFile, resultText);

            return pathSaveFile;
        }
    }
}