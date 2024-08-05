using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory_System
{
    public class MainMenu
    {
        private List<Beverage> _beverages;
        private List<Vegetables> _vegetables;
        private List<Milk> _smilk;
        private List<Meat> _smeat;
        private List<Fish> _sfish;
        private BeverageMenu _beverageMenu;
        private VegetablesMenu _vegetablesMenu;
        private MilkMenu _milkMenu;
        private MeatMenu _meatMenu;
        private FishMenu _fishMenu;

        public MainMenu(List<Beverage>beverages,List<Vegetables> vegetables,List<Milk> smilk, List<Meat> smeat, List<Fish> sfish)
        {
            _beverages = beverages;
            _vegetables = vegetables;
            _smilk = smilk;
            _smeat = smeat;
            _sfish = sfish;
            _beverageMenu = new BeverageMenu(_beverages);
            _vegetablesMenu = new VegetablesMenu(_vegetables);
            _milkMenu = new MilkMenu(_smilk);
            _meatMenu = new MeatMenu(_smeat);
            _fishMenu = new FishMenu(_sfish);
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
}
