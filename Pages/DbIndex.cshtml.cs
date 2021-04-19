using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstService.Data;
using MyFirstService.Models;

namespace MyFirstService.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MyFirstService.Data.DBdataContext _context;

        public IndexModel(MyFirstService.Data.DBdataContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
