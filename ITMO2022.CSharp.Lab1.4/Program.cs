﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO2022.CSharp.Lab1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first integer: ");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.Write("Enter second integer: ");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine($"The result of division {i} on {j} = {k}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }

        }
    }
}
