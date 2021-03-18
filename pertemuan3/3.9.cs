using System;

namespace BAD
{
    class program3_9
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 8, 0, 5};
            Array.Sort(numbers);

            Console.WriteLine("Berikut angka yang telah diurutkan");
            foreach (int i in numbers)
                Console.WriteLine("-->" + i);
            
            Console.ReadLine();
        }
    }
}
