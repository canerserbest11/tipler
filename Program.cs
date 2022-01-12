using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            // ToString
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy); 

            string zz = 12.5.ToString();
            Console.WriteLine(zz);

            // ToInt
            string s1 = "20", s2 = "10";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
            Console.Read();
        }
    }
}
