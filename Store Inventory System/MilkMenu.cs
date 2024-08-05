using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public class MilkMenu
    {
        private List<Milk> SMilk;

        public MilkMenu(List<Milk> smilk)
        {
            SMilk = smilk;
        }
        public void ManageMilk()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Manage Milk");
                Console.WriteLine("1. Add Milk");
                Console.WriteLine("2. Remove Milk");
                Console.WriteLine("3. Show contains of the milk products");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMilk();
                        break;
                    case "2":
                        RemoveMilk();
                        break;
                    case "3":
                        ShowMilk();
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

        public void AddMilk()
        {
            Console.WriteLine("Write name of the Milk:");
            var milkName = Console.ReadLine();
            Console.WriteLine("Enter price:");
            var milkPR = Console.ReadLine();
            double milkPrice = Convert.ToDouble(milkPR);
            Console.WriteLine("Enter quantity:");
            var milkQuantity = Convert.ToInt32(Console.ReadLine());
            var milk = new Milk(milkName, milkPrice, milkQuantity);
            SMilk.Add(milk);
        }

        public void RemoveMilk()
        {
            Console.WriteLine("Enter milk name to remove:");
            var milkName = Console.ReadLine();
            var found = false;
            foreach (var smilk in SMilk)
            {
                var milk = SMilk.Find(s => s.Name == milkName);
                if (milk != null)
                {
                    SMilk.Remove(milk);
                    Console.WriteLine("Milk removed successfully");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Milk not found.");
            }

        }
        public void ShowMilk()
        {
            int sum = 0;
            foreach (var milk in SMilk)
            {
                sum += milk.Quantity;
            }
            Console.WriteLine($"Milk contain{sum}bottles");
            foreach (var milk in SMilk)
            {
                Console.WriteLine($"{milk.Name} - {milk.Quantity}");
            }
        }
    }
}
