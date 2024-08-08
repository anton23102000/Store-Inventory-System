using Store_Inventory_System.Menues;
using Store_Inventory_System.Models;

namespace Store_Inventory_System;

public static class Program
{
    public static void Main()
    {
        var store = new Store();
        var users = new List<User>();
        
        var manageStore = new LoginMenu(store, users);
        manageStore.ShowMenu();
    }
}