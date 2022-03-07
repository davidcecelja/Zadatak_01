using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Zadatak_Tria
{
    internal class Program
    {
        private const string Pattern = @"(?:^|(?<![-0-9]))([0-9]+)";
        static void Main()
        {
            int rezultat = 0;
            string[] niz = new string[5];
            niz = new string[5] { "asd5k55", "", "h-4jh5", "", "sde4h-6h7" };
            foreach (string s in niz)
            {
                string[] input = Regex.Split(s, Pattern);
                foreach (string _s in input)
                {
                    int broj;
                    if (int.TryParse(_s, out broj))
                    {
                        rezultat += broj;
                    }
                }
            }
            Console.WriteLine("Zbroj je: {0}", rezultat);
        }
    }
}
