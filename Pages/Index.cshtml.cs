using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_1_Restaurant.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Project_1_Restaurant.Pages
{
    public class IndexModel : PageModel
    {
      

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Cart> Items { get; set; }



        public async Task OnGet()
        {
            Products = await _db.Product.ToListAsync();
        }


        public async Task OnPost()
        {
            
           
        }



        public string SearchProduct { get; set; }
            
    }
}
