using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace RandomColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suvalised värvid!");

            //kasutada switchi
            //kuvab iga kord suvalised värvid
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli

            for (int i = 0; i < 1000; i++)
            {
                Color c = (Color)(new Random()).Next(0, 5);
                switch (c)
                {
                    case Color.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Red");
                        break;

                    case Color.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Green");
                        break;

                    case Color.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Blue");
                        break;

                    case Color.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("White");
                        break;

                    case Color.Orange:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.WriteLine("DarkYellow");
                        break;

                    default:
                        break;
                }
            }
        }

            public enum Color
        {
            Red, Green, Blue, White, Orange
        }
        }
    }

