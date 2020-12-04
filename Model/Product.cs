﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1_Restaurant.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal price { get; set; }

        public string Category { get; set; }

        public string Type { get; set; }

        public string Tag { get; set; }

        public string Description { get; set; }

        public string ProdcutImage { get; set; }


    }
}
