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
            Console.Out.WriteLine("Hello " + name);
        }
    }
}
