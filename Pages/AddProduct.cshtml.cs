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
            _service.AddProduct(Input.ID, Input.Name, Input.Price);
            return RedirectToPage("/Index");
        }

        public class UserInput
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }

    }
}