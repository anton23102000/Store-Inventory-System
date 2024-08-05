using Store_Inventory_System;
public static class Program
{
    public static void Main()
    {
        var users = new List<User>();
        var beverage = new List<Beverage>();
        var vegetables = new List<Vegetables>();
        var milk = new List<Milk>();
        var meat = new List<Meat>();
        var fish = new List<Fish>();
        var manageStore = new LoginMenu(users);
        manageStore.ShowMenu();
    }
}