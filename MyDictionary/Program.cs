using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           

            MDict<int, string> Ogrenciler = new MDict<int, string>();
            Ogrenciler.Add(1, "Çiğdem");
            Ogrenciler.Add(2, "Yıldız");

            Console.WriteLine("---Öğrencilerin Listelenmesi---");
            Ogrenciler.Print();

            Console.WriteLine("---Öğrencilerin Sayısı---");
            Console.WriteLine(Ogrenciler.Count);
        }
    }
}
