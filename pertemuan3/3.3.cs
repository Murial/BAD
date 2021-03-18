using System;

namespace BAD
{
    class program3_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apakah C# menarik? (ya/tidak/biasa)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "ya" :
                case "biasa" :
                    Console.WriteLine("Luar biasa!");
                    break;
                case "tidak" :
                    Console.WriteLine("Yah,sayang banget!");
                    break;
                default :
                    Console.WriteLine("Maaf inputan anda tidak dapat dipahami");
                    break;
            }
            Console.ReadLine();
        }
    }
}