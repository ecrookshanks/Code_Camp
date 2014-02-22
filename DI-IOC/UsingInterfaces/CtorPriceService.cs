using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingInterfaces
{
    class CtorPriceService : IPriceService
    {
        public double GetPrice(GrocItem g)
        {
            double dPrice = 0.0;

            switch (g.Name)
            {
                case "wine":
                    dPrice = 15.25;
                    break;
                case "cheese":
                    dPrice = 5.50;
                    break;
                case "beer":
                    dPrice = 9.75;
                    break;
                // Other cases here
                default:
                    dPrice = 0.75;
                    break;
            }
            return dPrice;
        }

        public double GetTax(double subTotal)
        {
            double tax = 0.0;

            // hard code 7.5% tax
            tax = subTotal * 0.075;

            return tax;
        }
    }
}
