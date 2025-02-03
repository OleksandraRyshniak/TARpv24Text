namespace IfElseFootSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma jalanumber: ");
            int size = int.Parse(Console.ReadLine());
            if (size >= 30 && size <=33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Size: 30-33");
            }
            else
            if (size >= 34 && size <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Size: 34-38");
            }
            else
            if (size >= 39 && size <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Size: 39-44");
            }
            else
            if (size >= 45 && size <= 48)
            {
                Console.Beep();
                Console.WriteLine("Size: 45-48");
            }
            else
            {
                Console.WriteLine("Kasutage teistsugust suurust.");
            }
        }
    }
}
