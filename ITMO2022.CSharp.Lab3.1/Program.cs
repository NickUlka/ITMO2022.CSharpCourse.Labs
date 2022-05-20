using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write("Input the number of day in a year from 1 to 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum =0;
            /* if (dayNum <= 31)
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
             }*/
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

            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();


            Console.WriteLine($"It is {dayNum} of {monthName}");
        }
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
