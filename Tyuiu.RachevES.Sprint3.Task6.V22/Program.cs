using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint3.Task6.V22.Lib;
namespace Tyuiu.RachevES.Sprint3.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                           *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                            *");
            Console.WriteLine("* Задание #6                                                                          *");
            Console.WriteLine("* Вариант #22                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                                 *");
            Console.WriteLine("* принадлежащих числовому отрезку [19, 31] количество всех делителей                  *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            int startValue = 19;
            int stopValue = 31;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Первый отрезок :" + startValue);
            Console.WriteLine("Второй отрезок :" + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Кол-во делителей :" + res);

            Console.ReadKey();
        }
    }
}
