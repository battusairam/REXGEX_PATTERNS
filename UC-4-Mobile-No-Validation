using System.Text.RegularExpressions;
namespace REXGEX_PATTERNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile No");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            string namepatterns = "^[0-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(namepatterns);  
            if(regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid Mobile No " + name);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Mobile No " + name);
                Console.ResetColor();
            }

        }
    }
}
