using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Prototype
{
    public class Person : ICloneable
    {
        public string[] Names { get; set; }
        public Address Address { get; set; }


        public Person(string[] names, Address address)
        {
            Names= names;
            Address= address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)} : {string.Join(" " , Names)} {nameof(Address)} : {Address}";
        }
        public object Clone()
        {
           return new Person(Names, (Address) Address.Clone());
        }
    }
}
