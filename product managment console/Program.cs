using product_managment_console;

ProductService productservice1 = new ProductService();

productservice1.LoadProducts();

Product product1 = new Product();

Console.Write("Enter Product Name: ");
product1.Name = Console.ReadLine();

Console.Write("Enter Product Price: ");
product1.Price = int.Parse(Console.ReadLine());

productservice1.AddProduct(product1);

productservice1.Printroducts();


