using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingUnityConfig
{
    class PremiumPriceService : IPriceService
    {
        public double GetPrice(GrocItem g)
        {
            double dPrice = 0.0;

            switch (g.Name)
            {
                case "wine":
                    dPrice = 28.99;
                    break;
                case "cheese":
                    dPrice = 9.99;
                    break;
                case "beer":
                    dPrice = 12.99;
                    break;
                // Other cases here
                default:
                    dPrice = 2.99;
                    break;
            }
            return dPrice;
        }

        public double GetTax(double subTotal)
        {
            double tax = 0.0;

            // hard code 9.5% tax
            tax = subTotal * 0.095;

            return tax;
        }
    }
}
