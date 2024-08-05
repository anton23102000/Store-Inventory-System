using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public class Beverage : Product, ICountable
    {
        public override void CountAmount()
        {
            Console.WriteLine($"Amount:{Quantity}bottles");
        }

        public Beverage(string name, double price, int quantity)
        { 
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
