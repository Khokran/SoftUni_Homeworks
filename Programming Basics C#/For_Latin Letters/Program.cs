using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
           for (char currentletter = 'a'; currentletter <= 'z'; currentletter++)
            {
                Console.WriteLine(currentletter);
            }
        }
    }
}
