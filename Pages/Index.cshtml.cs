using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MatgarApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductListService _service;
        public List<ProductModel> Products { get; set; }

        public IndexModel(ProductListService service)
        {
            _service = service;
        }
        

        public ActionResult OnGet()
        {
            Products = _service.GetAllProducts();
            return Page();
        }
    }
}
