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
            Register reg = new Register();

            //studnet objects
            Student std1 = new Student("", 2, "", 12);
            reg.StudentList.Add(std1); //stuent obj)
        }
    }


    class Student {


        public string Name { get; set; }
        

        private int number;
        public string address;
        public int standard;


        public Student(string Name, int Number, string Address, int Standard)
        {
            this.Name = Name;
            this.number = Number;
            this.address = Address;
            this.standard = Standard;
        }

    }

    class Register {
        public List<Student> StudentList;

        public Register()
        {
            StudentList = new List<Student>();
        }

        public string Search(int number) {
            return 1;  


        }

    }
}
