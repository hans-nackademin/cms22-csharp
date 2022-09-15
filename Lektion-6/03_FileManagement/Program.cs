
using _03_FileManagement.Services;

IMenu menu = new MenuService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\products.json");

menu.Init();
menu.Create();
