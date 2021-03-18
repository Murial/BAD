using System;
					
namespace BAD
{
    public class program3_1
    {
        public static void Main(string[] args)
		{
            int angka;

            Console.WriteLine("Silahkan inputkan angka antara 0 dan 10 : ");
            angka = int.Parse(Console.ReadLine());

            //if (angka > 10 || angka < 0)
                //Console.WriteLine("Hi! Angka yang diinputkan harus antara 0 dan 10 dan tidak lebih besar dari 0");

            if (angka > 10)
                Console.WriteLine("Hi! Angka yang diinputkan harus antara 0 dan 10");
            else if (angka < 0)
                Console.WriteLine("Hi! Angka yang diinputkan harus besar dari 0");
            else
                Console.WriteLine("Mantul Gan!!");
            
            Console.ReadLine();
        }
    }
}