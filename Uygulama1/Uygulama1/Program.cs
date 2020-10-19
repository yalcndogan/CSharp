using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int BuyukSayi(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
                return sayi1;
            else if (sayi2 > sayi1)
                return sayi2;
            else
                return sayi1;
        }
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı giriniz : ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Büyük sayı : " + BuyukSayi(s1, s2));
            Console.ReadKey();
        }
    }
}

