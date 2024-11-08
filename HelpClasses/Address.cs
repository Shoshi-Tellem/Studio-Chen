﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpClasses
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public Address(string city, string street, int streetNumber)
        {
            City = city;
            Street = street;
            StreetNumber = streetNumber;
        }
    }
}
