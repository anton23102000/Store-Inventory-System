namespace Store_Inventory_System.Models;

public class Store
{
    public readonly List<Beverage> Beverages = new();
    public readonly List<Fish> Fish = new();
    public readonly List<Meat> Meat = new();
    public readonly List<Milk> Milk = new();
    public readonly List<Vegetables> Vegetables = new();
}