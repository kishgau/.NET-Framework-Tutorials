using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string city;
            int age;
            int pin;

            Console.WriteLine("Enter you name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter you city:");
            city = Console.ReadLine();

            Console.WriteLine("Enter you age:");
            age = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter you pin:");
            pin = Convert.ToInt32(Console.ReadLine());

            User user1 = new User(name,city,age,pin);
            user1.displayUserDetails();

        }


    }


    class User
    {
         string name;
         string city;
         int age;
         int  pin;

        public User(string name, string city, int age, int pin)
        {
            this.name = name;
            this.city = city;
            this.age = age;
            this.pin = pin;
        }

       public void displayUserDetails()
        {
       //     Console.WriteLine( this.name + ": " + this.city + ":" + this.age + ":" + this.pin);
            Console.WriteLine(this.name );
            Console.WriteLine(this.city);
            Console.WriteLine(this.age);
            Console.WriteLine(this.pin);
            Console.ReadLine();
        }


    }
}
