/*  
       CLASS - en slags mall över hur något ska se ut
       -----------------------------------------------------------
        Constructor(s)              Pascal

        fields                      camelCase
        Properties                  Pascal
        Method(s)                   Pascal
        
        Access Modifiers
        ----------------------------------------------------------
        public              accessbar överallt
        internal            accessbar bara in om samma projekt (assembly)
        protected           accessbar via arv (class Student : Person)
        private             accessbar inom samma kodblock { }

        
        class           (public/internal)
        fields          (public/internal/protected/private)
        Properties      (public/intenral/protected/private)
        Methods         (public/internal/protected/private)


        class Person
        public class Person


        Getter Setter - Läs/Skriv rättigheter
        ---------------------------------------------------------
        fields              camelCase       public string firstName
        Properties          Pascal          public string FirstName { get; set; }



        SET/Skriv
        -------------------------------------
        FirstName       =   "Hans"
        LastName        =   "Mattin-Lassei"
        DisplayName     =   "Kalle Oppbs"

        GET/Läs
        -------------------------------------
        var value = person.FirstName
        var value = person.LastName
        var value = person.DisplayName


        Constructor
        -------------------------------------------------
        
        public Person() 
        {
    
        }


        var person = new Person();
                         --------
*/



using _00_Repetition.Models;

var person = new Person()
{
    FirstName = "Hans",
    Email = "hans@domain.com"
};



person.FirstName = "Hans";
person.LastName = "Mattin-Lassei";

Console.WriteLine($"{person.FirstName} {person.LastName}");
Console.WriteLine(person.Email);
Console.ReadKey();


