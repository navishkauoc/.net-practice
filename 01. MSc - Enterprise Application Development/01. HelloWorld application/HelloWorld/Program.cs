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
            Console.Out.WriteLine("Hello " + name + person.getName());
        }
    }

    class Person
    {
        String name;

        public String getName()
        {
            return name;
        }

        public void setName(String _name)
        {
            name = _name;
        }
    }
}
