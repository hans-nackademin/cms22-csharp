/*  
    GETTER AND SETTER
    ------------------------------------------------------------------------------
    SET     SPARA/SKRIV     customer.Name = "Hans";
    GET     HÄMTA/LÄS       var firstName = customer.Name;
                            Console.WriteLine(customer.Name);

    Example 1:              private string name;
                            public string Name 
                            {
                                get 
                                {
                                    return name;
                                }
                                set
                                {
                                    name = value;
                                }
                            }
 
    Example 2:              public string Name { get; set; }
    
    Example 3:              public string Name { get; private set; }
    
    Example 4:              public string Name { get; }
                            public string Name => $"";

*/

using _02_GetterSetter.Models;

var customer = new Example4();

customer.FirstName = "Hans";
customer.LastName = "Mattin-Lassei";

Console.WriteLine($"{customer.FirstName} {customer.LastName}");
Console.WriteLine(customer.FullName);
Console.WriteLine(customer.DisplayName);
Console.WriteLine(customer.GetFullName());
Console.ReadKey();



customer.LastName = "Andersson";

Console.WriteLine($"{customer.FirstName} {customer.LastName}");
Console.WriteLine(customer.FullName);
Console.WriteLine(customer.DisplayName);
Console.WriteLine(customer.GetFullName());
Console.ReadKey();