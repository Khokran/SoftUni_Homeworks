using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            double thikness = 0.4;
            double rIn = radius - thikness;
            double rOut = radius + thikness;

            for (double y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double point = x * x + y * y;
                    if (point >= rIn * rIn && point <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
