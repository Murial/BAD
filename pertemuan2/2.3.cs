using System;

namespace BAD
{	
    public class program2_3
    {
        public static void Main(string[] args)
        {
            int number1, number2;
            
            Console.WriteLine("Silahkan masukkan angka 1 : ");
            number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Silahkan masukkan angka 2 : ");
            number2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Hasil penjumlahan : " + (number1 + number2));
            Console.ReadLine();
        }
    }
}
