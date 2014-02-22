using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_IOC
{
    class GrocItem
    {
        public GrocItem(String name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
