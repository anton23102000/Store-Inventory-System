﻿namespace Store_Inventory_System.Models;

public class User
{
    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public string UserName { get; set; }
    public string Password { get; set; }
}