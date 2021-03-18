using System;

namespace BAD
{						
	public class program2_5
	{
		public static void Main(string[] args)
		{
			int hasil = TambahAngka(5, 10);
			Console.WriteLine("Hasil dari 5 + 10 adalah : " + hasil);
			Console.ReadLine();
		}
		
		public static int TambahAngka(int angka1, int angka2)
		{
			int hasil = angka1 + angka2;
			if (hasil > 5){
				return hasil;
			}
			return 0;
		}
	}
}