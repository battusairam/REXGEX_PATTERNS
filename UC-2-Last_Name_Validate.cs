using System.Text.RegularExpressions;
namespace REXGEX_PATTERNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Last Name ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            string namepatterns = "^[A-Z][a-zA-Z]{2,}$";
            Regex regex = new Regex(namepatterns);  
            if(regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("valid Last Name " + name);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Last Name " + name);
            }
            
        }
    }
}
