using System.Text.RegularExpressions;
namespace REXGEX_PATTERNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email ID ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            string namepatterns = "^[0-9a-zA-Z]+[]{0,2}[0-9a-zA-Z]"+"+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            Regex regex = new Regex(namepatterns);  
            if(regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("valid Email id " + name);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Email id " + name);
            }
            
        }
    }
}
