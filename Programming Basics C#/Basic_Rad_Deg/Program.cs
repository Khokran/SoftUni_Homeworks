using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Rad_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = double.Parse(Console.ReadLine());
            rad = deg * Math.PI / 180;
            deg = rad * 180 / Math.PI;
            var area = Math.PI * rad * deg;
            Console.WriteLine(Math.Round(rad, deg, 2));
            Console.WriteLine(area);
        }
    }
}
