using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHasslerChasenB
{
    class Savings : Account
    {
        private double interestRate { get; set; }
        private double minBalance { get; set; }
        public double InterestRate { get { return interestRate; } set { interestRate = value; } }
        public double MinBalance { get { return minBalance; } set { minBalance = value; } }

        public Savings(long acctNumber) : base(acctNumber)
        {
            interestRate = 0.02;
            minBalance = 25.00;
        }

        public override double Withdrawal(double amount)
        {
            if (amount < this.balance - minBalance)
            {
                this.balance -= amount;
            }
            else
            {
                throw new PolicyException("Insufficient Funds");
            }
            return amount;
        }
    }
}
