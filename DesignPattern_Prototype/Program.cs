
using System;

namespace DesignPattern_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fadl = new Person(new[] { "fadl", "Nasser" }, new Address("Sanaa", 24));

            // without clone interface it will change in tow objects
            var ali = fadl;
            ali.Names[0] = "ali";

            Console.WriteLine(fadl);
            Console.WriteLine(ali);

            // with clone 
            //var Mohmmed = (Person) fadl.Clone();

            // when copy the constractor with class its self get clone 
            var Mohmmed = new Person(fadl);
            Mohmmed.Names[0] = "Mohmmed";
            Mohmmed.Address.StreetName = "Aden";

            Console.WriteLine(Mohmmed);

            Console.WriteLine("Hello World!");
        }
    }
}
