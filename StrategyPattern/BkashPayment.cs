using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class BkashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Pay with Bkash is successful");
        }
    }
}
