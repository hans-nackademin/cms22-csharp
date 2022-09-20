using _00_Repetition.ProductCatalog.Models;
using _00_Repetition.ProductCatalog.Services;
using Newtonsoft.Json;


var productCatalog = new List<Product>();
var filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ProductCatalog.json";

// Read Product(s) from a File and Add it to the List
productCatalog = JsonConvert.DeserializeObject<List<Product>>(FileManager.Read(filePath));

do
{
    // Show Menu Options
    var option = MenuManager.OptionsMenu();
    
    switch(option)
    {
        case "1":
            // View Product Catalog
            MenuManager.ViewListMenu(productCatalog);
            break;
        
        case "2":
            // Create New Product and Save it to a File
            var product = MenuManager.CreateMenu();
            if (product != null)
            {
                productCatalog.Add(product);
                FileManager.Save(filePath, JsonConvert.SerializeObject(productCatalog, Formatting.Indented));
            }
            break;
        
        case "3":
            // Remove Product from List and Save it to a File
            MenuManager.ViewListMenu(productCatalog);
            MenuManager.RemoveMenu(ref productCatalog);
            FileManager.Save(filePath, JsonConvert.SerializeObject(productCatalog, Formatting.Indented));
            break;

        default:
            Console.WriteLine("Invalid option selected");
            Console.ReadKey();
            break;
    }
} while (true);
