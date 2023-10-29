using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint3.Task2.V12.Lib;
namespace Tyuiu.RachevES.Sprint3.Task2.V12
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
            Console.WriteLine("* Задание #2                                                                          *");
            Console.WriteLine("* Вариант #12                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, используя цикл do-while, которая вычисляет сумму ряда по формуле*");
            Console.WriteLine("* при x = 5                                                                           *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*     5                                                                               *");
            Console.WriteLine("* S = Σ (300/(i+x^i))^i                                                               *");
            Console.WriteLine("*    i=1                                                                              *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            int value, startValue, stopValue;
            value = 5; startValue = 1; stopValue = 5;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Старт шага равен " + startValue);
            Console.WriteLine("Конец шага равен " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Произведение ряда =" + res);

            Console.ReadKey();
        }
    }
}
