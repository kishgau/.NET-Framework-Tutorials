using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of register

        }
    }


    class Student {


        public string Name;
        public int number;
        public string address;
        public int standard;


        public Student(string Name, int Number, string Address, int Standard)
        {
            this.Name = Name;
            this.Number = Number;
            this.Address = Address;
            this.Standard = Standard;
        }

    }

    class Register {
        List<Student> StudentList = new List<Student>();

        public void Search(int number) {
            return 1;  


        }

    }
}
