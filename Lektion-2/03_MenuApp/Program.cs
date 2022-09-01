string option;

do
{
    Console.WriteLine("--------  MENY  --------");
    Console.WriteLine("1. Skapa en användare");
    Console.WriteLine("2. Ta bort en användare");
    Console.WriteLine("3. Lista alla användare");
    Console.WriteLine("Q. Avsluta applikationen");
    Console.Write("Välj ett av alternativen: ");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Visar menyn för att skapa en användare");
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Visar menyn för att ta bort en användare");
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("Visar menyn för att lista alla användare");
            break;
    }

    Console.ReadKey();
    Console.Clear();
}
while (option.ToLower() != "q");

