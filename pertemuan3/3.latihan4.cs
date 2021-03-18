using System;

namespace BAD
{
    class program3_L4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka urutan bulan (ex : 5)");
            int bulan = int.Parse(Console.ReadLine());
            switch (bulan)
            {
                case 1 :
                    Console.WriteLine("Bulan ke-1 adalah Januari");
                    break;
                case 2 :
                    Console.WriteLine("Bulan ke-2 adalah Februari");
                    break;
                case 3 :
                    Console.WriteLine("Bulan ke-3 adalah Maret");
                    break;
                case 4 :
                    Console.WriteLine("Bulan ke-4 adalah April");
                    break;
                case 5 :
                    Console.WriteLine("Bulan ke-5 adalah Mei");
                    break;
                case 6 :
                    Console.WriteLine("Bulan ke-6 adalah Juni");
                    break;
                case 7 :
                    Console.WriteLine("Bulan ke-7 adalah Juli");
                    break;
                case 8 :
                    Console.WriteLine("Bulan ke-8 adalah Agustus");
                    break;
                case 9 :
                    Console.WriteLine("Bulan ke-9 adalah September");
                    break;
                case 10 :
                    Console.WriteLine("Bulan ke-10 adalah Oktober");
                    break;
                case 11 :
                    Console.WriteLine("Bulan ke-11 adalah November");
                    break;
                case 12 :
                    Console.WriteLine("Bulan ke-12 adalah Desember");
                    break;
                default :
                    Console.WriteLine("BULAN CUMA ADA 12!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}