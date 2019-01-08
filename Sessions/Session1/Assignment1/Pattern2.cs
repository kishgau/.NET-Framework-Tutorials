using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 0; i <= 5; i++)
            {
          
                for ( j=6; j>=i ; j--)
                {
                   Console.Write("*");
                }
               Console.WriteLine(" ");

            }
            Console.ReadLine();
        }
    }
}
