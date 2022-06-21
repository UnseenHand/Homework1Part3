using System;

namespace Homework1Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;

            Console.Write("The radius of the circle : ");
            double r = Convert.ToDouble(Console.ReadLine());
            double length = 2 * PI * r;
            double area = PI * r * r;
            double volume = 4 / 3 * PI * r * r * r;
            Console.WriteLine($"The length of the circle : {length}, its area : {area}, and the volume : {volume}");
        }
    }
}
