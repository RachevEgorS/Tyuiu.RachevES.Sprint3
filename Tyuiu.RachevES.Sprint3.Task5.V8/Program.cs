using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint3.Task5.V8.Lib;
namespace Tyuiu.RachevES.Sprint3.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                           *");
            Console.WriteLine("* Тема: Вложенные циклы                                                               *");
            Console.WriteLine("* Задание #5                                                                          *");
            Console.WriteLine("* Вариант #8                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("*     8                                                                               *");
            Console.WriteLine("* S = Σ (6/(n^k))^2                                                                   *");
            Console.WriteLine("*    k=1                                                                              *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("Старт первой суммы чисел :" + startValue1);
            Console.WriteLine("Конец первой суммы чисел :" + stopValue1);
            Console.WriteLine("Старт второй суммы чисел :" + startValue2);
            Console.WriteLine("Конец второй суммы чисел :" + stopValue2);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма рядов :" + res);

            Console.ReadKey();
        }
    }
}
