using System;
using System.Collections.Generic;
using System.Threading;
using lab5_Singleton.Ducks;

namespace lab5_Singleton
{
    class Program
    {
        static void Main()
        {
            var threds = new List<Thread>();

            Console.WriteLine("Генерирование 100 потоков...");

            for (int i = 1; i < 100; i++)
            {
                Thread myThread = new(_ => PoultryFarm.Get());
                threds.Add(myThread);
            }

            foreach (var item in threds)
            {
                item.Start();
            }

            foreach (var item in threds)
            {
                item.Join();
            }

            Console.WriteLine($"Количество ссылок на ферму: {PoultryFarm.Count}");

            PoultryFarm farm = PoultryFarm.Get();

            farm.Add(new Duck[] { new DomesticDuck(), new GrayDuck(), new WildDuck() });

            farm.Info();

            Console.ReadKey();
        }
    }
}
