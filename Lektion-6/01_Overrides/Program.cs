/*  
    Objektorienterad programmering
    -----------------------------------------
    Encapsulation           Klasser
    Inheritance             Arv/Interface
    Polymorphism            Overload/Override
    Abstraction 


    OVERLOAD/OVERRIDE
    ------------------------------------------------------------------------------
    Overload innebär att vi kan göra flera olika konstruktorer som tar olika
    parameterar, eller en metod som tar olika parametrar

        var user = new User();
        var user = new User("Hans", "Mattin-Lassei");
        var user = new User("Hans", "Mattin-Lassei", "hans@domain.com");
        var user = new User(1, "Hans", "Mattin-Lassei", "hans@domain.com");

        IUserService userService = new UserService();
        var users = userService.Read();
        var user = userService.Read(1);
        var user = userService.Read("hans@domain.com");

    Override innebär att vi kan skriva över olika metoder i en klass och
    sedan använda oss av något som heter base (som är ordinarie metod) och
    får då tillgång till det ursprungliga. Ett arv krävs för att detta ska fungera

        virtual     vi gör en metod överskrivningsbar.
        override    talar om att vi kommer skriva över metoden
        base        ger tillgång till ordinarie information/funktionalitet


*/

using _01_Overrides.Models;
using _01_Overrides.Services;


var dog = new Dog();
dog.MakeSound();


Console.ReadKey();


