using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AramaAG.Sprint4.Task6.V29.Lib;

namespace Tyuiu.AramaAG.Sprint4.Task6.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Арама А.Г. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс ArrayФайл                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Арама Анастасия Георгиевна | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Весна\", \"Лето\", \"Осень\", \"Зима\"]          *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых   *");
            Console.WriteLine("* больше 4.                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var Seasons = new string[] { "Весна", "Лето", "Осень", "Зима" };
            
            Console.WriteLine("Исходный Массив: ");
            for (int i = 0; i < Seasons.Length; i++)
            {

                    Console.WriteLine(Seasons[i]);

            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(Seasons));
            Console.ReadKey();
        }
    }
}
