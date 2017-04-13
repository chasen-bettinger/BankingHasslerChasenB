using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHasslerChasenB
{
    class PolicyException : Exception
    {
        public PolicyException()
        {

        }

        public PolicyException(string message): base(message)
        {

        }

        public PolicyException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
