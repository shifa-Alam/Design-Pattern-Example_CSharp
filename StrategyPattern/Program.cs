using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentOption paymentOption = new PaymentOption();
            int orderAmount = 500;
            string selectedMethod = "COD";


            if (selectedMethod.Equals("Bkash")){
                paymentOption.SetOption(new BkashPayment());
                paymentOption.ExecuteOption();
            }
            else if (selectedMethod.Equals("Nagad"))
            {
                paymentOption.SetOption(new NagadPayment());
                paymentOption.ExecuteOption();
            }
            else if (orderAmount >= 500 && selectedMethod.Equals("COD"))
            {
                paymentOption.SetOption(new CODPayment());
                paymentOption.ExecuteOption();
            }
            else
            {
               Console.WriteLine("Sorry! Minimum 500tk order is required for COD");
          }
        }
    }
}
