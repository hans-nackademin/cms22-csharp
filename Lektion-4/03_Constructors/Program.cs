using _03_Constructors.Models;

var customer1 = new Customer();
    customer1.Id = Guid.NewGuid();
    customer1.FirstName = "Hans";
    customer1.LastName = "Mattin-Lassei";
    customer1.Email = "hans@domain.com";

var customer2 = new Customer()
{
    Id = Guid.NewGuid(),
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans@domain.com"
};

var customer3 = new Customer();
var customer4 = new Customer("Hans", "Mattin-Lassei");
var customer5 = new Customer("Hans", "Mattin-Lassei", "hans@domain.com");
var customer6 = new Customer(Guid.NewGuid(), "Hans", "Mattin-Lassei", "hans@domain.com");
