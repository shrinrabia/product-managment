using System;

namespace product_managment_console
{
    public class ProductService
    {
        public void AddProducts(int Id, string Name) 
        {
            Console.WriteLine($"Product added: {Id}, {Name}");
        }

        public string GetProduct(int Id)
        {
            return "Product 1";

        }
        public void deleteProduct(int Id)
        {
            Console.WriteLine("product deleted");   
        }
    }
}
