using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningASP.Models;
using LearningASP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LearningASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService jsonFileProductService)
        {
            _logger = logger;
            ProductService = jsonFileProductService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
