using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello World!");

            String name = null;
            name = Console.ReadLine();
            //Console.Out.WriteLine("Hello " + name);

            Person person = new Person();
            person.setName("Ghale");
            Console.Out.WriteLine("Hello " + name + " " + person.getName());

            printDetails();
        }

        private static void printDetails()
        {
            Person person = new Person();
            person.setName("Aron");
            person.Age = 30;
            person.Address = "Arizona";

            Console.Out.WriteLine(person.Age);
        }
    }

    class Person
    {
        private String name;
        private int age;
        private String email;
        private String address;

        public String getName()
        {
            return name;
        }

        public void setName(String _name)
        {
            name = _name;
        }

        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
    }


    
}
