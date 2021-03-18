using System;

namespace BAD
{	
	public class program2_6
	{	
		public static void Main(string[] args)
		{
			HaloTeman(0);
			HaloTeman(25, "Ani", "Toni", "Budi");
			Console.ReadLine();
		}
		
		static void HaloTeman(int parameterTambahan, params string[] names)
		{
			foreach (string name in names)
				Console.WriteLine("Halo, " + name);
		}
	}
}