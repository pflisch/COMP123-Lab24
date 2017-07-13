using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Magneto", 20);
            superHero.AddPower("Turning Invisible", 50);
            superHero.AddPower("Wall Climbing", 40);
            Console.WriteLine(superHero.ToString());


        }
    }
}