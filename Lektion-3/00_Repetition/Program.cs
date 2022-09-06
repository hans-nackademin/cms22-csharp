/* 
    DATA TYPES
    --------------------------------------------------------------------------------
    char, string                                            text
    byte, sbyte, int, uint,long, ulong                      heltal
    decimal, float, double                                  decimaltal
    Guid                                                    unikt id
    object                                                  objekt
    null                                                    är ingenting
    dynamic                                                 som är en dynamisk typ  
    bool                                                    sant/falskt


    string sentence = "Hej jag heter Hans Mattin-Lassei";
    string sentence = $"Hej jag heter {firstName} {lastName}";
    string path = @"c:\users\hansmattin-lassei\desktop\mytextfile.txt"

    \   =   escape next 
    \n  =   ny rad
    \t  =   tabb indentering

    int value =   10;

    double value    = 10.0;
    decimal value   = 10.0m;
    float value     = 10.0f;


    DEKLARERA
    --------------------------------------------------------------------------------
    string firstName = 
    var firstName = "Hans";
 
 */


/* 
    IF-STATEMENTS
    --------------------------------------------------------------------------------
    operander:  ==, !=, <, <=, >, >=, &&, ||, !

    if (statement is true) {  do this }
    if (statement is true) {  do this } else { do this }
    if (statement is true) {  do this } else if (statement is true) { do this } else { do this }

    switch(value)
    {
        case "Hans":
            Console.WriteLine("Du heter Hans");
            break;

        case "Tommy":
            Console.WriteLine("Du heter inte Hans");
            break;

        default:
            Console.WriteLine("Jag har ingen aning om vad du heter");
            break;          
    }


    string firstName = "Hans";

    for (int i = 0; i < firstName.Length; i++)
    {
        Console.WriteLine(firstName[i]);
    }

    var contacts = new List<string>();
    contacts.Add("Hans");
    contacts.Add("Tommy");
    contacts.Add("Joakim");

    foreach (var contact in contacts)
    {
        Console.WriteLine(contact);
    }

    for (int i = 0; i < contacts.Count; i++)
    {
        Console.WriteLine(contacts[i]);
    }

    while (true)
    {
        do this
    }

    do
    {
        do this at least one time
    } while(true);
*/

