using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ыаыаыаыаыаыаыаыаыаыаыа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N=m^2-2,8|m|+0,55");
            Random rand = new Random();
            double m = rand.Next(0, 99);
            Console.WriteLine($"m={m}");
            Double N = Math.Pow(m, 2) - 2.8 * Math.Abs(m) + 0.55;
            Console.WriteLine($"N={N}");
            Console.ReadLine();
        }
    }
}
