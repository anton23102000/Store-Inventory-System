using Store_Inventory_System.Models;

namespace Store_Inventory_System.Menues;

public class FishMenu
{
    private readonly List<Fish> SFish;

    public FishMenu(List<Fish> sfish)
    {
        SFish = sfish;
    }

    public void ManageFish()
    {
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("Manage Fish");
            Console.WriteLine("1. Add Fish");
            Console.WriteLine("2. Remove Fish");
            Console.WriteLine("3. Show contains of fish products");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddFish();
                    break;
                case "2":
                    RemoveFish();
                    break;
                case "3":
                    ShowFish();
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

    public void AddFish()
    {
        Console.WriteLine("Write name of the Fish:");
        var fishName = Console.ReadLine();
        Console.WriteLine("Enter price:");
        var fishPR = Console.ReadLine();
        var fishPrice = Convert.ToDouble(fishPR);
        Console.WriteLine("Enter quantity:");
        var fishQuantity = Convert.ToInt32(Console.ReadLine());
        var fish = new Fish(fishName, fishPrice, fishQuantity);
        SFish.Add(fish);
    }

    public void RemoveFish()
    {
        Console.WriteLine("Enter fish name to remove:");
        var fishName = Console.ReadLine();
        var found = false;
        foreach (var sfish in SFish)
        {
            var fish = SFish.Find(s => s.Name == fishName);
            if (fish != null)
            {
                SFish.Remove(fish);
                Console.WriteLine("Fish removed successfully");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Fish not found.");
    }

    public void ShowFish()
    {
        var sum = 0;
        foreach (var fish in SFish) sum += fish.Quantity;
        Console.WriteLine($"Fish contain{sum}kilograms");
        foreach (var fish in SFish) Console.WriteLine($"{fish.Name} - {fish.Quantity}kg");
    }
}