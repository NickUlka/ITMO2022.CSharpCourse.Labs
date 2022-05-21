using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// lab 4.1. Использование параметров в методах, возвращающих значения. Создан класс Utils, в котором определяется метод Greater.
// Этот метод будет принимать два целочисленных параметра и возвращать больший из них. Для тестирования работы данного класса
// создадан еще один класс (класс Test), в котором у пользователя запрашиваются два числа, далее вызывается
// метод Utils.Greater, после чего на экран консоли выводится результат.  

namespace ITMO2022.CSharp.Lab4._1
{
    internal class Utils
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

        }
        static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

    }
}
