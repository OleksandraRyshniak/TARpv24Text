namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raha ümber maa!");

            //vaja arvutada, mitu kahe eurost münti läheb ümber maa
            // maa ümbermõõt tuleb välja arvutada raadiuse abil
            double earthR = 6378000000;
            double CD = 25.75; //mm
            double aroundEarth = 2 * Math.PI * earthR;

            Console.WriteLine("Maa ümbermõõt: " + aroundEarth);

            //nüüd arvutame müntide arvu
            double result = aroundEarth / CD;

            Console.WriteLine("Ümber maa mahub nii " +
                "palju kahe eurosid " + result);

        }
    }
}