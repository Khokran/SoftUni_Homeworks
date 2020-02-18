using System;

namespace VehiclesExtension
{
    public static class Validator
    {
        internal static void CheckValue(double value)
        { 
            if (value < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
