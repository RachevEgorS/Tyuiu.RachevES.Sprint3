using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint3.Task4.V2.Lib;

namespace Tyuiu.RachevES.Sprint3.Task4.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                           *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                            *");
            Console.WriteLine("* Задание #4                                                                          *");
            Console.WriteLine("* Вариант #2                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                                    *");
            Console.WriteLine("* вычислить значение функции y=cos(x)/x                                               *");
            Console.WriteLine("*При х = 0 прервать цикл. Полученные значения суммировать.                            *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                    * ");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);


            Console.WriteLine("Старт :" + startValue);
            Console.WriteLine("Конец :" + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма ряда :" + res);

            Console.ReadKey();
        }
    }
}
