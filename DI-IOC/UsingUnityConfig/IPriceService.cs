using System;

namespace UsingUnityConfig
{
    interface IPriceService
    {
        double GetPrice(GrocItem g);
        double GetTax(double subTotal);
    }
}
