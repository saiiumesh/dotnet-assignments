
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  GenericCollections
{
    class Main
    {
        public void printarray(int[] integeraaray)
        {
            foreach (var item in integeraaray)
            {
                Console.Write("{0} ",item);
            }
        }
        public void printarray(string[] stringarray)
        {
            foreach (var item in stringarray)
            {
                Console.Write("{0} ", item);
            }
        }
        public void Display()
        {

        }
    }
    class Program
    {       
       static void Main(string[] args)
        {
            int[] integerarray = new int[5];
            int[] integerarray1 = new int[5];
            string[] stringarray = new string[5];
            string[] stringarray1 = new string[5];
            Console.WriteLine("Enter the 5 array elements");
            for (int i = 0; i < integerarray.Length; i++)
            {
                integerarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the 5 String elements");
            for (int i = 0; i < stringarray.Length; i++)
            {
               stringarray[i] = Console.ReadLine();
            }
            Main m1 = new Main();
            Console.WriteLine("Array List are : ");
            m1.printarray(integerarray);
            Console.WriteLine();

            Console.WriteLine("\nString elements are :");
            m1.printarray(stringarray);
            Console.WriteLine();

            
            Array.Reverse(integerarray);
            Console.WriteLine("\nAfter Reversing the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();


            Array.Sort(integerarray);
            Console.WriteLine("\nAfter Sorting the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

            
            Array.Clear(integerarray,1,2);
            Console.WriteLine("\nAfter Clearing the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

            
            Array.Copy(integerarray,integerarray1,5);
            Console.WriteLine("\nAfter Copying the Array :");
            m1.printarray(integerarray);
            Console.WriteLine();

           
            Array.Reverse(stringarray);
            Console.WriteLine("\nAfter Reversing the Array :");
            m1.printarray(stringarray);
            Console.WriteLine();

          
            Array.Sort(stringarray);
            Console.WriteLine("\nAfter Sorting the Array :");
            m1.printarray(stringarray);
            Console.WriteLine();

            
            Array.Clear(stringarray,1,2);
            Console.WriteLine("\nAfter Clearing the Array : ");
            m1.printarray(stringarray);
            Console.WriteLine();

            Array.Copy(stringarray,stringarray1,5);
            Console.WriteLine("\nAfter Copying the Array :");
            m1.printarray(stringarray);
            Console.WriteLine();


            Console.ReadKey();
        }
    }

    
}

