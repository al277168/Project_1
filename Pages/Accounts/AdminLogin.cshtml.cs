using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_1_Restaurant.Model;

namespace Project_1_Restaurant.Pages.Accounts
{
    public class AdminLoginModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AdminLoginModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public SignUpUser SignUpUser { get; set; }



        public void onGet()
        {
           

        }

    }

}
