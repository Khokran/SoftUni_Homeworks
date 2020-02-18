using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Car
{
    class Program    
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Renault", "Megane", 2019, 45, 6);
            Console.WriteLine(myCar.WhoAmI());
            Console.WriteLine(myCar.HowPowerfullAmI());

            myCar.Drive(760);

            Console.WriteLine(myCar.Fuel);

        }
    }
}
