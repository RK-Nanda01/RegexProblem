namespace RegexProblem;
class Program
{
    static void Main(string[] args)
    {
        string lname;
        RegExpression rg = new RegExpression();
        Console.WriteLine("Welcome to Regular Expression Problems");
        Console.WriteLine("Enter your last name");
        lname = Console.ReadLine();

        if(rg.ValidateName(lname))
        {
            Console.WriteLine($"The last name {lname} is Valid");
        }
        else
        {
            Console.WriteLine($"The last name {lname} is InValid");
        }
        Console.ReadLine(); 

    }
}

