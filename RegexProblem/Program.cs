namespace RegexProblem;
class Program
{
    static void Main(string[] args)
    {
        string email;
        RegExpression rg = new RegExpression();
        Console.WriteLine("Welcome to Regular Expression Problems");
        // Check all the examples given separately //
        for(int i = 1; i<=8;i++)
        {
            Console.WriteLine("Enter your Email");
            email = Console.ReadLine();

            if (rg.ValidateEmail(email))
            {
                Console.WriteLine($"The last name {email} is Valid");
            }
            else
            {
                Console.WriteLine($"The last name {email} is InValid");
            }
            
        }

        Console.ReadLine();
    }
}

