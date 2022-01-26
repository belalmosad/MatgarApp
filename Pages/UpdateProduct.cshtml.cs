using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatgarApp
{
    public class UpdateProductModel : PageModel
    {
        [BindProperty]
        public UserInput Input { get; set; }
        private readonly ProductListService _service;
        public ProductModel Item;
        public UpdateProductModel(ProductListService service)
        {
            _service = service;
        }
        public void OnGet(int id)
        {
            Item = _service.GetProduct(id);
        }
        public ActionResult OnPost(int id)
        {
            
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _service.UpdateProduct(id, Input.Name, Input.Price);
           return RedirectToPage("/ProductDetails", new {id = id});
        }

        public class UserInput
        {
            [Required]
            public string Name { get; set; }
            [Required]
            public double Price { get; set; }
        }

    }
}