namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Insert first number and pess enter:");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert first number and pess enter: ");
            float secondNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int calculationtype = int.Parse(Console.ReadLine());



            float result = 0;

            switch (calculationtype)
            {
                case 1:
                    result = firstNr + secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + "+" + secondNr + "=" + result);
                    break;
                case 2:
                    result = firstNr - secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + "-" + secondNr + "=" + result);
                    break;
                case 3:
                    result = firstNr * secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + "*" + secondNr + "=" + result);
                    break;
                case 4:
                    result = firstNr / secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + "/" + secondNr + "=" + result);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
