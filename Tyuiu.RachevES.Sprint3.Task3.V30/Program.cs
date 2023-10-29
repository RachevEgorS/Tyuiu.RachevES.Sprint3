using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint3.Task3.V30.Lib;
namespace Tyuiu.RachevES.Sprint3.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                           *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                        *");
            Console.WriteLine("* Задание #3                                                                          *");
            Console.WriteLine("* Вариант #30                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");

            Console.WriteLine("*     'fyyklbtyn ygrc vfyyyyh'                                                        * ");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';

            int res = ds.GetMaxCharCount(value, item);

          
         
            Console.WriteLine("строка :" + value);
            Console.WriteLine("символ :" + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("кол-во соседних y :" + res);

            Console.ReadKey();
        }
    }
}
