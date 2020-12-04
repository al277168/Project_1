using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_1_Restaurant.Model;



namespace Project_1_Restaurant.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public SignUpUser SignUpUser{ get; set; }

        public void onGet()
        {

        }

       
        public async Task<IActionResult> OnPost()
        {

            //will put user input into a queue before adding to database
            await _db.SignUpUser.AddAsync(SignUpUser);
            await _db.SaveChangesAsync();

            //return does not work
            return RedirectToAction("applicationUrl");
        }
       
        
    }
}
