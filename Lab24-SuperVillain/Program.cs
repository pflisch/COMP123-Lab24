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
            SuperVillain superVillain = new SuperVillain("Magneto", 20);
            superVillain.AddPower("Invisibility", 50);
            superVillain.AddPower("Nuclear Gun", 40);
            Console.WriteLine(superVillain.ToString());


        }
    }
}