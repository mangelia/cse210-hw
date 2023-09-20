using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentage_by_user = Console.ReadLine();
        int percentage_to_int = int.Parse(percentage_by_user);

        if (percentage_to_int >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (percentage_to_int >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (percentage_to_int >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (percentage_to_int >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (percentage_to_int < 60)
        {
            Console.WriteLine("Your grade is F");
        }
    }
}