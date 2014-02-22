using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr = new CashRegister();

            cr.AddItem(new GrocItem("wine"));
            cr.AddItem(new GrocItem("cheese"));
            cr.AddItem(new GrocItem("beer"));

            cr.PrintReceipt();

            Console.Write("\n\nPress enter to quit...");
            Console.ReadLine();
        }
    }
}
