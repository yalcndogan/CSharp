using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc = 0;
            Console.Write("1. Sayı : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi2; i++)
            {
                sonuc = sayi1 + sonuc;
            }
            Console.WriteLine("Çarpım Sonucu : " + sonuc);
            Console.ReadKey();
        }
    }
}
