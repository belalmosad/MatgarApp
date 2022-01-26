using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatgarApp
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public UserInput Input { get; set; }
        private readonly ProductListService _service;
        public AddProductModel(ProductListService service)
        {
            _service = service;
        }
        public ActionResult OnPost()
        {
           if (!ModelState.IsValid)
           {
               System.Console.WriteLine("Somethin wrong");
               return Page();
           }
            _service.AddProduct(Input.ID, Input.Name, Input.Price);
            return RedirectToPage("/Index");
        }

        public class UserInput
        {
            [Required]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public double Price { get; set; }
        }

    }
}