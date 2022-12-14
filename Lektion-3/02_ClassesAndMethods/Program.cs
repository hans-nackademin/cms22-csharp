/*  
    variable            camelCase           var firstName = "Hans";
    field               camelCase           private string firstName;
    parameter           camelCase           GetFullName(string firstName, string lastName)
    Property            Pascal              public string FirstName { get; set; }
    Method              Pascal              public void GetFullName() {}
    Class               Pascal              class Contact {}




    CLASSES AND GETTERS/SETTERS
    ----------------------------------------------------------------------------------

    Objektorienterad Programmering (OOP)
    ------------------------------------
    Encapsulation
    Inheritance
    Polymorphism
    Abstraction


    CLASSES (Encapsulation) - mall av någonting (Class, Entity, Object, Dto, Model)
    ---------------------------------------------------------------------------------
    var contact = new Contact();
    
    class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Address 
    {
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }

    class Contact 
    {
        public Person ContactPerson { get; set; }
        public Address ContactAddress { get; set; }
    }
    
 
    Design Patterns / Code Patterns
    ---------------------------------
    MVC         Model View Controller
    MVVM        Model View ViewModel
    SOLID       Single responsiblitity Open-closed Liskov substition Interface segregation Dependency inversion

*/

using _02_ClassesAndMethods.Helpers;


do
{
    switch (AddressBook.OptionsMenu())
    {
        case "1":
            AddressBook.ViewContactsMenu();
            break;

        case "2":
            AddressBook.NewContactMenu();
            break;

        case "Q":
            Environment.Exit(0);
            break;
    }

    Console.ReadKey();

} while (true);