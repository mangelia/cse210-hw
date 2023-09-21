using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number_int_while;
        List<int> numbers = new List<int>();


        do
        {
            Console.WriteLine("Enter number:");
            string number = Console.ReadLine();
            int number_int = int.Parse(number);
            number_int_while = number_int;
            if (number_int != 0)
            {
            numbers.Add(number_int);
            }


        }while(number_int_while != 0);

        float sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        long largest_so_far = -99999999999;
        foreach (int n in numbers)
        {
            if (n > largest_so_far)
            {
                largest_so_far=n;
            }
        }
        Console.WriteLine($"The largest is: {largest_so_far}");
    
    }
}