using System;

class Program
{
    static void Main()
    {
        string filePath = Console.ReadLine();

        string[] pathParts = filePath.Split('/', '\\');

        string fileName = pathParts.Length > 0 ? pathParts[pathParts.Length - 1] : filePath;

        string[] nameAndExtension = fileName.Split('.');

        string nameWithoutExtension = nameAndExtension.Length > 1 ? string.Join(".", nameAndExtension, 0, nameAndExtension.Length - 1) : fileName;
        string extension = nameAndExtension.Length > 1 ? nameAndExtension[nameAndExtension.Length - 1] : "No extension";

        Console.WriteLine($"File name: {nameWithoutExtension}");
        Console.WriteLine($"File extension: {extension}");

        Console.ReadLine();
    }
}