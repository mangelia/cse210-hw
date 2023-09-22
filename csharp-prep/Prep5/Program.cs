using System;

class Program
{
    static void DisplayWelcome()
    {
    Console.WriteLine("\"Welcome to the Program!\"");
    }

    static void PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Your name is {name}");
    }

    static void PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number");
        string number = Console.ReadLine();
        int number_int = int.Parse(number);
        Console.WriteLine($"Your favorite number is {number_int}");
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        
        Console.WriteLine("What is the square that you want to calculate");
        string number = Console.ReadLine();
        int number_int = int.Parse(number);
        Console.WriteLine($"The square is {SquareNumber(number_int)}");

    }

    


}