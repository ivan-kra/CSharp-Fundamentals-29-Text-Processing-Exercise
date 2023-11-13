using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] inputStrings = input.Split(' ');

        if (inputStrings.Length == 2)
        {
            string str1 = inputStrings[0];
            string str2 = inputStrings[1];

            int result = CalculateAsciiSum(str1, str2);

            Console.WriteLine($"{result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter two strings separated by a space.");
        }

        Console.ReadLine(); 
    }

    static int CalculateAsciiSum(string str1, string str2)
    {
        int sum = 0;

        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            sum += str1[i] * str2[i];
        }

        for (int i = minLength; i < str1.Length; i++)
        {
            sum += str1[i];
        }

        for (int i = minLength; i < str2.Length; i++)
        {
            sum += str2[i];
        }

        return sum;
    }
}