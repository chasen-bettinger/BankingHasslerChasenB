using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHasslerChasenB
{
    class Account
    {
        private long acctNo { get; set; }
        protected double balance { get; set; }
        public long AcctNo { get { return acctNo; } set { acctNo = value; } }
        public double Balance { get { return balance; } }

        public Account(long acctNo)
        {
            this.acctNo = acctNo;
        }

        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }  

        public virtual double Withdrawal(double amount)
        {  
                balance -= amount;
                return amount;
          
        }



        


    }
}
