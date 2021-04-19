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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
   

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
          
        }

        public void OnGet()
        {
       
        }
    }
}
