namespace _01_Threads.ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            Console.ReadKey();
            Console.WriteLine("Program started.");
            Console.WriteLine("Main Thread: " + Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 1000; i++)
            {
                new Thread(() =>
                {
                    Console.WriteLine($"#{i}, Thread: {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(10000);
                    Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId} - completed");
                }).Start();

            }



            Console.WriteLine("Program Completed.");
            Console.ReadKey();
        }
    }
}