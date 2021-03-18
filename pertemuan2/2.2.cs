using System;

namespace BAD
{		
	public class program2_2
	{
		public static void Main(string[] args)
		{
			string namaDepan = "Budi";
			string namaAkhir = "Anto";
			
			Console.WriteLine("Nama : " + namaDepan + " " + namaAkhir);
			
			Console.WriteLine("Masukkan nama depan : ");
			namaDepan = Console.ReadLine();
			
			Console.WriteLine("Input nama baru : " + namaDepan + " " + namaAkhir);
			Console.ReadLine();
		}
	}
}