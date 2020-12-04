using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project_1_Restaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Project_1_Restaurant.Pages.CartList
{
    public class CartModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CartModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Cart> Items { get; set; }

        public IEnumerable<Product> Products { get; set; }



        public async Task OnGet()
        {
            Items = await _db.Cart.ToListAsync();
        }
    }
}
