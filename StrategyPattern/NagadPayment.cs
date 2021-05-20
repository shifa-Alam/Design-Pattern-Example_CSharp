using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class NagadPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment with Nagad Successfull!");
        }
    }
}
