/*  
        Objektorienterad Programmering (OOP)
        -----------------------------------------------------------------
        Encapsulation
        Inheritance
        Polymorphism
        Abstraction
 
        Klasser/Classes (Encapsulation)
        -----------------------------------------------------------------
        det är en modell,mall,template över något

        En klass kan instaniseras, skapar ett objekt av klassen/typen
        och reserverar ett utrymme i RAM-minnet när jag behöver det.
        
        var customer = new Customer();
        var age = customer.GetAge(38);        

        class Customer 
        {
            public Customer() {}                    <- Constructor

            private string firstName                <- Field
            public string FirstName { get; set; }   <- Property

            public int GetAge(int age)              <- Method
            {
                return age
            }
        }


        static innebär att objektet reserveras redan när programmet 
        startar och finns där under hela programmets livstid. Detta
        gör att det blir snabbare

        var age = Customer.GetAge(38);

        static class Customer 
        {
            public Customer() {}                    <- Constructor

            private string firstName                <- Field
            public string FirstName { get; set; }   <- Property

            public int GetAge(int age)              <- Method
            {
                return age
            }
        }

*/

using _00_Repetition.Helpers;

while(true) 
{

    MenuHelper.MainMenu();
    
}

