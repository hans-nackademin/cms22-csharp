/* 
    IF STATEMENT
    ------------------------------------------------------------------------
    ==          lika med
    !=          inte lika med
    <           mindre än
    <=          mindre eller lika med
    >           större än
    >=          större eller lika med
    !           om det inte är det här
    &&          och
    ||          eller                                   (alt gr + < ) (mac: opt + 7)


    if (true) {}
    if (true) {} else {}
    if (true) {} else if (true) {} else {}
    if (true) {} else if (true) {} else if (true) {} else if (true) {} else {}
    (true) ? do_this : do_this
 

    int value = 10;

    if (value == 11)
    {
        Console.WriteLine("Värdet är 11");
        Console.WriteLine("Du måste ha {} om du har mer en en sak här");
    }
    else if (value == 23)
        Console.WriteLine("Värdet är 23");
    else
        Console.WriteLine("Värdet är något annat");

 
 
 
 
    SWITCH
    ------------------------------------------------------------------------
    Alternativ till en if-sats (lika med)

    var value = 100;

    switch(value)
    {
        case 100:
            Console.WriteLine("Värdet är 100");
            break;

        case 75:
            Console.WriteLine("Värdet är 75");
            break;

        case 50:
            Console.WriteLine("Värdet är 50");
            break;

        case 25:
            Console.WriteLine("Värdet är 25");
            break;

        default:
            Console.WriteLine("Värdet är något annat");
            break;
    }


    


    LOOP
    -------------------------------------------------------------------------------
    for             gör något ett givet antal gånger
    foreach         gör något för varje värde/objekt i en lista/array
    while           om ett tillstånd är sant gör något tills det inte är sant
    do-while        gör något minst en gång och gör det sedan igen tills tillståndet inte är sant


    
    FOR-LOOP
    ----------------------------------------------------
    for (int i = 0; i < 10; i++) 
    {
        Console.WriteLine("loop nr: " + i);
    }


    
    FOREACH-LOOP
    ----------------------------------------------------
    string[] names = new string[] { "Hans", "Tommy", "Angelica", "Joakim" };
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }



    WHILE
    ----------------------------------------------------
    var index = 1000;

    while (index < 1000)
    {
        Console.WriteLine("Index är " + index);
        index++;
    }


    DO WHILE
    ----------------------------------------------------
    var index = 1000;

    do
    {
        Console.WriteLine("Index är " + index);
        index++;
    }
    while (index < 1000);

*/

var index = 1000;

do
{
    Console.WriteLine("Index är " + index);
    index++;
}
while (index < 1000);









Console.ReadKey();