var contacts = new List<string>();

do
{

    Console.Clear();
    Console.WriteLine("##### ADDRESS BOOK #####");
    Console.WriteLine("1. View Address book");
    Console.WriteLine("2. Add new Contact");
    Console.WriteLine("Q. Exit Application");
    Console.Write("Choose one option: ");
    var option = Console.ReadLine();

    if(string.IsNullOrEmpty(option))
    {
        Console.WriteLine("You must enter a option");
        Console.ReadKey();
    }
    else
    {
        switch(option)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("##### CONTACTS - ADDRESS BOOK #####");
                foreach (var contact in contacts)
                    Console.WriteLine(contact);

                break;

            case "2":
                Console.Clear();
                Console.WriteLine("##### NEW CONTACT - ADDRESS BOOK #####");
                
                Console.Write("First name: ");
                var firstName = Console.ReadLine();

                Console.Write("Last name: ");
                var lastName = Console.ReadLine();

                Console.Write("Street name: ");
                var streetName = Console.ReadLine();

                Console.Write("Postal code: ");
                var postalCode = Console.ReadLine();

                Console.Write("City: ");
                var city = Console.ReadLine();

                contacts.Add($"{firstName} {lastName}, {streetName} {postalCode} {city}");
                Console.WriteLine("Contact added to Address book");

                break;

            case "Q":
                Environment.Exit(0);
                break;
        }
    }

    Console.ReadKey();

} while (true);