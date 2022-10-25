using System;
using System.Threading;


namespace lab5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ducks = { "Домашняя утка", "Дикая утка", "Железная утка" };

            for (int i = 1; i < 6; i++)
            {
                Thread thread = new Thread(Print);
            }
            PoultryFarm farm = PoultryFarm.Get(ducks);


            farm.Info();

            Console.ReadKey();
        }

        private static void Print(object obj)
        {
            throw new NotImplementedException();
        }

        public void Print() { Thread.Sleep(100); }
    }
}
