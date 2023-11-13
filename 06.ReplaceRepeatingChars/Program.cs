using System;
using System.Text;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        string result = CollapseDuplicateCharacters(inputString);

        Console.WriteLine($"{result}");

        Console.ReadLine(); 
    }

    static string CollapseDuplicateCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder result = new StringBuilder();
        char currentChar = input[0];
        result.Append(currentChar);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != currentChar)
            {
                currentChar = input[i];
                result.Append(currentChar);
            }
        }

        return result.ToString();
    }
}