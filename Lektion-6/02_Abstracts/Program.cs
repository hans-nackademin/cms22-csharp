/*  
    ABSTRACT (abstraction - OOP)
    ------------------------------------------------------------------------------
    Handlar om att döja sånt som är onödigt för en brukare och istället bara
    visa det som ska finnas med.

    Genom att göra en klass som en abstract class  så går det inte längre att
    göra en instans utav klassen.

*/



using _02_Abstracts.Services;

var userManager = new UserManager();
userManager.Connect();
userManager.Create();
userManager.Read();
Console.ReadKey();

var weatherService = new WeatherService();
weatherService.Connect();
weatherService.Create();
weatherService.Read();
Console.ReadKey();