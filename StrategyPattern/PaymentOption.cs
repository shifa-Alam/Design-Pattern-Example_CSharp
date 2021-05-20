using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class PaymentOption
    {
        IPayment payment;

        public void SetOption(IPayment payment)
        {
            this.payment = payment;
        }
        public void ExecuteOption()
        {
            payment.Pay();
        }
    }
}
