

namespace product_managment_console
{
   public class Product
    {
        public Product(string Name, decimal Price)
        {
         this.Name = Name;
         this.Price = Price;
        }
        public Product()
        {

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
