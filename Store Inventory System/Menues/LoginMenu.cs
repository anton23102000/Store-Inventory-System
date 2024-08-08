using Store_Inventory_System.Models;

namespace Store_Inventory_System.Menues;

public class LoginMenu
{
    private readonly Store _store;
    private readonly List<User> _users;

    private readonly MainMenu _mainMenu;

    public LoginMenu(Store store, List<User> users)
    {
        _store = store;
        _users = users;
        _mainMenu = new MainMenu(_store);
    }

    public void ShowMenu()
    {
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Student Management System");
            Console.WriteLine("1. Sign-In");
            Console.WriteLine("2. Log-In");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SignIn();
                    break;
                case "2":
                    LogIn();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void SignIn()
    {
        Console.Write("Enter username: ");
        var username = Console.ReadLine();
        Console.Write("Enter password: ");
        var password = Console.ReadLine();

        if (_users.Exists(u => u.UserName == username))
        {
            Console.WriteLine("Username already exists. Please try logging in.");
        }
        else
        {
            _users.Add(new User(username, password));
            Console.WriteLine("User registered successfully.");
        }
    }

    public void LogIn()
    {
        Console.Write("Enter username: ");
        var username = Console.ReadLine();
        Console.Write("Enter password: ");
        var password = Console.ReadLine();

        var user = _users.Find(u => u.UserName == username && u.Password == password);
        if (user != null)
        {
            Console.WriteLine("Login successful!");
            _mainMenu.ShowMainMenu();
        }
        else
        {
            Console.WriteLine("Invalid credentials. Please try again.");
        }
    }
}