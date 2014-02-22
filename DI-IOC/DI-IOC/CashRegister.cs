using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_IOC
{
    class CashRegister
    {
        private List<GrocItem> _itemList = new List<GrocItem>();

        private PriceService _ps = new PriceService();

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
            ListItemsWithPrices();

            foreach (var g in _itemList)
            {
                subTotal += _ps.GetPrice(g);
            }

            tax = _ps.GetTax(subTotal);

            Console.WriteLine(string.Format("\n{0,16} {1:$###.##}", "Subtotal: ", subTotal));

            Console.WriteLine(string.Format("\n{0,16} {1:$###.##}", "Tax: ", tax));

            Console.WriteLine(string.Format("\n{0,16} {1:$###.##}", "Total: ", subTotal + tax));

        }
    }
}
