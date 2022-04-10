using System;

namespace area_and_circumference
{
    public class area_and_circumference
    {
        public static void a_and_c(float r)
        {
            float area, circumference, pie=3.14F;
            area = pie * r * r;
            Console.WriteLine("Area of Circle {0}", area);
            circumference = 2 * pie * r;
            Console.WriteLine("Circumference of Circle {0}", circumference);
        }
        static void Main(string[] args)
        {
            float r;
            Console.WriteLine("Enter Circle Radius: ");
            r= Single.Parse(Console.ReadLine());
            a_and_c(r);
        }
    }
}