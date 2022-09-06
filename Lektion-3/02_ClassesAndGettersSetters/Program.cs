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

*/

using _02_ClassesAndGettersSetters.Models;

var contact = new Contact();