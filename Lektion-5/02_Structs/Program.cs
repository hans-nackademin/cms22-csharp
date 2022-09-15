/*   
    HEAP vs STACK (Minneshantering)
    -------------------------------------------------------------------------------
    STACK       snabb, men klarar bara enkla saker
                direkt association
                static innebär att det läggs i stacken
                litet utrymme som kan fyllas snabbt vilket ger stackoverflow

    HEAP        långsammare, men klarar mer komplexa saker
                använder pekare
                dynamiskt allokerat minne (instance)
                exception: not set to an instance of an object

    Value Types             STACK           int, double, decimal, float, bool, enum, struct
    Reference Types         HEAP            array, list, object, string, class

    Value Types             Har en direkt koppling till sin plats i minnet där informationen lagras
    Reference Types         Använder sig av en "pekare" för att peka på en plats i minnet där information lagras
    

            Value Types                                                 Reference Types
        
        +----------------+ +------------------+         +--------------------------------------+      +--------------------------------+                    
        | int age1 = 38; | | int age2 = age1; |         |  Customer customer = new Customer(); |      |  Customer customer = customer; |
        +----------------+ +------------------+         +--------------------------------------+      +--------------------------------+
                |                   |                             |                                       |
                |                   |                             |  +------------------------------------+
                |                   |                             |  |
                V                   V                             V  V
        +----------------+  +----------------+                +---------+         +---------+         +---------+         +---------+
STACK   | memory address |  | memory address |                | pointer |         | pointer |         | pointer |         | pointer |
        +----------------+  +----------------+                +---------+         +---------+         +---------+         +---------+
               38                  38                              |                   |                   |                   |
                                                                   |                   |                   |                   |
                                                                   V                   V                   V                   V
                                                           +----------------+  +----------------+  +----------------+  +----------------+
HEAP                                                       | memory address |  | memory address |  | memory address |  | memory address |
                                                           +----------------+  +----------------+  +----------------+  +----------------+
                                                         customer.Name = "Tommy"                   
 
 
*/

using c = _02_Structs.Classes;
using s = _02_Structs.Structs;


var age1 = 40;
var age2 = age1;
age1 = 50;
Console.WriteLine($"Value Types (int) | Age1 = {age1}, Age2 = {age2}");




var cc1 = new c.Customer() { Name = "Hans", Email = "hans@domain.com" };
var cc2 = cc1;
cc1.Name = "Johanna";
Console.WriteLine($"Reference Types (Class) | cc1.Name = {cc1.Name}, cc2.Name = {cc2.Name}");


var sc1 = new s.Customer() { Name = "Hans", Email = "hans@domain.com" };
var sc2 = sc1;
sc1.Name = "Johanna";
Console.WriteLine($"Value Types (Struct) | sc1.Name = {sc1.Name}, sc2.Name = {sc2.Name}");





Console.ReadKey();

