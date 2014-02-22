using System;
namespace UsingInterfaces
{
    interface IPriceService
    {
        double GetPrice(GrocItem g);
        double GetTax(double subTotal);
    }
}
