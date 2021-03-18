using System;
using System.Collections.Generic;

namespace BAD
{
    class program3_11
    {
        static void Main(string[] args)
        {
            //versi 1
            Dictionary<string, int> nama = new Dictionary<string, int>();
            nama.Add("Budi Santoso", 42);
            nama.Add("Iwan Handoko", 38);
            nama.Add("Rini Sulastri", 12);
            nama.Add("Tatik Lestari", 12);
            Console.WriteLine("Versi 1");
            Console.WriteLine("Budi Santoso berusia " + nama["Budi Santoso"] + "tahun");

            //versi 2
            Console.WriteLine("versi 2");
            string key = "Iwan Handoko";
            if (nama.ContainsKey(key))
                Console.WriteLine("Iwan Handoko " + nama[key] + "tahun");
            
            //versi 3
            Console.WriteLine("versi 3");
            foreach (KeyValuePair<string, int> user in nama)
            {
                Console.WriteLine(user.Key + " berusia " + user.Value + " tahun");
            }
            Console.ReadLine();
        }
    }
}
