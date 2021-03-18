using System;
	
namespace BAD
{					
	public class program2_4
	{
		private static string helloClass = "hallo, Class";
		
		public static void Main(string[] args)
		{
			string helloLocal = "hello Local";
			Console.WriteLine(helloLocal);
			Console.WriteLine(program2_4.helloClass);
			TestFunction();
		}
		
		static void TestFunction()
		{
			Console.WriteLine("Pemanggilan variabel dari function TestFucntion " + program2_4.helloClass);
			Console.ReadLine();
		}
	}
}