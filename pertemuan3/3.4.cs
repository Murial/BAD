using System;

namespace BAD
{
    class program3_4
    {
        static void Main(string[] args)
        {
            int angka = 0;

            while (angka < 5)
            {
                Console.WriteLine("Angka ke-" + angka);
                angka = angka +1;
            }
            Console.ReadLine();
        }
    }
}