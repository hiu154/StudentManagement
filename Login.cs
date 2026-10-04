using System;

public class Login
{
    public bool LoginUser(string username, string password)
    {
        if (username == "admin" && password == "123456")
        {
            Console.WriteLine("Login successful!");
            return true;
        }

        Console.WriteLine("Login failed!");
        return false;
    }
}