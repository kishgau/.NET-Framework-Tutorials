using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Enter first number A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(A+B)^2 =" + (a * a + 2 * a * b + b * b));
            Console.ReadLine();
        }
    }
}
