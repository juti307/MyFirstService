using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyFirstService.Models;
using MyFirstService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstService.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        public PrivacyModel(ILogger<PrivacyModel> logger,
             JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }
        public Product Product { get; set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
