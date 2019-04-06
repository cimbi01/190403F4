using System;
using System.Collections.Generic;

namespace _190403F4
{
    internal static class Program
    {
        #region Public Constructors

        static Program()
        {
            for (int i = 65; i < 90; i++)
            {
                dictionary.Add((char)i, i - 64);
            }
            // Az Y 25 lesz, ha az A = 1 az ASCII kódtábla szerint
        }

        #endregion Public Constructors

        #region Private Fields

        private static readonly Dictionary<char, int> dictionary = new Dictionary<char, int>();

        #endregion Private Fields

        #region Private Methods

        private static void Main(string[] args)
        {
            Console.WriteLine("Add meg a karaktersorozatot!");
            string karsor = Console.ReadLine().ToUpper();
            char[] kar = karsor.ToCharArray();
            List<int> intek = new List<int>();
            int index = 0;
            for (int i = 0; i < kar.Length; i++)
            {
                object write;
                if (dictionary.TryGetValue(kar[i], out int szam))
                {
                    intek.Add(szam);
                    write = intek[index];
                    index++;
                }
                else
                {
                    write = "Nincs";
                }
                Console.Write("{0} ", write);
            }
            Console.WriteLine("\nProgram Vége");
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}
