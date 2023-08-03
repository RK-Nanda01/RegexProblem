namespace RegexProblem;
class Program
{
    static void Main(string[] args)
    {
        string num;
        RegExpression rg = new RegExpression();
        Console.WriteLine("Welcome to Regular Expression Problems");
        // Check examples  //
        for(int i = 1; i<=8;i++)
        {
            Console.WriteLine("Enter your Phone Number");
            num = Console.ReadLine();

            if (rg.ValidatePhoneNumber(num))
            {
                Console.WriteLine($"The last name {num} is Valid");
            }
            else
            {
                Console.WriteLine($"The last name {num} is InValid");
            }
            
        }

        Console.ReadLine();
    }
}

