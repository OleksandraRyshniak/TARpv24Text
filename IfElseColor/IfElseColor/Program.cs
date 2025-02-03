using System.Numerics;

namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saadaolevad värvid: red, blue, green, white.");
            string input = Console.ReadLine()?.ToLower();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Sa ei sisestanud värvi. Palun proovi uuesi.");
            }
            else
            if (input == "red")
            {
                Console.WriteLine("Sa valisid punase värv.");
            }
            else
            if (input == "blue")
            {
                Console.WriteLine("Sa valisid sinise värvi.");
            }
            else
            if (input == "green")
            {
                Console.WriteLine("Sa valisid rohelise värv.");
            }
            else
            if (input == "white")
            {
                Console.WriteLine("Sa valisid valge värv.");
            }
            else
            {
                Console.WriteLine("Värv ei ole õigesti sisestatud.");
            }
        }
    }
}
