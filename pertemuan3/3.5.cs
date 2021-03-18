using System;

namespace BAD
{
    class program3_5
    {
        static void Main(string[] args)
        {
            int angka = 0;

            do
            {
                Console.WriteLine("Angka ke-" + angka);
                angka = angka + 1;

            } while (angka < 5);

            Console.ReadLine();
        }
    }
}