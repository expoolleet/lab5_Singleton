using System;
using System.Threading;
using lab5_Singleton.Ducks;


namespace lab5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] duckArray = { new DomesticDuck(), new WildDuck() };

            PoultryFarm farm = PoultryFarm.Get(duckArray);


            farm.Info();

            Thread thread = Thread.CurrentThread;
            thread.Name = "Main поток";
            Console.WriteLine($"Имя: {thread.Name}");
            Console.WriteLine($"Запущен ли: {thread.IsAlive}");
            Console.WriteLine($"ID: {thread.ManagedThreadId}");
            Console.WriteLine($"Приоритет: {thread.Priority}");
            Console.WriteLine($"Статус: {thread.ThreadState}");
            Console.WriteLine(Thread.GetDomain());
            Thread.Sleep(1000);
            Console.WriteLine("test");


            //int x = 0;

            //for (int i = 1; i < 6; i++)
            //{
            //    Thread myThread = new();
            //    myThread.Name = $"Поток {i}";
            //    myThread.Start();
            //}


           
            Console.ReadKey();
        }
    }
}
