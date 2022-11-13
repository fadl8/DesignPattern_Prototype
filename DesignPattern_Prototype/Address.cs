using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Prototype
{
    public class Address : IPrototype<Address>
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }

        public Address(string streetName , int houseNumner)
        {
            StreetName= streetName;
            HouseNumber = houseNumner;
        }

        public Address(Address otherAdress)
        {
            StreetName = otherAdress.StreetName;
            HouseNumber = otherAdress.HouseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)} : {string.Join(" ", StreetName)} {nameof(HouseNumber)} : {HouseNumber}";
        }

        //public object Clone()
        //{
        //    return new Address(StreetName, HouseNumber);
        //}
    }
}
