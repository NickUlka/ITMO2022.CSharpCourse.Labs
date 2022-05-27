using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// необходимо добавить пространство имен Sysytem.IO для работы с классом потоков - Stream
using System.IO;

// lab 5.1. . Работа с массивами размерных типов.В метод Main в качестве аргумента передается массив,  содержащий параметры
// командной строки (имя файла), передаваемый при запуске программы. 
// Содержимое файла считывается в массив символов, а дальше производятся итерации по всему массиву для подсчета
// количества гласных и согласных. В итоге, на консоль будет выводиться информация об общем количестве символов, гласных,
// согласных и строк.

namespace ITMO2022.CSharp.Lab5._1
{
    internal class Program
    {
        static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;
            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("Total no of characters: {0}", contents.Length);
            Console.WriteLine("Total no of vowels : {0}", vowels);
            Console.WriteLine("Total no of consonants: {0}", consonants);
            Console.WriteLine("Total no of lines : {0}", lines);
        }

        static void Main(string[] args)
        {
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            Summarize(contents);
            reader.Close();
            /*
             Вывод содержимого массива contents, в который ранее считалось содержимое файла, в консоль
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }

       
           Вывод на консоль длины массива и содержимого, введенного ранее пользователем в консоль
            Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);

            }
            */
        }
    }
}
