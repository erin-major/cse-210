using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(square, name); 

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());

        return favNum; 
    }

    static int SquareNumber(int number)
    {
        int squaredNum = number * number;

        return squaredNum;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}