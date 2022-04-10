using System;

namespace methodcall
{
    public class methodcall
    {
        public static void staticMethod(int[] integer)
        {
            int sum=0;
            for (int i = 0; i < integer.Length; i++)
                sum += integer[i];
            Console.WriteLine("Sum of all integers {0}", sum);
        }
        public static void Main(string[] args)
        {
            int[] integer = new int[5];
            for (int i = 0; i < integer.Length; i++)
                integer[i] = Convert.ToInt32(Console.ReadLine());
            staticMethod(integer);
        }
    }
}