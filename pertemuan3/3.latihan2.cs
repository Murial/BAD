using System;

namespace BAD
{
    class program3_L2
    {
        static void Main(string[] args)
        {
            string saya = "mukmin arrijal";

            Console.WriteLine("Inputkan nama anda: ");
            string nama = Console.ReadLine();

            if(nama == saya)
                Console.WriteLine("Selamat Datang " + saya);
            else
                Console.WriteLine("Maaf, nama anda tidak dikenali");

        }
    }
}