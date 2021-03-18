using System;

namespace BAD
{
    class program3_8
    {
        static void Main(string[] args)
        {
            string[] nama = new string[2];

            nama[0] = "Budi Susanto";
            nama[1] = "Rina Sukawati";
            Console.WriteLine("Berikut nama dari Array : ");
            for (int i = 0; i < nama.Length; i++)
                Console.WriteLine("-->" + nama[i]);
            // foreach (string s in nama)
            //     Console.WriteLine("-->" + s);
            Console.ReadLine();
        }
    }
}
