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

            Car c1 = new Car();

            Bike b1 = new Bike();

            v1.setColor("orange");
            b1.setColor("grey");
            c1.setColor("white");

            List<int> i = new List<int>();
            i.
            v1.

            //v1.display();

            //b1.display();


            v1.temp();
        }
    }

    class Vehicle
    {
        public int numofTyres { set; get; }
    
        public string color { get; set; }

        public string getColor()
        {
            return this.color ;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        private void display()
        {
            Console.WriteLine(this.color);
        }
        public void temp()
        {
            display();
        }
    }

    class Car : Vehicle
    {
        public Boolean airbags;

     
    }


    class Bike : Vehicle
    {
        public Boolean diskbrakes;


    }


}
