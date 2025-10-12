using Moq;
using product_managment_console;

namespace product_managment_console_tests
{
    internal interface IFileService
    {
        void WriteToFile(IEnumerable<Product> products);
        List<Product> ReadFromFile();
    }

    public class ProductService_Tests
    {
        public int Price { get; private set; }

        [Fact]
        public void AddProductToList_ShouldAddProductToList()
        {
            // Arrange
            var product = new Product { Name = "Test Product", Price = 100 };

            var productService = new ProductService();

            // Act
            productService.AddProduct(product);

            // Assert
            var Products = productService.Products;
            Assert.Single(Products);

        }

    }
}
