using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create an array of size 10, initialise with integer and reverse array using in-place operation 
namespace Assignments_Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(array1)  ;
            Console.WriteLine("After reversing");

            for ( int counter = 0; counter < array1.Length; counter++)
            {
                Console.WriteLine(array1[counter]);

            }
            Console.ReadLine();



        }
    }
}
