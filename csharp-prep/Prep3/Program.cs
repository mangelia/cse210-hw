using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the magic number? Please type your guess between 1 and 100!");
        Random randomGenerator = new Random();

        //This section is for the random number
        int number = randomGenerator.Next(1, 100);
        int answer_to_int = number;
        int answer_guess_to_int_while;
        Console.WriteLine(number);

        /* This section works when the user types the magic number
        string answer = Console.ReadLine();
        int answer_to_int = int.Parse(answer);
        int answer_guess_to_int_while;
        */

        do
        {
        Console.Write("What is your guess?");
        string answer_guess = Console.ReadLine();
        int answer_guess_to_int = int.Parse(answer_guess);
        answer_guess_to_int_while = answer_guess_to_int;

        if (answer_guess_to_int == answer_to_int)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (answer_guess_to_int > answer_to_int)
        {
            Console.WriteLine("Lower");
        }
        else if(answer_guess_to_int < answer_to_int)
        {
            Console.WriteLine("Higher");
        }

        }while(answer_to_int != answer_guess_to_int_while);

    }
}