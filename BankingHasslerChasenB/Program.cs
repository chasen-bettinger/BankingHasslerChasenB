using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHasslerChasenB
{
    class Program
    {
        static void Main(string[] args)
        {

            Checking myCheckingAcct = new Checking(77002);
            myCheckingAcct.Deposit(500.00);
            Console.WriteLine(myCheckingAcct.Balance);

            Savings mySavingsAcct = new Savings(323213);
            mySavingsAcct.Deposit(500.00);
            Console.WriteLine(mySavingsAcct.Balance);
            Console.WriteLine(mySavingsAcct.InterestRate);
            Console.WriteLine(mySavingsAcct.MinBalance);

            try
            {
                mySavingsAcct.Withdrawal(640.00);
            }
            catch (PolicyException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.Read();
        }
    }
}
