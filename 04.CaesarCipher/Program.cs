using System;
using System.Text;

class Program
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        string encryptedText = EncryptText(inputText);

        Console.WriteLine($"{encryptedText}");

        Console.ReadLine();
    }

    static string EncryptText(string text)
    {
        StringBuilder encryptedText = new StringBuilder();

        foreach (char character in text)
        {
            char encryptedChar = (char)(((int)character + 3));

            encryptedText.Append(encryptedChar);
        }

        return encryptedText.ToString();
    }
}