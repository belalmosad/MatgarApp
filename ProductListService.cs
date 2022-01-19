using System.Collections.Generic;

namespace MatgarApp
{
    public class ProductListService
    {
        private List<ProductModel> _products = new List<ProductModel> {
            new ProductModel{ID = 1, Name = "Back Pack", Price = 5.6},
            new ProductModel{ID = 2, Name = "Shoes", Price = 3.5},
            new ProductModel{ID = 3, Name = "Phone", Price = 55.6},
            new ProductModel{ID = 4, Name = "TV", Price = 51.5}
        };
        public List<ProductModel> GetAllProducts()
        {
            return _products;
        }
    }
}