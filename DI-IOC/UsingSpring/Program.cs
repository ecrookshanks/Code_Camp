using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Objects;
using Spring.Context;
using Spring.Context.Support;


namespace UsingSpring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Spring.NET xml configuration");

            // IApplicationContext cont = ContextRegistry.GetContext();
            IApplicationContext cont = new XmlApplicationContext("config://spring/objects");
            // IApplicationContext cont = new XmlApplicationContext("spring_config.xml");
            
            CashRegister cr = cont.GetObject("cashRegister") as CashRegister;

            AddItems(cr);
            cr.PrintReceipt();

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
