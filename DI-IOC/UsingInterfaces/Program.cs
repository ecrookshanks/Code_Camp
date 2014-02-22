using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            // TODO: Change the class to have a PriceService for EACH type
            // and have the SomePriceService be the default.
            // AccessorPriceService, MethodPriceService, etc.
            //

            Console.WriteLine("Default implementation...");
            
            CashRegister cr = new CashRegister();
            AddItems(cr);
            cr.PrintReceipt();
            


            Console.WriteLine("Using the accessor...");
            // Setting via an accessor
            CashRegister cr1 = new CashRegister();
            cr1.PriceService = new SetterPriceService();

            AddItems(cr1);
            cr1.PrintReceipt();
            
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Using the constructor...");
            // Setting via the constructor
            CashRegister cr2 = new CashRegister(new CtorPriceService());

            AddItems(cr2);
            cr2.PrintReceipt();

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Using the method...");
            // Setting via the method
            CashRegister cr3 = new CashRegister();
            AddItems(cr3);
            cr3.PrintReceipt(new MethodPriceService());

            
            Console.Write("\n\nPress enter to quit...");
            Console.ReadLine();
        }

        static void AddItems(CashRegister c)
        {
            c.AddItem(new GrocItem("wine"));
            c.AddItem(new GrocItem("cheese"));
            c.AddItem(new GrocItem("beer"));
        }
    }
}
