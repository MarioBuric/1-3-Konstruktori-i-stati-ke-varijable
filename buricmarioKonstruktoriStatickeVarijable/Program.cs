using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmarioKonstruktoriStatickeVarijable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa X = new PrvaKlasa("Andrej", "Kramarić");
            PrvaKlasa Y = new PrvaKlasa("Nikola", "Vlašić");
            PrvaKlasa Z = new PrvaKlasa();
            
            Console.WriteLine(X+ "\n" + Y + "\n" + Z);
            Console.ReadKey();
        }
    }
}