﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_APIApp.Models
{
    public class CatProduct
    {
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
