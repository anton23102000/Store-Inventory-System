using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public class Meat: Product, ICountable
    {
        public Meat(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public override void CountAmount()
        {
            Console.WriteLine($"Amount:{Quantity}kilograms");
        }
    }
}
