using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Prototype
{
    public class Person : IPrototype<Person>
    {
        public string[] Names { get; set; }
        public Address Address { get; set; }


        public Person(string[] names, Address address)
        {
            Names= names;
            Address= address;
        }

        public Person(Person other)
        {
            Names = other.Names;
            Address = other.Address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)} : {string.Join(" " , Names)} {nameof(Address)} : {Address}";
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy());
        }
        //public object Clone()
        //{
        //   return new Person(Names, (Address) Address.Clone());
        //}
    }
}
