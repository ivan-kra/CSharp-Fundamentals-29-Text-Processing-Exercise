using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] usernames = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string username in usernames)
        {
            if (IsValidUsername(username))
            {
                Console.WriteLine(username);
            }
        }

        Console.ReadLine(); 
    }

    static bool IsValidUsername(string username)
    {
        if (username.Length < 3 || username.Length > 16)
        {
            return false;
        }

        foreach (char c in username)
        {
            if (!Char.IsLetterOrDigit(c) && c != '-' && c != '_')
            {
                return false;
            }
        }

        return true;
    }
}