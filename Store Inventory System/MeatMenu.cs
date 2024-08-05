using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public class MeatMenu
    {
        private List<Meat> SMeat;

        public MeatMenu(List<Meat> smeat)
        {
            SMeat = smeat;
        }
        public void ManageMeat()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Manage Meat");
                Console.WriteLine("1. Add Meat");
                Console.WriteLine("2. Remove Meat");
                Console.WriteLine("3. Show contains of meat products");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMeat();
                        break;
                    case "2":
                        RemoveMeat();
                        break;
                    case "3":
                        ShowMeat();
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

        public void AddMeat()
        {
            Console.WriteLine("Write name of the Meat:");
            var meatName = Console.ReadLine();
            Console.WriteLine("Enter price:");
            var meatPR = Console.ReadLine();
            double meatPrice = Convert.ToDouble(meatPR);
            Console.WriteLine("Enter quantity:");
            var meatQuantity = Convert.ToInt32(Console.ReadLine());
            var meat = new Meat(meatName, meatPrice, meatQuantity);
            SMeat.Add(meat);
        }

        public void RemoveMeat()
        {
            Console.WriteLine("Enter meat name to remove:");
            var meatName = Console.ReadLine();
            var found = false;
            foreach (var smeat in SMeat)
            {
                var meat = SMeat.Find(s => s.Name == meatName);
                if (meat != null)
                {
                    SMeat.Remove(meat);
                    Console.WriteLine("Meat removed successfully");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Meat not found.");
            }

        }
        public void ShowMeat()
        {
            int sum = 0;
            foreach (var meat in SMeat)
            {
                sum += meat.Quantity;
            }
            Console.WriteLine($"Meat contain{sum}kilograms");
            foreach (var meat in SMeat)
            {
                Console.WriteLine($"{meat.Name} - {meat.Quantity}kg");
            }
        }
    }
}
