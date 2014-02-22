using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UsingUnityConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Unity XML configuration...");

            IUnityContainer cont = new UnityContainer().LoadConfiguration();

            CashRegister cr = cont.Resolve<CashRegister>();

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
