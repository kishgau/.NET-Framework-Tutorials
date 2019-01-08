using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            string contactType;
            string name;
            int age;
            string address;
            int contact_number;

            while (true) {
                Console.WriteLine("Enter contactType [P]rofessor/[S]tudent):");
    
                contactType = Console.ReadLine();
                ;
                if ((contactType != "P") && (contactType != "S"))
                {
                    Console.WriteLine("Valid values :[P]rofessor/[S]tudent");
                    Console.ReadLine();
                    break;
                } else
                {
                    Console.WriteLine("Enter contact details below:");
                    Console.WriteLine("Enter name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter age");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Address");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter contact number ");
                    contact_number = Convert.ToInt32(Console.ReadLine());

                      

                    switch (contactType)
                    {
                        case "P":
                            Console.WriteLine("Professor created");
                            Professor p1 = new Professor(name,age,address,contact_number);
                            p1.displayProfessor();
                            Console.ReadLine();
                            break;
                        case "S":
                            Console.WriteLine("Student created");
                            Student s1 = new Student(name, age, address, contact_number);
                            s1.displayStudent();
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid value");
                            break;
                    }

                    break;

                }

            }
        }
    }

    class Professor
    {
        string name;
        int age;
        string address;
        int contact_number;

        public Professor(string name, int age, string address, int contact_number)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.contact_number = contact_number;
        }

       public void displayProfessor()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.address);
            Console.WriteLine(this.contact_number);
        }

    }

    class Student
    {
        string name;
        int age;
        string address;
        int contact_number;

        public Student(string name, int age, string address, int contact_number)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.contact_number = contact_number;
        }

        public void displayStudent()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.address);
            Console.WriteLine(this.contact_number);
        }

    }
}
