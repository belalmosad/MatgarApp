using System.Collections.Generic;
using System.Linq;
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
        public ProductModel GetProduct(int id) => _products.Where(i => i.ID == id).FirstOrDefault();
        public void AddProduct(int id, string name, double price)
        {
            ProductModel newProduct = new ProductModel();
            newProduct.ID = id;
            newProduct.Name = name;
            newProduct.Price = price;
            _products.Add(newProduct);
        }
    }
}