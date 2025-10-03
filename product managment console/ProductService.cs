

namespace product_managment_console
{
    public class ProductService
    {
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product myProduct) 
        {
            myProduct.Id = Guid.NewGuid();
            Products.Add(myProduct);
        }

        public void Printroducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"Product: {product.Id}, {product.Name}, {product.Price}");
            }
        }

        public void deleteProduct(int Id)
        {
            Console.WriteLine("product deleted");   
        }  
    }

}
