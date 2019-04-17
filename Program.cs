using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            kissa cat = new kissa();
            Console.WriteLine(cat.nimi);
            cat.nimi = "tuukka";
            Console.WriteLine(cat.nimi + cat.Ika);
            kissa cat2 = new kissa();
            Console.WriteLine(cat2.nimi + cat2.Ika);
            Console.ReadKey();
        }
    }
}
