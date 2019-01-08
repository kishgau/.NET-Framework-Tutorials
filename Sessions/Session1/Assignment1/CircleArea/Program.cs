using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //double radius ; ------- Tried this initially but returned error
            double pi=3.14;

            Console.WriteLine("Enter radius of circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Circle:" + (pi*radius*radius));
            Console.ReadLine();

        }
    }
}
