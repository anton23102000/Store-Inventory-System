using Store_Inventory_System.Models;

namespace Store_Inventory_System.Menues;

public class MainMenu
{
    private readonly Store _store;
    private readonly BeverageMenu _beverageMenu;
    private readonly FishMenu _fishMenu;
    private readonly MeatMenu _meatMenu;
    private readonly MilkMenu _milkMenu;
    private readonly VegetablesMenu _vegetablesMenu;

    public MainMenu(Store store)
    {
        _store = store;
        _beverageMenu = new BeverageMenu(_store.Beverages);
        _vegetablesMenu = new VegetablesMenu(_store.Vegetables);
        _milkMenu = new MilkMenu(_store.Milk);
        _meatMenu = new MeatMenu(_store.Meat);
        _fishMenu = new FishMenu(_store.Fish);
    }

    public void ShowMainMenu()
    {
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Manage Beverage");
            Console.WriteLine("2. Manage Vegetables");
            Console.WriteLine("3. Manage Milk");
            Console.WriteLine("4. Manage Meat");
            Console.WriteLine("5. Manage Fish");
            Console.WriteLine("6. Log Out");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _beverageMenu.ManageBeverage();
                    break;
                case "2":
                    _vegetablesMenu.ManageVegetables();
                    break;
                case "3":
                    _milkMenu.ManageMilk();
                    break;
                case "4":
                    _meatMenu.ManageMeat();
                    break;
                case "5":
                    _fishMenu.ManageFish();
                    break;
                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}