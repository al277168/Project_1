using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1_Restaurant.Model
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal price { get; set; }

        public int NumOfOrders { get; set; }


    }
}
