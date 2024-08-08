using Store_Inventory_System.Models.Base;
using Store_Inventory_System.Models.Interfaces;

namespace Store_Inventory_System.Models;

public class Vegetables : Product, ICountable
{
    public Vegetables(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void CountAmount()
    {
        Console.WriteLine($"Amount:{Quantity}kilograms");
    }
}