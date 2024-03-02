using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;

namespace Uppg_6_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv "); //Initial mening
            var svar1 = Console.ReadLine();

            Console.WriteLine("En till:");
            var svar2 = Console.ReadLine();

            Console.WriteLine($"Det längsta talet, eller en längsta meningen du matade in var {Längst}");


        }
        static string Längst(string svar1, string svar2)
        {
            if (svar2.Length > svar1.Length)
            {
                return svar2;
            }
            return svar1;

        }

        static int Längst(int svar1, int svar2)
        {
            if (svar2 > svar1)
            {
                return svar2;
            }
            else return svar1;
        }
    }
}
