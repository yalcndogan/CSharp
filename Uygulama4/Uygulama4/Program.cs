using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Yazın : ");
            string metin = Console.ReadLine();
            int uzunluk = metin.Length;
            Console.Write("Metnin Uzunluğu : " + uzunluk);
            Console.ReadLine();
        }
    }
}