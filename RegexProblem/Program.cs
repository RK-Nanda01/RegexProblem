﻿namespace RegexProblem;
class Program
{
    static void Main(string[] args)
    {
        string pass;
        RegExpression rg = new RegExpression();
        Console.WriteLine("Welcome to Regular Expression Problems");
        // Check examples  //
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine("Enter your Password");
            pass = Console.ReadLine();

            if (rg.ValidateFirstName(pass))
            {
                Console.WriteLine($"The Password {pass} is Valid");
            }
            else
            {
                Console.WriteLine($"The Password {pass} is InValid");
            }

        }

        Console.ReadLine();
    }
}

