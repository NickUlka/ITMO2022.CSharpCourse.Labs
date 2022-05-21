using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// lab 1.1 Программа будет спрашивать, как Вас зовут и затем здороваться с Вами по имени.
namespace ITMO2022.CSharp.Lab1._1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name");
           string myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

        }
    }
}
