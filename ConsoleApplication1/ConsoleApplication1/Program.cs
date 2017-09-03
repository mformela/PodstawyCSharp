using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cześć, jak masz na imie?");
            string name;
            name = Console.Redline();

            Console.WriteLine("Ile masz lat");
            string age;
            name = Console.Redline();

            Console.WriteLine("Cześć "  + name + "fajnie, że masz " + age + " lat.");
            Console.ReadLine(); 
        }
    }
}
