using System;

namespace UsingSpring
{
    interface IPriceService
    {
        double GetPrice(GrocItem g);
        double GetTax(double subTotal);
    }
}
