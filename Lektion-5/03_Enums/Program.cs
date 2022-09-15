namespace _03_Enums
{

    enum CaseState
    {
        NotStarted,
        Open,
        Closed,
        Canceled
    }





    enum ConnectionState
    {
        Disconnected,
        Connecting,
        Initializing,
        Connected,
        Disconnecting
    }

    class Program
    {
        private static ConnectionState connection = ConnectionState.Disconnected;

        public static async Task Main()
        {
            Console.WriteLine(connection);
            Console.ReadKey();
            connection = ConnectionState.Connecting;


            do
            {
                switch (connection)
                {
                    case ConnectionState.Disconnected:
                        Console.WriteLine("Device not connected");
                        break;

                    case ConnectionState.Connecting:
                        Console.WriteLine("Device is connecting. Please wait...");
                        await Task.Delay(2000);
                        connection = ConnectionState.Connected;
                        break;
                }

            } while (connection != ConnectionState.Connected);

            Console.WriteLine("Device is now connected");


            Console.ReadKey();
        }
    }
}