using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CODPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Pay with COD is successful");
        }
    }
}
