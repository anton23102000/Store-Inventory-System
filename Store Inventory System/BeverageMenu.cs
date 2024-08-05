using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public class BeverageMenu
    {
        private List<Beverage> Beverages;

        public BeverageMenu(List<Beverage> beverages)
        {
            Beverages = beverages;
        }
        public void ManageBeverage()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Manage Beverage");
                Console.WriteLine("1. Add Beverage");
                Console.WriteLine("2. Remove Beverage");
                Console.WriteLine("3. Show contains of beverages");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBeverage();
                        break;
                    case "2":
                        RemoveBeverage();
                        break;
                    case "3":
                        ShowBeverages();
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

        public void AddBeverage()
        {
            Console.WriteLine("Write name of the Beverage:");
            var beverageName=Console.ReadLine();
            Console.WriteLine("Enter price:");
            var beveragePR=Console.ReadLine();
            double beveragePrice=Convert.ToDouble(beveragePR);
            Console.WriteLine("Enter quantity:");
            var beverageQuantity = Convert.ToInt32(Console.ReadLine());
            var beverage = new Beverage(beverageName, beveragePrice, beverageQuantity);
            Beverages.Add(beverage);
        }

        public void RemoveBeverage()
        {
            Console.WriteLine("Enter beverage name to remove:");
            var beverageName= Console.ReadLine();
            var found = false;
            foreach (var beverages in Beverages)
            {
                var beverage = Beverages.Find(s => s.Name == beverageName);
                if (beverage != null)
                {
                    Beverages.Remove(beverage);
                    Console.WriteLine("Beverage removed successfully");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Beverage not found.");
            }

        }
        public void ShowBeverages()
        {
            int sum = 0;
            foreach (var beverage in Beverages)
            {
                sum += beverage.Quantity;
            }
            Console.WriteLine($"Fish contain{sum}kilograms");
            foreach (var beverage in Beverages)
            {
                Console.WriteLine($"{beverage.Name} - {beverage.Quantity}kg");
            }
        }
    }
}
