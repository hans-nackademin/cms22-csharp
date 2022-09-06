/*  
    LIST - dynamiska (pekare)
    -----------------------------------------------------------------------
    System.Collections.Generic

    List<int> values
    List<string> values
    List<bool> values
    List<dynamic> values
    List<Customer> values
    List<Product> values

    deklarera en lista
    --------------------------------------------------------------------
    var contacts = new List<string>();
    List<string> contacts = new List<string>();
    List<string> contacts = new();


    Lägga till värden i listan i samband med deklareringen
    -------------------------------------------------------------------
    var contacts = new List<string>() 
    {
        "Hans",
        "Tommy",
        "Joakim",
        "Haithem"
    };

    [0][1][2][3] = 4 stycken
    ["Hans"]["Tommy"]["Joakim"]["Haithem"]




    Lägga till värden i listan i efterhand (hamnar i slutet av listan)
    -------------------------------------------------------------------
    contacts.Add("Janette");
    contacts.Add("Kristoffer");

    [0][1][2][3][4][5] = 6 stycken
    ["Hans"]["Tommy"]["Joakim"]["Haithem"]["Janette"]["Kristoffer"]




    Lägg till på en specifik position i listan
    -------------------------------------------------------------------
    contacts.Insert(2, "Stefan");

           |
    [0][1][2][3][4][5][6] = 7 stycken
    ["Hans"]["Tommy"]["Stefan"]["Joakim"]["Haithem"]["Janette"]["Kristoffer"]

  



    Ta bort något från listan
    -------------------------------------------------------------------
    contacts.Remove("Hans");
    
    contacts = contacts.Where(name => name != "Hans").ToList();
    contacts = contacts.Where(contact => contact.FirstName != "Hans").ToList();

    contact => contact != "Hans"        = lambda expression (arrow function)
    name => name != "Hans"
    x => x != "Hans"
    c => c != "Hans"
    asdf => asdf != "Hans"
*/

/*  
    ARRAYS - statiska listor
    -------------------------------------------------------------------------------------
    int[] values
    string[] values
    bool[] values
    dynamic[] values
    Customer[] values
    Product[] values
    byte[] values

    deklarera en array
    -------------------------------------------------------------------- 
    var contacts = new string[4];
    string[] contacts = new string[4];
    
    [0][1][2][3] = 4 stycken
    [][][][]



    Lägga till värden i arrayen i samband med deklareringen
    -------------------------------------------------------------------
    string[] contacts = new string[] 
    {
        "Hans",
        "Tommy",
        "Joakim",
        "Haithem"
    };

    string[] contacts = 
    {
        "Hans",
        "Tommy",
        "Joakim",
        "Haithem"
    };


    [0][1][2][3] = 4 stycken
    ["Hans"]["Tommy"]["Joakim"]["Haithem"]




    Lägga till värden i arrayen i efterhand
    -------------------------------------------------------------------
    
    contacts[0] = "Johan";
    contacts[3] = "Amanda";


    [0][1][2][3] = 4 stycken
    ["Johan"]["Tommy"]["Joakim"]["Amanda"]




    Ta bort något från arrayen
    -------------------------------------------------------------------
    contacts[2] = "";



*/
