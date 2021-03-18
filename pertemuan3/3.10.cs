using System;
using System.Collections.Generic;

namespace BAD
{
    class program3_10
    {
        static void Main(string[] args)
        {            
            //versi 1
            List<string> ListNama = new List<string>()
                {"Budi", "Hasan", "Santoso"};
            Console.WriteLine("isi dari list index ke 0 : " + ListNama[0]);   

            // int nomor = 0;
            // foreach (string nama in ListNama){
            //     Console.WriteLine($"isi dari list index ke-{nomor} : {nama}");
            //     nomor++;
            // }

            Console.WriteLine();

            //versi2
            var angka1 = new List<int>();
            angka1.Add(2);
            angka1.Add(3);
            angka1.Add(5);
            angka1.Add(7);
            Console.WriteLine("total isi list 1 : " + angka1.Count);

            // angka1.Remove(2);
            // nomor = 0;
            // foreach (int angka in angka1){
            //     Console.WriteLine($"isi dari list 1 index ke-{nomor} : {angka}");
            //     nomor++;
            // }

            Console.WriteLine();

            //versi3
            var angka2 = new List<int>() {2, 3, 5, 7};
            Console.WriteLine("Total isi list 2 : " + angka2.Count);
            
            // nomor = 0;
            // foreach (int angka in angka2){
            //     Console.WriteLine($"isi dari list 2 index ke-{nomor} : {angka}");
            //     nomor++;
            // }

            Console.ReadLine();
        }
    }
}
