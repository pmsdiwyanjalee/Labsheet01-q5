using System;

class Labsheet05
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            DisplayMultiplicationTable(number);
        }
        else
        {
            Console.WriteLine("ERROR: Please enter a valid integer.");
        }
    }

    static void DisplayMultiplicationTable(int number)
    {
        Console.WriteLine($"Multiplication Table for {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
            Console.ReadLine();
        }
    }
}

