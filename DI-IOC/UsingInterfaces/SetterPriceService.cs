using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingInterfaces
{
    class SetterPriceService : IPriceService
    {
        public double GetPrice(GrocItem g)
        {
            double dPrice = 0.0;

            switch (g.Name)
            {
                case "wine":
                    dPrice = 11.99;
                    break;
                case "cheese":
                    dPrice = 2.99;
                    break;
                case "beer":
                    dPrice = 10.99;
                    break;
                // Other cases here
                default:
                    dPrice = 3.99;
                    break;
            }
            return dPrice;
        }

        public double GetTax(double subTotal)
        {
            double tax = 0.0;

            // hard code 2% tax
            tax = subTotal * 0.02;

            return tax;
        }
    }
}
