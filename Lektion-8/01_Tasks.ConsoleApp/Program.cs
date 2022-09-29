using System.Diagnostics;

namespace _01_Tasks.ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            Console.ReadKey();
            //Console.WriteLine("Program started.");

            //for (int i = 0; i < 10000; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"Task ID: {Task.CurrentId} \t Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            //    });
            //}

            ////for (int i = 0; i < 10000; i++)
            ////{
            ////    new Thread(() =>
            ////    {
            ////        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            ////    }).Start();
            ////}

            //Console.WriteLine("Program Completed.");
            //Console.ReadKey();




            Console.Clear();
            Console.WriteLine("Din beställning är skickad.");

            Resturang();

            Console.WriteLine("Din mat är nu leverarad. (Blocking)");


            Console.ReadLine();

        }


        private static void Resturang()
        {
            Task.Run(async () =>
            {
                await Task.Delay(1000);
                Debug.WriteLine("Din beställning är mottagen.");
                Console.WriteLine("Din beställning är mottagen.");


                await Task.Delay(2000);
                Debug.WriteLine("Din beställning tillagas.");
                Console.WriteLine("Din beställning tillagas.");


                await Task.Delay(5000);
                Debug.WriteLine("Din beställning är klar för leverans");
                Console.WriteLine("Din beställning är klar för leverans");

                await Task.Delay(2000);
            });
        }
    }
}