// See https://aka.ms/new-console-template for more information


product_managment_console.ProductService productservice1 = new product_managment_console.ProductService();

productservice1.AddProducts(1, "prod1");

string productName;


productName = productservice1.GetProduct(1);
Console.WriteLine(productName);

productservice1.deleteProduct(1);


