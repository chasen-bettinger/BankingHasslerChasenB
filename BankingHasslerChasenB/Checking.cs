using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHasslerChasenB
{
    class Checking : Account
    {
        private double overdraft { get; set; }
        private double maxWithdrawal { get; set; }
        public double OverDraft { get { return overdraft; } set { overdraft = value; } }
        public double MaxWithdrawal { get { return maxWithdrawal; } set { maxWithdrawal = value; } }

        public Checking(long acctNumber) : base(acctNumber)
        {
            overdraft = 10.00;
            maxWithdrawal = 200.00;         
        }

        public override double Withdrawal(double amount)
        {
            if (amount <= (this.balance + overdraft))
            {
                if (amount <= maxWithdrawal || maxWithdrawal == 0)
                {
                    balance -= amount;
                }
                else
                {
                    throw new PolicyException("Over Max. Withdrawal");
                }
            }
            else
            {
                throw new PolicyException("Insufficient Funds");
            }
            return amount;
        }
    }
}
