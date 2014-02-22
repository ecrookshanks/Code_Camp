using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace UsingUnityConfig
{
    class CashRegister
    {
        private List<GrocItem> _itemList = new List<GrocItem>();

        // Instead of instance, use interface
        private IPriceService _ps;

        #region Constructors
        
        // Pass reference in via the constructor
        public CashRegister(IPriceService ps)
        {
            _ps = ps;
        }

        /*
        public CashRegister()
        {
            // Could also use a "default" implementation
            _ps = null;
        }
         */

        #endregion

        // Accessor method
        public IPriceService PriceService
        {
            set { this._ps = value; }
            get { return this._ps; }
        }

        #region utility methods
        
        public void AddItem(GrocItem g)
        {
            _itemList.Add(g);
        }

        public List<GrocItem> Items
        {
            get { return _itemList; }
        }
        
        public void ListItems()
        {
            foreach (var g in _itemList)
            {
                Console.WriteLine(g.Name);
            }
        }
        
        #endregion

        public void ListItemsWithPrices()
        {
            // Manually check to see if a price service exists.
            if (_ps == null)
            {
                throw new ArgumentNullException("IPriceService", "No Price Service Set");
            }

            foreach (GrocItem gi in _itemList)
            {
                Console.WriteLine(string.Format("{0,16} {1:$###.##}", gi.Name, _ps.GetPrice(gi)));
            }
        }
        
        public void PrintReceipt()
        {
            double subTotal = 0.0;
            double tax = 0.0;

            Console.WriteLine("Blah Blah Grocery Store");
            Console.WriteLine("Sales Receipt \n{0}\n", DateTime.Now);

            try
            {
                ListItemsWithPrices();

                foreach (var g in _itemList)
                {
                    subTotal += _ps.GetPrice(g);
                }

                // Don't have to check b/c checked above in ListItemsWithPrices()
                tax = _ps.GetTax(subTotal);

                Console.WriteLine(string.Format("\n{0,16} {1:$###.##}", "Subtotal: ", subTotal));

                Console.WriteLine(string.Format("\n{0,16} {1:$###.##}", "Tax: ", tax));

                Console.WriteLine(string.Format("\n{0,16} {1:$###.##}", "Total: ", subTotal + tax));

                Console.WriteLine("\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught printing receipt: " + ex.Message);
            }
        }

        #region Overloads with passed in PriceService

        public void ListItemsWithPrices(IPriceService ps)
        {
            this.PriceService = ps;
            ListItemsWithPrices();
        }

        public void PrintReceipt(IPriceService ps)
        {
            this.PriceService = ps;
            PrintReceipt();
        }

        #endregion



    }
}
