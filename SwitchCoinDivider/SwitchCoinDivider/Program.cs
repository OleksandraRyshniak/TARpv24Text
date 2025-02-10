using System.Diagnostics;

namespace SwitchCoinDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int one = 1, two = 2, five = 5, ten = 10, twenty = 20, fifty = 50;
            Console.WriteLine("Enter sum and press enter: ");
            int sum = int.Parse(Console.ReadLine());
            int centAmmount = 0;

            if (sum >= fifty)
            {
                centAmmount = sum / fifty;
                Console.WriteLine("50 sendised: " + centAmmount);
            }
            if (sum >= twenty)
            {
                sum = sum - centAmmount * fifty;
                centAmmount = sum / twenty;
                Console.WriteLine("20 sendised: " + centAmmount);
            }
            if (sum >= ten)
            {
                sum = sum - centAmmount * twenty;
                centAmmount = sum / ten;
                Console.WriteLine("10 sendised: " + centAmmount);
            }
            if (sum >= five)
            {
                sum = sum - centAmmount * ten;
                centAmmount = sum / five;
                Console.WriteLine("5 sendised: " + centAmmount);
            }
            if (sum >= two)
            {
                sum = sum - centAmmount * five;
                centAmmount = sum / two;
                Console.WriteLine("2 sendised: " + centAmmount);
            }
            if (sum >= one)
            {
                sum = sum - centAmmount * two;
                centAmmount = sum / one;
                Console.WriteLine("1 sendised: " + centAmmount);
            }
            else
            {
                Console.WriteLine("Rohkem ei ole");
            }
        }
    }
}
