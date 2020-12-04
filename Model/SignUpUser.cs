using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1_Restaurant.Model
{
    public class SignUpUser
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Username { get; set; }


       [Required]
        public string Password { get; set; }

    }
}
