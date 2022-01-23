using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatgarApp
{
    public class ProductDetailsModel : PageModel
    {
        private readonly ProductListService _service;
        public ProductModel Product;
        public ProductDetailsModel (ProductListService service)
        {
            _service = service;
        }

        public ActionResult OnGet(int id)
        {
            Product = _service.GetProduct(id);
            if(Product == null) return RedirectToPage("/Index");
            return Page();
        }
    }
}