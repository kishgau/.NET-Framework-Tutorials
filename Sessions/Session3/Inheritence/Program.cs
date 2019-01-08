using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle("White");
            Console.WriteLine("");
            Car c1 = new Car();
            Console.WriteLine("");
            Car c2 = new Car(1000);
            Console.WriteLine("");

            Car c3 = new Car(1000, "Red");

        }
    }

    class Vehicle     // super class, parent class, Base class
    {
        public string color { get; set; }


        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
        public Vehicle(String color)
        {
            this.color = color;
            Console.WriteLine("Vehicle Constructor with color");
        }

    }

    class Car : Vehicle   // Child class, Derived  Class, subclass
    {
        public int cc { get; set; }


        public Car()
        {
            Console.WriteLine("Car Constructor");
        }

        public Car(int cc)
        {
            this.cc = cc;
            Console.WriteLine("Car Constructor with cc argument");
        }

        public Car(int cc, string color) :base(color)
        {
            this.cc = cc;
            Console.WriteLine("Car Constructor with cc & color");
        }

     
    }


    //class Bike : Vehicle   // Child class, Derived class
    //{
    //    public Boolean diskbrakes;


    //}


}
