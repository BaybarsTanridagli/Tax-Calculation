using System;

class KDV
{
    static void Main(string[] args)
    {
        string sayi;
        Console.Write("Please first number");
        sayi = Console.ReadLine();
        Double KDV = 0.18;

        Console.WriteLine("The number you entered %18 :" + (Convert.ToDouble(sayi) * KDV));
        Console.ReadKey();
    }
}