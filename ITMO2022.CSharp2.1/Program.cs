using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// lab 2.1. Cоздаybt перечисления для представления различных типов банковских счетов
namespace ITMO2022.CSharp.Lab2._1

{
    public enum AccountType { Checking, Deposit };
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

        }
    }
}
