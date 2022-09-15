using _06_Interfaces.Models;
using _06_Interfaces.Services;

IProductService productService = new ProductService();

do
{
    Console.WriteLine("1. Create new Product");
    Console.WriteLine("2. Delete Product");
    Console.WriteLine("3. Get Product");
    Console.WriteLine("4. Get All Products");
    Console.Write("Choose one option: ");

    var product = new Product();

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            Console.Write("Product Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Product Price: ");
            product.Price = decimal.Parse(Console.ReadLine());

            productService.Create(product);
            break;

        case "2":
            Console.Clear();
            Console.Write("Product Id: ");
            productService.Delete(int.Parse(Console.ReadLine()));
            break;

        case "3":
            Console.Clear();
            Console.Write("Product Id: ");
            product = productService.Get(int.Parse(Console.ReadLine()));
            if (product != null)
                Console.WriteLine($"{product.Id}, {product.Name} - {product.Price}");

            else
                Console.WriteLine("Product not found!");
            break;   
            

        case "4":
            Console.Clear();
            foreach (var item in productService.GetAll()) 
            {
                Console.WriteLine($"{item.Id}, {item.Name} - {item.Price}");
            }
            break;
    }

    Console.ReadKey();

} while (true);


