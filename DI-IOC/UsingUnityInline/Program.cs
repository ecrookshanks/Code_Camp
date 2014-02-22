using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace UsingUnityInline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Unity INLINE configuration...");

            IUnityContainer cont = new UnityContainer().RegisterType<IPriceService, SomePriceService>();

            // Instantiate using unity container and specifying constructor
            CashRegister cr = new CashRegister(cont.Resolve<IPriceService>());

            AddItems(cr);
            cr.PrintReceipt();


            Console.WriteLine("Using the InjectionConstructor...");
            IUnityContainer c2 = new UnityContainer().RegisterType<CashRegister>(new InjectionConstructor(new SomePriceService()));

            CashRegister cr2 = c2.Resolve<CashRegister>();

            AddItems(cr2);
            cr2.PrintReceipt();

            Console.WriteLine("Registering all types in the container...");
            // Finally, register all types in the same container
            IUnityContainer uc3 = new UnityContainer()
                .RegisterType<CashRegister>()
                .RegisterType<IPriceService, PremiumPriceService>(new ContainerControlledLifetimeManager());

            //
            // NOTE: this particular lifetime manager is a long-winded name for a singleton
            //

            CashRegister cr3 = uc3.Resolve<CashRegister>();

            AddItems(cr3);
            cr3.PrintReceipt();


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
