using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public abstract class Product
    {
        public string Name { get; set; }  
        public double Price { get; set; }
        public int Quantity { get; set; }

        public abstract void CountAmount();
    }
}
