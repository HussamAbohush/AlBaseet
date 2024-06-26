﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBaseet.Core.Entities
{
    public class Customer
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public IEnumerable<RealEstate>? RealEstates { get; set; }

    }
}
