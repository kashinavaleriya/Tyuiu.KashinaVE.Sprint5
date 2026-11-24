
using System;
using System.IO;
using Tyuiu.KashinaVE.Sprint5.Task4.V22.Lib;

namespace Tyuiu.KashinaVE.Sprint5.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Кашина В. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "InPutDataFileTask4V22.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                Console.WriteLine("Убедитесь, что файл InPutDataFileTask4V22.txt лежит в папке: " + Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            }

            Console.ReadKey();
        }
    }
}