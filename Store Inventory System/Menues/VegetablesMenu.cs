using Store_Inventory_System.Models;

namespace Store_Inventory_System.Menues;

public class VegetablesMenu
{
    private readonly List<Vegetables> Vegetableses;

    public VegetablesMenu(List<Vegetables> vegetables)
    {
        Vegetableses = vegetables;
    }

    public void ManageVegetables()
    {
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("Manage Vegetables");
            Console.WriteLine("1. Add Vegetables");
            Console.WriteLine("2. Remove Vegetables");
            Console.WriteLine("3. Show contains of vegetables");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddVegetables();
                    break;
                case "2":
                    RemoveVegetables();
                    break;
                case "3":
                    ShowVegetables();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void AddVegetables()
    {
        Console.WriteLine("Write name of the Vegetable:");
        var vegetableName = Console.ReadLine();
        Console.WriteLine("Enter price:");
        var vegetablePR = Console.ReadLine();
        var vegetablePrice = Convert.ToDouble(vegetablePR);
        Console.WriteLine("Enter quantity:");
        var vegetableQuantity = Convert.ToInt32(Console.ReadLine());
        var vegetable = new Vegetables(vegetableName, vegetablePrice, vegetableQuantity);
        Vegetableses.Add(vegetable);
    }

    public void RemoveVegetables()
    {
        Console.WriteLine("Enter vegetable name to remove:");
        var vegetableName = Console.ReadLine();
        var found = false;
        foreach (var vegetables in Vegetableses)
        {
            var vegetable = Vegetableses.Find(s => s.Name == vegetableName);
            if (vegetable != null)
            {
                Vegetableses.Remove(vegetable);
                Console.WriteLine("Vegetable removed successfully");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Vegetable not found.");
    }

    public void ShowVegetables()
    {
        var sum = 0;
        foreach (var vegetable in Vegetableses) sum += vegetable.Quantity;
        Console.WriteLine($"Vegetables contain {sum} kilograms");
        foreach (var vegetable in Vegetableses) Console.WriteLine($"{vegetable.Name} - {vegetable.Quantity}kg");
    }
}