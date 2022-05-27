using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// lab 4.2. Использование в методах параметров, передаваемых по ссылке. Дополнительно к lab 4.1. создан метод Swap,
// который меняет местами значения параметров, передаваемых по ссылке, из метода Greater.

namespace ITMO2022.CSharp.Lab4._2
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
            
            Console.WriteLine("Before swap: first number = " + x + ", second = " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: first number = " + x + ", second = " + y);

        }
        static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
