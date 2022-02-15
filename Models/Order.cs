﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_MPA.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int PhoneID { get; set; }

        public Customer Customer { get; set; }
        public Phone Phone { get; set; }
    }
}
