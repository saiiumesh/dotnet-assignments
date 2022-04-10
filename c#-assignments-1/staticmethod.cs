using System;

namespace swapping2vars
{
    public class swapping
    {
        public static void Swap(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A: {0}\n B: {1}",a,b);
        }
        public static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Swap(a, b);
        }
    }
}