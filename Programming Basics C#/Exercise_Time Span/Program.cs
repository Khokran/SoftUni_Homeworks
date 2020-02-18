using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = new TimeSpan(12, 0, 0);
            TimeSpan timeToAdd = new TimeSpan(3, 0, 0);
            TimeSpan result = time.Add(timeToAdd);

            Console.WriteLine(result);



        }
    }
}
