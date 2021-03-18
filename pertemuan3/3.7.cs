using System;
using System.Collections;

namespace BAD
{
    class program3_7
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ricky");
            list.Add("Lee");
            list.Add("Rina");

            foreach (string nama in list)
                Console.WriteLine("Nama dalam list : " + nama);

            Console.ReadLine();
        }
    }
}
