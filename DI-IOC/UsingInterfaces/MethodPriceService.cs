using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingInterfaces
{
    class MethodPriceService : IPriceService
    {
        public double GetPrice(GrocItem g)
        {
            double dPrice = 0.0;

            switch (g.Name)
            {
                case "wine":
                    dPrice = 30.00;
                    break;
                case "cheese":
                    dPrice = 8.00;
                    break;
                case "beer":
                    dPrice = 16.00;
                    break;
                // Other cases here
                default:
                    dPrice = 2.00;
                    break;
            }
            return dPrice;
        }

        public double GetTax(double subTotal)
        {
            double tax = 0.0;

            // hard code 11.5% tax
            tax = subTotal * 0.115;

            return tax;
        }
    }
}
