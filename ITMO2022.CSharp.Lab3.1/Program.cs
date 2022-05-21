using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// lab 3.1 Преобразование дня года в дату типа  месяц - день
// lab 3.2 Проверка вводимого пользователем значения  дня года c пользовательским обработчиком исключительных ситуаций
// lab 3.3 Учет високосных годов. Конечный вариант программы будет запрашивать у пользователя не только день года, но и сам год.
// Программа будет определять, является ли год високосным. Если да, то будет проверяться, попадает ли значение дня года в диапазон
// от 1 до 366. Если год не является високосным, то проверяется попадание значения дня года в диапазон от 1 до 365. 

namespace ITMO2022.CSharp.Lab3._1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input a year: ");
                int yearNum=int.Parse(Console.ReadLine());

                // опеределение (не)високосного года (isLeapYear true, если год високосный)
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);

                /* проверка високосности:
                 if (isLeapYear)
                     Console.WriteLine(yearNum + "  - IS a leap year");
                 else
                     Console.WriteLine(yearNum + " - is NOT a leap year");
                
                 Присваивание переменной maxDayNum 366, если год високосный и 365, если нет и вывод на экран
                в качестве правой границы диапазона ввода */
                int maxDayNum = isLeapYear ? 366 : 365;
                Console.Write($"Input a days number in a year from 1 to {maxDayNum}: ");
                int dayNum = int.Parse(Console.ReadLine());

                // lab 3.2. Проверка вводимого пользователем значения  дня года c пользовательским обработчиком исключений
                if (dayNum < 1 || dayNum > maxDayNum)
                    throw new ArgumentOutOfRangeException(dayNum + " is out of days in the year range");

                /* Первоначальный вариант - преобразование дня года в дату типа  месяц - день

                  int monthNum = 0;
                 if (dayNum <= 31)
                     monthNum=0;
                 else
                 {
                     dayNum-=31;
                     if (dayNum <=28)
                         monthNum=1;
                     else
                     {
                         dayNum-=28;
                         if (dayNum <=31)
                             monthNum=2;
                         else
                         { 
                             dayNum-=31;
                             if (dayNum <=30)
                                 monthNum=3;
                             else
                             { 
                                 dayNum-=30;
                                 if (dayNum <=31)
                                     monthNum=4;
                                 else
                                 {
                                     dayNum -= 31;
                                     if (dayNum <=30)
                                         monthNum=5;
                                     else
                                     {
                                         dayNum -= 30;
                                         if (dayNum <=31)
                                             monthNum =6;
                                         else 
                                         {
                                             dayNum -= 31;
                                             if (dayNum <=31)
                                                 monthNum =7;
                                             else
                                             {
                                                 dayNum -= 31;
                                                 if (dayNum <=30)
                                                     monthNum =8;
                                                 else
                                                 {
                                                     dayNum -= 30;
                                                     if (dayNum <=31)
                                                         monthNum=9;
                                                     else
                                                     {
                                                         dayNum-=31;
                                                         if (dayNum <=30)
                                                             monthNum=10;
                                                         else
                                                         {
                                                             dayNum -= 30;
                                                             if (dayNum <= 31)
                                                                 monthNum = 11;
                                                         }
                                                     }
                                                 }
                                             }
                                         }
                                     }
                                 }
                             }
                         }
                     }

                 }
                 string monthName;
                 switch (monthNum)
                 {
                     case 0:
                         monthName = "January"; 
                         break;
                     case 1:
                         monthName = "February"; 
                         break;
                     case 2:
                         monthName = "March"; 
                         break;
                     case 3:
                         monthName = "April"; 
                         break;
                     case 4:
                         monthName = "May"; 
                         break;
                     case 5:
                         monthName = "June";
                         break;
                     case 6:
                         monthName = "July"; 
                         break;
                     case 7:
                         monthName = "August"; 
                         break;
                     case 8:
                         monthName = "September"; 
                         break;
                     case 9:
                         monthName = "October"; 
                         break;
                     case 10:
                         monthName = "November"; 
                         break;
                     case 11:
                         monthName = "December"; 
                         break;
                     default:
                         monthName = "not done yet"; 
                         break;
                }
                
                 
                 lab 3.3 Учет високосных годов.
                 */
                int monthNum = 0;
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                            break;
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                            break;
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine($"It is {dayNum} of {monthName}");
            }

            catch (Exception caught)
            {
                Console.WriteLine(caught.Message);
            }
        }
        // создание коллекции дней в невисокосном году
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // создание коллекции дней в високосном году
        static System.Collections.ICollection DaysInLeapMonths
            = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
