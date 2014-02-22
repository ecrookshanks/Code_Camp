using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingInterfaces
{
    class SomePriceService : IPriceService
    {
        public double GetPrice(GrocItem g)
        {
            double dPrice = 0.0;

            switch (g.Name)
            {
                case "wine":
                    dPrice = 18.99;
                    break;
                case "cheese":
                    dPrice = 4.99;
                    break;
                case "beer":
                    dPrice = 6.99;
                    break;
                // Other cases here
                default:
                    dPrice = 0.99;
                    break;
            }
            return dPrice;
        }

        public double GetTax(double subTotal)
        {
            double tax = 0.0;

            // hard code 8% tax
            tax = subTotal * 0.08;

            return tax;
        }
    }
}
