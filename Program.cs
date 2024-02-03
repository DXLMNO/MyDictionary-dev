using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "Arif");
            users.Add(2, "Tarık");
            users.Add(3, "İsmail");
            users.Add(3, "Engin");

            foreach (Dictionary<int, string> User in users)
            {
                Console.WriteLine("ID:" + User.Keys + "  " + "Name:" + User.Values);
            }

            Console.ReadKey();
        }
    }
}