using System;
namespace UsingUnityInline
{
    interface IPriceService
    {
        double GetPrice(GrocItem g);
        double GetTax(double subTotal);
    }
}
