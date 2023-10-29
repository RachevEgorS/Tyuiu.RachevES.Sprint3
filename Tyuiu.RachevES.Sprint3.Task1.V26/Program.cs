using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint3.Task1.V26.Lib;

namespace Tyuiu.RachevES.Sprint3.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                           *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                               *");
            Console.WriteLine("* Задание #1                                                                          *");
            Console.WriteLine("* Вариант #26                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет сумму ряда по формуле,  *");
            Console.WriteLine("* при n = 5                                                                           *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*     8                                                                               *");
            Console.WriteLine("* S = Σ (6/(n^k))^2                                                                   *");
            Console.WriteLine("*    k=1                                                                              *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            int value, startValue, stopValue;
            value = 5; startValue = 1; stopValue = 8;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Старт шага равен " + startValue);
            Console.WriteLine("Конец шага равен " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма ряда =" + res);

            Console.ReadKey();
        }
    }
}
