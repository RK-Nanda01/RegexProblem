namespace RegexProblem;
class Program
{
    static void Main(string[] args)
    {
        string fname;
        RegExpression rg = new RegExpression();
        Console.WriteLine("Welcome to Regular Expression Problems");
        Console.WriteLine("Enter your first name");
        fname = Console.ReadLine();

        if(rg.ValidateFirstName(fname))
        {
            Console.WriteLine($"The name {fname} is Valid");
        }
        else
        {
            Console.WriteLine($"The name {fname} is InValid");
        }
        Console.ReadLine(); 

    }
}

