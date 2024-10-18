using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_10_18_01_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat

            int osszeg = 0;
            string kartya = "";
            float kedvezmeny = 0;
            float vegosszeg = 0;

            Console.WriteLine("Mennyi a vásárlás összege?");
            osszeg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Van-e törzsvásárlói kártyája? (igen/nem)");
            kartya = Console.ReadLine();

            if (osszeg < 10000) kedvezmeny = 0;
            else if (osszeg >= 10000 && osszeg < 50000 &&  kartya == "nem") kedvezmeny = 0;
            else if (osszeg >= 10000 && osszeg < 50000 && kartya == "igen") kedvezmeny = 5;
            else if (osszeg > 50000 && kartya == "igen") kedvezmeny = 10;
            else if (osszeg > 50000 && kartya == "nem") kedvezmeny = 5;

            float lejon = osszeg * (kedvezmeny / 100);
            vegosszeg = osszeg - lejon;

            Console.WriteLine("A fizetendő összeg: {0} Ft.", vegosszeg);
        }
    }
}
